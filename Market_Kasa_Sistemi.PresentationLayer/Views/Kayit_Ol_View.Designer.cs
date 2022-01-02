namespace Market_Kasa_Sistemi.Views
{
    partial class Kayit_Ol_View
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
            this.kayitOlButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.kullaniciSifreTxt = new System.Windows.Forms.TextBox();
            this.kasiyerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // kayitOlButton
            // 
            this.kayitOlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.kayitOlButton.FlatAppearance.BorderSize = 0;
            this.kayitOlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOlButton.Location = new System.Drawing.Point(135, 326);
            this.kayitOlButton.Margin = new System.Windows.Forms.Padding(2);
            this.kayitOlButton.Name = "kayitOlButton";
            this.kayitOlButton.Size = new System.Drawing.Size(116, 65);
            this.kayitOlButton.TabIndex = 9;
            this.kayitOlButton.Text = "KAYIT OL";
            this.kayitOlButton.UseVisualStyleBackColor = false;
            // 
            // iptalButton
            // 
            this.iptalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.iptalButton.FlatAppearance.BorderSize = 0;
            this.iptalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iptalButton.Location = new System.Drawing.Point(341, 326);
            this.iptalButton.Margin = new System.Windows.Forms.Padding(2);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(116, 65);
            this.iptalButton.TabIndex = 8;
            this.iptalButton.Text = "İPTAL";
            this.iptalButton.UseVisualStyleBackColor = false;
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(135, 103);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(322, 27);
            this.kullaniciAdiTxt.TabIndex = 10;
            // 
            // kullaniciSifreTxt
            // 
            this.kullaniciSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSifreTxt.Location = new System.Drawing.Point(135, 166);
            this.kullaniciSifreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kullaniciSifreTxt.Name = "kullaniciSifreTxt";
            this.kullaniciSifreTxt.Size = new System.Drawing.Size(322, 27);
            this.kullaniciSifreTxt.TabIndex = 11;
            // 
            // kasiyerComboBox
            // 
            this.kasiyerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasiyerComboBox.FormattingEnabled = true;
            this.kasiyerComboBox.Location = new System.Drawing.Point(135, 229);
            this.kasiyerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.kasiyerComboBox.Name = "kasiyerComboBox";
            this.kasiyerComboBox.Size = new System.Drawing.Size(322, 28);
            this.kasiyerComboBox.TabIndex = 12;
            // 
            // Kayit_Ol_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.kasiyerComboBox);
            this.Controls.Add(this.kullaniciSifreTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.kayitOlButton);
            this.Controls.Add(this.iptalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Kayit_Ol_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit_Ol";
            this.Load += new System.EventHandler(this.Kayit_Ol_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitOlButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.TextBox kullaniciSifreTxt;
        private System.Windows.Forms.ComboBox kasiyerComboBox;
    }
}