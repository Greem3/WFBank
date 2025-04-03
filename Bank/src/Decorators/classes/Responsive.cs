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
        public static void Center(Control control)
        {
            Responsive.Center(control, 0, 0);
        }

        public static void Center(Control control, int margin)
        {
            Responsive.Center(control, 0, 0);
        }

        public static void Center(Control control, int marginX, int marginY)
        {
            Action func = () =>
            {
                control.Location = new Point(
                    control.Parent.ClientRectangle.Width / 2 - control.ClientRectangle.Width / 2 + marginX,
                    control.Parent.ClientRectangle.Height / 2 - control.ClientRectangle.Height / 2 + marginY
                );
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void MiddleX(Control control)
        {
            Responsive.MiddleX(control, 0);
        }

        public static void MiddleX(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Parent.Width / 2 - control.Width / 2 + margin, control.Location.Y);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void MiddleY(Control control)
        {
            Responsive.MiddleY(control, 0);
        }

        public static void MiddleY(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Location.X, control.Parent.Height / 2 - control.Height / 2 + margin);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void Left(Control control)
        {
            Responsive.Left(control, 0);
        }

        public static void Left(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(margin, control.Location.Y);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void LeftTop(Control control)
        {
            Responsive.LeftTop(control, 0, 0);
        }

        public static void LeftTop(Control control, int margin)
        {
            Responsive.LeftTop(control, margin, margin);
        }

        public static void LeftTop(Control control, int marginX, int marginY)
        {
            Action func = () =>
            {
                control.Location = new Point(marginX, marginY);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void LeftBottom(Control control)
        {
            Responsive.LeftBottom(control, 0, 0);
        }

        public static void LeftBottom(Control control, int marginX, int marginY)
        {
            Action func = () =>
            {
                control.Location = new Point(marginX, control.Parent.Height - control.Height - marginY);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void LeftCenter(Control control)
        {
            Responsive.LeftCenter(control, 0);
        }

        public static void LeftCenter(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(margin, control.Parent.Height / 2 - control.Height / 2);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void Right(Control control)
        {
            Responsive.Right(control, 0);
        }

        public static void Right(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Parent.Width - control.Width - margin, control.Location.Y);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void RightTop(Control control)
        {
            Responsive.RightTop(control, 0, 0);
        }

        public static void RightTop(Control control, int marginX, int marginY)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Parent.Width - control.Width - marginX, marginY);
            };
            
            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void RightBottom(Control control)
        {
            Responsive.RightBottom(control, 0, 0);
        }

        public static void RightBottom(Control control, int marginX, int marginY)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Parent.Width - control.Width - marginX, control.Parent.Height - control.Height - marginY);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void Top(Control control)
        {
            Responsive.Top(control, 0);
        }

        public static void Top(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Location.X, margin);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }

        public static void Bottom(Control control)
        {
            Responsive.Bottom(control, 0);
        }

        public static void Bottom(Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Location.X, control.Parent.Height - control.Height - margin);
            };

            control.Parent.Resize += (sender, e) => func();

            func();
        }
    }
}
