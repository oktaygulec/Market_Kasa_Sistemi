using Market_Kasa_Sistemi.Components;
using System.Drawing;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Utils
{
    public static class TableLayoutMaker
    {
        private static TableLayoutPanel CreateResponsiveTable(string tableName, int rowCount, int columnCount, float[] rowStyles, float[] columnStyles)
        {
            TableLayoutPanel newTable = new TableLayoutPanel();

            newTable.Name = tableName;
            newTable.RowCount = rowCount;
            newTable.ColumnCount = columnCount;
            newTable.Dock = DockStyle.Fill;
            newTable.Location = new Point(0, 0);

            for (int i = 0; i < rowCount; i++)
            {
                newTable.RowStyles.Insert(i, new RowStyle(SizeType.Percent, rowStyles[i]));
            }

            for (int i = 0; i < columnCount; i++)
            {
                newTable.ColumnStyles.Insert(i, new ColumnStyle(SizeType.Percent, columnStyles[i]));
            }

            return newTable;
        }

        public static TableLayoutPanel CreateResponsiveTable(string tableName, ResponsiveControl[] controls, int rowCount, int columnCount, float[] rowStyles, float[] columnStyles)
        {
            TableLayoutPanel newTable = CreateResponsiveTable(tableName, rowCount, columnCount, rowStyles, columnStyles);
            int counter = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
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

        public static TableLayoutPanel CreateResponsiveTable(string tableName, TableLayoutPanel[] panels, int rowCount, int columnCount, float[] rowStyles, float[] columnStyles)
        {
            TableLayoutPanel newTable = CreateResponsiveTable(tableName, rowCount, columnCount, rowStyles, columnStyles);
            int counter = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
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

        public static TableLayoutPanel CreateContainerTable(ResponsiveControl title, TableLayoutPanel panel)
        {
            TableLayoutPanel container = new TableLayoutPanel();

            container.Name = "ContainerPanel";
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

        public static TableLayoutPanel CreateEqualSizedTable(ResponsiveControl title, string tableName, ResponsiveControl[] controls, int rowCount, int columnCount)
        {
            float[] rowStyles = new float[rowCount];
            for (int i = 0; i < rowCount; i++)
                rowStyles[i] = 100f / rowCount;

            float[] columnStyles = new float[columnCount];
            for (int i = 0; i < columnCount; i++)
                columnStyles[i] = 100f / columnCount;

            TableLayoutPanel panel = CreateResponsiveTable(tableName, controls, rowCount, columnCount, rowStyles, columnStyles);

            return CreateContainerTable(title, panel);
        }
    }
}
