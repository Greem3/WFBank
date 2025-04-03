using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DbModelBuilder builder = new DbModelBuilder();

            builder.Entity<user>().HasIndex(u => u.email).IsUnique();

            if (Context.actualUser.Acceded)
            {
                Application.Run(new Home());
                return;
            }

            Application.Run(new LogIn());
        }
    }
}
