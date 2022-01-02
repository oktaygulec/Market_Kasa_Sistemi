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
    public partial class Personeller_View : Form
    {
        public Personeller_View()
        {
            InitializeComponent();
        }

        private void Personeller_View_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
                (
                    this.Size,
                    "Personeller",
                    personellerDGW,
                    new string[] { "ID", "Adı", "Soyadı", "Başlangıç Tarihi", "Tipi" },
                    new float[] { 10f, 20f, 20f, 30f, 20f },
                    RightTable()
                );
            this.Controls.Add(tlp);
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

            ResponsiveControl[] kullaniciButtonsControls = new ResponsiveControl[]
            {
                new ResponsiveControl(personelEkleButton, this.Size, ControlType.Button),
                new ResponsiveControl(personelDuzenleButton, this.Size, ControlType.Button),
                new ResponsiveControl(personelSilButton, this.Size, ControlType.Button)
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
    }
}
