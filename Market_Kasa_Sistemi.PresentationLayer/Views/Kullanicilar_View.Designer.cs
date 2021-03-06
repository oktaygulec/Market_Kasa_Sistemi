namespace Market_Kasa_Sistemi.Views
{
    partial class Kullanicilar_View
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
            this.kullaniciEkleButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.kullaniciSifreTxt = new System.Windows.Forms.TextBox();
            this.kullaniciSilButton = new System.Windows.Forms.Button();
            this.personelComboBox = new System.Windows.Forms.ComboBox();
            this.kullanicilarDGW = new System.Windows.Forms.DataGridView();
            this.kullaniciDuzenleButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciEkleButton
            // 
            this.kullaniciEkleButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.kullaniciEkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullaniciEkleButton.FlatAppearance.BorderSize = 0;
            this.kullaniciEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciEkleButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciEkleButton.Location = new System.Drawing.Point(744, 272);
            this.kullaniciEkleButton.Margin = new System.Windows.Forms.Padding(0);
            this.kullaniciEkleButton.Name = "kullaniciEkleButton";
            this.kullaniciEkleButton.Size = new System.Drawing.Size(277, 38);
            this.kullaniciEkleButton.TabIndex = 16;
            this.kullaniciEkleButton.Text = "EKLE";
            this.kullaniciEkleButton.UseVisualStyleBackColor = false;
            this.kullaniciEkleButton.Click += new System.EventHandler(this.kullaniciEkleButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cikisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikisButton.Location = new System.Drawing.Point(745, 517);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(0);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(275, 123);
            this.cikisButton.TabIndex = 15;
            this.cikisButton.Text = "ÇIKIŞ YAP";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(744, 106);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(277, 32);
            this.kullaniciAdiTxt.TabIndex = 25;
            // 
            // kullaniciSifreTxt
            // 
            this.kullaniciSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSifreTxt.Location = new System.Drawing.Point(744, 165);
            this.kullaniciSifreTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciSifreTxt.Name = "kullaniciSifreTxt";
            this.kullaniciSifreTxt.PasswordChar = '*';
            this.kullaniciSifreTxt.Size = new System.Drawing.Size(277, 32);
            this.kullaniciSifreTxt.TabIndex = 27;
            // 
            // kullaniciSilButton
            // 
            this.kullaniciSilButton.BackColor = System.Drawing.Color.MediumPurple;
            this.kullaniciSilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullaniciSilButton.FlatAppearance.BorderSize = 0;
            this.kullaniciSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSilButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciSilButton.Location = new System.Drawing.Point(745, 373);
            this.kullaniciSilButton.Margin = new System.Windows.Forms.Padding(0);
            this.kullaniciSilButton.Name = "kullaniciSilButton";
            this.kullaniciSilButton.Size = new System.Drawing.Size(276, 38);
            this.kullaniciSilButton.TabIndex = 31;
            this.kullaniciSilButton.Text = "SİL";
            this.kullaniciSilButton.UseVisualStyleBackColor = false;
            this.kullaniciSilButton.Click += new System.EventHandler(this.kullaniciSilButton_Click);
            // 
            // personelComboBox
            // 
            this.personelComboBox.FormattingEnabled = true;
            this.personelComboBox.Location = new System.Drawing.Point(744, 225);
            this.personelComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personelComboBox.Name = "personelComboBox";
            this.personelComboBox.Size = new System.Drawing.Size(279, 24);
            this.personelComboBox.TabIndex = 33;
            // 
            // kullanicilarDGW
            // 
            this.kullanicilarDGW.AllowUserToAddRows = false;
            this.kullanicilarDGW.AllowUserToDeleteRows = false;
            this.kullanicilarDGW.AllowUserToResizeColumns = false;
            this.kullanicilarDGW.AllowUserToResizeRows = false;
            this.kullanicilarDGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kullanicilarDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kullanicilarDGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kullanicilarDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullanicilarDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.kullanicilarDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.kullanicilarDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanicilarDGW.ColumnHeadersVisible = false;
            this.kullanicilarDGW.Location = new System.Drawing.Point(37, 79);
            this.kullanicilarDGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullanicilarDGW.MultiSelect = false;
            this.kullanicilarDGW.Name = "kullanicilarDGW";
            this.kullanicilarDGW.ReadOnly = true;
            this.kullanicilarDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.kullanicilarDGW.RowHeadersVisible = false;
            this.kullanicilarDGW.RowHeadersWidth = 51;
            this.kullanicilarDGW.RowTemplate.Height = 24;
            this.kullanicilarDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kullanicilarDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kullanicilarDGW.Size = new System.Drawing.Size(657, 561);
            this.kullanicilarDGW.TabIndex = 17;
            this.kullanicilarDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanicilarDGW_CellClick);
            // 
            // kullaniciDuzenleButton
            // 
            this.kullaniciDuzenleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.kullaniciDuzenleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullaniciDuzenleButton.FlatAppearance.BorderSize = 0;
            this.kullaniciDuzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciDuzenleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciDuzenleButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciDuzenleButton.Location = new System.Drawing.Point(745, 322);
            this.kullaniciDuzenleButton.Margin = new System.Windows.Forms.Padding(0);
            this.kullaniciDuzenleButton.Name = "kullaniciDuzenleButton";
            this.kullaniciDuzenleButton.Size = new System.Drawing.Size(277, 38);
            this.kullaniciDuzenleButton.TabIndex = 34;
            this.kullaniciDuzenleButton.Text = "DÜZENLE";
            this.kullaniciDuzenleButton.UseVisualStyleBackColor = false;
            this.kullaniciDuzenleButton.Click += new System.EventHandler(this.kullaniciDuzenleButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Kullanicilar_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 678);
            this.Controls.Add(this.kullaniciDuzenleButton);
            this.Controls.Add(this.personelComboBox);
            this.Controls.Add(this.kullaniciSilButton);
            this.Controls.Add(this.kullaniciSifreTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.kullanicilarDGW);
            this.Controls.Add(this.kullaniciEkleButton);
            this.Controls.Add(this.cikisButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kullanicilar_View";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Kullanicilar_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kullaniciEkleButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.TextBox kullaniciSifreTxt;
        private System.Windows.Forms.Button kullaniciSilButton;
        private System.Windows.Forms.ComboBox personelComboBox;
        private System.Windows.Forms.DataGridView kullanicilarDGW;
        private System.Windows.Forms.Button kullaniciDuzenleButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}