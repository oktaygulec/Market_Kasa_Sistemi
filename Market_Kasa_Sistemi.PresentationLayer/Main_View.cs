using Market_Kasa_Sistemi.DatabaseAccessLayer;
using Market_Kasa_Sistemi.Models;
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

        private void Main_View_Load(object sender, EventArgs e)
        {

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
    }
}
