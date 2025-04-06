using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class SignIn: Form
    {
        public SignIn()
        {
            InitializeComponent();

            DecText.SetSize(label1, TextSize.H2);
            DecText.SetSizeInto(infoPanel, TextSize.NormalText);

            Filler.Fill(splitContainer1);
            Filler.Fill(pictureBox1);

            Responsive.Center(infoPanel);
            Aligner.ItemsCenter(infoPanel, 20, 30);
            Fitsizer.AdjustObject(infoPanel, 20);

            Aligner.TopLeft(infoPanel, label1, 30, 50);

            Pencil.Paint(splitContainer1.Panel2, Palette.Background);
            Pencil.Paint(infoPanel, Palette.Primary);

            Pencil.PaintText(label1, Palette.Text);
            Pencil.PaintItemsText(infoPanel, Palette.Text);
            Pencil.PaintText(signInButton, Palette.ButtonText);

            linkLabel1.LinkColor = Color.White;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (!Conditioner.IsName(userName.Text))
                return;

            if (!Conditioner.IsMail(mail.Text))
                return;

            if (!Conditioner.IsPassword(password.Text))
                return;

            user newUser = new user()
            {
                name = userName.Text,
                email = mail.Text,
                password = password.Text,
                isAdmin = false,
                profilePicture = "C:\\Users\\ianpi\\OneDrive\\Imágenes\\equipo_flow_front.jpg"
            };

            using (FiDBEntities db = new FiDBEntities())
            {

                card cardTarget = 
                    (from c in db.cards 
                    where c.cardNumber.ToString() == keyCard.Text &&
                          c.userId == null 
                    select c).FirstOrDefault();

                if (cardTarget is null)
                {
                    MessageBox.Show(
                        "Esta tarjeta ya esta en uso",
                        "Tarjeta usada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                Helper.TryCatch(() =>
                {
                    SqlConnection connection =
                        new SqlConnection(
                            "Server=localhost;Database=FiDB;Trusted_Connection=True;TrustServerCertificate=True;");
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(
                               $"insert into users (name, email, password) values ('{newUser.name}', '{newUser.email}', '{newUser.password}')",
                               connection
                           )
                          )
                    {
                        command.ExecuteNonQuery();
                    }

                    user infoUser = (from u in db.users where u.email == newUser.email select u).FirstOrDefault();

                    using (SqlCommand command = new SqlCommand($"update cards set userId = {infoUser.id} where cardNumber = {int.Parse(keyCard.Text.Trim())}", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                },
                (ex) =>
                {
                    MessageBox.Show(
                        $"Ha ocurrido un error inesperado.\n\n{ex.Message}\n\nReportelo a los administradores",
                        "Error desconocido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                });
                
            }

            Context.actualUser.Acceded = keepSesion.Checked;
            Context.actualUser.Info.Set(newUser);

            Context.actualUser.Save();

            FormFabric.OpenAndClose(new Home());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFabric.OpenAndClose(new LogIn());
        }
    }
}
