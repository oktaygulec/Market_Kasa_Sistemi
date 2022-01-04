namespace Market_Kasa_Sistemi.Views
{
    partial class Urun_Satis_View
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
            this.urunGirisiTxt = new System.Windows.Forms.TextBox();
            this.urunEkleButton = new System.Windows.Forms.Button();
            this.urunCikartButton = new System.Windows.Forms.Button();
            this.odemeTipiComboBox = new System.Windows.Forms.ComboBox();
            this.satisYapButton = new System.Windows.Forms.Button();
            this.iptalEtButton = new System.Windows.Forms.Button();
            this.toplamTutarLabel = new System.Windows.Forms.Label();
            this.satisDGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.satisDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // urunGirisiTxt
            // 
            this.urunGirisiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunGirisiTxt.Location = new System.Drawing.Point(553, 150);
            this.urunGirisiTxt.Margin = new System.Windows.Forms.Padding(2);
            this.urunGirisiTxt.MaxLength = 10;
            this.urunGirisiTxt.Name = "urunGirisiTxt";
            this.urunGirisiTxt.Size = new System.Drawing.Size(209, 27);
            this.urunGirisiTxt.TabIndex = 18;
            // 
            // urunEkleButton
            // 
            this.urunEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.urunEkleButton.FlatAppearance.BorderSize = 0;
            this.urunEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkleButton.Location = new System.Drawing.Point(553, 198);
            this.urunEkleButton.Margin = new System.Windows.Forms.Padding(2);
            this.urunEkleButton.Name = "urunEkleButton";
            this.urunEkleButton.Size = new System.Drawing.Size(208, 31);
            this.urunEkleButton.TabIndex = 21;
            this.urunEkleButton.Text = "EKLE";
            this.urunEkleButton.UseVisualStyleBackColor = false;
            this.urunEkleButton.Click += new System.EventHandler(this.urunEkleButton_Click);
            // 
            // urunCikartButton
            // 
            this.urunCikartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.urunCikartButton.FlatAppearance.BorderSize = 0;
            this.urunCikartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunCikartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunCikartButton.Location = new System.Drawing.Point(553, 243);
            this.urunCikartButton.Margin = new System.Windows.Forms.Padding(2);
            this.urunCikartButton.Name = "urunCikartButton";
            this.urunCikartButton.Size = new System.Drawing.Size(208, 31);
            this.urunCikartButton.TabIndex = 22;
            this.urunCikartButton.Text = "ÇIKART";
            this.urunCikartButton.UseVisualStyleBackColor = false;
            // 
            // odemeTipiComboBox
            // 
            this.odemeTipiComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeTipiComboBox.FormattingEnabled = true;
            this.odemeTipiComboBox.Location = new System.Drawing.Point(553, 352);
            this.odemeTipiComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.odemeTipiComboBox.Name = "odemeTipiComboBox";
            this.odemeTipiComboBox.Size = new System.Drawing.Size(209, 28);
            this.odemeTipiComboBox.TabIndex = 25;
            // 
            // satisYapButton
            // 
            this.satisYapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.satisYapButton.FlatAppearance.BorderSize = 0;
            this.satisYapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisYapButton.Location = new System.Drawing.Point(553, 399);
            this.satisYapButton.Margin = new System.Windows.Forms.Padding(2);
            this.satisYapButton.Name = "satisYapButton";
            this.satisYapButton.Size = new System.Drawing.Size(208, 93);
            this.satisYapButton.TabIndex = 26;
            this.satisYapButton.Text = "SATIŞ YAP";
            this.satisYapButton.UseVisualStyleBackColor = false;
            this.satisYapButton.Click += new System.EventHandler(this.satisYapButton_Click);
            // 
            // iptalEtButton
            // 
            this.iptalEtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(250)))));
            this.iptalEtButton.FlatAppearance.BorderSize = 0;
            this.iptalEtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalEtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalEtButton.Location = new System.Drawing.Point(553, 496);
            this.iptalEtButton.Margin = new System.Windows.Forms.Padding(2);
            this.iptalEtButton.Name = "iptalEtButton";
            this.iptalEtButton.Size = new System.Drawing.Size(208, 37);
            this.iptalEtButton.TabIndex = 27;
            this.iptalEtButton.Text = "İPTAL ET";
            this.iptalEtButton.UseVisualStyleBackColor = false;
            this.iptalEtButton.Click += new System.EventHandler(this.iptalEtButton_Click);
            // 
            // toplamTutarLabel
            // 
            this.toplamTutarLabel.AutoSize = true;
            this.toplamTutarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamTutarLabel.Location = new System.Drawing.Point(455, 511);
            this.toplamTutarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toplamTutarLabel.Name = "toplamTutarLabel";
            this.toplamTutarLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toplamTutarLabel.Size = new System.Drawing.Size(60, 22);
            this.toplamTutarLabel.TabIndex = 30;
            this.toplamTutarLabel.Text = "51651";
            this.toplamTutarLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // satisDGW
            // 
            this.satisDGW.AllowUserToAddRows = false;
            this.satisDGW.AllowUserToDeleteRows = false;
            this.satisDGW.AllowUserToResizeColumns = false;
            this.satisDGW.AllowUserToResizeRows = false;
            this.satisDGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.satisDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.satisDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.satisDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.satisDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.satisDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisDGW.ColumnHeadersVisible = false;
            this.satisDGW.Location = new System.Drawing.Point(30, 108);
            this.satisDGW.Margin = new System.Windows.Forms.Padding(2);
            this.satisDGW.MultiSelect = false;
            this.satisDGW.Name = "satisDGW";
            this.satisDGW.ReadOnly = true;
            this.satisDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.satisDGW.RowHeadersVisible = false;
            this.satisDGW.RowHeadersWidth = 51;
            this.satisDGW.RowTemplate.Height = 24;
            this.satisDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.satisDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.satisDGW.Size = new System.Drawing.Size(499, 384);
            this.satisDGW.TabIndex = 32;
            // 
            // Urun_Satis_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.satisDGW);
            this.Controls.Add(this.toplamTutarLabel);
            this.Controls.Add(this.iptalEtButton);
            this.Controls.Add(this.satisYapButton);
            this.Controls.Add(this.odemeTipiComboBox);
            this.Controls.Add(this.urunCikartButton);
            this.Controls.Add(this.urunEkleButton);
            this.Controls.Add(this.urunGirisiTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Urun_Satis_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satışı";
            this.Load += new System.EventHandler(this.Urun_Satis_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox urunGirisiTxt;
        private System.Windows.Forms.Button urunEkleButton;
        private System.Windows.Forms.Button urunCikartButton;
        private System.Windows.Forms.ComboBox odemeTipiComboBox;
        private System.Windows.Forms.Button satisYapButton;
        private System.Windows.Forms.Button iptalEtButton;
        private System.Windows.Forms.Label toplamTutarLabel;
        private System.Windows.Forms.DataGridView satisDGW;
    }
}