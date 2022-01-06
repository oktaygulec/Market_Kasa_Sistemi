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
    public partial class Kayit_Ol_View : Form
    {
        public Kayit_Ol_View()
        {
            InitializeComponent();
        }

        private void Kayit_Ol_View_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                personelComboBox.DataSource = uow.PersonelRepository.ToList();
                personelComboBox.DisplayMember = "PersonelAd";
            }

            this.Controls.Add(Table());
        }

        private TableLayoutPanel Table()
        {
            Size newSize = new Size((int)(this.Size.Width + 400), (int)(this.Size.Height + 400));

            TableLayoutPanel kullaniciAdiPanel = TableLayoutMaker.CreateInputWithTitleTable(
                "Kullanıcı Adı",
                "kullaniciAdiPanel",
                kullaniciAdiTxt,
                newSize
            );

            TableLayoutPanel kullaniciSifrePanel = TableLayoutMaker.CreateInputWithTitleTable(
                "Şifre",
                "kullaniciSifrePanel",
                kullaniciSifreTxt,
                newSize
            );

            TableLayoutPanel kasiyerPanel = TableLayoutMaker.CreateInputWithTitleTable(
                "Kasiyer",
                "kullaniciSifrePanel",
                personelComboBox,
                newSize
            );

            ResponsiveControl[] buttons = new ResponsiveControl[]
            {
                new ResponsiveControl(kayitOlButton, this.Size, ControlType.Button),
                new ResponsiveControl(iptalButton, this.Size, ControlType.Button),
            };

            TableLayoutPanel buttonsPanel = TableLayoutMaker.CreateResponsiveTable(
                "ButtonsPanel",
                buttons,
                1, 2,
                new float[] { 100f },
                new float[] { 50f, 50f }
            );

            TableLayoutPanel panel = TableLayoutMaker.CreateResponsiveTable(
                "MainPanel",
                new TableLayoutPanel[] { kullaniciAdiPanel, kullaniciSifrePanel, kasiyerPanel, buttonsPanel },
                4, 1,
                new float[] { 25f, 25f, 25f, 25f },
                new float[] { 100f }
            );

            ResponsiveControl title = new ResponsiveControl(new Label() { Text = "Kayıt Ol", Name = "formTitle" }, this.Size, ControlType.HeadTitle);
            return TableLayoutMaker.CreateContainerTable(title, panel);
        }

        private void AddNewUser()
        {
            Kullanici newUser = new Kullanici
            {
                KullaniciAd = kullaniciAdiTxt.Text,
                KullaniciSifre = kullaniciSifreTxt.Text,
                Personel = personelComboBox.SelectedItem as Personel
            };
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.KullaniciRepository.Add(newUser);
            }
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            AddNewUser();
            MessageBox.Show("Yeni kullanıcı oluşturuldu.");
            this.Close();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personelComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string ad = (e.ListItem as Personel).PersonelAd;
            string soyad = (e.ListItem as Personel).PersonelSoyad;

            e.Value = ad + " " + soyad;
        }
    }
}
