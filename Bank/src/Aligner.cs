using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Aligner
    {
        public static void Top(Control mainControl, Control childControl)
        {
            Aligner.Top(mainControl, childControl, 0);
        }

        public static void Top(Control mainControl, Control childControl, int margin)
        {
            Action func = () =>
            {
                childControl.Location = new Point(childControl.Location.X, mainControl.Location.Y - mainControl.Size.Height - margin);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();
        }

        public static void TopCenter(Control mainControl, Control childControl)
        {
            Aligner.TopCenter(mainControl, childControl, 0);
        }

        public static void TopCenter(Control mainControl, Control childControl, int margin)
        {
            Action func = () =>
            {
                childControl.Location = new Point(
                    mainControl.Location.X + (mainControl.Size.Width - childControl.Size.Width) / 2,
                    mainControl.Location.Y - mainControl.Size.Height - margin
                );
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();
        }

        public static void Bottom(Control mainControl, Control childControl)
        {
            Aligner.Bottom(mainControl, childControl, 0);
        }

        public static void Bottom(Control mainControl, Control childControl, int margin)
        {
            Action func = () =>
            {
                childControl.Location = new Point(childControl.Location.X,
                    mainControl.Location.Y + mainControl.Size.Height + margin);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();
        }

        public static void BottomCenter(Control mainControl, Control childControl)
        {
            Aligner.BottomCenter(mainControl, childControl, 0);
        }

        public static void BottomCenter(Control mainControl, Control childControl, int margin)
        {
            Action func = () =>
            {
                childControl.Location = new Point(
                    mainControl.Location.X + (mainControl.Size.Width - childControl.Size.Width) / 2,
                    mainControl.Location.Y + mainControl.Size.Height + margin
                );
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();
        }

        public static void Left(Control mainControl, Control childControl)
        {
            Aligner.Left(mainControl, childControl, 0);
        }

        public static void Left(Control mainControl, Control childControl, int margin)
        {
            Action func = () =>
            {
                childControl.Location = new Point(mainControl.Location.X - mainControl.Size.Width - margin,
                    mainControl.Location.Y);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();
        }

        public static void Right(Control mainControl, Control childControl)
        {
            Aligner.Right(mainControl, childControl, 0);
        }

        public static void Right(Control mainControl, Control childControl, int margin)
        {
            Action func = () =>
            {
                childControl.Location = new Point(mainControl.Location.X + mainControl.Size.Width + margin,
                    mainControl.Location.Y);
            };

            mainControl.Resize += (sender, e) => func();

            mainControl.Move += (sender, e) => func();
        }

        public static void ItemsCenter(Control mainControl, int startY = 0, int spacing = 0)
        {
            Aligner.ItemsCenter(mainControl, mainControl.Controls.Cast<Control>().ToArray());
        }

        public static void ItemsCenter(Control mainControl, Control[] childrenControls, int startY = 0, int spacing = 0)
        {
            (int x, int y) location = (mainControl.Size.Width / 2, startY);

            foreach (Control childControl in childrenControls)
            {
                int centeredX = location.x - (childControl.Width / 2);

                childControl.Location = new Point(centeredX, location.y);

                location.y += childControl.Size.Height + spacing;
            }
        }
    }
}
