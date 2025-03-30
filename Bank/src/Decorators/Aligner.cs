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
        public static void Top(Control mainControl, Control control)
        {
            Aligner.Top(mainControl, control, 0);
        }

        public static void Top(Control mainControl, Control control, int margin)
        {
            Action func = () =>
            {
                control.Location = new Point(control.Location.X, mainControl.Location.Y - mainControl.Size.Height - margin);
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
                control.Location = new Point(control.Location.X,
                    mainControl.Location.Y + mainControl.Size.Height + margin);
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

        public static void ItemsCenter(Control control, int startY = 0, int spacing = 0)
        {
            Aligner.ItemsCenter(control, control.Controls.Cast<Control>().ToArray());
        }

        public static void ItemsCenter(Control mainControl, Control[] childrenControls, int startY = 0, int spacing = 0)
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
    }
}
