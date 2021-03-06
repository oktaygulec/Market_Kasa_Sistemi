namespace Market_Kasa_Sistemi.Views
{
    partial class Personeller_View
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
            this.personellerDGW = new System.Windows.Forms.DataGridView();
            this.cikisButton = new System.Windows.Forms.Button();
            this.personelEkleButton = new System.Windows.Forms.Button();
            this.personelAdiTxt = new System.Windows.Forms.TextBox();
            this.personelSoyadiTxt = new System.Windows.Forms.TextBox();
            this.personelSilButton = new System.Windows.Forms.Button();
            this.personelDuzenleButton = new System.Windows.Forms.Button();
            this.personelTipiComboBox = new System.Windows.Forms.ComboBox();
            this.baslangicTarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personellerDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // personellerDGW
            // 
            this.personellerDGW.AllowUserToAddRows = false;
            this.personellerDGW.AllowUserToDeleteRows = false;
            this.personellerDGW.AllowUserToResizeColumns = false;
            this.personellerDGW.AllowUserToResizeRows = false;
            this.personellerDGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.personellerDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personellerDGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.personellerDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personellerDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.personellerDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.personellerDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personellerDGW.ColumnHeadersVisible = false;
            this.personellerDGW.Location = new System.Drawing.Point(15, 80);
            this.personellerDGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personellerDGW.MultiSelect = false;
            this.personellerDGW.Name = "personellerDGW";
            this.personellerDGW.ReadOnly = true;
            this.personellerDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.personellerDGW.RowHeadersVisible = false;
            this.personellerDGW.RowHeadersWidth = 51;
            this.personellerDGW.RowTemplate.Height = 24;
            this.personellerDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.personellerDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personellerDGW.Size = new System.Drawing.Size(679, 580);
            this.personellerDGW.TabIndex = 28;
            this.personellerDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personellerDGW_CellClick);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(753, 569);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(277, 106);
            this.cikisButton.TabIndex = 39;
            this.cikisButton.Text = "ÇIKIŞ YAP";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // personelEkleButton
            // 
            this.personelEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.personelEkleButton.FlatAppearance.BorderSize = 0;
            this.personelEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelEkleButton.Location = new System.Drawing.Point(753, 366);
            this.personelEkleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelEkleButton.Name = "personelEkleButton";
            this.personelEkleButton.Size = new System.Drawing.Size(277, 38);
            this.personelEkleButton.TabIndex = 38;
            this.personelEkleButton.Text = "EKLE";
            this.personelEkleButton.UseVisualStyleBackColor = false;
            this.personelEkleButton.Click += new System.EventHandler(this.personelEkleButton_Click);
            // 
            // personelAdiTxt
            // 
            this.personelAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelAdiTxt.Location = new System.Drawing.Point(753, 112);
            this.personelAdiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelAdiTxt.Name = "personelAdiTxt";
            this.personelAdiTxt.Size = new System.Drawing.Size(276, 32);
            this.personelAdiTxt.TabIndex = 37;
            // 
            // personelSoyadiTxt
            // 
            this.personelSoyadiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelSoyadiTxt.Location = new System.Drawing.Point(753, 170);
            this.personelSoyadiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelSoyadiTxt.Name = "personelSoyadiTxt";
            this.personelSoyadiTxt.Size = new System.Drawing.Size(276, 32);
            this.personelSoyadiTxt.TabIndex = 43;
            // 
            // personelSilButton
            // 
            this.personelSilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.personelSilButton.FlatAppearance.BorderSize = 0;
            this.personelSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelSilButton.Location = new System.Drawing.Point(753, 480);
            this.personelSilButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelSilButton.Name = "personelSilButton";
            this.personelSilButton.Size = new System.Drawing.Size(277, 38);
            this.personelSilButton.TabIndex = 51;
            this.personelSilButton.Text = "SİL";
            this.personelSilButton.UseVisualStyleBackColor = false;
            this.personelSilButton.Click += new System.EventHandler(this.personelSilButton_Click);
            // 
            // personelDuzenleButton
            // 
            this.personelDuzenleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(199)))));
            this.personelDuzenleButton.FlatAppearance.BorderSize = 0;
            this.personelDuzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelDuzenleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelDuzenleButton.Location = new System.Drawing.Point(753, 425);
            this.personelDuzenleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelDuzenleButton.Name = "personelDuzenleButton";
            this.personelDuzenleButton.Size = new System.Drawing.Size(277, 38);
            this.personelDuzenleButton.TabIndex = 52;
            this.personelDuzenleButton.Text = "DÜZENLE";
            this.personelDuzenleButton.UseVisualStyleBackColor = false;
            this.personelDuzenleButton.Click += new System.EventHandler(this.personelDuzenleButton_Click);
            // 
            // personelTipiComboBox
            // 
            this.personelTipiComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelTipiComboBox.FormattingEnabled = true;
            this.personelTipiComboBox.Location = new System.Drawing.Point(753, 309);
            this.personelTipiComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelTipiComboBox.Name = "personelTipiComboBox";
            this.personelTipiComboBox.Size = new System.Drawing.Size(276, 34);
            this.personelTipiComboBox.TabIndex = 53;
            // 
            // baslangicTarihDateTimePicker
            // 
            this.baslangicTarihDateTimePicker.Location = new System.Drawing.Point(753, 256);
            this.baslangicTarihDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslangicTarihDateTimePicker.Name = "baslangicTarihDateTimePicker";
            this.baslangicTarihDateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.baslangicTarihDateTimePicker.TabIndex = 55;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Personeller_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.baslangicTarihDateTimePicker);
            this.Controls.Add(this.personelTipiComboBox);
            this.Controls.Add(this.personelDuzenleButton);
            this.Controls.Add(this.personelSilButton);
            this.Controls.Add(this.personelSoyadiTxt);
            this.Controls.Add(this.personellerDGW);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.personelEkleButton);
            this.Controls.Add(this.personelAdiTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Personeller_View";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellerDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personellerDGW;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button personelEkleButton;
        private System.Windows.Forms.TextBox personelAdiTxt;
        private System.Windows.Forms.TextBox personelSoyadiTxt;
        private System.Windows.Forms.Button personelSilButton;
        private System.Windows.Forms.Button personelDuzenleButton;
        private System.Windows.Forms.ComboBox personelTipiComboBox;
        private System.Windows.Forms.DateTimePicker baslangicTarihDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}