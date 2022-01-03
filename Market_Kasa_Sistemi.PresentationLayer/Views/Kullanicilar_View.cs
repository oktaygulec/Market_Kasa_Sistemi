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
    public partial class Kullanicilar_View : Form
    {
        BindingSource source;

        public Kullanicilar_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Kullanicilar_View_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
                (
                    this.Size,
                    "Kullanıcılar",
                    kullanicilarDGW,
                    new string[] { "ID", "Adı", "Personel" },
                    new float[] { 20f, 40f, 40f },
                    RightTable()
                );
            this.Controls.Add(tlp);
            GetKullanicilar();
        }

        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel tableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Kullanıcı Ekle", this.Size);

            TableLayoutPanel tableInputs = TableLayoutMaker.CreateResponsiveTable(
                "inputsTable",
                new TableLayoutPanel[]
                    {
                        TableLayoutMaker.CreateInputWithTitleTable("Kullanıcı Adı", "kullaniciAdiInputTitle", kullaniciAdiTxt, this.Size),
                        TableLayoutMaker.CreateInputWithTitleTable("Şifre", "kullaniciSifreInputTitle", kullaniciSifreTxt, this.Size),
                        TableLayoutMaker.CreateInputWithTitleTable("Personel", "kullaniciPersonelComboBoxTitle", personelComboBox, this.Size)
                    },
                3, 1,
                new float[] { 100 / 3, 100 / 3, 100 / 3},
                new float[] { 100f }
            );

            ResponsiveControl[] kullaniciButtonsControls = new ResponsiveControl[]
            {
                new ResponsiveControl(kullaniciEkleButton, this.Size, ControlType.Button),
                new ResponsiveControl(kullaniciDuzenleButton, this.Size, ControlType.Button),
                new ResponsiveControl(kullaniciSilButton, this.Size, ControlType.Button)
            };

            TableLayoutPanel tableKullaniciButtons = TableLayoutMaker.CreateResponsiveTable
                (
                    "tableKullaniciButtons",
                    kullaniciButtonsControls,
                    3, 1,
                    new float[] { 33f, 33f, 33f },
                    new float[] { 100f }
                );

            TableLayoutPanel tableBottomButton = TableLayoutMaker.CreateResponsiveTable
                (
                    "tableBottomButton",
                    new ResponsiveControl(cikisButton, this.Size, ControlType.Button)
                );

            return TableLayoutMaker.CreateResponsiveTable
                (
                    "rightTable",
                    new TableLayoutPanel[] { tableTitleWithDivider, tableInputs, tableKullaniciButtons, tableBottomButton },
                    4, 1,
                    new float[] { 10f, 45f, 30f, 15f },
                    new float[] { 100f }
                );
        }

        private void GetKullanicilar()
        {
            kullanicilarDGW.DataSource = source;
            using (UnitOfWork uow = new UnitOfWork())
            {
                source.DataSource = uow.KullaniciRepository.ToList();
                personelComboBox.DataSource = uow.PersonelRepository.ToList();
                personelComboBox.DisplayMember = "PersonelAd";
            }
        }

        private void AddNewKullanici()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Kullanici newKullanici = new Kullanici
                {
                    KullaniciAd = kullaniciAdiTxt.Text,
                    KullaniciSifre = kullaniciSifreTxt.Text,
                    Personel = personelComboBox.SelectedItem as Personel
                };
                newKullanici.Id = Convert.ToInt32(uow.KullaniciRepository.Add(newKullanici));
                source.Add(newKullanici);
            }
        }

        private void RemoveKullanici()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Kullanici removeThis = source.Current as Kullanici;
                uow.KullaniciRepository.Remove(removeThis);
                source.Remove(removeThis);
            }
        }

        private void UpdateKullanici()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Kullanici updateThis = source.Current as Kullanici;
                updateThis.KullaniciAd = kullaniciAdiTxt.Text;
                updateThis.KullaniciSifre = kullaniciSifreTxt.Text;
                updateThis.Personel = personelComboBox.SelectedItem as Personel;
                uow.KullaniciRepository.Update(updateThis);
                source.ResetCurrentItem();
            }
        }

        private void kullaniciEkleButton_Click(object sender, EventArgs e)
        {
            AddNewKullanici();
        }

        private void kullaniciDuzenleButton_Click(object sender, EventArgs e)
        {
            UpdateKullanici();
        }

        private void kullaniciSilButton_Click(object sender, EventArgs e)
        {
            RemoveKullanici();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanicilarDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kullanici currentKullanici = source.Current as Kullanici;
            kullaniciAdiTxt.Text = currentKullanici.KullaniciAd;
            kullaniciSifreTxt.Text = currentKullanici.KullaniciSifre;
            personelComboBox.SelectedIndex = personelComboBox.FindStringExact(currentKullanici.PersonelAd);
        }
    }
}
