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
                new ResponsiveControl(stokBilgisiButton, this.Size, ControlType.Button),
                new ResponsiveControl(kullaniciDegistirButton, this.Size, ControlType.Button),
                new ResponsiveControl(programKapatButton, this.Size, ControlType.Button)
            };

            Label title = new Label
            {
                Text = "Ana Sayfa"
            };

            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            TableLayoutPanel tlp = TableLayoutMaker.CreateEqualSizedTable(
                responsiveTitle, 
                "mainTable", 
                controls,
                3, 2
            );

            this.Controls.Add(tlp);
        }
    }
}
