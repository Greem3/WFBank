using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Resizer
    {
        public static void Square(Control control)
        {
            int maxSize = Math.Max(control.Size.Width, control.Size.Height);

            control.Size = new Size(maxSize, maxSize);
        }

        public static void Square(Control control, int newSize)
        {
            control.Size = new Size(newSize, newSize);
        }
    }
}
