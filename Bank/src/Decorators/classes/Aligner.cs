using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Aligner
    {
        public static void Top(Control mainControl, Control control)
        {
            Aligner.Top(mainControl, control, 0);
        }

        public static void Top(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Location.X, mainControl.Location.Y - control.Size.Height - margin);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void TopLeft(Control mainControl, Control control)
        {
            Aligner.TopLeft(mainControl, control, 0, 0);
        }

        public static void TopLeft(Control mainControl, Control control, int margin)
        {
            Aligner.TopLeft(mainControl, control, margin, 0);
        }

        public static void TopLeft(Control mainControl, Control control, int margin, int moreLeft)
        {
            Action func = () =>
            {
                control.Location = new Point(mainControl.Location.X - moreLeft,
                    mainControl.Location.Y - control.Size.Height - margin);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void TopCenter(Control mainControl, Control control)
        {
            Aligner.TopCenter(mainControl, control, 0);
        }

        public static void TopCenter(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(
                    mainControl.Location.X + (mainControl.Size.Width - control.Size.Width) / 2,
                    mainControl.Location.Y - mainControl.Size.Height - margin
                );
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void Bottom(Control mainControl, Control control)
        {
            Aligner.Bottom(mainControl, control, 0);
        }

        public static void Bottom(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(
                    mainControl.Location.X,
                    mainControl.Location.Y + mainControl.Size.Height + margin
                );
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void BottomCenter(Control mainControl, Control control)
        {
            Aligner.BottomCenter(mainControl, control, 0);
        }

        public static void BottomCenter(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(
                    mainControl.Location.X + (mainControl.Size.Width - control.Size.Width) / 2,
                    mainControl.Location.Y + mainControl.Size.Height + margin
                );
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void Left(Control mainControl, Control control)
        {
            Aligner.Left(mainControl, control, 0);
        }

        public static void Left(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(mainControl.Location.X - mainControl.Size.Width - margin,
                    mainControl.Location.Y);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void LeftCenter(Control mainControl, Control control)
        {
            Aligner.LeftCenter(mainControl, control, 0);
        }

        public static void LeftCenter(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(mainControl.Location.X - mainControl.Size.Width - margin,
                    mainControl.Location.Y + (mainControl.Size.Height - control.Size.Height) / 2);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void Right(Control mainControl, Control control)
        {
            Aligner.Right(mainControl, control, 0);
        }

        public static void Right(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(mainControl.Location.X + mainControl.Size.Width + margin,
                    mainControl.Location.Y);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void RightCenter(Control mainControl, Control control)
        {
            Aligner.RightCenter(mainControl, control, 0);
        }

        public static void RightCenter(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(mainControl.Location.X + mainControl.Size.Width + margin,
                    mainControl.Location.Y + (mainControl.Size.Height - control.Size.Height) / 2);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void RightTop(Control mainControl, Control control)
        {
            Action func = () =>
            {
                control.Location = new Point(mainControl.Location.X + mainControl.Size.Width,
                    mainControl.Location.Y - control.Size.Height);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();

            func();
        }

        public static void ItemsCenter(Control control)
        {
            Aligner.ItemsCenter(control, control.Controls.Cast<Control>().ToArray(), 0, 0);
        }

        public static void ItemsCenter(Control mainControl, int startY)
        {
            Aligner.ItemsCenter(mainControl, mainControl.Controls.Cast<Control>().ToArray(), startY, 0);
        }

        public static void ItemsCenter(Control mainControl, int startY, int spacing)
        {
            Aligner.ItemsCenter(mainControl, mainControl.Controls.Cast<Control>().ToArray(), startY, spacing);
        }

        public static void ItemsCenter(Control mainControl, Control[] childrenControls, int startY, int spacing)
        {
            Action func = () =>
            {
                (int x, int y) location = (mainControl.Width / 2, startY);

                foreach (Control childControl in childrenControls)
                {
                    int centeredX = location.x - (childControl.Width / 2);

                    childControl.Location = new Point(centeredX, location.y);

                    location.y += childControl.Height + spacing;
                }
            };

            mainControl.Resize += (sender, e) => func();

            func();
        }

        public static void ItemsLeft(Control mainControl)
        {
            Aligner.ItemsLeft(mainControl, 0);
        }

        public static void ItemsLeft(Control mainControl, int margin)
        {
            Aligner.ItemsLeft(mainControl, mainControl.Controls.Cast<Control>().ToArray(), margin);
        }

        public static void ItemsLeft(Control mainControl, Control[] childrenControls, int margin)
        {
            Action func = () =>
            {
                foreach (Control childControl in childrenControls)
                {
                    childControl.Location = new Point(margin, childControl.Location.Y);
                }
            };

            mainControl.Resize += (sender, e) => func();

            func();
        }
    }
}
