using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp
{
    static class Program
    {
        public static FrmMenuPrincipal frmMenuPrincipal;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMenuPrincipal = new FrmMenuPrincipal();
            Application.Run(frmMenuPrincipal);
        }
    }
}
