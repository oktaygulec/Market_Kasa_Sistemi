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
    public partial class Kullanicilar_View : Form
    {
        public Kullanicilar_View()
        {
            InitializeComponent();
        }

        private void Kullanicilar_View_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = TableLayoutMaker.CreateDualTableWithTitlesAndDGW
                (
                    this.Size,
                    "Kullanıcılar",
                    kullanicilarDGW,
                    new string[] { "ID", "Kullanıcı Adı", "Personel Ad" },
                    new float[] { 20f, 40f, 40f },
                    RightTable()
                );
            this.Controls.Add(tlp);
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
                new ResponsiveControl(kullaniciSilButton, this.Size, ControlType.Button)
            };

            TableLayoutPanel tableKullaniciButtons = TableLayoutMaker.CreateResponsiveTable
                (
                    "tableKullaniciButtons",
                    kullaniciButtonsControls,
                    2, 1,
                    new float[] { 50f, 50f },
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
                    new float[] { 10f, 45f, 25f, 20f },
                    new float[] { 100f }
                );
        }

    }
}
