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
    public partial class LoginSesion: Form
    {
        public LoginSesion()
        {
            InitializeComponent();
            Responsive.Center(this, mainPanel);

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
                20,
                25
            );

            Responsive.Left(buttonsPanel, logIn, 30);
            Responsive.Right(buttonsPanel, signIn, 30);
        }
    }
}
