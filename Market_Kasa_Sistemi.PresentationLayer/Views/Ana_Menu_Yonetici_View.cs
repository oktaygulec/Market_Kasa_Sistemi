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
    public partial class Ana_Menu_Yonetici_View : Form
    {
        public Ana_Menu_Yonetici_View()
        {
            InitializeComponent();
        }

        private void Ana_Menu_Yonetici_View_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            ChangeFontSizes(this);
        }

        private void ChangeFontSizes(Form form)
        {
            Button[] buttons = {
                satisButton,
                iadeButton,
                barkodOkuButton,
                zRaporuButton,
                stokBilgisiButton,
                yoneticiAyarlariButton,
                kullaniciDegistirButton,
                programKapatButton
            };
            ResponsiveFontSize.MakeResponsive(lblTitle, form, ResponsiveFontSize.TextType.Title);
            ResponsiveFontSize.MakeResponsive(buttons, form, ResponsiveFontSize.TextType.Text);
        }
    }
}
