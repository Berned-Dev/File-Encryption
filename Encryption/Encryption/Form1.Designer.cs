
namespace Encryption
{
    partial class Encryption
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.rdbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnDecrypt);
            this.groupBox1.Controls.Add(this.rdbtnEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What would you like to do";
            // 
            // rdbtnEncrypt
            // 
            this.rdbtnEncrypt.AutoSize = true;
            this.rdbtnEncrypt.Location = new System.Drawing.Point(35, 49);
            this.rdbtnEncrypt.Name = "rdbtnEncrypt";
            this.rdbtnEncrypt.Size = new System.Drawing.Size(116, 24);
            this.rdbtnEncrypt.TabIndex = 2;
            this.rdbtnEncrypt.TabStop = true;
            this.rdbtnEncrypt.Text = "Encrypt a file";
            this.rdbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(113, 212);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(108, 39);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rdbtnDecrypt
            // 
            this.rdbtnDecrypt.AutoSize = true;
            this.rdbtnDecrypt.Location = new System.Drawing.Point(35, 98);
            this.rdbtnDecrypt.Name = "rdbtnDecrypt";
            this.rdbtnDecrypt.Size = new System.Drawing.Size(119, 24);
            this.rdbtnDecrypt.TabIndex = 3;
            this.rdbtnDecrypt.TabStop = true;
            this.rdbtnDecrypt.Text = "Decrypt a file";
            this.rdbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 288);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbtnEncrypt;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.RadioButton rdbtnDecrypt;
    }
}

