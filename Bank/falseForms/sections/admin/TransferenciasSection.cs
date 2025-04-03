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
    public partial class TransferenciasSection: Form
    {
        public TransferenciasSection()
        {
            InitializeComponent();

            Responsive.Center(dataGridView1);

            DataButtons dataButtons = FormFabric.InsertForm<DataButtons>(this);

            Aligner.BottomCenter(dataGridView1, dataButtons);

            dataButtons.AddSaveEvent(SaveButtonEvent);

            dataButtons.AddRollbackEvent(RollbackButtonEvent);

            Pencil.Paint(this, Palette.Primary);
        }

        private void TransferenciasSection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiDBDataSet.transferences' table. You can move, or remove it, as needed.
            this.transferencesTableAdapter.Fill(this.fiDBDataSet.transferences);
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
                    transferencesTableAdapter.Update(fiDBDataSet.transferences);
                        
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
