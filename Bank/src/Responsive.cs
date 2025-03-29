using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Responsive
    {
        public static void Center(Control mainControl, Control childControl)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2, mainControl.Height / 2 - childControl.Height / 2);
            };

            childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2, mainControl.Height / 2 - childControl.Height / 2);
        }

        public static void Center(Control mainControl, Control childControl, int marginX = 0, int marginY = 0)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2 - marginX, mainControl.Height / 2 - childControl.Height / 2 + marginY);
            };

            childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2 - marginX, mainControl.Height / 2 - childControl.Height / 2 + marginY);
        }

        public static void Left(Control mainControl, Control childControl)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(0, childControl.Location.Y);
            };

            childControl.Location = new Point(0, childControl.Location.Y);
        }

        public static void Left(Control mainControl, Control childControl, int margin)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(margin, childControl.Location.Y);
            };

            childControl.Location = new Point(margin, childControl.Location.Y);
        }

        public static void Right(Control mainControl, Control childControl)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(mainControl.Width - childControl.Width, childControl.Location.Y);
            };

            childControl.Location = new Point(mainControl.Width - childControl.Width, childControl.Location.Y);
        }

        public static void Right(Control mainControl, Control childControl, int margin)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(mainControl.Width - childControl.Width - margin, childControl.Location.Y);
            };

            childControl.Location = new Point(mainControl.Width - childControl.Width - margin, childControl.Location.Y);
        }

        public static void Top(Control mainControl, Control childControl)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(childControl.Location.X, 0);
            };

            childControl.Location = new Point(childControl.Location.X, 0);
        }

        public static void Top(Control mainControl, Control childControl, int margin)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(childControl.Location.X, margin);
            };

            childControl.Location = new Point(childControl.Location.X, margin);
        }

        public static void Bottom(Control mainControl, Control childControl)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(childControl.Location.X, mainControl.Height - childControl.Height);
            };

            childControl.Location = new Point(childControl.Location.X, mainControl.Height - childControl.Height);
        }

        public static void Bottom(Control mainControl, Control childControl, int margin)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(childControl.Location.X, mainControl.Height - childControl.Height - margin);
            };

            childControl.Location = new Point(childControl.Location.X, mainControl.Height - childControl.Height - margin);
        }
    }
}
