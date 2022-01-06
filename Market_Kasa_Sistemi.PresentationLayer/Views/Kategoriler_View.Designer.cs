namespace Market_Kasa_Sistemi.Views
{
    partial class Kategoriler_View
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
            this.components = new System.ComponentModel.Container();
            this.kategoriSilButton = new System.Windows.Forms.Button();
            this.lblKategoriAd = new System.Windows.Forms.Label();
            this.kategoriAdiTxt = new System.Windows.Forms.TextBox();
            this.kategorilerDGW = new System.Windows.Forms.DataGridView();
            this.kategoriEkleButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.kategoriDuzenleButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kategoriSilButton
            // 
            this.kategoriSilButton.BackColor = System.Drawing.Color.MediumPurple;
            this.kategoriSilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kategoriSilButton.FlatAppearance.BorderSize = 0;
            this.kategoriSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriSilButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kategoriSilButton.Location = new System.Drawing.Point(756, 273);
            this.kategoriSilButton.Margin = new System.Windows.Forms.Padding(0);
            this.kategoriSilButton.Name = "kategoriSilButton";
            this.kategoriSilButton.Size = new System.Drawing.Size(277, 38);
            this.kategoriSilButton.TabIndex = 59;
            this.kategoriSilButton.Text = "SİL";
            this.kategoriSilButton.UseVisualStyleBackColor = false;
            this.kategoriSilButton.Click += new System.EventHandler(this.kategoriSilButton_Click);
            // 
            // lblKategoriAd
            // 
            this.lblKategoriAd.AutoSize = true;
            this.lblKategoriAd.Location = new System.Drawing.Point(756, 78);
            this.lblKategoriAd.Name = "lblKategoriAd";
            this.lblKategoriAd.Size = new System.Drawing.Size(80, 16);
            this.lblKategoriAd.TabIndex = 58;
            this.lblKategoriAd.Text = "Kategori Adı";
            this.lblKategoriAd.Visible = false;
            // 
            // kategoriAdiTxt
            // 
            this.kategoriAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriAdiTxt.Location = new System.Drawing.Point(756, 100);
            this.kategoriAdiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kategoriAdiTxt.Name = "kategoriAdiTxt";
            this.kategoriAdiTxt.Size = new System.Drawing.Size(277, 32);
            this.kategoriAdiTxt.TabIndex = 57;
            // 
            // kategorilerDGW
            // 
            this.kategorilerDGW.AllowUserToAddRows = false;
            this.kategorilerDGW.AllowUserToDeleteRows = false;
            this.kategorilerDGW.AllowUserToResizeColumns = false;
            this.kategorilerDGW.AllowUserToResizeRows = false;
            this.kategorilerDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kategorilerDGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kategorilerDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kategorilerDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.kategorilerDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.kategorilerDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategorilerDGW.ColumnHeadersVisible = false;
            this.kategorilerDGW.Location = new System.Drawing.Point(17, 78);
            this.kategorilerDGW.Margin = new System.Windows.Forms.Padding(0);
            this.kategorilerDGW.MultiSelect = false;
            this.kategorilerDGW.Name = "kategorilerDGW";
            this.kategorilerDGW.ReadOnly = true;
            this.kategorilerDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.kategorilerDGW.RowHeadersVisible = false;
            this.kategorilerDGW.RowHeadersWidth = 51;
            this.kategorilerDGW.RowTemplate.Height = 24;
            this.kategorilerDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kategorilerDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kategorilerDGW.Size = new System.Drawing.Size(728, 578);
            this.kategorilerDGW.TabIndex = 51;
            this.kategorilerDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kategorilerDGW_CellClick);
            // 
            // kategoriEkleButton
            // 
            this.kategoriEkleButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.kategoriEkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kategoriEkleButton.FlatAppearance.BorderSize = 0;
            this.kategoriEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.kategoriEkleButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kategoriEkleButton.Location = new System.Drawing.Point(756, 158);
            this.kategoriEkleButton.Margin = new System.Windows.Forms.Padding(0);
            this.kategoriEkleButton.Name = "kategoriEkleButton";
            this.kategoriEkleButton.Size = new System.Drawing.Size(277, 38);
            this.kategoriEkleButton.TabIndex = 50;
            this.kategoriEkleButton.Text = "EKLE";
            this.kategoriEkleButton.UseVisualStyleBackColor = false;
            this.kategoriEkleButton.Click += new System.EventHandler(this.kategoriEkleButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cikisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikisButton.Location = new System.Drawing.Point(819, 533);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(0);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(215, 123);
            this.cikisButton.TabIndex = 49;
            this.cikisButton.Text = "ÇIKIŞ YAP";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // kategoriDuzenleButton
            // 
            this.kategoriDuzenleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.kategoriDuzenleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kategoriDuzenleButton.FlatAppearance.BorderSize = 0;
            this.kategoriDuzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriDuzenleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriDuzenleButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kategoriDuzenleButton.Location = new System.Drawing.Point(756, 214);
            this.kategoriDuzenleButton.Margin = new System.Windows.Forms.Padding(0);
            this.kategoriDuzenleButton.Name = "kategoriDuzenleButton";
            this.kategoriDuzenleButton.Size = new System.Drawing.Size(277, 38);
            this.kategoriDuzenleButton.TabIndex = 60;
            this.kategoriDuzenleButton.Text = "DÜZENLE";
            this.kategoriDuzenleButton.UseVisualStyleBackColor = false;
            this.kategoriDuzenleButton.Click += new System.EventHandler(this.kategoriDuzenleButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Kategoriler_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.kategoriDuzenleButton);
            this.Controls.Add(this.kategoriSilButton);
            this.Controls.Add(this.lblKategoriAd);
            this.Controls.Add(this.kategoriAdiTxt);
            this.Controls.Add(this.kategorilerDGW);
            this.Controls.Add(this.kategoriEkleButton);
            this.Controls.Add(this.cikisButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kategoriler_View";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kategoriSilButton;
        private System.Windows.Forms.Label lblKategoriAd;
        private System.Windows.Forms.TextBox kategoriAdiTxt;
        private System.Windows.Forms.DataGridView kategorilerDGW;
        private System.Windows.Forms.Button kategoriEkleButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button kategoriDuzenleButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}