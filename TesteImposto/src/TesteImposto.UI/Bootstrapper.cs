using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace TesteImposto.UI
{
    public class Bootstrapper
    {
        public static Container container { get; set; }

        public static void Inicializar()
        {
            container = new Container();

            Imposto.Infra.IoC.Bootstrapper.RegisterServicesWeb(container);
        }

         
    }
    
         
}


