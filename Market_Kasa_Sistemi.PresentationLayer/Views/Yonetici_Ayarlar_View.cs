﻿using System;
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
    public partial class Yonetici_Ayarlar_View : Form
    {
        public Yonetici_Ayarlar_View()
        {
            InitializeComponent();
        }

        private void Yonetici_Ayarlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}