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
    public partial class Yonetici_Ayarlar_View : Form
    {
        public Yonetici_Ayarlar_View()
        {
            InitializeComponent();
        }

        private void Yonetici_Ayarlar_View_Load(object sender, EventArgs e)
        {
            FormSettings.SetFullscreen(this);

            this.Controls.Add(MainTable());
        }

        private TableLayoutPanel MainTable()
        {
            ResponsiveControl[] controls = {
                new ResponsiveControl(kullanicilarButton, this.Size, ControlType.Button),
                new ResponsiveControl(personellerButton, this.Size, ControlType.Button),
                new ResponsiveControl(urunlerButton, this.Size, ControlType.Button),
                new ResponsiveControl(kategorilerButton, this.Size, ControlType.Button)
            };

            Label title = new Label
            {
                Text = "Yönetici Ayarları"
            };

            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            TableLayoutPanel mainButtons = TableLayoutMaker.CreateEqualSizedTable(
                "mainButtons",
                controls,
                2, 2
            );

            TableLayoutPanel anaMenuButton = TableLayoutMaker.CreateResponsiveTable
            (
                "anaMenuTable", 
                new ResponsiveControl[]
                {
                    null,
                    new ResponsiveControl(anaMenuyeDonButton, this.Size, ControlType.Button),
                    null
                },
                1, 3,
                new float[] { 100f },
                new float[] { 25f, 50f, 25f }
            );

            TableLayoutPanel panel = TableLayoutMaker.CreateResponsiveTable
            (
                "mainTable",
                new TableLayoutPanel[] 
                { 
                    mainButtons, 
                    anaMenuButton
                },
                2, 1,
                new float[] { 70f, 30f },
                new float[] { 100f }
            );

            return TableLayoutMaker.CreateContainerTable(responsiveTitle, panel);
        }

        private void kullanicilarButton_Click(object sender, EventArgs e)
        {
            Kullanicilar_View kullanicilarView = new Kullanicilar_View();
            kullanicilarView.Show();
        }

        private void personellerButton_Click(object sender, EventArgs e)
        {
            Personeller_View personellerView = new Personeller_View();
            personellerView.Show();
        }

        private void urunlerButton_Click(object sender, EventArgs e)
        {
            Urunler_View urunlerView = new Urunler_View();
            urunlerView.Show();
        }

        private void kategorilerButton_Click(object sender, EventArgs e)
        {
            Kategoriler_View kategorilerView = new Kategoriler_View();
            kategorilerView.Show();
        }

        private void anaMenuyeDonButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
