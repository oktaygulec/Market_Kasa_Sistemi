using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Utils
{
    public class TableLayoutTemplate
    {
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public float[] RowStyles { get; set; }
        public float[] ColumnStyles { get; set; }

        public TableLayoutTemplate() : this(0, 0, new float[] { }, new float[] { }){}

        public TableLayoutTemplate(
            int rowCount, 
            int columnCount, 
            float[] rowStyles,
            float[] columnStyles
        )
        {
            this.RowCount = rowCount;
            this.ColumnCount = columnCount;
            this.RowStyles = rowStyles;
            this.ColumnStyles = columnStyles;
        }

        public void NewTableLayoutPanel(TableLayoutPanel container, ResponsiveControl[] controls, ResponsiveControl title)
        {
            container.Controls.Clear();

            container.RowCount = 2;
            container.RowStyles.Clear();
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 90));

            container.ColumnCount = 1;
            container.ColumnStyles.Clear();
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Padding = new Padding(32);

            TableLayoutPanel newTable = new TableLayoutPanel();

            newTable.RowCount = RowCount;
            newTable.ColumnCount = ColumnCount;
            newTable.Dock = DockStyle.Fill;
            newTable.Location = new Point(0, 0);

            for (int i = 0; i < RowCount; i++)
            {
                newTable.RowStyles.Insert(i, new RowStyle(SizeType.Percent, RowStyles[i]));
            }

            for (int i = 0; i < ColumnCount; i++)
            {
                newTable.ColumnStyles.Insert(i, new ColumnStyle(SizeType.Percent, ColumnStyles[i]));
            }

            int counter = 0;
            
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if (controls[counter] != null && controls[counter].Control != null)
                    {
                        newTable.Controls.Add(controls[counter].Control, j, i);
                    }
                    counter++;
                }
            }

            container.Controls.Add(title.Control, 0, 0);
            container.Controls.Add(newTable, 0, 1);
        }

        public static void TableLayoutOnlyButtons(int rows, int cols, string titleText, TableLayoutPanel container, ResponsiveControl[] controls, Size formSize)
        {
            Label title = new Label
            {
                Text = titleText.ToUpper(),
                ForeColor = Color.MediumBlue
            };
        ResponsiveControl responsiveTitle = new ResponsiveControl(title, formSize, TextType.Title);

            float[] rowStyles = { 100f / rows, 100f / rows, 100f / rows };
            float[] colStyles = { 100f / cols, 100f / cols, 100f / cols };

            TableLayoutTemplate tmp = new TableLayoutTemplate(rows, cols, rowStyles, colStyles);
            tmp.NewTableLayoutPanel(container, controls, responsiveTitle);
        }
    }
}
