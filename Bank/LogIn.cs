using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
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

            Resizer.Square(pictureBox1, 128);
            DecText.SetSizeInto(mainPanel, TextSize.NormalText);
            DecText.SetSize(title, TextSize.H1);
            Aligner.BottomCenter(borderlessGroupBox2, forgotPasswordLabel, 15);

            Fitsizer.AdjustHeightObject(buttonsPanel, 10);

            Aligner.ItemsCenter(
                mainPanel,
                new Control[]
                {
                    pictureBox1,
                    title,
                    borderlessGroupBox1,
                    borderlessGroupBox2
                },
                5,
                30
            );

            Aligner.BottomCenter(forgotPasswordLabel, keepSesion, 15);
            Aligner.BottomCenter(keepSesion, buttonsPanel, 15);

            Fitsizer.AdjustObject(mainPanel, 0, 5);
            Responsive.Center(mainPanel);

            Responsive.Left(logInButton, 30);
            Responsive.Right(signInButton, 30);

            Pencil.Paint(this, Palette.Background);
            Pencil.Paint(mainPanel, Palette.Primary);
            Pencil.PaintItemsText(mainPanel, Palette.Text);
            Pencil.PaintItemsText(buttonsPanel, Palette.ButtonText);

            forgotPasswordLabel.LinkColor = Color.White;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            FormFabric.OpenAndClose<SignIn>();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (!Conditioner.IsMail(mail.Text))
                return;

            if (!Conditioner.IsPassword(password.Text))
                return;

            user existUser;

            using (FiDBEntities db = new FiDBEntities())
            {
                existUser = (from u in db.users where u.email == mail.Text select u).FirstOrDefault();
            }

            if (existUser is null)
            {
                MessageBox.Show(
                    "El usuario no existe",
                    "Usuario inexistente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (existUser.password != password.Text)
            {
                MessageBox.Show(
                    "La contraseña es incorrecta",
                    "Contraseña incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Context.actualUser.Acceded = keepSesion.Checked;
            Context.actualUser.Info.Set(existUser);
            
            Context.Save();

            FormFabric.OpenAndClose<Home>();
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFabric.OpenDialog<ForgotPassword>();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }
    }
}
