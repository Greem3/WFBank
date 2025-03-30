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
        public static void AdjustObjects(Control mainControl)
        {
            Fitsizer.AdjustObjects(mainControl, 0, 0);
        }

        public static void AdjustObjects(Control mainControl, int padding)
        {
            Fitsizer.AdjustObjects(mainControl, padding, padding);
        }

        public static void AdjustObjects(Control mainControl, int paddingX = 0, int paddingY = 0)
        {
            (int X, int Y) sizeValue = (paddingX, paddingY);

            for (int i = 0; i < mainControl.Controls.Count; i++)
            {
                Control childControl = mainControl.Controls[i];

                sizeValue.X += childControl.Width;
                sizeValue.Y += childControl.Height;
            }

            mainControl.Size = new Size(sizeValue.X, sizeValue.Y);
        }
    }
}
