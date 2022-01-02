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
    public partial class Urunler_View : Form
    {
        public Urunler_View()
        {
            InitializeComponent();
        }

        private void Urunler_View_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
            (
                this.Size,
                "Ürünler",
                urunlerDGW,
                new string[] { "Barkod", "Ad", "Adet", "Fiyat", "Kategori", "Vergi" },
                new float[] { 15f, 15f, 15f, 15f, 15f, 15f },
                RightTable()
            );
            this.Controls.Add(tlp);
        }

        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel tableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Ürün Giriş", this.Size);

            TableLayoutPanel tableUrunAdInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Ürün Adı",
                "urunAdiInputTitle",
                urunAdiTxt,
                this.Size
            );

            TableLayoutPanel tableUrunFiyatInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Ürün Fiyatı",
                "urunFiyatiInputTitle",
                urunFiyatiTxt,
                this.Size
            );

            TableLayoutPanel tableUrunAdetInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Ürün Stok Adeti",
                "urunAdetiInputTitle",
                urunAdetTxt,
                this.Size
            );

            TableLayoutPanel tableUrunKategoriInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Ürün Kategorisi",
                "urunKategoriInputTitle",
                urunKategoriComboBox,
                this.Size
            );

            TableLayoutPanel tableUrunVergiInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Vergi Miktarı",
                "urunVergiMiktarInputTitle",
                vergiMiktarComboBox,
                this.Size
            );

            TableLayoutPanel tableInputs = TableLayoutMaker.CreateResponsiveTable
            (
                "tableInputs",
                new TableLayoutPanel[]
                {
                    tableUrunAdInput,
                    tableUrunFiyatInput,
                    tableUrunAdetInput,
                    tableUrunKategoriInput,
                    tableUrunVergiInput
                },
                5, 1,
                new float[] { 20f, 20f, 20f, 20f, 20f },
                new float[] { 100f }
            );

            TableLayoutPanel tableButtons = TableLayoutMaker.CreateResponsiveTable
            (
                "tableButtons",
                new ResponsiveControl[]
                {
                    new ResponsiveControl(urunEkleButton, this.Size, ControlType.Button),
                    new ResponsiveControl(urunDuzenleButton, this.Size, ControlType.Button),
                    new ResponsiveControl(urunSilButton, this.Size, ControlType.Button),
                    new ResponsiveControl(cikisButton, this.Size, ControlType.Button),
                },
                4, 1,
                new float[] { 25f, 25f, 25f, 25f },
                new float[] { 100f }
            );

            TableLayoutPanel tableUrunIslem = TableLayoutMaker.CreateResponsiveTable
            (
                "tableUrunIslem",
                new TableLayoutPanel[] { tableInputs, tableButtons },
                2, 1,
                new float[] { 60f, 40f },
                new float[] { 100f }
            );

            return TableLayoutMaker.CreateResponsiveTable
            (
                "rightTable",
                new TableLayoutPanel[] { tableTitleWithDivider, tableUrunIslem },
                2, 1,
                new float[] { 10f, 90f },
                new float[] { 100f }
            );
        }
    }
}
