using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.DatabaseAccessLayer;
using Market_Kasa_Sistemi.Enums;
using Market_Kasa_Sistemi.Models;
using Market_Kasa_Sistemi.Utils;
using Market_Kasa_Sistemi.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi
{
    public partial class Main_View : Form
    {
        public Main_View()
        {
            InitializeComponent();
        }
        private void kullanici_PlaceholderEnter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "Kullanıcı Adı" || textbox.Text == "Şifre")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }

        private void kullanici_PlaceholderLeave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            string textBoxName = textbox.Name;
            if (textbox.Text == "")
            {
                if (textBoxName == "kullaniciAdiTxt")
                {
                    textbox.Text = Properties.Settings.Default.PlaceholderAd;
                    textbox.ForeColor = Color.DarkGray;
                }
                else
                {
                    textbox.Text = Properties.Settings.Default.PlaceholderSifre;
                    textbox.ForeColor = Color.DarkGray;
                }
            }
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            using(UnitOfWork uow = new UnitOfWork())
            {
                if(uow.KullaniciRepository.Login(kullaniciAdiTxt.Text, kullaniciSifreTxt.Text))
                {
                    Program.Kullanici = uow.KullaniciRepository.GetItem(kullaniciAdiTxt.Text);
                    lblWrong.Text = "";
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lblWrong.Text = "Kullanıcı adınız veya şifreniz yanlış.";
                }
            }
        }

        private void Main_View_Load(object sender, EventArgs e)
        {
            this.Controls.Add(MainTable());
            this.AcceptButton = girisYapButton;
        }

        private TableLayoutPanel MainTable()
        {
            Size newSize = new Size((int)(this.Size.Width + 400), (int)(this.Size.Height + 400));
            TableLayoutPanel kullaniciAdiPanel = TableLayoutMaker.CreateInputWithTitleTable("Kullanıcı Adı", "kullaniciAdiLabelText", kullaniciAdiTxt, newSize);
            TableLayoutPanel kullaniciSifrePanel = TableLayoutMaker.CreateInputWithTitleTable("Şifre", "kullaniciSifreLabelText", kullaniciSifreTxt, newSize);

            TableLayoutPanel tableInputs = TableLayoutMaker.CreateResponsiveTable
            (
                "tableInputs",
                new TableLayoutPanel[] { kullaniciAdiPanel, kullaniciSifrePanel },
                2, 1,
                new float[] { 50f, 50f },
                new float[] { 100f }
            );

            TableLayoutPanel tableButtons = TableLayoutMaker.CreateResponsiveTable
            (
                "tableButtons",
                new ResponsiveControl[] 
                { 
                    new ResponsiveControl(girisYapButton, newSize, ControlType.Button),
                    new ResponsiveControl(kayitOlButton, newSize, ControlType.Button)
                },
                1, 2,
                new float[] { 100f },
                new float[] { 50f, 50f }
            );

            TableLayoutPanel panel = TableLayoutMaker.CreateResponsiveTable
            (
                "panel",
                new TableLayoutPanel[] { tableInputs, tableButtons },
                2, 1,
                new float[] { 50f, 50f },
                new float[] { 100f }
            );

            ResponsiveControl title = new ResponsiveControl(new Label { Name = "titleLabel", Text = "KULLANICI GİRİŞİ" }, this.Size, ControlType.HeadTitle);
            return TableLayoutMaker.CreateContainerTable(title, panel);
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            Kayit_Ol_View kayitOlView = new Kayit_Ol_View();
            kayitOlView.ShowDialog();
        }
    }
}
