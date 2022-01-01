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

        public ResponsiveControl(Control control, Size formSize, ControlType textType)
        {
            switch (textType)
            {
                case ControlType.Title:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, ControlType.Title);
                    this.Control.ForeColor = Color.MediumBlue;
                    this.Control.Anchor = AnchorStyles.None;
                    this.Control.AutoSize = true;
                    this.Control.Text = this.Control.Text.ToUpper();
                    break;
                case ControlType.Subtitle:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, ControlType.Subtitle);
                    this.Control.Anchor = AnchorStyles.Left;
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.AutoSize = true;
                    this.Control.Margin = new Padding(16, 0, 16, 0);
                    break;
                case ControlType.Button:
                    float height = (control.Height - 100) * 2.6f;
                    Size newSize = new Size((int)(formSize.Width + height), (int)(formSize.Height + height));
                    this.Control = ResponsiveFontSize.MakeResponsive(control, newSize, ControlType.Button);
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.Margin = new Padding(16);
                    break;
                case ControlType.Text:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, ControlType.Text);
                    this.Control.Anchor = AnchorStyles.Left;
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.AutoSize = true;
                    this.Control.Margin = new Padding(16, 0, 16, 0);
                    break;
                case ControlType.Input:
                    TextBox txt = ResponsiveFontSize.MakeResponsive(control, formSize, ControlType.Input) as TextBox;
                    txt.Anchor = AnchorStyles.Left;
                    txt.Dock = DockStyle.Fill;
                    txt.AutoSize = true;
                    txt.Margin = new Padding(16);
                    txt.TextAlign = HorizontalAlignment.Center;
                    this.Control = txt;
                    break;
                case ControlType.HorizontalDivider:
                    Label divider = ResponsiveFontSize.MakeResponsive(control, formSize, ControlType.HorizontalDivider) as Label;
                    divider.Dock = DockStyle.Fill;
                    divider.Text = "";
                    divider.BorderStyle = BorderStyle.Fixed3D;
                    divider.AutoSize = false;
                    divider.Height = 2;
                    this.Control = divider;
                    break;
                default:
                    break;
            }
        }
    }
}
