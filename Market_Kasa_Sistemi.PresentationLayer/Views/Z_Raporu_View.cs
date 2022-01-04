using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.DatabaseAccessLayer;
using Market_Kasa_Sistemi.Enums;
using Market_Kasa_Sistemi.ModelLayer;
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
            FormSettings.SetDataGridView(zRaporuDGW);
            FormSettings.SetFullscreen(this);

            Label title = new Label { Text = "Z Raporu" };
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            this.Controls.Add(TableLayoutMaker.CreateContainerTable(responsiveTitle, GetView()));
            GetZRaporu();
        }

        private TableLayoutPanel GetView()
        {
            TableLayoutPanel tableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Satış Yap", this.Size);

            ResponsiveControl cikisButtonResponsive = new ResponsiveControl(cikisButton, this.Size, ControlType.Button);
            ResponsiveControl zRaporuYazdirButtonResponsive = new ResponsiveControl(zRaporuYazdirButton, this.Size, ControlType.Button);
            TableLayoutPanel buttonTable = TableLayoutMaker.CreateResponsiveTable
            (
                "buttonTable",
                new ResponsiveControl[] { zRaporuYazdirButtonResponsive, null, cikisButtonResponsive },
                3, 1,
                new float[] { 33f, 33f, 33f },
                new float[] { 100f }
            );

            TableLayoutPanel rightPanel = TableLayoutMaker.CreateResponsiveTable
            (
                "rightPanel",
                new TableLayoutPanel[] { tableTitleWithDivider, buttonTable },
                2, 1,
                new float[] { 10f, 90f },
                new float[] { 100f }
            );

            TableLayoutPanel table = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
            (
                this.Size,
                zRaporuDGW,
                new string[] { "ID", "Tarih", "Ödeme Tipi", "Toplam Fiyat"},
                rightPanel,
                toplamTutarLabel
            );

            return table;
        }

        private void GetZRaporu()
        {
            zRaporuDGW.DataSource = source;

            List<ZRaporu> rapor = new List<ZRaporu>();
            
            using (UnitOfWork uow = new UnitOfWork())
            {
                rapor = uow.SatisRepository.GetZReport();
                source.DataSource = rapor;
            }

            foreach (var item in rapor)
            {
                toplamTutarLabel.Text = rapor.Sum(x => x.ToplamFiyat).ToString("C2");
            }
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
