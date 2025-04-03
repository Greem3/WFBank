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
            Aligner.RightCenter(cardInfo, cardInfoCantity, 100);

            Aligner.BottomCenter(cardInfo, transCantityInfo, 100);
            Aligner.RightCenter(transCantityInfo, transDateInfo, 100);

            Responsive.Center(noCardLabel);

            Pencil.Paint(this, Palette.Primary);
            Pencil.PaintItems(panel1, Palette.CardBackground, (control) => control is Panel);

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

                var trans = from t in db.transferences orderby t.transDate descending 
                    where t.actorId == Context.actualUser.Info.id
                    select t;

                transCantityTitle.Text = "Cantidad de transacciones realizadas";

                transDateTitle.Text = "Fecha de la ultima transaccion realizada";

                if (trans.Count() > 0)
                {
                    transCantity.Text = trans.Count().ToString();
                    transDate.Text = trans.FirstOrDefault().transDate.ToString();
                }

                transCantityInfo.Visible = true;
                transDateInfo.Visible = true;
                cardInfo.Visible = true;
                cardInfoCantity.Visible = true;

                Aligner.ItemsCenter(cardInfo, 30, 30);
                //Responsive.MiddleX(cardNumber);
                //Aligner.BottomCenter(cardNumber, cardNumberTitle, 20);

                Aligner.ItemsCenter(cardInfoCantity, 30, 30);
                //Responsive.MiddleX(cardMoney);
                //Aligner.BottomCenter(cardMoney, cardMoneyTitle, 20);

                Aligner.ItemsCenter(transCantityInfo, 30, 30);

                Aligner.ItemsCenter(transDateInfo, 30, 30);

                //Fitsizer.AdjustInside(this, 25);
            }

            Fitsizer.AdjustObject(panel1, 30);
            Responsive.Center(panel1);
        }
    }
}
