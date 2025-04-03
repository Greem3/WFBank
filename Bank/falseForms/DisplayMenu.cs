using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class DisplayMenu: Form
    {
        public DisplayMenu()
        {
            InitializeComponent();
            _LoadProfile();

            userName.Text = Context.actualUser.Info.name;
            userImg.Image = Image.FromFile(Context.actualUser.Info.profilePicture);

            Aligner.Right(companyImg, userInfo);
            
            Responsive.Left(userImg);

            Resizer.Square(userImg, 64);

            Aligner.RightCenter(userImg, userName);
            Fitsizer.AdjustObject(userInfo);

            Responsive.LeftTop(companyImg);

            Fitsizer.AdjustInside(sections);

            Responsive.Left(sections, 10);
            Aligner.ItemsLeft(sections, 15);

            Pencil.Paint(this, Palette.Background);
            Pencil.PaintAllItemsText(this, Palette.Text);
        }

        public void LoadSections(Dictionary<string, string> toAddSections, Action<object, EventArgs> onClick)
        {
            sections.Controls.Clear();

            foreach (KeyValuePair<string, string> sectionName in toAddSections)
            {
                Panel newSection = new Panel()
                {
                    Name = $"{sectionName.Key}"
                };

                newSection.Click += (sender, e) => onClick(sender, e);

                PictureBox sectionImg = new PictureBox()
                {
                    Image = Image.FromFile(Formatter.PathFormat($"assets/{sectionName.Value}")),
                    Name = $"{sectionName.Key}_Img_",
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                sectionImg.Click += (sender, e) => onClick(sender, e);

                Label sectionTitle = new Label()
                {
                    Font = DecText.FontWithSize(TextSize.NormalText),
                    AutoSize = true,
                    Name = $"{sectionName.Key}_Label_",
                    Text = sectionName.Key
                };

                sectionTitle.Click += (sender, e) => onClick(sender, e);

                Resizer.Square(sectionImg, 64);

                Aligner.RightCenter(sectionImg, sectionTitle);

                newSection.Controls.AddRange(new Control[] { sectionImg, sectionTitle });

                Responsive.Left(sectionImg);

                sections.Controls.Add(newSection);
            }

            Aligner.ItemsCenter(
                sections,
                sections.Controls.Cast<Control>().ToArray(),
                0,
                0
            );
        }

        private void _LoadProfile()
        {
            Functionalizer.AddFuncMainAndItems(
                userInfo,
                (sender, e) =>
                {
                    Form form = sender as Form;

                    FormFabric.OpenAndClose<Profile>();
                }
            );
        }
    }
}
