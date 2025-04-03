using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Filler
    {

        public static void Fill(Control control)
        {
            Filler.Fill(control, 0);
        }

        public static void Fill(Control control, int padding)
        {
            Action func = () =>
            {
                control.Location = new Point(padding, padding);
                control.Size = new Size(
                    control.Parent.ClientRectangle.Width - padding*2,
                    control.Parent.ClientRectangle.Height - padding*2
                );
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void FillX(Control control)
        {
            Filler.FillX(control, 0);
        }

        public static void FillX(Control control, int margin)
        {
            Action func = () =>
            {
                control.Size = new Size(control.Parent.Size.Width - margin, control.Size.Height);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void FillY(Control control)
        {
            Filler.FillY(control, 0);
        }

        public static void FillY(Control control, int margin)
        {
            Action func = () =>
            {
                control.Size = new Size(control.Size.Width, control.Parent.Size.Height - margin);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }
    }
}
