using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Loader
    {
        public static void OnLoad(Form form, Control control, Action<Control, Control> responsiveFunc)
        {
            form.Load += (sender, e) => responsiveFunc(form, control);
        }
    }
}
