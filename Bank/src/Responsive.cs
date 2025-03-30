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
            Responsive.Center(mainControl, childControl, 0, 0);
        }

        public static void Center(Control mainControl, Control childControl, int marginX = 0, int marginY = 0)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2 + marginX, mainControl.Height / 2 - childControl.Height / 2 + marginY);
            };

            childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2 + marginX, mainControl.Height / 2 - childControl.Height / 2 + marginY);
        }

        public static void MiddleX(Control mainControl, Control childControl)
        {
            Responsive.MiddleX(mainControl, childControl, 0);
        }

        public static void MiddleX(Control mainControl, Control childControl, int margin)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2 + margin, childControl.Location.Y);
            };

            childControl.Location = new Point(mainControl.Width / 2 - childControl.Width / 2 + margin, childControl.Location.Y);
        }

        public static void MiddleY(Control mainControl, Control childControl)
        {
            Responsive.MiddleY(mainControl, childControl, 0);
        }

        public static void MiddleY(Control mainControl, Control childControl, int margin)
        {
            mainControl.Resize += (sender, e) =>
            {
                childControl.Location = new Point(childControl.Location.X, mainControl.Height / 2 - childControl.Height / 2 + margin);
            };
            childControl.Location = new Point(childControl.Location.X, mainControl.Height / 2 - childControl.Height / 2 + margin);
        }

        public static void Left(Control mainControl, Control childControl)
        {
            Responsive.Left(mainControl, childControl, 0);
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
            Responsive.Right(mainControl, childControl, 0);
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
            Responsive.Top(mainControl, childControl, 0);
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
            Responsive.Bottom(mainControl, childControl, 0);
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
