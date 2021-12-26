namespace Market_Kasa_GP_Proje.Views
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
            this.label1 = new System.Windows.Forms.Label();
            this.cikisYapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barkodGirisiTxt
            // 
            this.barkodGirisiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodGirisiTxt.Location = new System.Drawing.Point(107, 138);
            this.barkodGirisiTxt.Name = "barkodGirisiTxt";
            this.barkodGirisiTxt.Size = new System.Drawing.Size(463, 41);
            this.barkodGirisiTxt.TabIndex = 13;
            // 
            // urunGetirButton
            // 
            this.urunGetirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.urunGetirButton.FlatAppearance.BorderSize = 0;
            this.urunGetirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunGetirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunGetirButton.Location = new System.Drawing.Point(107, 217);
            this.urunGetirButton.Name = "urunGetirButton";
            this.urunGetirButton.Size = new System.Drawing.Size(190, 101);
            this.urunGetirButton.TabIndex = 12;
            this.urunGetirButton.Text = "ÜRÜN GETİR";
            this.urunGetirButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(214, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "BARKOD OKU";
            // 
            // cikisYapButton
            // 
            this.cikisYapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.cikisYapButton.FlatAppearance.BorderSize = 0;
            this.cikisYapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYapButton.Location = new System.Drawing.Point(380, 217);
            this.cikisYapButton.Name = "cikisYapButton";
            this.cikisYapButton.Size = new System.Drawing.Size(190, 101);
            this.cikisYapButton.TabIndex = 14;
            this.cikisYapButton.Text = "ÇIKIŞ YAP";
            this.cikisYapButton.UseVisualStyleBackColor = false;
            // 
            // Barkod_Oku_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 380);
            this.Controls.Add(this.cikisYapButton);
            this.Controls.Add(this.barkodGirisiTxt);
            this.Controls.Add(this.urunGetirButton);
            this.Controls.Add(this.label1);
            this.Name = "Barkod_Oku_View";
            this.Text = "Barkod Oku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barkodGirisiTxt;
        private System.Windows.Forms.Button urunGetirButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisYapButton;
    }
}