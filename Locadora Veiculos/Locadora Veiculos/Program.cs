using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_Veiculos
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
<<<<<<< HEAD
           // Autenticacao login = new Autenticacao();
            //if (login.ShowDialog() == DialogResult.OK)
=======
            Autenticacao login = new Autenticacao();
            if (login.ShowDialog() == DialogResult.OK)
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            {
                Application.Run(new TelaPrincipal());
            }
        }
    }
}
