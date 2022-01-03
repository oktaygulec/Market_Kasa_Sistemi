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
    public partial class Kategoriler_View : Form
    {
        BindingSource source;
        public Kategoriler_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Kategoriler_View_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW(
                this.Size, "Kategoriler", 
                kategorilerDGW, 
                new string[] { "ID", "Adı" },
                new float[] { 50f, 50f }, 
                RightTable()
            );

            this.Controls.Add(tlp);

            GetKategoriler();
        }
        
        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel rightTableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Kategori Ekle", this.Size);

            ResponsiveControl[] rightTableComponentsControls = {
                new ResponsiveControl(kategoriEkleButton, this.Size, ControlType.Button),
                new ResponsiveControl(kategoriDuzenleButton, this.Size, ControlType.Button),
                new ResponsiveControl(kategoriSilButton, this.Size, ControlType.Button),
            };

            ResponsiveControl rightTableBottomControl = new ResponsiveControl(cikisButton, this.Size, ControlType.Button);

            TableLayoutPanel rightTableComponents = TableLayoutMaker.CreateResponsiveTable(
                "rightTableComponents",
                rightTableComponentsControls,
                3, 1,
                new float[] { 33f, 33f, 33f },
                new float[] { 100f }
            );

            TableLayoutPanel rightTableBottom = TableLayoutMaker.CreateResponsiveTable(
                "rightTableBottom",
                rightTableBottomControl
            );

            TableLayoutPanel rightTableTopInput = TableLayoutMaker.CreateInputWithTitleTable(
                "Kategori Adı", "rightTableKategoriAdTitle", kategoriAdiTxt, this.Size);

            TableLayoutPanel rightTableContainer = TableLayoutMaker.CreateResponsiveTable(
                "rightTableContainer",
                new TableLayoutPanel[] { rightTableTitleWithDivider, rightTableTopInput, rightTableComponents, rightTableBottom },
                4, 1,
                new float[] { 10f, 20f, 40f, 30f },
                new float[] { 100f }
            );

            return rightTableContainer;
        }

        private void GetKategoriler()
        {
            kategorilerDGW.DataSource = source;
            using (UnitOfWork uow = new UnitOfWork())
            {
                source.DataSource = uow.KategoriRepository.ToList();
            }
        }

        private void AddNewKategori()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Kategori newKategori = new Kategori { KategoriAd = kategoriAdiTxt.Text };
                newKategori.Id = Convert.ToInt32(uow.KategoriRepository.Add(newKategori));
                source.Add(newKategori);
            }
        }

        private void RemoveKategori()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Kategori removeThis = source.Current as Kategori;
                uow.KategoriRepository.Remove(removeThis);
                source.Remove(removeThis);
            }
        }

        private void UpdateKategori()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Kategori updateThis = source.Current as Kategori;
                updateThis.KategoriAd = kategoriAdiTxt.Text;
                uow.KategoriRepository.Update(updateThis);
                source.ResetCurrentItem();
            }
        }

        private void kategoriEkleButton_Click(object sender, EventArgs e)
        {
            AddNewKategori();
        }

        private void kategoriSilButton_Click(object sender, EventArgs e)
        {
            RemoveKategori();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kategoriDuzenleButton_Click(object sender, EventArgs e)
        {
            UpdateKategori();
        }

        private void kategorilerDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kategori selectedItem = source.Current as Kategori;
            kategoriAdiTxt.Text = selectedItem.KategoriAd;
        }
    }
}
