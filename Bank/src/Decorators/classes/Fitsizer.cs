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
        public static void AdjustWidthObject(Control container)
        {
            Fitsizer.AdjustWidthObject(container, 0);
        }

        public static void AdjustWidthObject(Control container, int padding)
        {
            padding *= 2;

            if (container.Controls.Count == 0)
            {
                container.Size = new Size(padding, 0);
                return;
            }

            Control[] childrenControls = container.Controls.Cast<Control>().ToArray();

            int minLeft = childrenControls.Min(c => c.Left);

            container.Location = new Point(container.Location.X + minLeft, container.Location.Y);

            foreach (Control control in childrenControls)
            {
                control.Location = new Point(control.Location.X - minLeft, control.Location.Y);
            }

            int newSize = childrenControls.OrderByDescending(c => c.Right).First().Right;

            container.Size = new Size(newSize + padding, container.Size.Height);
        }

        public static void AdjustHeightObject(Control container)
        {
            Fitsizer.AdjustHeightObject(container, 0);
        }

        public static void AdjustHeightObject(Control container, int padding)
        {
            padding *= 2;

            if (container.Controls.Count == 0)
            {
                container.Size = new Size(0, padding);
                return;
            }

            Control[] childrenControls = container.Controls.Cast<Control>().ToArray();

            int minTop = childrenControls.Min(c => c.Top);

            container.Location = new Point(container.Location.X, container.Location.Y + minTop - padding);

            int newSize = childrenControls.OrderByDescending(c => c.Bottom).First().Bottom;

            foreach (Control control in childrenControls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y - minTop + padding);
            }

            container.Size = new Size(container.Size.Width, newSize + padding);
        }

        public static void AdjustObject(Control container)
        {
            Fitsizer.AdjustObject(container, 0, 0);
        }

        public static void AdjustObject(Control container, int padding)
        {
            Fitsizer.AdjustObject(container, padding, padding);
        }

        public static void AdjustObject(Control container, int paddingX, int paddingY)
        {
            paddingX *= 2;
            paddingY *= 2;

            if (container.Controls.Count == 0)
            {
                container.Size = new Size(paddingX*2, paddingY*2);
                return;
            }

            Control[] childrenControls = container.Controls.Cast<Control>().ToArray();

            int minLeft = childrenControls.Min(c => c.Left);
            int minTop = childrenControls.Min(c => c.Top);

            container.Location = new Point(container.Location.X + minLeft, container.Location.Y + minTop);

            foreach (Control control in childrenControls)
            {
                control.Location = new Point(control.Location.X - minLeft, control.Location.Y - minTop);
            }

            (int X, int Y) newSize = (
                childrenControls.OrderByDescending(c => c.Right).First().Right,
                childrenControls.OrderByDescending(c => c.Bottom).First().Bottom
            );

            container.Size = new Size(newSize.X + paddingX, newSize.Y + paddingY);
        }

        public static void AdjustInside(Control container)
        {
            Fitsizer.AdjustInside(container, 0);
        }

        public static void AdjustInside(Control container, int padding)
        {
            Fitsizer.AdjustInside(container, padding, padding);
        }

        public static void AdjustInside(Control container, int paddingX, int paddingY)
        {
            foreach (Control control in container.Controls)
            {
                Fitsizer.AdjustObject(control, paddingX, paddingY);
            }
        }
    }
}
