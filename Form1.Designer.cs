
namespace Vigenere_Cipher_11
{
    partial class Form1
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
            this.textKey = new System.Windows.Forms.TextBox();
            this.textMessege = new System.Windows.Forms.TextBox();
            this.textEncryption = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textKey
            // 
            this.textKey.AcceptsReturn = true;
            this.textKey.AcceptsTab = true;
            this.textKey.AllowDrop = true;
            this.textKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textKey.Location = new System.Drawing.Point(80, 65);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(277, 23);
            this.textKey.TabIndex = 0;
            this.textKey.TextChanged += new System.EventHandler(this.textKey_TextChanged);
            this.textKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKey_KeyPress);
            // 
            // textMessege
            // 
            this.textMessege.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textMessege.Location = new System.Drawing.Point(83, 142);
            this.textMessege.Multiline = true;
            this.textMessege.Name = "textMessege";
            this.textMessege.Size = new System.Drawing.Size(277, 98);
            this.textMessege.TabIndex = 1;
            this.textMessege.TextChanged += new System.EventHandler(this.textMessege_TextChanged);
            this.textMessege.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMessege_KeyPress);
            // 
            // textEncryption
            // 
            this.textEncryption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textEncryption.Location = new System.Drawing.Point(83, 297);
            this.textEncryption.Multiline = true;
            this.textEncryption.Name = "textEncryption";
            this.textEncryption.ReadOnly = true;
            this.textEncryption.Size = new System.Drawing.Size(274, 95);
            this.textEncryption.TabIndex = 2;
            this.textEncryption.TextChanged += new System.EventHandler(this.textEncryption_TextChanged);
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(36, 68);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(26, 15);
            this.Key.TabIndex = 3;
            this.Key.Text = "Key";
            this.Key.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Messege";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encryption Messege";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.textEncryption);
            this.Controls.Add(this.textMessege);
            this.Controls.Add(this.textKey);
            this.Name = "Form1";
            this.Text = "Encryption App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textMessege;
        private System.Windows.Forms.TextBox textEncryption;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

