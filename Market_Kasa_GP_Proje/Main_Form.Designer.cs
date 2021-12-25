namespace Market_Kasa_GP_Proje
{
    partial class Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.kullaniciSifreTxt = new System.Windows.Forms.TextBox();
            this.girisYap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(255, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(185, 136);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(428, 30);
            this.kullaniciAdiTxt.TabIndex = 1;
            this.kullaniciAdiTxt.Text = "Kullanıcı Adı";
            this.kullaniciAdiTxt.Enter += new System.EventHandler(this.kullanici_Placeholder);
            // 
            // kullaniciSifreTxt
            // 
            this.kullaniciSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSifreTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.kullaniciSifreTxt.Location = new System.Drawing.Point(185, 207);
            this.kullaniciSifreTxt.Name = "kullaniciSifreTxt";
            this.kullaniciSifreTxt.PasswordChar = '●';
            this.kullaniciSifreTxt.Size = new System.Drawing.Size(428, 30);
            this.kullaniciSifreTxt.TabIndex = 2;
            this.kullaniciSifreTxt.Text = "Şifre";
            this.kullaniciSifreTxt.Enter += new System.EventHandler(this.kullanici_Placeholder);
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(125)))));
            this.girisYap.FlatAppearance.BorderSize = 0;
            this.girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.girisYap.Location = new System.Drawing.Point(185, 292);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(154, 80);
            this.girisYap.TabIndex = 3;
            this.girisYap.Text = "GİRİŞ YAP";
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(459, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 80);
            this.button2.TabIndex = 4;
            this.button2.Text = "KAYIT OL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.kullaniciSifreTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formKapat);
            this.Load += new System.EventHandler(this.kullaniciGirisPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.TextBox kullaniciSifreTxt;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.Button button2;
    }
}