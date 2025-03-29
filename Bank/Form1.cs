using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            Responsive.Center(this, panel1);
            Responsive.Center(panel1, textBox1);
            Responsive.Center(panel1, pictureBox1);
            Responsive.Top(panel1, pictureBox1, 0);
        }
    }
}
