namespace Market_Kasa_Sistemi.Views
{
    partial class Urun_Iade_View
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
            this.fisGirisiTxt = new System.Windows.Forms.TextBox();
            this.fisGetirButton = new System.Windows.Forms.Button();
            this.iadeEtButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.toplamTutarLabel = new System.Windows.Forms.Label();
            this.iadeDGW = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iadeDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fisGirisiTxt
            // 
            this.fisGirisiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fisGirisiTxt.Location = new System.Drawing.Point(748, 137);
            this.fisGirisiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fisGirisiTxt.MaxLength = 5;
            this.fisGirisiTxt.Name = "fisGirisiTxt";
            this.fisGirisiTxt.Size = new System.Drawing.Size(277, 32);
            this.fisGirisiTxt.TabIndex = 18;
            // 
            // fisGetirButton
            // 
            this.fisGetirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.fisGetirButton.FlatAppearance.BorderSize = 0;
            this.fisGetirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fisGetirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fisGetirButton.Location = new System.Drawing.Point(748, 208);
            this.fisGetirButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fisGetirButton.Name = "fisGetirButton";
            this.fisGetirButton.Size = new System.Drawing.Size(277, 38);
            this.fisGetirButton.TabIndex = 21;
            this.fisGetirButton.Text = "FİŞ GETİR";
            this.fisGetirButton.UseVisualStyleBackColor = false;
            this.fisGetirButton.Click += new System.EventHandler(this.fisGetirButton_Click);
            // 
            // iadeEtButton
            // 
            this.iadeEtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.iadeEtButton.FlatAppearance.BorderSize = 0;
            this.iadeEtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iadeEtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iadeEtButton.Location = new System.Drawing.Point(748, 443);
            this.iadeEtButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iadeEtButton.Name = "iadeEtButton";
            this.iadeEtButton.Size = new System.Drawing.Size(277, 114);
            this.iadeEtButton.TabIndex = 26;
            this.iadeEtButton.Text = "İADE ET";
            this.iadeEtButton.UseVisualStyleBackColor = false;
            this.iadeEtButton.Click += new System.EventHandler(this.iadeEtButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(748, 578);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(277, 46);
            this.cikisButton.TabIndex = 27;
            this.cikisButton.Text = "ÇIKIŞ YAP";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // toplamTutarLabel
            // 
            this.toplamTutarLabel.AutoSize = true;
            this.toplamTutarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamTutarLabel.Location = new System.Drawing.Point(585, 623);
            this.toplamTutarLabel.Name = "toplamTutarLabel";
            this.toplamTutarLabel.Size = new System.Drawing.Size(0, 26);
            this.toplamTutarLabel.TabIndex = 30;
            this.toplamTutarLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // iadeDGW
            // 
            this.iadeDGW.AllowUserToAddRows = false;
            this.iadeDGW.AllowUserToDeleteRows = false;
            this.iadeDGW.AllowUserToResizeColumns = false;
            this.iadeDGW.AllowUserToResizeRows = false;
            this.iadeDGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iadeDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iadeDGW.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.iadeDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iadeDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.iadeDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.iadeDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iadeDGW.ColumnHeadersVisible = false;
            this.iadeDGW.Location = new System.Drawing.Point(32, 137);
            this.iadeDGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iadeDGW.MultiSelect = false;
            this.iadeDGW.Name = "iadeDGW";
            this.iadeDGW.ReadOnly = true;
            this.iadeDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.iadeDGW.RowHeadersVisible = false;
            this.iadeDGW.RowHeadersWidth = 51;
            this.iadeDGW.RowTemplate.Height = 24;
            this.iadeDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.iadeDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iadeDGW.Size = new System.Drawing.Size(669, 421);
            this.iadeDGW.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Urun_Iade_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.iadeDGW);
            this.Controls.Add(this.toplamTutarLabel);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.iadeEtButton);
            this.Controls.Add(this.fisGetirButton);
            this.Controls.Add(this.fisGirisiTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Urun_Iade_View";
            this.Text = "Ürün İade";
            this.Load += new System.EventHandler(this.Urun_Iade_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iadeDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fisGirisiTxt;
        private System.Windows.Forms.Button fisGetirButton;
        private System.Windows.Forms.Button iadeEtButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Label toplamTutarLabel;
        private System.Windows.Forms.DataGridView iadeDGW;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}