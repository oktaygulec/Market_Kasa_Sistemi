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
    public partial class Ana_Menu_Kasiyer_View : Form
    {
        public Ana_Menu_Kasiyer_View()
        {
            InitializeComponent();
        }

        private void Ana_Menu_Kasiyer_View_Load(object sender, EventArgs e)
        {
            ResponsiveControl[] controls = {
                new ResponsiveControl(satisButton, this.Size, ControlType.Button),
                new ResponsiveControl(iadeButton, this.Size, ControlType.Button),
                new ResponsiveControl(barkodOkuButton, this.Size, ControlType.Button),
                new ResponsiveControl(programKapatButton, this.Size, ControlType.Button)
            };

            Label title = new Label
            {
                Text = "Ana Sayfa"
            };

            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            TableLayoutPanel panel = TableLayoutMaker.CreateEqualSizedTable(
                "mainTable", 
                controls,
                2, 2
            );

            TableLayoutPanel tlp = TableLayoutMaker.CreateContainerTable(responsiveTitle, panel);

            this.Controls.Add(tlp);
        }

        private void programKapatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void satisButton_Click(object sender, EventArgs e)
        {
            Urun_Satis_View satisView = new Urun_Satis_View();
            satisView.Show();
        }

        private void iadeButton_Click(object sender, EventArgs e)
        {
            Urun_Iade_View iadeView = new Urun_Iade_View();
            iadeView.Show();
        }

        private void barkodOkuButton_Click(object sender, EventArgs e)
        {
            Barkod_Oku_View barkodOkuView = new Barkod_Oku_View();
            barkodOkuView.Show();
        }
    }
}
