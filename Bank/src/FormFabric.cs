using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class FormFabric
    {

        public static T GetForm<T>() where T : Form, new()
        {
            T form = new T();

            form.TopLevel = false;
            form.Visible = true;

            return form;
        }

        public static T GetForm<T>(T newForm) where T : Form
        {
            newForm.TopLevel = false;
            newForm.Visible = true;

            return newForm;
        }

        public static T InsertForm<T>() where T : Form, new()
        {
            T form = new T();

            form.TopLevel = false;
            form.Visible = true;

            Application.OpenForms[0].Controls.Add(form);

            return form;
        }

        public static T InsertForm<T>(Control mainControl) where T : Form, new()
        {
            T form = new T();

            form.TopLevel = false;
            form.Visible = true;

            mainControl.Controls.Add(form);

            return form;
        }

        public static void OpenAndClose(Form newForm)
        {
            Form currentForm = Form.ActiveForm;

            if (Application.OpenForms[0] == currentForm)
            {
                currentForm.Hide();
            }
            else if (currentForm != null)
            {
                currentForm.Close();
            }

            newForm.Show();
        }

        public static void OpenAndClose<T>() where T: Form, new()
        {
            FormFabric.OpenAndClose(new T());
        }

        public static void OpenDialogAndClose(Form newForm)
        {
            Form currentForm = Form.ActiveForm;

            if (Application.OpenForms[0] == currentForm)
            {
                currentForm.Hide();
            }
            else if (currentForm != null)
            {
                currentForm.Close();
            }

            newForm.ShowDialog();
        }

        public static void OpenAndCloseDialog<T>() where T : Form, new()
        {
            FormFabric.OpenDialogAndClose(new T());
        }

        public static void OpenAndHide(Form newForm)
        {
            Form.ActiveForm.Hide();
            newForm.Show();
        }

        public static void OpenAndHide<T>() where T : Form, new()
        {
            FormFabric.OpenAndHide(new T());
        }

        public static void Open(Form newForm)
        {
            newForm.Show();
        }

        public static void Open<T>() where T : Form, new()
        {
            FormFabric.Open(new T());
        }

        public static void OpenDialog(Form newForm)
        {
            newForm.ShowDialog();
        }

        public static void OpenDialog<T>() where T : Form, new()
        {
            FormFabric.OpenDialog(new T());
        }

        public static bool Confirmation(string caption = "Confirmación", string text = "¿Guardar cambios?")
        {
            DialogResult result = MessageBox.Show(
                text,
                caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                return true;

            return false;
        }
    }
}