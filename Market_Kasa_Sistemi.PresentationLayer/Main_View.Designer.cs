namespace Market_Kasa_Sistemi
{
    partial class Main_View
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
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.kullaniciSifreTxt = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.kayitOlButton = new System.Windows.Forms.Button();
            this.lblWrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(130, 146);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(322, 26);
            this.kullaniciAdiTxt.TabIndex = 1;
            this.kullaniciAdiTxt.Text = "Kullanıcı Adı";
            this.kullaniciAdiTxt.Enter += new System.EventHandler(this.kullanici_PlaceholderEnter);
            this.kullaniciAdiTxt.Leave += new System.EventHandler(this.kullanici_PlaceholderLeave);
            // 
            // kullaniciSifreTxt
            // 
            this.kullaniciSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSifreTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.kullaniciSifreTxt.Location = new System.Drawing.Point(130, 204);
            this.kullaniciSifreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kullaniciSifreTxt.Name = "kullaniciSifreTxt";
            this.kullaniciSifreTxt.PasswordChar = '*';
            this.kullaniciSifreTxt.Size = new System.Drawing.Size(322, 26);
            this.kullaniciSifreTxt.TabIndex = 2;
            this.kullaniciSifreTxt.Text = "Şifre";
            this.kullaniciSifreTxt.Enter += new System.EventHandler(this.kullanici_PlaceholderEnter);
            this.kullaniciSifreTxt.Leave += new System.EventHandler(this.kullanici_PlaceholderLeave);
            // 
            // girisYapButton
            // 
            this.girisYapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(125)))));
            this.girisYapButton.FlatAppearance.BorderSize = 0;
            this.girisYapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.girisYapButton.Location = new System.Drawing.Point(130, 312);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(2);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(116, 65);
            this.girisYapButton.TabIndex = 3;
            this.girisYapButton.Text = "GİRİŞ YAP";
            this.girisYapButton.UseVisualStyleBackColor = false;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // kayitOlButton
            // 
            this.kayitOlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.kayitOlButton.FlatAppearance.BorderSize = 0;
            this.kayitOlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOlButton.Location = new System.Drawing.Point(335, 312);
            this.kayitOlButton.Margin = new System.Windows.Forms.Padding(2);
            this.kayitOlButton.Name = "kayitOlButton";
            this.kayitOlButton.Size = new System.Drawing.Size(116, 65);
            this.kayitOlButton.TabIndex = 4;
            this.kayitOlButton.Text = "KAYIT OL";
            this.kayitOlButton.UseVisualStyleBackColor = false;
            this.kayitOlButton.Click += new System.EventHandler(this.kayitOlButton_Click);
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(127, 241);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(0, 13);
            this.lblWrong.TabIndex = 5;
            // 
            // Main_View
            // 
            this.AcceptButton = this.girisYapButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.kayitOlButton);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.kullaniciSifreTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Paneli";
            this.Load += new System.EventHandler(this.Main_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.TextBox kullaniciSifreTxt;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Button kayitOlButton;
        private System.Windows.Forms.Label lblWrong;
    }
}