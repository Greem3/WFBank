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
    public partial class InicioSection: Form
    {
        public InicioSection()
        {
            InitializeComponent();

            DecText.SetSizeAll(this, TextSize.H4,
                (control) => control.Name.EndsWith("Title"));

            DecText.SetSizeAll(this, TextSize.NormalText,
                (control) => !control.Name.EndsWith("Title"));

            Responsive.LeftTop(cardInfo, 20);
            Aligner.RightCenter(cardInfo, cardInfoCantity, 20);

            Responsive.Center(noCardLabel);

            Pencil.Paint(this, Palette.Primary);
            Pencil.PaintItems(this, Palette.CardBackground, (control) => control is Panel);

            Pencil.PaintAllItemsText(this, Palette.ButtonText);
            Pencil.PaintText(noCardLabel, Palette.Text);
        }

        private void InicioSection_Load(object sender, EventArgs e)
        {
            using (FiDBEntities db = new FiDBEntities())
            {
                card userCard = (from u in db.users 
                    join c in db.cards on u.id equals c.userId 
                    where u.id == Context.actualUser.Info.id select c).FirstOrDefault();

                if (userCard is null)
                {
                    DecText.SetSize(noCardLabel, TextSize.H1);
                    return;
                }

                noCardLabel.Visible = false;

                cardNumber.Text = userCard.cardNumber.ToString();
                cardNumberTitle.Text = "Número de tarjeta";

                cardMoney.Text = userCard.moneyCantity.ToString();
                cardMoneyTitle.Text = "Dinero en la tarjeta";

                cardInfo.Visible = true;
                cardInfoCantity.Visible = true;

                Responsive.MiddleX(cardNumber);
                Aligner.BottomCenter(cardNumber, cardNumberTitle, 20);

                Responsive.MiddleX(cardMoney);
                Aligner.BottomCenter(cardMoney, cardMoneyTitle, 20);

                Fitsizer.AdjustObject(cardInfoCantity, 15);
                Fitsizer.AdjustObject(cardInfo, 15);
                return;
            }
        }
    }
}
