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
    public partial class Barkod_Oku_View : Form
    {
        public Barkod_Oku_View()
        {
            InitializeComponent();
        }

        private void Barkod_Oku_View_Load(object sender, EventArgs e)
        {
            // Responsive control'leri oluşturma
            ResponsiveControl[] barkodControl = 
            {
                new ResponsiveControl(barkodGirisiTxt, this.Size, TextType.ButtonText)
            };
            ResponsiveControl[] butonControls = 
            { 
                new ResponsiveControl(urunGetirButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(cikisYapButton, this.Size, TextType.ButtonText)
            };

            // Title için label oluşturma
            Label title = new Label
            {
                Text = "Barkod Oku".ToUpper()
            };

            // Title'ı responsive yapma
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, TextType.Title);

            // Barkod Girişi Input'u için tablo oluşturma
            TableLayoutPanel barkodGirisiPanel = TableLayoutMaker.CreateResponsiveTable(
                "barkodPanel", // tabloya verilecek ad
                barkodControl, // içerisine alınacak control'ler (component'ler)
                1, 1, // tablonun satır ve sütun sayısı
                new float[] { 50f }, // tablodaki satırların %'lik boyutu
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

            /* Yukarıda oluşturduğumuz tabloları container ile sarma 
               (%10'luk bir alana title, geri kalan %90'lık alana
               yukarıdaki tablolar ekleniyor)
            */
            TableLayoutPanel tlp = TableLayoutMaker.CreateContainerTable(responsiveTitle, surroundingPanel);

            // Oluşturulan tabloyu Form'a ekleme
            this.Controls.Add(tlp);
        }
    }
}
