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
        public Urun_Iade_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Urun_Iade_View_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
            (
                this.Size,
                "Ürün İade",
                iadeDGW,
                new string[] { "Barkod", "Adı", "Adeti", "Fiyatı" },
                new float[] { 20f, 40f, 15f, 25f},
                RightTable(),
                toplamTutar
            );
            this.Controls.Add(tlp);
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
        }

        private void RemoveSatis()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Satis removeThis = source.Current as Satis;
                uow.SatisRepository.Remove(removeThis);
                source.Remove(removeThis);
            }
        }

        private void fisGetirButton_Click(object sender, EventArgs e)
        {
            GetSatislar();
        }

        private void iadeEtButton_Click(object sender, EventArgs e)
        {
            RemoveSatis();
        }
    }
}