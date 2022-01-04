
namespace Market_Kasa_Sistemi.Views
{
    partial class Z_Raporu_View
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
            this.zRaporuDGW = new System.Windows.Forms.DataGridView();
            this.cikisButton = new System.Windows.Forms.Button();
            this.zRaporuYazdirButton = new System.Windows.Forms.Button();
            this.toplamTutarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zRaporuDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // zRaporuDGW
            // 
            this.zRaporuDGW.AllowUserToAddRows = false;
            this.zRaporuDGW.AllowUserToDeleteRows = false;
            this.zRaporuDGW.AllowUserToResizeColumns = false;
            this.zRaporuDGW.AllowUserToResizeRows = false;
            this.zRaporuDGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zRaporuDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zRaporuDGW.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.zRaporuDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zRaporuDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.zRaporuDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.zRaporuDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zRaporuDGW.ColumnHeadersVisible = false;
            this.zRaporuDGW.Location = new System.Drawing.Point(11, 66);
            this.zRaporuDGW.Margin = new System.Windows.Forms.Padding(2);
            this.zRaporuDGW.MultiSelect = false;
            this.zRaporuDGW.Name = "zRaporuDGW";
            this.zRaporuDGW.ReadOnly = true;
            this.zRaporuDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.zRaporuDGW.RowHeadersVisible = false;
            this.zRaporuDGW.RowHeadersWidth = 51;
            this.zRaporuDGW.RowTemplate.Height = 24;
            this.zRaporuDGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.zRaporuDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zRaporuDGW.Size = new System.Drawing.Size(483, 339);
            this.zRaporuDGW.TabIndex = 1;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cikisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikisButton.Location = new System.Drawing.Point(608, 322);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(16);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(167, 83);
            this.cikisButton.TabIndex = 9;
            this.cikisButton.Text = "ÇIKIŞ YAP";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // zRaporuYazdirButton
            // 
            this.zRaporuYazdirButton.BackColor = System.Drawing.Color.Green;
            this.zRaporuYazdirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zRaporuYazdirButton.FlatAppearance.BorderSize = 0;
            this.zRaporuYazdirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zRaporuYazdirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zRaporuYazdirButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zRaporuYazdirButton.Location = new System.Drawing.Point(608, 66);
            this.zRaporuYazdirButton.Margin = new System.Windows.Forms.Padding(16);
            this.zRaporuYazdirButton.Name = "zRaporuYazdirButton";
            this.zRaporuYazdirButton.Size = new System.Drawing.Size(167, 83);
            this.zRaporuYazdirButton.TabIndex = 10;
            this.zRaporuYazdirButton.Text = "RAPOR YAZDIR";
            this.zRaporuYazdirButton.UseVisualStyleBackColor = false;
            // 
            // toplamTutarLabel
            // 
            this.toplamTutarLabel.AutoSize = true;
            this.toplamTutarLabel.Location = new System.Drawing.Point(459, 424);
            this.toplamTutarLabel.Name = "toplamTutarLabel";
            this.toplamTutarLabel.Size = new System.Drawing.Size(0, 13);
            this.toplamTutarLabel.TabIndex = 11;
            this.toplamTutarLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Z_Raporu_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toplamTutarLabel);
            this.Controls.Add(this.zRaporuYazdirButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.zRaporuDGW);
            this.Name = "Z_Raporu_View";
            this.Text = "Z_Raporu_View";
            this.Load += new System.EventHandler(this.Z_Raporu_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zRaporuDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zRaporuDGW;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button zRaporuYazdirButton;
        private System.Windows.Forms.Label toplamTutarLabel;
    }
}