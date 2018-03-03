using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Application.Interfaces;

namespace TesteImposto.UI
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {

            Bootstrapper.Inicializar();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormImposto(Bootstrapper.container.GetInstance<INotaFiscalAppAction>()));
        }
    }
}
