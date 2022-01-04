using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Utils
{
    public static class FormSettings
    {
        public static void SetFullscreen(Form form)
        {
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
        }

        public static void SetDataGridView(DataGridView dgw)
        {
            dgw.AllowDrop = false;
            dgw.AllowUserToAddRows = false;
            dgw.AllowUserToDeleteRows = false;
            dgw.AllowUserToResizeRows = false;
            dgw.AllowUserToOrderColumns = false;
            dgw.AllowUserToResizeColumns = false;
            dgw.Anchor = AnchorStyles.Left;
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw.BackgroundColor = Color.White;
            dgw.BorderStyle = BorderStyle.None;
            dgw.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgw.ColumnHeadersVisible = false;
            dgw.DefaultCellStyle = new DataGridViewCellStyle { SelectionBackColor = Color.Tomato };
            dgw.MultiSelect = false;
            dgw.ReadOnly = true;
            dgw.RowHeadersVisible = false;
            dgw.ScrollBars = ScrollBars.Vertical;
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
