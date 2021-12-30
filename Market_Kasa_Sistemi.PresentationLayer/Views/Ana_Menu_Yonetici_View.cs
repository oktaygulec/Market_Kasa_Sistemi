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

            ResponsiveControl[] controls = {
                new ResponsiveControl(satisButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(iadeButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(barkodOkuButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(zRaporuButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(stokBilgisiButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(yoneticiAyarlariButton, this.Size, TextType.ButtonText),
                new ResponsiveControl(kullaniciDegistirButton, this.Size, TextType.ButtonText),
                null,
                new ResponsiveControl(programKapatButton, this.Size, TextType.ButtonText)
            };

            TableLayoutTemplate.TableLayoutOnlyButtons(3, 3, "Ana Menü", tableLayoutPanel1, controls, this.Size);
        }
    }
}
