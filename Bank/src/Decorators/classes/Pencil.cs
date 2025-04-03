using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Pencil
    {
        public static void Transparent(Control control)
        {
            control.BackColor = Color.Transparent;
        }

        public static void TransparentItems(Control container)
        {
            foreach (Control control in container.Controls)
            {
                control.BackColor = Color.Transparent;
            }
        }

        public static void Paint(Control control, Palette color)
        {
            control.BackColor = color.GetColor();
        }

        public static void PaintButton(Button control, Palette color, int borderSize)
        {
            PaintButton(control, color, color, control.ForeColor, borderSize);
        }

        public static void PaintButton(Button control, Palette color, Palette borderColor, int borderSize)
        {
            PaintButton(control, color, color, control.ForeColor, borderSize);
        }

        public static void PaintButton(Button control, Palette color, Palette borderColor, Palette foreColor, int borderSize)
        {
            Paint(control, color);
            control.FlatStyle = FlatStyle.Flat;
            control.FlatAppearance.BorderColor = borderColor.GetColor();
            control.FlatAppearance.BorderSize = borderSize;
            PaintText(control, foreColor);
        }

        public static void PaintButton(Button control, Palette color, Palette borderColor, Color foreColor, int borderSize)
        {
            Paint(control, color);
            control.FlatStyle = FlatStyle.Flat;
            control.FlatAppearance.BorderColor = borderColor.GetColor();
            control.FlatAppearance.BorderSize = borderSize;
            PaintText(control, foreColor);
        }

        public static void PaintItems(Control container, Palette color)
        {
            foreach (Control control in container.Controls)
            {
                Paint(control, color);
            }
        }

        public static void PaintItems(Control container, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in container.Controls)
            {
                if (condition(control))
                    Paint(control, color);
            }
        }

        public static void PaintAllItems(Control container, Palette color)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Controls.Count > 0)
                    PaintAllItemsText(control, color);

                Paint(control, color);
            }
        }

        public static void PaintAllItems(Control container, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Controls.Count > 0)
                    PaintAllItems(container, color, condition);

                Paint(control, color);
            }
        }

        public static void PaintText(Control control, int a, int r, int g, int b)
        {
            control.ForeColor = Color.FromArgb(a, r, g, b);
        }

        public static void PaintText(Control control, Color color)
        {
            control.ForeColor = color;
        }

        public static void PaintText(Control control, Palette color)
        {
            control.ForeColor = color.GetColor();
        }

        public static void PaintItemsText(Control container, Palette color)
        {
            foreach (Control control in container.Controls)
            {
                PaintText(control, color);
            }
        }

        public static void PaintItemsText(Control container, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in container.Controls)
            {
                if (condition(control))
                    PaintText(control, color);
            }
        }

        public static void PaintAllItemsText(Control container, Palette color)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Controls.Count > 0)
                    PaintAllItemsText(control, color);

                PaintText(control, color);
            }
        }

        public static void PaintAllItemsText(Control container, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Controls.Count > 0)
                    PaintAllItemsText(control, color);

                if (condition(control))
                    PaintText(control, color);
            }
        }

        public static void PaintFormItems(Form form, Palette color)
        {
            foreach (Control control in form.Controls)
            {
                Paint(control, color);
            }
        }

        public static void PaintFormItems(Form form, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in form.Controls)
            {
                if (condition(control))
                    Paint(control, color);
            }
        }

        public static void PainFormItemsText(Form form, Palette color)
        {
            foreach (Control control in form.Controls)
            {
                PaintText(control, color);
            }
        }

        public static void PaintFormItemsText(Form form, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in form.Controls)
            {
                if (condition(control))
                    PaintText(control, color);
            }
        }

        public static void PaintFormAllItemsText(Form form, Palette color, Func<Control, bool> condition)
        {
            foreach (Control control in form.Controls)
            {
                if (control.Controls.Count > 0)
                    PaintAllItemsText(control, color);

                if (condition(form))
                    PaintText(form, color);
            }
        }
    }
}
