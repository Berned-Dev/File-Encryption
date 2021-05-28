
namespace Encryption
{
    partial class DecryptFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DecryptGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.DecryptFilePathtextBox = new System.Windows.Forms.TextBox();
            this.btnDecryptBrowse = new System.Windows.Forms.Button();
            this.DecryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.DecryptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecryptGroupBox
            // 
            this.DecryptGroupBox.Controls.Add(this.label1);
            this.DecryptGroupBox.Controls.Add(this.btnDecrypt);
            this.DecryptGroupBox.Controls.Add(this.DecryptFilePathtextBox);
            this.DecryptGroupBox.Controls.Add(this.btnDecryptBrowse);
            this.DecryptGroupBox.Controls.Add(this.DecryptPasswordTextBox);
            this.DecryptGroupBox.Controls.Add(this.label4);
            this.DecryptGroupBox.Location = new System.Drawing.Point(28, 31);
            this.DecryptGroupBox.Name = "DecryptGroupBox";
            this.DecryptGroupBox.Size = new System.Drawing.Size(563, 242);
            this.DecryptGroupBox.TabIndex = 26;
            this.DecryptGroupBox.TabStop = false;
            this.DecryptGroupBox.Text = "Decrypt file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "File path :";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(161, 159);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(255, 29);
            this.btnDecrypt.TabIndex = 22;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // DecryptFilePathtextBox
            // 
            this.DecryptFilePathtextBox.Location = new System.Drawing.Point(161, 73);
            this.DecryptFilePathtextBox.Name = "DecryptFilePathtextBox";
            this.DecryptFilePathtextBox.Size = new System.Drawing.Size(255, 27);
            this.DecryptFilePathtextBox.TabIndex = 17;
            // 
            // btnDecryptBrowse
            // 
            this.btnDecryptBrowse.Location = new System.Drawing.Point(426, 73);
            this.btnDecryptBrowse.Name = "btnDecryptBrowse";
            this.btnDecryptBrowse.Size = new System.Drawing.Size(97, 29);
            this.btnDecryptBrowse.TabIndex = 19;
            this.btnDecryptBrowse.Text = "Browse";
            this.btnDecryptBrowse.UseVisualStyleBackColor = true;
            this.btnDecryptBrowse.Click += new System.EventHandler(this.btnDecryptBrowse_Click);
            // 
            // DecryptPasswordTextBox
            // 
            this.DecryptPasswordTextBox.Location = new System.Drawing.Point(161, 113);
            this.DecryptPasswordTextBox.Name = "DecryptPasswordTextBox";
            this.DecryptPasswordTextBox.Size = new System.Drawing.Size(255, 27);
            this.DecryptPasswordTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Enter password :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(345, 292);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 36);
            this.btnDone.TabIndex = 28;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // DecryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 358);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DecryptGroupBox);
            this.Name = "DecryptFile";
            this.Text = "Decryption";
            this.DecryptGroupBox.ResumeLayout(false);
            this.DecryptGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DecryptGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox DecryptFilePathtextBox;
        private System.Windows.Forms.Button btnDecryptBrowse;
        public System.Windows.Forms.TextBox DecryptPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
    }
}