namespace Market_Kasa_Sistemi.Views
{
    partial class Urunler_View
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
            this.urunlerDGW = new System.Windows.Forms.DataGridView();
            this.cikisButton = new System.Windows.Forms.Button();
            this.urunEkleButton = new System.Windows.Forms.Button();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            this.urunFiyatiTxt = new System.Windows.Forms.TextBox();
            this.urunAdetTxt = new System.Windows.Forms.TextBox();
            this.urunKategoriComboBox = new System.Windows.Forms.ComboBox();
            this.vergiMiktarComboBox = new System.Windows.Forms.ComboBox();
            this.urunSilButton = new System.Windows.Forms.Button();
            this.urunDuzenleButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // urunlerDGW
            // 
            this.urunlerDGW.AllowUserToAddRows = false;
            this.urunlerDGW.AllowUserToDeleteRows = false;
            this.urunlerDGW.AllowUserToResizeColumns = false;
            this.urunlerDGW.AllowUserToResizeRows = false;
            this.urunlerDGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urunlerDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunlerDGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.urunlerDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urunlerDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.urunlerDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.urunlerDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDGW.ColumnHeadersVisible = false;
            this.urunlerDGW.Location = new System.Drawing.Point(15, 129);
            this.urunlerDGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunlerDGW.MultiSelect = false;
            this.urunlerDGW.Name = "urunlerDGW";
            this.urunlerDGW.ReadOnly = true;
            this.urunlerDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.urunlerDGW.RowHeadersVisible = false;
            this.urunlerDGW.RowHeadersWidth = 51;
            this.urunlerDGW.RowTemplate.Height = 24;
            this.urunlerDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.urunlerDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.urunlerDGW.Size = new System.Drawing.Size(696, 548);
            this.urunlerDGW.TabIndex = 28;
            this.urunlerDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDGW_CellClick);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(760, 571);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(277, 106);
            this.cikisButton.TabIndex = 39;
            this.cikisButton.Text = "ÇIKIŞ YAP";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // urunEkleButton
            // 
            this.urunEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.urunEkleButton.FlatAppearance.BorderSize = 0;
            this.urunEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkleButton.Location = new System.Drawing.Point(760, 442);
            this.urunEkleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunEkleButton.Name = "urunEkleButton";
            this.urunEkleButton.Size = new System.Drawing.Size(277, 38);
            this.urunEkleButton.TabIndex = 38;
            this.urunEkleButton.Text = "EKLE";
            this.urunEkleButton.UseVisualStyleBackColor = false;
            this.urunEkleButton.Click += new System.EventHandler(this.urunEkleButton_Click);
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdiTxt.Location = new System.Drawing.Point(759, 148);
            this.urunAdiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(277, 32);
            this.urunAdiTxt.TabIndex = 37;
            // 
            // urunFiyatiTxt
            // 
            this.urunFiyatiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatiTxt.Location = new System.Drawing.Point(759, 206);
            this.urunFiyatiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunFiyatiTxt.Name = "urunFiyatiTxt";
            this.urunFiyatiTxt.Size = new System.Drawing.Size(277, 32);
            this.urunFiyatiTxt.TabIndex = 43;
            // 
            // urunAdetTxt
            // 
            this.urunAdetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdetTxt.Location = new System.Drawing.Point(759, 266);
            this.urunAdetTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunAdetTxt.Name = "urunAdetTxt";
            this.urunAdetTxt.Size = new System.Drawing.Size(277, 32);
            this.urunAdetTxt.TabIndex = 45;
            // 
            // urunKategoriComboBox
            // 
            this.urunKategoriComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunKategoriComboBox.FormattingEnabled = true;
            this.urunKategoriComboBox.Location = new System.Drawing.Point(759, 329);
            this.urunKategoriComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunKategoriComboBox.Name = "urunKategoriComboBox";
            this.urunKategoriComboBox.Size = new System.Drawing.Size(277, 34);
            this.urunKategoriComboBox.TabIndex = 47;
            // 
            // vergiMiktarComboBox
            // 
            this.vergiMiktarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vergiMiktarComboBox.FormattingEnabled = true;
            this.vergiMiktarComboBox.Location = new System.Drawing.Point(759, 393);
            this.vergiMiktarComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vergiMiktarComboBox.Name = "vergiMiktarComboBox";
            this.vergiMiktarComboBox.Size = new System.Drawing.Size(277, 34);
            this.vergiMiktarComboBox.TabIndex = 49;
            // 
            // urunSilButton
            // 
            this.urunSilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.urunSilButton.FlatAppearance.BorderSize = 0;
            this.urunSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSilButton.Location = new System.Drawing.Point(760, 528);
            this.urunSilButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunSilButton.Name = "urunSilButton";
            this.urunSilButton.Size = new System.Drawing.Size(277, 38);
            this.urunSilButton.TabIndex = 51;
            this.urunSilButton.Text = "SİL";
            this.urunSilButton.UseVisualStyleBackColor = false;
            this.urunSilButton.Click += new System.EventHandler(this.urunSilButton_Click);
            // 
            // urunDuzenleButton
            // 
            this.urunDuzenleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(199)))));
            this.urunDuzenleButton.FlatAppearance.BorderSize = 0;
            this.urunDuzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunDuzenleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunDuzenleButton.Location = new System.Drawing.Point(760, 485);
            this.urunDuzenleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunDuzenleButton.Name = "urunDuzenleButton";
            this.urunDuzenleButton.Size = new System.Drawing.Size(277, 38);
            this.urunDuzenleButton.TabIndex = 52;
            this.urunDuzenleButton.Text = "DÜZENLE";
            this.urunDuzenleButton.UseVisualStyleBackColor = false;
            this.urunDuzenleButton.Click += new System.EventHandler(this.urunDuzenleButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Urunler_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.urunDuzenleButton);
            this.Controls.Add(this.urunSilButton);
            this.Controls.Add(this.vergiMiktarComboBox);
            this.Controls.Add(this.urunKategoriComboBox);
            this.Controls.Add(this.urunAdetTxt);
            this.Controls.Add(this.urunFiyatiTxt);
            this.Controls.Add(this.urunlerDGW);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.urunEkleButton);
            this.Controls.Add(this.urunAdiTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Urunler_View";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView urunlerDGW;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button urunEkleButton;
        private System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.TextBox urunFiyatiTxt;
        private System.Windows.Forms.TextBox urunAdetTxt;
        private System.Windows.Forms.ComboBox urunKategoriComboBox;
        private System.Windows.Forms.ComboBox vergiMiktarComboBox;
        private System.Windows.Forms.Button urunSilButton;
        private System.Windows.Forms.Button urunDuzenleButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}