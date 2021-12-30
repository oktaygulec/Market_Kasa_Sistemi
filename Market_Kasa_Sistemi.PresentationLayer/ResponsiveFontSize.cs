using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi
{
    public static class ResponsiveFontSize
    {
        public enum TextType
        {
            Title,
            Text
        }
        private static float NewFontSize(Size size)
        {
            float wRatio = size.Width / 10;
            float hRatio = size.Height / 10;
            float ratio = Math.Min(hRatio, wRatio);
            return ratio * 0.4f;
        }

        private static Font ResponsiveFont(Form form, TextType textType)
        {
            float fontSize = textType == TextType.Text
                ? NewFontSize(form.Size) * 0.9f
                : NewFontSize(form.Size);

            Font font = new Font("Consolas", fontSize, FontStyle.Bold);

            return font;
        }

        public static void MakeResponsive(Control control, Form form, TextType textType)
        {
            control.Font = ResponsiveFont(form, textType);
        }

        public static void MakeResponsive(Control[] controls, Form form, TextType textType)
        {
            foreach (Control item in controls)
            {
                item.Font = ResponsiveFont(form, textType);
            }
        }
    }
}
