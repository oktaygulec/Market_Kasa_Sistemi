﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Kasa_Sistemi.Utils
{
    public static class Validation
    {
        public static bool ValidationControl(ErrorProvider provider, Control control)
        {
            if (String.IsNullOrWhiteSpace(control.Text) || control.Text.Length < 3)
            {
                provider.SetError(control, "Alan boş veya 3 karakterden az olamaz.");
                return false;
            }
            else
            {
                provider.SetError(control, "");
                return true;
            }
        }
    }
}
