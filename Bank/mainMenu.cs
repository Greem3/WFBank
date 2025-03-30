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
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Filler.Fill(splitContainer1);

            Responsive.LeftTop(profileImg);

            Filler.FillX(sections);

            Responsive.MiddleX(sections);
            Responsive.LeftTop(examplebutton);
            Responsive.RightBottom(button1);

            Responsive.Left(section1, 30);

            Responsive.MiddleY(sectionIcon1);
            Aligner.RightCenter(sectionIcon1, sectionName1);

            Responsive.Left(button2);
        }
    }
}
