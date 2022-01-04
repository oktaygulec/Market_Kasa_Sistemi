using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.DatabaseAccessLayer;
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
    public partial class Z_Raporu_View : Form
    {
        BindingSource source;
        public Z_Raporu_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Z_Raporu_View_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            Label title = new Label { Text = "Z Raporu" };
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            this.Controls.Add(TableLayoutMaker.CreateContainerTable(responsiveTitle, GetView()));
            GetZRaporu();
        }

        private TableLayoutPanel GetView()
        {
            TableLayoutPanel table = TableLayoutMaker.CreateTitlesAndDGWTable
            (
                this.Size,
                zRaporuDGW,
                new string[] { "Barkod", "Adı", "Adeti", "Fiyatı" },
                new float[] { 20f, 40f, 15f, 25f }
            );
            ResponsiveControl cikisButtonResponsive = new ResponsiveControl(cikisButton, this.Size, ControlType.Button);
            ResponsiveControl zRaporuYazdirButtonResponsive = new ResponsiveControl(zRaporuYazdirButton, this.Size, ControlType.Button);
            TableLayoutPanel buttonTable = TableLayoutMaker.CreateResponsiveTable
            (
                "buttonTable",
                new ResponsiveControl[] { zRaporuYazdirButtonResponsive, cikisButtonResponsive },
                1, 2,
                new float[] { 100f },
                new float[] { 50f, 50f }
            );
            return TableLayoutMaker.CreateResponsiveTable
            (
                "mainTable",
                new TableLayoutPanel[] { table, buttonTable },
                2, 1,
                new float[] { 85f, 15f },
                new float[] { 100f }
            );
        }

        private void GetZRaporu()
        {
            zRaporuDGW.DataSource = source;

            using (UnitOfWork uow = new UnitOfWork())
            {
                source.DataSource = uow.SatisRepository.GetZReport();
            }
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
