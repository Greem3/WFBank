using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class DecText
    {

        public static Font FontWithSize(float newSize)
        {
            return new Font(
                Context.config.FontFamily,
                newSize
            );
        }

        public static Font FontWithSize(TextSize newSize)
        {
            return FontWithSize(_GetSize(newSize));
        }

        public static Font FontWithSize(Font font, float newSize)
        {
            return new Font(
                font.FontFamily,
                newSize
            );
        }

        public static Font FontWithSize(Font font, TextSize newSize)
        {
            return new Font(
                font.FontFamily,
                _GetSize(newSize)
            );
        }

        public static void SetSize(Control control, float newSize)
        {
            control.Font = new Font(control.Font.FontFamily, newSize);
        }

        public static void SetSize(Control control, TextSize newSize)
        {
            control.Font = new Font(
                control.Font.FontFamily,
                _GetSize(newSize)
            );
        }

        public static void SetSizeInto(Control mainControl, TextSize newSize)
        {
            foreach (Control control in mainControl.Controls)
            {
                DecText.SetSize(control, newSize);
            }
        }

        public static void SetSizeAll(Control mainControl, TextSize newSize)
        {
            foreach (Control control in mainControl.Controls)
            {
                if (control.Controls.Count > 0)
                    SetSizeAll(control, newSize);

                DecText.SetSize(control, newSize);
            }
        }

        public static void SetSizeAll(Control mainControl, TextSize newSize, Func<Control, bool> condition)
        {
            foreach (Control control in mainControl.Controls)
            {
                if (control.Controls.Count > 0)
                    SetSizeAll(control, newSize);

                if (condition(control))
                    DecText.SetSize(control, newSize);
            }
        }

        private static float _GetSize(TextSize size)
        {
            string tSizeName = size.Name();

            Type configType = Context.config.GetType();

            PropertyInfo property = configType.GetProperty(tSizeName);

            return Convert.ToSingle(property.GetValue(Context.config));
        }
    }
}
