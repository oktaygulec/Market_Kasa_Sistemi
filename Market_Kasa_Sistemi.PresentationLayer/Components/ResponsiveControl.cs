using Market_Kasa_Sistemi.Enums;
using Market_Kasa_Sistemi.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Components
{
    public class ResponsiveControl
    {
        public Control Control { get; set; }

        public ResponsiveControl(Control control, Size formSize, TextType textType)
        {
            switch (textType)
            {
                case TextType.Title:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, TextType.Title);
                    break;
                case TextType.ButtonText:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, TextType.ButtonText);
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.Margin = new Padding(16);
                    break;
                case TextType.Text:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, TextType.Text);
                    break;
                default:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, TextType.Text);
                    break;
            }
        }
    }
}
