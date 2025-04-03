using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Functionalizer
    {
        public static void AddFuncItems(Control container, Action func)
        {
            foreach (Control control in container.Controls)
            {
                control.Click += (sender, e) => func();
            }
        }

        public static void AddFuncItems(Control container, Action<object, EventArgs> func)
        {
            foreach (Control control in container.Controls)
            {
                control.Click += (sender, e) => func(sender, e);
            }
        }

        public static void AddFuncMainAndItems(Control container, Action func)
        {
            container.Click += (sender, e) => func();

            foreach (Control control in container.Controls)
            {
                control.Click += (sender, e) => func();
            }
        }

        public static void AddFuncMainAndItems(Control container, Action<object, EventArgs> func)
        {
            container.Click += (sender, e) => func(sender, e);

            foreach (Control control in container.Controls)
            {
                control.Click += (sender, e) => func(sender, e);
            }
        }
    }
}
