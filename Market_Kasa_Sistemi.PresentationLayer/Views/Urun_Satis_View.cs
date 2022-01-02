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
    public partial class Urun_Satis_View : Form
    {
        public Urun_Satis_View()
        {
            InitializeComponent();
        }

        private void Urun_Satis_View_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
(
                this.Size,
                "Satış",
                satisDGW,
                new string[] { "Barkod", "Adı", "Adeti", "Fiyatı" },
                new float[] { 20f, 40f, 15f, 25f },
                RightTable(),
                toplamTutar
            );

            this.Controls.Add(tlp);
        }

        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel tableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Satış Yap", this.Size);

            TableLayoutPanel tableUrunGirisInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Ürün Giriş",
                "urunGirisInputTitle",
                urunGirisiTxt,
                this.Size
            );

            ResponsiveControl[] buttonControls = new ResponsiveControl[]
            {
                new ResponsiveControl(urunEkleButton, this.Size, ControlType.Button),
                new ResponsiveControl(urunCikartButton, this.Size, ControlType.Button)
            };

            TableLayoutPanel tableUrunGirisButtons = TableLayoutMaker.CreateResponsiveTable
            (
                "tableUrunGirisButtons",
                buttonControls,
                2, 1,
                new float [] { 50f, 50f },
                new float [] { 100f }
            );

            TableLayoutPanel tableUrunGiris = TableLayoutMaker.CreateResponsiveTable
            (
                "tableUrunGiris",
                new TableLayoutPanel[] { tableUrunGirisInput, tableUrunGirisButtons, null },
                3, 1,
                new float[] { 30f, 50f, 20f },
                new float[] { 100f }
            );

            TableLayoutPanel tableOdemeTipInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Ödeme Tipi",
                "odemeTipInputTitle",
                odemeTipiComboBox,
                this.Size
            );

            TableLayoutPanel tableBottomButtons = TableLayoutMaker.CreateResponsiveTable
            (
                "tableBottomButtons",
                new ResponsiveControl[]
                {
                    new ResponsiveControl(satisYapButton, this.Size, ControlType.Button),
                    new ResponsiveControl(iptalEtButton, this.Size, ControlType.Button)
                },
                2, 1,
                new float[] { 70f, 30f },
                new float[] { 100f }
            );

            return TableLayoutMaker.CreateResponsiveTable
            (
                "rightTable",
                new TableLayoutPanel[] { tableTitleWithDivider, tableUrunGiris, tableOdemeTipInput, tableBottomButtons},
                4, 1,
                new float[] { 10f, 40f, 15f, 35f },
                new float[] { 100f }
            );
        }
    }
}
