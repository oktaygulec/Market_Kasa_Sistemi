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
    public partial class Barkod_Oku_View : Form
    {
        public Barkod_Oku_View()
        {
            InitializeComponent();
        }

        private void Barkod_Oku_View_Load(object sender, EventArgs e)
        {
            FormSettings.SetFullscreen(this);

            // Oluşturulan tabloyu Form'a ekleme
            this.Controls.Add(ContainerTable());
        }

        private TableLayoutPanel ContainerTable()
        {
            // Responsive control'leri oluşturma
            ResponsiveControl[] barkodControl =
            {
                null, // barkod textbox'ın aşağı doğru kayması için boşluk
                new ResponsiveControl(barkodGirisiTxt, new Size((int)(this.Size.Width + 500), (int)(this.Size.Height + 500)), ControlType.Input)
            };
            ResponsiveControl[] butonControls =
            {
                new ResponsiveControl(urunGetirButton, this.Size, ControlType.Button),
                new ResponsiveControl(cikisYapButton, this.Size, ControlType.Button)
            };

            // Barkod Girişi Input'u için tablo oluşturma
            TableLayoutPanel barkodGirisiPanel = TableLayoutMaker.CreateResponsiveTable(
                "barkodPanel", // tabloya verilecek ad
                barkodControl, // içerisine alınacak control'ler (component'ler)
                2, 1, // tablonun satır ve sütun sayısı (1. satır boşluk, 2. satır TextBox)
                new float[] { 50f, 50f }, // tablodaki satırların %'lik boyutu
                new float[] { 100f } // tablodaki sütunların %'lik boyutu
            );

            // Butonlar için tablo oluşturma
            TableLayoutPanel butonGirisiPanel = TableLayoutMaker.CreateResponsiveTable(
                "butonPanel", // tabloya verilecek ad
                butonControls, // içerisine alınacak control'ler (component'ler)
                1, 2, // tablonun satır ve sütun sayısı
                new float[] { 50f }, // tablodaki satırların %'lik boyutu
                new float[] { 50f, 50f } // tablodaki sütunların %'lik boyutu
            );

            // Barkod Input'unu ve Butonları sarmak için tablo oluşturma
            TableLayoutPanel surroundingPanel = TableLayoutMaker.CreateResponsiveTable(
                "surroundingPanel", // tabloya verilecek ad
                new TableLayoutPanel[] { barkodGirisiPanel, butonGirisiPanel }, // içerisine alınacak tablolar
                2, 1, // tablonun satır ve sütun sayısı
                new float[] { 30f, 70f }, // tablodaki satırların %'lik boyutu
                new float[] { 100f } // tablodaki sütunların %'lik boyutu
            );

            // Title için label oluşturma
            Label title = new Label
            {
                Text = "Barkod Oku"
            };

            // Title'ı responsive yapma
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            /* Yukarıda oluşturduğumuz tabloları container ile sarma 
               (%10'luk bir alana title, geri kalan %90'lık alana
               yukarıdaki tablolar ekleniyor)
            */
            return TableLayoutMaker.CreateContainerTable(responsiveTitle, surroundingPanel);
        }

        private void urunGetirButton_Click(object sender, EventArgs e)
        {
            if (Validation.ValidationControl(errorProvider1, barkodGirisiTxt))
            {
                Urun urun;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    urun = uow.UrunRepository.GetItem(Convert.ToInt32(barkodGirisiTxt.Text));
                }

                if (urun.Id != 0)
                {
                    MessageBox.Show(urun.UrunAd + " - Fiyat: " + urun.UrunFiyat, "Ürün Getir", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.", "Ürün Getir", MessageBoxButtons.OK);
                }
            }
        }

        private void cikisYapButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
