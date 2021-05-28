using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Encryption
{
    public partial class EncryptFile : Form
    {
        public EncryptFile()
        {
            InitializeComponent();
        }

        string hashPassword;         
        string saveFilePath;
        string passwordInHash;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog EncryptionWindow = new OpenFileDialog();
                if (EncryptionWindow.ShowDialog() == DialogResult.OK)
                {
                    EncryptFilePathtextBox.Text = EncryptionWindow.FileName;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                hashPassword = EncryptPasswordTextBox.Text;

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashPassword));
                    passwordInHash = BitConverter.ToString(keys);

                    using (TripleDESCryptoServiceProvider trippleDes = new TripleDESCryptoServiceProvider()
                    {
                        Key = keys,
                        Mode = CipherMode.ECB,
                        Padding = PaddingMode.PKCS7
                    })
                    {
                        byte[] Bytes = File.ReadAllBytes(EncryptFilePathtextBox.Text);
                        ICryptoTransform transform = trippleDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(Bytes, 0, Bytes.Length);

                        saveFilePath = Path.GetExtension(EncryptFilePathtextBox.Text);
                        SaveFileDialog save = new SaveFileDialog();

                        save.Filter = "Files (*" + saveFilePath + ") | *" + saveFilePath;
                        File.WriteAllBytes(EncryptFilePathtextBox.Text, results);

                    }
                }

                MessageBox.Show("Encryption successfull. File saved!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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

        private void btnView_Click(object sender, EventArgs e)
        {
            hashPasswordtextBox.Text = passwordInHash;
        }
    }
}
