
namespace Encryption
{
    partial class EncryptFile
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
            this.EncryptGroupBox = new System.Windows.Forms.GroupBox();
            this.EncryptFilePathtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.EncryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblHashPassword = new System.Windows.Forms.Label();
            this.hashPasswordtextBox = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.EncryptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptGroupBox
            // 
            this.EncryptGroupBox.Controls.Add(this.EncryptFilePathtextBox);
            this.EncryptGroupBox.Controls.Add(this.label5);
            this.EncryptGroupBox.Controls.Add(this.btnEncrypt);
            this.EncryptGroupBox.Controls.Add(this.btnBrowse);
            this.EncryptGroupBox.Controls.Add(this.EncryptPasswordTextBox);
            this.EncryptGroupBox.Controls.Add(this.label6);
            this.EncryptGroupBox.Location = new System.Drawing.Point(31, 36);
            this.EncryptGroupBox.Name = "EncryptGroupBox";
            this.EncryptGroupBox.Size = new System.Drawing.Size(558, 220);
            this.EncryptGroupBox.TabIndex = 17;
            this.EncryptGroupBox.TabStop = false;
            this.EncryptGroupBox.Text = "Encrypt File";
            // 
            // EncryptFilePathtextBox
            // 
            this.EncryptFilePathtextBox.Location = new System.Drawing.Point(157, 59);
            this.EncryptFilePathtextBox.Name = "EncryptFilePathtextBox";
            this.EncryptFilePathtextBox.Size = new System.Drawing.Size(255, 27);
            this.EncryptFilePathtextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "File path :";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(157, 140);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(255, 29);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(418, 59);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 29);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // EncryptPasswordTextBox
            // 
            this.EncryptPasswordTextBox.Location = new System.Drawing.Point(157, 97);
            this.EncryptPasswordTextBox.Name = "EncryptPasswordTextBox";
            this.EncryptPasswordTextBox.Size = new System.Drawing.Size(255, 27);
            this.EncryptPasswordTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Create password :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(343, 343);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 36);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblHashPassword
            // 
            this.lblHashPassword.AutoSize = true;
            this.lblHashPassword.Location = new System.Drawing.Point(31, 289);
            this.lblHashPassword.Name = "lblHashPassword";
            this.lblHashPassword.Size = new System.Drawing.Size(168, 20);
            this.lblHashPassword.TabIndex = 19;
            this.lblHashPassword.Text = "View password in Hash :";
            // 
            // hashPasswordtextBox
            // 
            this.hashPasswordtextBox.Location = new System.Drawing.Point(205, 282);
            this.hashPasswordtextBox.Name = "hashPasswordtextBox";
            this.hashPasswordtextBox.Size = new System.Drawing.Size(281, 27);
            this.hashPasswordtextBox.TabIndex = 15;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(492, 280);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(97, 29);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // EncryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 400);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.hashPasswordtextBox);
            this.Controls.Add(this.lblHashPassword);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.EncryptGroupBox);
            this.Name = "EncryptFile";
            this.Text = "Encryption";
            this.EncryptGroupBox.ResumeLayout(false);
            this.EncryptGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EncryptGroupBox;
        private System.Windows.Forms.TextBox EncryptFilePathtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.TextBox EncryptPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblHashPassword;
        public System.Windows.Forms.TextBox hashPasswordtextBox;
        private System.Windows.Forms.Button btnView;
    }
}