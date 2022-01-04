using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.DatabaseAccessLayer;
using Market_Kasa_Sistemi.Enums;
using Market_Kasa_Sistemi.Models;
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
    public partial class Urun_Iade_View : Form
    {
        BindingSource source;
        decimal toplamTutar = 0;
        decimal kdvliToplamTutar = 0;
        public Urun_Iade_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Urun_Iade_View_Load(object sender, EventArgs e)
        {
            FormSettings.SetDataGridView(iadeDGW);
            FormSettings.SetFullscreen(this);

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
            (
                this.Size,
                iadeDGW,
                new string[] { "Barkod", "Adı", "Adeti", "Fiyatı" },
                RightTable(),
                toplamTutarLabel
            );
            Label title = new Label { Text = "Ürün İade" };
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            this.Controls.Add(TableLayoutMaker.CreateContainerTable(responsiveTitle, tlp));
        }

        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel tableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("İade Et", this.Size);

            TableLayoutPanel tableFisInput = TableLayoutMaker.CreateInputWithTitleTable
            (
                "Fiş Giriş",
                "fisGirisInputTitle",
                fisGirisiTxt,
                this.Size
            );

            TableLayoutPanel tableFisButton = TableLayoutMaker.CreateResponsiveTable
            (
                "tableFisButton",
                new ResponsiveControl(fisGetirButton, this.Size, ControlType.Button)
            );

            TableLayoutPanel tableFisGetir = TableLayoutMaker.CreateResponsiveTable
            (
                "tableFisGetir",
                new TableLayoutPanel[] { tableFisInput, tableFisButton },
                2, 1,
                new float[] { 50f, 50f },
                new float[] { 100f }
            );

            TableLayoutPanel tableBottomButtons = TableLayoutMaker.CreateResponsiveTable
            (
                "tableBottomButtons",
                new ResponsiveControl[] 
                {
                    new ResponsiveControl(iadeEtButton, this.Size, ControlType.Button),
                    new ResponsiveControl(cikisButton, this.Size, ControlType.Button)
                },
                2, 1,
                new float[] { 70f, 30f },
                new float[] { 100f }
            );

            return TableLayoutMaker.CreateResponsiveTable
            (
                "rightTable",
                new TableLayoutPanel[] { tableTitleWithDivider, tableFisGetir, null, tableBottomButtons},
                4, 1,
                new float[] { 10f, 30f, 15f, 45f },
                new float[] { 100f }
            );
        }

        private void GetSatislar()
        {
            iadeDGW.DataSource = source;
            using (UnitOfWork uow = new UnitOfWork())
            {
                source.DataSource = uow.SatisRepository.AllSatisByFisId(Convert.ToInt32(fisGirisiTxt.Text));
            }

            foreach (Satis item in source.DataSource as List<Satis>)
            {
                toplamTutar += item.ToplamFiyat;
                kdvliToplamTutar += item.ToplamKdvliFiyat;
            }
            toplamTutarLabel.Text = "Toplam tutar: " + toplamTutar.ToString("C2") + "\n KDV'li toplam tutar: " + kdvliToplamTutar.ToString("C2");
        }

        private void RemoveSatis()
        {
            Satis removeThis = source.Current as Satis;
            
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.SatisRepository.Remove(removeThis);
            }

            source.Remove(removeThis);

            toplamTutar -= removeThis.ToplamFiyat;
            kdvliToplamTutar -= removeThis.ToplamKdvliFiyat;
            toplamTutarLabel.Text = "Toplam tutar: " + toplamTutar.ToString("C2") + "\n KDV'li toplam tutar: " + kdvliToplamTutar.ToString("C2");
        }

        private void fisGetirButton_Click(object sender, EventArgs e)
        {
            GetSatislar();
        }

        private void iadeEtButton_Click(object sender, EventArgs e)
        {
            RemoveSatis();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}