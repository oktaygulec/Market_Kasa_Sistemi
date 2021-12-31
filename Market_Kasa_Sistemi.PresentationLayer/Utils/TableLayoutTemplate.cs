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

        private TableLayoutPanel CreateResponsiveTemplate(string tableName)
        {
            TableLayoutPanel newTable = new TableLayoutPanel();

            newTable.Name = tableName;
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

            return newTable;
        }

        public TableLayoutPanel CreateResponsiveTemplate(string tableName, ResponsiveControl[] controls)
        {
            TableLayoutPanel newTable = CreateResponsiveTemplate(tableName);
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

            return newTable;
        }

        public TableLayoutPanel CreateResponsiveTemplate(string tableName, TableLayoutPanel[] panels)
        {
            TableLayoutPanel newTable = CreateResponsiveTemplate(tableName);
            int counter = 0;

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if (panels[counter] != null)
                    {
                        newTable.Controls.Add(panels[counter], j, i);
                    }
                    counter++;
                }
            }

            return newTable;
        }

        public TableLayoutPanel CreateContainerTable(ResponsiveControl title, TableLayoutPanel panel)
        {
            TableLayoutPanel container = new TableLayoutPanel();

            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 90));

            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Padding = new Padding(32);

            container.Controls.Add(title.Control, 0, 0);
            container.Controls.Add(panel, 0, 1);

            return container;
        }

        public TableLayoutPanel TableLayoutOnlyButtons(ResponsiveControl title, string tableName, ResponsiveControl[] controls)
        {
            
            RowStyles = new float[]{ 100f / RowCount, 100f / RowCount, 100f / RowCount };
            ColumnStyles = new float[] { 100f / ColumnCount, 100f / ColumnCount, 100f / ColumnCount };

            TableLayoutPanel panel = CreateResponsiveTemplate(tableName, controls);

            return CreateContainerTable(title, panel);
        }
    }
}
