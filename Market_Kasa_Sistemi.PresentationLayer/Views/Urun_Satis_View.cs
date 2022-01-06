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
    public partial class Urun_Satis_View : Form
    {
        BindingSource source;
        decimal toplamTutar = 0;
        decimal kdvliToplamTutar = 0;
        public Urun_Satis_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Urun_Satis_View_Load(object sender, EventArgs e)
        {
            FormSettings.SetFullscreen(this);
            FormSettings.SetDataGridView(satisDGW);

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
(
                this.Size,
                satisDGW,
                new string[] { "Barkod", "Adı", "Adeti", "Fiyatı" },
                RightTable(),
                toplamTutarLabel
            );
            Label title = new Label { Text = "Satış" };
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            this.Controls.Add(TableLayoutMaker.CreateContainerTable(responsiveTitle,tlp));
            satisDGW.DataSource = source;
            toplamTutarLabel.Text = "";
            
            using(UnitOfWork uow = new UnitOfWork())
            {
                odemeTipiComboBox.DataSource = uow.OdemeTipRepository.ToList();
                odemeTipiComboBox.DisplayMember = "OdemeTipAd";
            }
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

        List<Satis> satislar = new List<Satis>();

        private void SatisEkle()
        {
            Urun currentUrun;

            using (UnitOfWork uow = new UnitOfWork())
            {
                currentUrun = uow.UrunRepository.GetItem(Convert.ToInt32(urunGirisiTxt.Text));
            }
            if(currentUrun.Id != 0) { 
                Satis satis = satislar.FirstOrDefault(x => x.UrunBarkod == currentUrun.Id);
                
                if (satis == null)
                {
                    satislar.Add
                    (
                        new Satis
                        {
                            SatisAdet = 1,
                            Fis = new Fis(),
                            Urun = currentUrun
                        }
                    );
                }
                else
                {
                    satis.SatisAdet += 1;
                }

                toplamTutar += currentUrun.UrunFiyat;
                kdvliToplamTutar += currentUrun.KdvliUrunFiyat;

                source.DataSource = satislar;
                source.ResetBindings(false);
                toplamTutarLabel.Text = "Toplam tutar: " + toplamTutar.ToString("C2") + "\n KDV'li toplam tutar: " + kdvliToplamTutar.ToString("C2");
            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı", "Ürün Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SatisCikart()
        {
            Satis currentSatis = source.Current as Satis;
            satislar.Remove(currentSatis);
            source.Remove(currentSatis);
            toplamTutar -= currentSatis.ToplamFiyat;
            kdvliToplamTutar -= currentSatis.ToplamKdvliFiyat;
            toplamTutarLabel.Text = "Toplam tutar: " + toplamTutar.ToString("C2") + "\n KDV'li toplam tutar: " + kdvliToplamTutar.ToString("C2");

            source.ResetBindings(false);
        }

        private void SatisYap()
        {
            Fis newFis;
            using (UnitOfWork uow = new UnitOfWork())
            {
                newFis = new Fis
                {
                    FisTarih = DateTime.Now,
                    Personel = uow.PersonelRepository.GetItem(Program.Kullanici.Personel.Id),
                    OdemeTip = odemeTipiComboBox.SelectedItem as OdemeTip
                };

                newFis.Id = Convert.ToInt32(uow.FisRepository.Add(newFis));

                foreach (Satis item in satislar)
                {
                    item.Fis = newFis;
                    uow.SatisRepository.Add(item);
                }
            }

            MessageBox.Show(newFis.Id.ToString());
            source.Clear();
            toplamTutar = 0;
            kdvliToplamTutar = 0;
            toplamTutarLabel.Text = "";
            urunGirisiTxt.Text = "";
        }

        private void iptalEtButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            if (Validation.ValidationControl(errorProvider1, urunGirisiTxt))
            {
                SatisEkle();
            }
        }

        private void satisYapButton_Click(object sender, EventArgs e)
        {
            if (source.List.Count > 0)
                SatisYap();
            else
                MessageBox.Show("Ürün Girişi Yapınız..","Ürün Satış",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void urunCikartButton_Click(object sender, EventArgs e)
        {
            if (source.List.Count > 0)
                SatisCikart();
            else
                MessageBox.Show("Ürün Giriniz..", "Ürün Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
