using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Encryption
{
    public partial class DecryptFile : Form
    {
        public DecryptFile()
        {
            InitializeComponent();
        }

        string hashPassword;
        string saveFilePath;

        private void btnDecryptBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog DecryptionWindow = new OpenFileDialog();
                if (DecryptionWindow.ShowDialog() == DialogResult.OK)
                {
                    DecryptFilePathtextBox.Text = DecryptionWindow.FileName;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                hashPassword = DecryptPasswordTextBox.Text;

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashPassword));
                    using (TripleDESCryptoServiceProvider trippleDes = new TripleDESCryptoServiceProvider()
                    {
                        Key = keys,
                        Mode = CipherMode.ECB,
                        Padding = PaddingMode.PKCS7
                    })
                    {
                        byte[] Bytes = File.ReadAllBytes(DecryptFilePathtextBox.Text);
                        ICryptoTransform transform = trippleDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(Bytes, 0, Bytes.Length);

                        saveFilePath = Path.GetExtension(DecryptFilePathtextBox.Text);
                        SaveFileDialog save = new SaveFileDialog();

                        save.Filter = "Files (*" + saveFilePath + ") | *" + saveFilePath;
                        File.WriteAllBytes(DecryptFilePathtextBox.Text, results);
                    }

                    MessageBox.Show("Decrypted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Password");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
