using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULAHeranca3.View
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            MyGlobal.pessoas = new List<Model.PESSOA>();
            MyGlobal.fisicas = new List<Model.FISICA>();
            MyGlobal.juridicas = new List<Model.JURIDICA>();
            Application.Run(new FrmPrincipal());
        }
    }
}
