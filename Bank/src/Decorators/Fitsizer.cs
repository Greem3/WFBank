using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Fitsizer
    {
        public static void AdjustObjects(Control control)
        {
            Fitsizer.AdjustObjects(control, 0, 0);
        }

        public static void AdjustObjects(Control control, int padding)
        {
            Fitsizer.AdjustObjects(control, padding, padding);
        }

        public static void AdjustObjects(Control control, int paddingX = 0, int paddingY = 0)
        {
            (int X, int Y) sizeValue = (paddingX, paddingY);

            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control childControl = control.Controls[i];

                sizeValue.X += childControl.Width;
                sizeValue.Y += childControl.Height;
            }

            control.Size = new Size(sizeValue.X, sizeValue.Y);
        }
    }
}
