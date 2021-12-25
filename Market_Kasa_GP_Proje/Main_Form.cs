using Market_Kasa_GP_Proje.Models;
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

namespace Market_Kasa_GP_Proje
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void kullanici_Placeholder(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "Kullanıcı Adı" || textbox.Text == "Şifre")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }
        private void kullaniciGirisPaneli_Load(object sender, EventArgs e)
        {
            
        }

        private void formKapat(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {

        }
    }
}
