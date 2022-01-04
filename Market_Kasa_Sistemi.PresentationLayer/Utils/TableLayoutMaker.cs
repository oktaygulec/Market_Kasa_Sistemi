using Market_Kasa_Sistemi.Components;
using Market_Kasa_Sistemi.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Utils
{
    public static class TableLayoutMaker
    {
        private static TableLayoutPanel CreateResponsiveTable(string tableName)
        {
            TableLayoutPanel newTable = new TableLayoutPanel();

            newTable.Name = tableName;
            newTable.RowCount = 1;
            newTable.ColumnCount = 1;
            newTable.Dock = DockStyle.Fill;
            newTable.Location = new Point(0, 0);

            newTable.RowStyles.Insert(0, new RowStyle(SizeType.Percent, 100f));

            newTable.ColumnStyles.Insert(0, new ColumnStyle(SizeType.Percent, 100f));
            
            return newTable;
        }

        private static TableLayoutPanel CreateResponsiveTable(string tableName, int rowCount, int columnCount, float[] rowStyles, float[] columnStyles)
        {
            TableLayoutPanel newTable = CreateResponsiveTable(tableName);

            newTable.RowCount = rowCount;
            newTable.ColumnCount = columnCount;

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

        public static TableLayoutPanel CreateResponsiveTable(string tableName, ResponsiveControl control)
        {
            TableLayoutPanel newTable = CreateResponsiveTable(tableName);
            
            if (control != null && control.Control != null)
            {
                newTable.Controls.Add(control.Control, 0, 0);
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

        public static TableLayoutPanel CreateEqualSizedTable(string tableName, ResponsiveControl[] controls, int rowCount, int columnCount)
        {
            float[] rowStyles = new float[rowCount];
            for (int i = 0; i < rowCount; i++)
                rowStyles[i] = 100f / rowCount;

            float[] columnStyles = new float[columnCount];
            for (int i = 0; i < columnCount; i++)
                columnStyles[i] = 100f / columnCount;

            TableLayoutPanel panel = CreateResponsiveTable(tableName, controls, rowCount, columnCount, rowStyles, columnStyles);

            return panel;
        }

        public static TableLayoutPanel CreateTitleWithDividerTable(string tableTitleText, Size formSize)
        {
            Label lblTitle = new Label() { Text = tableTitleText, TextAlign = ContentAlignment.BottomLeft };
            ResponsiveControl tableTitleControl = new ResponsiveControl(lblTitle, formSize, ControlType.Title);

            Label divider = new Label();
            ResponsiveControl tableDividerControl = new ResponsiveControl(divider, formSize, ControlType.HorizontalDivider);

            TableLayoutPanel tableTitle = CreateResponsiveTable(
                "tableTitle",
                tableTitleControl
            );

            TableLayoutPanel tableDivider = CreateResponsiveTable(
                "tableDivider",
                tableDividerControl
            );

            return CreateResponsiveTable(
                "tableTitleWithDivider",
                new TableLayoutPanel[] { tableTitle, tableDivider },
                2, 1,
                new float[] { 90f, 10f },
                new float[] { 100f }
            );
        }

        public static TableLayoutPanel CreateTitlesWithDividerTable(string[] tableTitlesText, Size formSize)
        {
            ResponsiveControl[] tableTitleControls = new ResponsiveControl[tableTitlesText.Length];

            float[] columnStyles = new float[tableTitlesText.Length];
            for(int i = 0; i < tableTitlesText.Length; i++)
            {
                string titleText = tableTitlesText[i];
                Label lblTitle = new Label() { Text = titleText, TextAlign = ContentAlignment.BottomLeft };
                tableTitleControls[i] = new ResponsiveControl(lblTitle, formSize, ControlType.Title);
                columnStyles[i] = 100 / tableTitlesText.Length;
            }

            ResponsiveControl tableDividerControl = new ResponsiveControl(new Label(), formSize, ControlType.HorizontalDivider);

            TableLayoutPanel tableTitle = CreateResponsiveTable(
                "tableTitle",
                tableTitleControls,
                1, tableTitlesText.Length,
                new float[] { 100f },
                columnStyles
            );

            TableLayoutPanel tableDivider = CreateResponsiveTable(
                "tableDivider",
                tableDividerControl
            );

            return CreateResponsiveTable(
                "tableTitleWithDivider",
                new TableLayoutPanel[] { tableTitle, tableDivider },
                2, 1,
                new float[] { 90f, 10f },
                new float[] { 100f }
            );
        }

        public static TableLayoutPanel CreateInputWithTitleTable(string titleText, string titleName, Control input, Size formSize)
        {
            Label title = new Label() { Text = titleText, Name = titleName };

            ResponsiveControl[] controls = {
                new ResponsiveControl(title, formSize, ControlType.Subtitle),
                new ResponsiveControl(input, formSize, ControlType.Input),
            };

            return CreateResponsiveTable(
                "inputWithTitleTable",
                controls,
                2, 1,
                new float[] { 35f, 65f },
                new float[] { 100f }
            );
        }
        
        public static TableLayoutPanel CreateTitlesAndDGWTable(Size formSize, Control dgwControl, string[] dgwTitles, Label toplam = null)
        {
            TableLayoutPanel leftTableTitlesWithDivider = CreateTitlesWithDividerTable
            (
                dgwTitles,
                formSize
            );

            ResponsiveControl leftTableDGWControl = new ResponsiveControl(dgwControl, formSize, ControlType.Text);

            TableLayoutPanel leftTableDGW = toplam == null ? CreateResponsiveTable
            (
                "leftTableDGW",
                leftTableDGWControl
            ) : CreateResponsiveTable
            (
                "leftTableDGW",
                new ResponsiveControl[] { leftTableDGWControl, new ResponsiveControl(toplam, formSize, ControlType.Title) },
                2, 1,
                new float[] { 90f, 10f },
                new float[] { 100f }
            );


            TableLayoutPanel leftTableContainer = CreateResponsiveTable
            (
                "leftTableContainer",
                new TableLayoutPanel[] { leftTableTitlesWithDivider, leftTableDGW },
                2, 1,
                new float[] { 10f, 90f },
                new float[] { 100f }
            );

            return leftTableContainer;
        }

        public static TableLayoutPanel CreateDualTableWithTitlesAndDGW(Size formSize, Control dgwControl, string[] dgwTitles, TableLayoutPanel rightTable, Label toplam = null)
        {
            TableLayoutPanel leftTableContainer = CreateTitlesAndDGWTable(formSize, dgwControl, dgwTitles,  toplam); 
            TableLayoutPanel panel = CreateResponsiveTable(
                "panel",
                new TableLayoutPanel[] { leftTableContainer, rightTable },
                1, 2,
                new float[] { 100f },
                new float[] { 75f, 25f }
            );

            return panel;
        }
    }
}
