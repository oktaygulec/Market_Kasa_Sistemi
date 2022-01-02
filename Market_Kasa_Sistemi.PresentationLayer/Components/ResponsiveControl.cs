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
            float height = ((control.Height - 100) * 2.6f) - control.Width;
            Size newButtonSize = new Size((int)(formSize.Width + height), (int)(formSize.Height + height));
            Size newTextSize = new Size((int)(formSize.Width + height + 100), (int)(formSize.Height + height + 100));
            
            switch (textType)
            {
                    
                case ControlType.HeadTitle:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, formSize, ControlType.HeadTitle);
                    this.Control.ForeColor = Color.MediumBlue;
                    this.Control.Anchor = AnchorStyles.None;
                    this.Control.AutoSize = true;
                    this.Control.Text = this.Control.Text.ToUpper();
                    break;
                case ControlType.Title:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, newTextSize, ControlType.Title);
                    this.Control.Anchor = AnchorStyles.Left;
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.AutoSize = true;
                    this.Control.Margin = new Padding(0, 0, 16, 0);
                    break;
                case ControlType.Subtitle:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, newTextSize, ControlType.Subtitle);
                    this.Control.ForeColor = Color.Gray;
                    this.Control.Anchor = AnchorStyles.Left;
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.AutoSize = true;
                    this.Control.Margin = new Padding(0, 0, 16, 0);
                    break;
                case ControlType.Text:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, newTextSize, ControlType.Text);
                    this.Control.Anchor = AnchorStyles.Left;
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.AutoSize = true;
                    this.Control.Margin = new Padding(0, 0, 16, 0);
                    break;
                case ControlType.Button:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, newButtonSize, ControlType.Button);
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.Margin = new Padding(8, 16, 24, 0);
                    break;
                case ControlType.Input:
                    this.Control = ResponsiveFontSize.MakeResponsive(control, newTextSize, ControlType.Input);
                    this.Control.Anchor = AnchorStyles.Left;
                    this.Control.Dock = DockStyle.Fill;
                    this.Control.AutoSize = true;
                    this.Control.Margin = new Padding(8, 8, 24, 0);
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
