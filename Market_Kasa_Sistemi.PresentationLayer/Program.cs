using Market_Kasa_Sistemi.Models;
using Market_Kasa_Sistemi.Views;
using System;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Kullanici Kullanici { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Main_View giris = new Main_View();
            if (giris.ShowDialog() == DialogResult.OK)
            {
                if (Kullanici.Personel.PersonelTip.PersonelTipAd == "Yönetici")
                {
                    Application.Run(new Ana_Menu_Yonetici_View()
                    {
                        TopMost = true,
                        FormBorderStyle = FormBorderStyle.None,
                        WindowState = FormWindowState.Maximized
                    });
                }
                else
                {
                    Application.Run(new Ana_Menu_Kasiyer_View()
                    {
                        TopMost = true,
                        FormBorderStyle = FormBorderStyle.None,
                        WindowState = FormWindowState.Maximized
                    });
                }
            }
        }
    }
}
