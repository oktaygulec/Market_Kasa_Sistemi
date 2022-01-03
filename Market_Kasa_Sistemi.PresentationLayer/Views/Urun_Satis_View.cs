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
        public Urun_Satis_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Urun_Satis_View_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
(
                this.Size,
                "Satış",
                satisDGW,
                new string[] { "Barkod", "Adı", "Adeti", "Fiyatı" },
                new float[] { 20f, 40f, 15f, 25f },
                RightTable(),
                toplamTutarLabel
            );

            this.Controls.Add(tlp);
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

        private void UrunAdd()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                source.Add(uow.UrunRepository.GetItem(Convert.ToInt32(urunGirisiTxt.Text)));
                toplamTutar += (source.Current as Urun).UrunFiyat;
                toplamTutarLabel.Text = toplamTutar.ToString("C2");
            }
        }

        private void SatisYap()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Fis newFis = new Fis
                {
                    FisTarih = DateTime.Now,
                    OdemeTip = odemeTipiComboBox.SelectedItem as OdemeTip,
                    Personel = uow.PersonelRepository.GetItem(Program.Kullanici.Personel.Id)
                };

                newFis.Id = Convert.ToInt32(uow.FisRepository.Add(newFis));

                List<Satis> satislar = new List<Satis>();

                for (int i = 0; i < source.List.Count; i++)
                {
                    Urun currentUrun = source.List[i] as Urun;
                    if(satislar.FirstOrDefault(x => x.UrunBarkod == currentUrun.Id) != null)
                    {
                        Satis satis = satislar.FirstOrDefault(x => x.UrunBarkod == currentUrun.Id);
                        satis.SatisAdet++;
                        satis.Urun.UrunFiyat = currentUrun.UrunFiyat * satis.SatisAdet;
                    }
                    else
                    {
                        satislar.Add
                        (
                            new Satis 
                            {
                                SatisAdet = 1,
                                Fis = newFis,
                                Urun = currentUrun
                            }
                        );
                    }
                }

                foreach (Satis item in satislar)
                {
                    uow.SatisRepository.Add(item);
                }

                MessageBox.Show(newFis.Id.ToString());
                source.Clear();
                toplamTutar = 0;
                toplamTutarLabel.Text = "";
            }
        }

        private void iptalEtButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            UrunAdd();
        }

        private void satisYapButton_Click(object sender, EventArgs e)
        {
            SatisYap();
        }
    }
}
