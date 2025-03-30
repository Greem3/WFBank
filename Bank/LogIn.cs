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
    public partial class LogIn: Form
    {
        public LogIn()
        {
            InitializeComponent();
            
            Responsive.Center(mainPanel);

            Fitsizer.AdjustHeightObject(buttonsPanel, 10);

            Aligner.ItemsCenter(
                mainPanel,
                new Control[]
                {
                    pictureBox1,
                    title,
                    borderlessGroupBox1,
                    borderlessGroupBox2,
                    buttonsPanel
                },
                0,
                25
            );

            Fitsizer.AdjustObject(mainPanel);

            Aligner.BottomCenter(borderlessGroupBox2, forgotPassword, 5);
            Responsive.Left(logInButton, 30);
            Responsive.Right(signInButton, 30);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
