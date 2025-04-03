using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Profile: Form
    {
        private bool _closedSesion = false;
        private string _newImagePath = Context.actualUser.Info.profilePicture;

        public Profile()
        {
            InitializeComponent();
            _LoadUserImage();

            Resizer.Square(userImg, 128);

            Aligner.ItemsCenter(mainPanel, 20, 30);

            Fitsizer.AdjustObject(mainPanel, 20);

            Responsive.Center(mainPanel, 25);

            Pencil.Paint(this, Palette.Background);
            Pencil.Paint(mainPanel, Palette.Primary);
            Pencil.PaintItemsText(mainPanel, Palette.Text);
            Pencil.PaintButton(saveButton, Palette.Confirm, 0);
            Pencil.PaintButton(cancelButton, Palette.Cancel, 0);
            Pencil.PaintButton(closeSesionButton, Palette.Cancel, 0);
        }

        private void _LoadUserImage()
        {
            userImg.Image = Image.FromFile(_newImagePath);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            userName.Text = Context.actualUser.Info.name;
            userMail.Text = Context.actualUser.Info.email;
            password.Text = Context.actualUser.Info.password;
        }

        private void userImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Selecciona una imagen para tu foto de perfil",
                Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png",
                FilterIndex = 1,
                Multiselect = false
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _newImagePath = fileDialog.FileName;
                _LoadUserImage();
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_closedSesion)
            {
                Debug.WriteLine("Activando modo de auto destruccion...");
                userImg.Image.Dispose();
                userImg.Dispose();

                FormFabric.Open<Home>();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Conditioner.IsName(userName.Text))
                return;

            if (!Conditioner.IsMail(userMail.Text))
                return;

            if (!Conditioner.IsPassword(password.Text))
                return;

            user existUser;

            using (FiDBEntities db = new FiDBEntities())
            {
                existUser = (from u in db.users where u.id == Context.actualUser.Info.id select u).FirstOrDefault();
                
                existUser.email = userMail.Text;
                existUser.name = userName.Text;
                existUser.password = password.Text;
                existUser.profilePicture = _newImagePath;

                db.SaveChanges();
            }

            Context.actualUser.Info.Set(existUser);
            Context.Save();

            MessageBox.Show(
                "Cambios guardados correctamente",
                "Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            userMail.Text = Context.actualUser.Info.email;
            userName.Text = Context.actualUser.Info.name;
            password.Text = Context.actualUser.Info.password;
            _newImagePath = Context.actualUser.Info.profilePicture;
            _LoadUserImage();
        }

        private void closeSesionButton_Click(object sender, EventArgs e)
        {
            _closedSesion = true;
            Context.actualUser.Acceded = false;

            Context.Save();

            FormFabric.OpenAndClose<LogIn>();
        }
    }
}
