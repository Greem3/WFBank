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
    public partial class TransferirSection: Form
    {
        public TransferirSection()
        {
            InitializeComponent();

            Responsive.LeftTop(infoMethod, 30);

            Aligner.RightCenter(infoMethod, receiverInfo, 20);

            Aligner.Bottom(infoMethod, cantityInfo, 20);

            Responsive.Left(resetTexts);

            Aligner.Bottom(resetTexts, startTrans, 20);

            //Fitsizer.AdjustObject(actionButtons);

            Aligner.Bottom(cantityInfo, actionButtons, 20);

            Pencil.Paint(this, Palette.Primary);

            Pencil.PaintText(infoMethod, Palette.Text);
            Pencil.PaintText(receiverInfo, Palette.Text);
            Pencil.PaintText(cantityInfo, Palette.Text);
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

            //Logica de base de datos
        }

        private void resetTexts_Click(object sender, EventArgs e)
        {
            if (!FormFabric.Confirmation(text: "Seguro que desea limpiar los campos?"))
                return;

            receiverValue.Text = "";
            userMethod.SelectedIndex = 0;
            cantityValue.Value = 0;
        }

        private void cantityValue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;

            if (obj.Value == 0)
            {
                startTrans.Enabled = false;
                return;
            }

            startTrans.Enabled = true;
        }
    }
}
