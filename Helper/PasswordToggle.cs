using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMS_v1.Helper
{
    public static class PasswordToggle
    {
        public static void Attach(KryptonTextBox box, ButtonSpecAny spec)
        {
            box.UseSystemPasswordChar = true;
            spec.Image = Resources.Resources.EyeClose;

            spec.Click += (s, e) =>
            {
                bool hidden = box.UseSystemPasswordChar;
                box.UseSystemPasswordChar = !hidden;
                spec.Image = hidden ? Resources.Resources.LoginEye : Resources.Resources.EyeClose;
            };
        }
    }
}
