using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Conditioner
    {
        public static bool IsName(string name)
        {
            return name.Trim().Length > 0;
        }

        public static bool IsMail(string mail)
        {
            Regex realMail = new Regex(@"[a-zA-Z0-9.-]+\@[a-zA-Z0-9.-]+\.[a-zA-Z]+");

            if (!realMail.IsMatch(mail.Trim()))
            {
                MessageBox.Show($"El correo {mail} no es valido!", "Correo invalido", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool IsPassword(string password)
        {
            if (password.Trim().Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres", "Contraseña corta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
