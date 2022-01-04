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
    public partial class Personeller_View : Form
    {
        BindingSource source;
        public Personeller_View()
        {
            InitializeComponent();
            source = new BindingSource();
        }

        private void Personeller_View_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
                (
                    this.Size,
                    personellerDGW,
                    new string[] { "ID", "Adı", "Soyadı", "Başlangıç Tarihi", "Tipi" },
                    new float[] { 10f, 20f, 20f, 30f, 20f },
                    RightTable()
                );
            Label title = new Label { Text = "Personeller" };
            ResponsiveControl responsiveTitle = new ResponsiveControl(title, this.Size, ControlType.HeadTitle);

            this.Controls.Add(TableLayoutMaker.CreateContainerTable(responsiveTitle, tlp));
            GetPersoneller();
        }

        private TableLayoutPanel RightTable()
        {
            TableLayoutPanel tableTitleWithDivider = TableLayoutMaker.CreateTitleWithDividerTable("Personel Ekle", this.Size);

            TableLayoutPanel tableInputs = TableLayoutMaker.CreateResponsiveTable(
                "inputsTable",
                new TableLayoutPanel[]
                    {
                        TableLayoutMaker.CreateInputWithTitleTable("Personel Adı", "personelAdiInputTitle", personelAdiTxt, this.Size),
                        TableLayoutMaker.CreateInputWithTitleTable("Personel Soyadı", "personelSifreInputTitle", personelSoyadiTxt, this.Size),
                        TableLayoutMaker.CreateInputWithTitleTable("Başlangıç Tarihi", "baslangicTarihDateTimePickerTitle", baslangicTarihDateTimePicker, this.Size),
                        TableLayoutMaker.CreateInputWithTitleTable("Personel Tipi", "personelTipiComboBoxTitle", personelTipiComboBox, this.Size)
                    },
                4, 1,
                new float[] { 25f, 25f, 25f, 25f },
                new float[] { 100f }
            );

            ResponsiveControl[] personelButtonsControls = new ResponsiveControl[]
            {
                new ResponsiveControl(personelEkleButton, this.Size, ControlType.Button),
                new ResponsiveControl(personelDuzenleButton, this.Size, ControlType.Button),
                new ResponsiveControl(personelSilButton, this.Size, ControlType.Button)
            };

            TableLayoutPanel tablePersonelButtons = TableLayoutMaker.CreateResponsiveTable
                (
                    "tablePersonelButtons",
                    personelButtonsControls,
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
                    new TableLayoutPanel[] { tableTitleWithDivider, tableInputs, tablePersonelButtons, tableBottomButton },
                    4, 1,
                    new float[] { 10f, 45f, 30f, 15f },
                    new float[] { 100f }
                );
        }

        private void GetPersoneller()
        {
            personellerDGW.DataSource = source;
            using (UnitOfWork uow = new UnitOfWork())
            {
                source.DataSource = uow.PersonelRepository.ToList();
                personelTipiComboBox.DataSource = uow.PersonelTipRepository.ToList();
                personelTipiComboBox.DisplayMember = "PersonelTipAd";
            }
        }

        private void AddNewPersonel()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Personel newPersonel = new Personel
                {
                    PersonelAd = personelAdiTxt.Text,
                    PersonelSoyad = personelSoyadiTxt.Text,
                    PersonelBaslangicTarih = baslangicTarihDateTimePicker.Value,
                    PersonelTip = personelTipiComboBox.SelectedItem as PersonelTip
                };
                newPersonel.Id = Convert.ToInt32(uow.PersonelRepository.Add(newPersonel));
                source.Add(newPersonel);
            }
        }

        private void RemovePersonel()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Personel removeThis = source.Current as Personel;
                uow.PersonelRepository.Remove(removeThis);
                source.Remove(removeThis);
            }
        }

        private void UpdatePersonel()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Personel updateThis = source.Current as Personel;
                updateThis.PersonelAd = personelAdiTxt.Text;
                updateThis.PersonelSoyad = personelSoyadiTxt.Text;
                updateThis.PersonelBaslangicTarih = baslangicTarihDateTimePicker.Value;
                updateThis.PersonelTip = personelTipiComboBox.SelectedItem as PersonelTip;
                uow.PersonelRepository.Update(updateThis);
                source.ResetCurrentItem();
            }
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            AddNewPersonel();
        }

        private void personelDuzenleButton_Click(object sender, EventArgs e)
        {
            UpdatePersonel();
        }

        private void personelSilButton_Click(object sender, EventArgs e)
        {
            RemovePersonel();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personellerDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Personel currentPersonel = source.Current as Personel;
            personelAdiTxt.Text = currentPersonel.PersonelAd;
            personelSoyadiTxt.Text = currentPersonel.PersonelSoyad;
            baslangicTarihDateTimePicker.Value = currentPersonel.PersonelBaslangicTarih;
            personelTipiComboBox.SelectedIndex = personelTipiComboBox.FindStringExact(currentPersonel.PersonelTipAd);
        }
    }
}
