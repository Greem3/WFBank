using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    class ColorAttribute : Attribute
    {
        public Color CustomColor { get; private set; }

        public ColorAttribute(int r, int g, int b, int a)
        {
            CustomColor = Color.FromArgb(r, g, b, a);
        }

        public ColorAttribute(int r, int g, int b)
        {
            CustomColor = Color.FromArgb(r, g, b);
        }

        public ColorAttribute(string hex)
        {
            hex = hex.Replace("#", "");

            int argb = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            CustomColor = Color.FromArgb(argb);
        }
    }
}
