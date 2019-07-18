namespace ManzantinesApp
{

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Reflection;
    using System.Windows.Forms;

    internal static class Program
    {
        public static FrmMenuPrincipal frmMenuPrincipal;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ",";
            customCulture.NumberFormat.NumberGroupSeparator = ".";
            customCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMenuPrincipal = new FrmMenuPrincipal();
            Application.Run(frmMenuPrincipal);
        }
    }
}
