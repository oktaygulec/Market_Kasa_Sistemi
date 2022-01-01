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
    public static class ResponsiveFontSize
    {
        private static float NewFontSize(Size size)
        {
            float wRatio = size.Width / 10;
            float hRatio = size.Height / 10;
            float ratio = Math.Min(hRatio, wRatio);
            return ratio * 0.4f;
        }

        private static Font ResponsiveFont(Size formSize, ControlType textType)
        {
            float fontSize;

            Font font;

            switch (textType)
            {
                case ControlType.Title:
                    fontSize = NewFontSize(formSize);
                    font = new Font("Segoe UI", fontSize, FontStyle.Bold);
                    break;
                case ControlType.Subtitle:
                    fontSize = NewFontSize(formSize) * 0.6f;
                    font = new Font("Segoe UI", fontSize, FontStyle.Bold);
                    break;
                case ControlType.Button:
                    fontSize = NewFontSize(formSize) * 0.9f;
                    font = new Font("Segoe UI", fontSize, FontStyle.Bold);
                    break;
                case ControlType.Text:
                    fontSize = NewFontSize(formSize) * 0.6f;
                    font = new Font("Consolas", fontSize, FontStyle.Regular);
                    break;
                case ControlType.Input:
                    fontSize = NewFontSize(formSize) * 0.8f;
                    font = new Font("Segoe UI", fontSize, FontStyle.Regular);
                    break;
                default:
                    fontSize = 16f;
                    font = new Font("Consolas", fontSize, FontStyle.Regular);
                    break;
            }

            return font;
        }

        public static void MakeResponsive(Control[] controls, Size formSize, ControlType textType)
        {
            foreach (Control item in controls)
            {
                if (item != null)
                {
                    item.Font = ResponsiveFont(formSize, textType);
                }
            }
        }

        public static Control MakeResponsive(Control control, Size formSize, ControlType textType)
        {
            control.Font = ResponsiveFont(formSize, textType);
            return control;
        }
    }
}
