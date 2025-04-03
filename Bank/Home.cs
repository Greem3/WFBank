using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();
            _LoadSections();

            InicioSection homeSection = FormFabric.InsertForm<InicioSection>(this);

            splitContainer1.Panel2.Controls.Add(homeSection);

            Filler.Fill(homeSection);
        }

        private void _LoadSections()
        {
            DisplayMenu generalMenu = FormFabric.InsertForm<DisplayMenu>(splitContainer1.Panel1);

            Dictionary<string, string> actSection = Context.sections.User;

            if (Context.actualUser.Info.isAdmin)
                actSection = Context.sections.Admin;

            generalMenu.LoadSections(actSection, (sender, e) =>
            {
                string objectName = ((Control)sender).Name;

                Regex rgx = new Regex(@"_(\w+)_$");

                objectName = rgx.Replace(objectName, "");

                Type formType = Type.GetType($"Bank.{objectName}Section");

                Form openForm = Helper.TryCatch(
                    () =>
                    {
                        return (Form)Activator.CreateInstance(formType);
                    },
                    () =>
                    {
                        MessageBox.Show(
                            "Formulario no encontrado",
                            "Formulario inexistente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                );

                if (openForm is null)
                    return;

                openForm.TopLevel = false;
                openForm.Visible = true;

                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(openForm);

                Filler.Fill(openForm);
            });

            Filler.Fill(generalMenu);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
