using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class ForgotPassword: Form
    {
        public ForgotPassword()
        {
            InitializeComponent();

            Responsive.Center(options);

            Responsive.MiddleX(borderlessGroupBox1);

            Responsive.MiddleY(accept);
            Aligner.Right(accept, cancel, 40);

            Fitsizer.AdjustObject(buttonsPanel);

            Responsive.MiddleX(buttonsPanel);

            Pencil.Paint(this, Palette.Background);
            Pencil.PaintText(borderlessGroupBox1, Palette.Text);

            Pencil.PaintButton(accept, Palette.Confirm, 0);
            Pencil.PaintButton(cancel, Palette.Cancel, 0);
            Pencil.PaintItemsText(buttonsPanel, Palette.ButtonText);
        }

        private void accept_Click(object sender, EventArgs e)
        {
            //Todo: logica para enviar el correo mediante la api

            MessageBox.Show("No tienes conexión a internet", "No Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;

            WebRequest request = WebRequest.Create(
                "https://api.testmail.app/api/json&apikey=5e063c6c-d28f-428d-aaa8-0cd42b255d76&namespace=qznu9"
                );

            request.Method = "GET";

            var response = request.GetResponse();

            Debug.WriteLine(response);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
