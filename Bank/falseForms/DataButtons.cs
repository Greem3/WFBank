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
using Bank;

namespace Bank
{
    public partial class DataButtons: Form
    {
        public DataButtons()
        {
            InitializeComponent();

            Pencil.Paint(this, Palette.Primary);
            Pencil.PaintButton(saveButton, Palette.Confirm, 0);
            Pencil.PaintButton(rollbackButton, Palette.Cancel, 0);
            Pencil.PaintItemsText(this, Palette.Text);

            DecText.SetSize(saveButton, TextSize.H4);
            DecText.SetSize(rollbackButton, TextSize.H4);
        }

        public void AddSaveEvent(Action func)
        {
            saveButton.Click += (sender, e) => func();
        }

        public void AddRollbackEvent(Action func)
        {
            rollbackButton.Click += (sender, e) => func();
        }
    }
}
