using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashInicio inicio = new SplashInicio();
            if (inicio.ShowDialog() == DialogResult.OK)
            {
                Application.Run(/*new FormLogin()*/ new Formularis.FormEquips());
            }
        }
    }
}
