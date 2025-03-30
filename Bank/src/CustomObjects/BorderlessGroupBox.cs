using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    class BorderlessGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(
                this.Text,
                this.Font,
                new SolidBrush(this.ForeColor),
                new PointF(0, 5),
                format
            );
        }
    }
}
