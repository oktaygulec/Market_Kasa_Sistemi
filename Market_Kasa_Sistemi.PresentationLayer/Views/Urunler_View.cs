using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.DatabaseAccessLayer;
using Market_Kasa_Sistemi.Enums;
using Market_Kasa_Sistemi.Models;
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
        BindingSource source;
        public Urunler_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Urunler_View_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
            (
                this.Size,
                urunlerDGW,
                new string[] { "Barkod", "Ad", "Fiyat", "Adet", "Kategori", "Vergi" },
                new float[] { 15f, 15f, 15f, 15f, 15f, 15f },
                RightTable()
            );
            Label title = new Label { Text = "Ürünler" };
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            this.Controls.Add(TableLayoutMaker.CreateContainerTable(responsiveTitle, tlp));

            GetUrunler();
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

        private void GetUrunler()
        {
            urunlerDGW.DataSource = source;
            using (UnitOfWork uow = new UnitOfWork())
            {
                source.DataSource = uow.UrunRepository.ToList();

                urunKategoriComboBox.DataSource = uow.KategoriRepository.ToList();
                urunKategoriComboBox.DisplayMember = "KategoriAd";

                vergiMiktarComboBox.DataSource = uow.VergiRepository.ToList();
                vergiMiktarComboBox.DisplayMember = "VergiMiktar";
            }
        }

        private void AddNewUrunler()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Urun newUrun = new Urun
                {
                    UrunAd = urunAdiTxt.Text,
                    UrunFiyat = Convert.ToDecimal(urunFiyatiTxt.Text),
                    UrunStokAdet = Convert.ToInt32(urunAdetTxt.Text),
                    Kategori = urunKategoriComboBox.SelectedItem as Kategori,
                    Vergi = vergiMiktarComboBox.SelectedItem as Vergi,
                };
                newUrun.Id = Convert.ToInt32(uow.UrunRepository.Add(newUrun));
                source.Add(newUrun);
            }
        }

        private void RemoveUrun()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Urun removeThis = source.Current as Urun;
                uow.UrunRepository.Remove(removeThis);
                source.Remove(removeThis);
            }
        }

        private void UpdateUrun()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Urun updateThis = source.Current as Urun;
                updateThis.UrunAd = urunAdiTxt.Text;
                updateThis.UrunFiyat = Convert.ToDecimal(urunFiyatiTxt.Text);
                updateThis.UrunStokAdet = Convert.ToInt32(urunAdetTxt.Text);
                updateThis.Kategori = urunKategoriComboBox.SelectedItem as Kategori;
                updateThis.Vergi = vergiMiktarComboBox.SelectedItem as Vergi;
                uow.UrunRepository.Update(updateThis);
                source.ResetCurrentItem();
            }
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            AddNewUrunler();
        }

        private void urunDuzenleButton_Click(object sender, EventArgs e)
        {
            UpdateUrun();
        }

        private void urunSilButton_Click(object sender, EventArgs e)
        {
            RemoveUrun();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunlerDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Urun currentUrun = source.Current as Urun;
            urunAdiTxt.Text = currentUrun.UrunAd;
            urunFiyatiTxt.Text = currentUrun.UrunFiyat.ToString();
            urunAdetTxt.Text = currentUrun.UrunStokAdet.ToString();
            urunKategoriComboBox.SelectedIndex = urunKategoriComboBox.FindStringExact(currentUrun.KategoriAd);
            vergiMiktarComboBox.SelectedIndex = vergiMiktarComboBox.FindStringExact(currentUrun.VergiMiktar.ToString());
        }
    }
}
