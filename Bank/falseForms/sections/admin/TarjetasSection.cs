using Bank.FiDBDataSetTableAdapters;
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
    public partial class TarjetasSection: Form
    {
        public TarjetasSection()
        {
            InitializeComponent();

            Responsive.Center(dataGridView1);

            DataButtons dataButtons = FormFabric.InsertForm<DataButtons>(this);

            Aligner.BottomCenter(dataGridView1, dataButtons);

            dataButtons.AddSaveEvent(SaveButtonEvent);

            dataButtons.AddRollbackEvent(RollbackButtonEvent);

            Pencil.Paint(this, Palette.Primary);
        }

        private void TarjetasSection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiDBDataSet.cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter.Fill(this.fiDBDataSet.cards);

        }

        private bool HasChanges()
        {
            if (!fiDBDataSet.HasChanges())
            {
                MessageBox.Show("No ha habido ningun cambio");
                return false;
            }

            return true;
        }

        private void SaveButtonEvent()
        {
            if (!HasChanges())
                return;

            if (!FormFabric.Confirmation())
                return;

            Helper.TryCatch(
                () =>
                {
                    cardsTableAdapter.Update(fiDBDataSet.cards);

                    fiDBDataSet.AcceptChanges();

                    MessageBox.Show("Cambios guardados correctamente");
                },
                (e) =>
                {
                    MessageBox.Show($"{e.Message}", "Error al guardar");
                    fiDBDataSet.RejectChanges();
                }
            );
        }

        private void RollbackButtonEvent()
        {
            if (!HasChanges())
                return;

            if (!FormFabric.Confirmation("¿Revertir cambios?"))
                return;

            Helper.TryCatch(
                () =>
                {
                    fiDBDataSet.RejectChanges();
                }
            );
        }
    }
}
