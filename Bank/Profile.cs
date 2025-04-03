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
    public partial class Profile: Form
    {
        public Profile()
        {
            InitializeComponent();

            Responsive.LeftTop(returnButton);

            Responsive.Center(mainPanel, 25);

            Resizer.Square(userImg, 128);

            Aligner.ItemsCenter(mainPanel, 20, 30);

            Fitsizer.AdjustObject(mainPanel);

            Pencil.Paint(this, Palette.Background);
            Pencil.Paint(mainPanel, Palette.Primary);
        }

        private void _LoadUserImage()
        {
            userImg.Image = Image.FromFile(Context.actualUser.Info.profilePicture);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
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
                Context.actualUser.Info.profilePicture = fileDialog.FileName;
                _LoadUserImage();
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormFabric.Open<Home>();
        }
    }
}
