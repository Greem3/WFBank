using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class TransferirSection: Form
    {
        public TransferirSection()
        {
            InitializeComponent();

            DecText.SetSizeAll(panel1, TextSize.NormalText);

            Responsive.Center(panel1);

            Responsive.LeftTop(infoMethod, 30);

            Aligner.RightCenter(infoMethod, receiverInfo, 20);

            Aligner.Bottom(infoMethod, cantityInfo, 40);

            Responsive.Left(resetTexts);

            Aligner.Right(resetTexts, startTrans, 50);

            //Fitsizer.AdjustObject(actionButtons);

            Aligner.Bottom(cantityInfo, actionButtons, 20);

            Pencil.Paint(this, Palette.Primary);

            Pencil.PaintText(infoMethod, Palette.Text);
            Pencil.PaintText(receiverInfo, Palette.Text);
            Pencil.PaintText(cantityInfo, Palette.Text);
            Pencil.PaintButton(resetTexts, Palette.Cancel, 0);
            Pencil.PaintButton(startTrans, Palette.Confirm, 0);
            Pencil.PaintText(resetTexts, Palette.Text);
            Pencil.PaintText(startTrans, Palette.Text);
        }

        private void userMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox method = sender as ComboBox;

            receiverInfo.Text = $"{method.Text} del receptor";
            receiverValue.Text = "";
        }

        private void TransferirSection_Load(object sender, EventArgs e)
        {
            userMethod.SelectedIndex = 0;

            cantityValue.Maximum = long.MaxValue;
        }

        private void userMethod_TextUpdate(object sender, EventArgs e)
        {
            ComboBox method = sender as ComboBox;

            if (!method.Items.Contains(method.Text))
            {
                MessageBox.Show(
                    "El método de transferencia no es válido",
                    "Método de transferencia invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void methodValue_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;

            if (text.Text.Length == 0)
            {
                cantityInfo.Visible = false;
                cantityValue.Value = 0;
                return;
            }

            cantityInfo.Visible = true;
        }

        private void startTrans_Click(object sender, EventArgs e)
        {
            if (!FormFabric.Confirmation(text: "Seguro que desea realizar la transferencia?"))
                return;

            using (FiDBEntities db = new FiDBEntities())
                using (var transaction = db.Database.BeginTransaction())
            {
                Func<user>[] arr = new Func<user>[]
                {
                    () =>
                    {
                        return (from u in db.users where u.email == receiverValue.Text select u).FirstOrDefault();
                    },
                    () =>
                    {
                        return (from c in db.cards from u in db.users
                                where c.userId == u.id
                                select u)
                            .FirstOrDefault();
                    }
                };

                int toUserId = 0;

                Exception exception = Helper.TryCatch(
                    () =>
                    {
                        toUserId = arr[userMethod.SelectedIndex]().id;
                    },
                    (ex) =>
                    {
                        MessageBox.Show("Este usuario no existe", "Usuario inexistente", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return ex;
                    }
                );

                if (exception != null)
                    return;

                if (toUserId == 0)
                {
                    MessageBox.Show("No se realizó la transacción", "Transacción cancelada", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                transference trans = new transference()
                {
                    actorId = Context.actualUser.Info.id,
                    cantity = cantityValue.Value,
                    toUserId = toUserId,
                    transDate = DateTime.Now
                };

                //db.transferences.Add(trans);

                SqlConnection connection =
                    new SqlConnection(
                        "Server=localhost;Database=FiDB;Trusted_Connection=True;TrustServerCertificate=True;");
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                           $"insert into transferences (actorId, toUserId, cantity) values ({trans.actorId}, {trans.toUserId}, {trans.cantity})",
                           connection
                           )
                       )
                {
                    command.ExecuteNonQuery();
                }

                //db.SaveChanges();
            }

            MessageBox.Show(
                "Transferencia realizada con exito",
                "Transferencia exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            _ResetAll();
        }

        private void resetTexts_Click(object sender, EventArgs e)
        {
            if (!FormFabric.Confirmation(text: "Seguro que desea limpiar los campos?"))
                return;

            _ResetAll();
        }

        private void _ResetAll()
        {
            receiverValue.Text = "";
            userMethod.SelectedIndex = 0;
            cantityValue.Value = 0;
        }

        private void cantityValue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;

            if (obj.Value == 0)
            {
                startTrans.Visible = false;
                return;
            }

            startTrans.Visible = true;
        }
    }
}
