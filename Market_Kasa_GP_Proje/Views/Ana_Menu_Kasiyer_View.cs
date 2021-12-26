using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_GP_Proje.Views
{
    public partial class Ana_Menu_Kasiyer_View : Form
    {
        public Ana_Menu_Kasiyer_View()
        {
            InitializeComponent();
        }

        private void Ana_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
