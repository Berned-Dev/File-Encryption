using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnEncrypt.Checked)
                {
                    EncryptFile encrypt = new EncryptFile();
                    encrypt.ShowDialog();
                }

                else if (rdbtnDecrypt.Checked) {
                    DecryptFile decrypt = new DecryptFile();
                    decrypt.ShowDialog();

                }
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
