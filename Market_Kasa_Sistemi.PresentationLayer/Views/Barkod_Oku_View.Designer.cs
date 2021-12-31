namespace Market_Kasa_Sistemi.Views
{
    partial class Barkod_Oku_View
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
            this.barkodGirisiTxt = new System.Windows.Forms.TextBox();
            this.urunGetirButton = new System.Windows.Forms.Button();
            this.cikisYapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barkodGirisiTxt
            // 
            this.barkodGirisiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodGirisiTxt.Location = new System.Drawing.Point(80, 112);
            this.barkodGirisiTxt.Margin = new System.Windows.Forms.Padding(2);
            this.barkodGirisiTxt.Name = "barkodGirisiTxt";
            this.barkodGirisiTxt.Size = new System.Drawing.Size(348, 35);
            this.barkodGirisiTxt.TabIndex = 13;
            // 
            // urunGetirButton
            // 
            this.urunGetirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.urunGetirButton.FlatAppearance.BorderSize = 0;
            this.urunGetirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunGetirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunGetirButton.Location = new System.Drawing.Point(80, 176);
            this.urunGetirButton.Margin = new System.Windows.Forms.Padding(2);
            this.urunGetirButton.Name = "urunGetirButton";
            this.urunGetirButton.Size = new System.Drawing.Size(142, 82);
            this.urunGetirButton.TabIndex = 12;
            this.urunGetirButton.Text = "ÜRÜN GETİR";
            this.urunGetirButton.UseVisualStyleBackColor = false;
            // 
            // cikisYapButton
            // 
            this.cikisYapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.cikisYapButton.FlatAppearance.BorderSize = 0;
            this.cikisYapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYapButton.Location = new System.Drawing.Point(285, 176);
            this.cikisYapButton.Margin = new System.Windows.Forms.Padding(2);
            this.cikisYapButton.Name = "cikisYapButton";
            this.cikisYapButton.Size = new System.Drawing.Size(142, 82);
            this.cikisYapButton.TabIndex = 14;
            this.cikisYapButton.Text = "ÇIKIŞ YAP";
            this.cikisYapButton.UseVisualStyleBackColor = false;
            // 
            // Barkod_Oku_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 309);
            this.Controls.Add(this.cikisYapButton);
            this.Controls.Add(this.barkodGirisiTxt);
            this.Controls.Add(this.urunGetirButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Barkod_Oku_View";
            this.Text = "Barkod Oku";
            this.Load += new System.EventHandler(this.Barkod_Oku_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barkodGirisiTxt;
        private System.Windows.Forms.Button urunGetirButton;
        private System.Windows.Forms.Button cikisYapButton;
    }
}