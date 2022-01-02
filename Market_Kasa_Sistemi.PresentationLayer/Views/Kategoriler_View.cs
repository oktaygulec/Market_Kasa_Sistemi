using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.Enums;
using Market_Kasa_Sistemi.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Views
{
    public partial class Kategoriler_View : Form
    {
        public Kategoriler_View()
        {
            InitializeComponent();
        }

        private void Kategoriler_View_Load(object sender, EventArgs e)
        {
            //TopMost = true;
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            
            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW(
                this.Size, "Kategoriler", 
                kategorilerDGW, 
                new string[] { "ID", "Kategori Adı" },
                new float[] { 30f, 70f }, 
                RightTable()
            );

            this.Controls.Add(tlp);
        }

        
        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel rightTableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Kategori Ekle", this.Size);

            ResponsiveControl[] rightTableComponentsControls = {
                new ResponsiveControl(kategoriEkleButton, this.Size, ControlType.Button),
                new ResponsiveControl(kategoriSilButton, this.Size, ControlType.Button),
            };

            ResponsiveControl rightTableBottomControl = new ResponsiveControl(cikisButton, this.Size, ControlType.Button);

            TableLayoutPanel rightTableComponents = TableLayoutMaker.CreateResponsiveTable(
                "rightTableComponents",
                rightTableComponentsControls,
                2, 1,
                new float[] { 50f, 50f },
                new float[] { 100f }
            );

            TableLayoutPanel rightTableBottom = TableLayoutMaker.CreateResponsiveTable(
                "rightTableBottom",
                rightTableBottomControl
            );

            TableLayoutPanel rightTableTopInput = TableLayoutMaker.CreateInputWithTitleTable(
                "Kategori Adı", "rightTableKategoriAdTitle", kategoriAdiTxt, this.Size);

            TableLayoutPanel rightTableContainer = TableLayoutMaker.CreateResponsiveTable(
                "rightTableContainer",
                new TableLayoutPanel[] { rightTableTitleWithDivider, rightTableTopInput, rightTableComponents, rightTableBottom },
                4, 1,
                new float[] { 10f, 20f, 40f, 30f },
                new float[] { 100f }
            );

            return rightTableContainer;
        }
    }
}
