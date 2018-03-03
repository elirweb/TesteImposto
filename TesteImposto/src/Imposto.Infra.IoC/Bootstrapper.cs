using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Infra.IoC
{
    public class Bootstrapper
    {
        public static void RegisterServicesWeb(SimpleInjector.Container container)
        {
            RegisterServices(container, SimpleInjector.Lifestyle.Singleton);
        }

        public static void RegisterServices(SimpleInjector.Container container, SimpleInjector.Lifestyle lifestyle)
        {
            // registrando os container
            //app
            container.Register<Imposto.Application.Interfaces.INotaFiscalAppAction, Imposto.Application.AppActions.NotaFiscalAppAction>(lifestyle);
          
            //data
            container.Register<Imposto.Core.Interfaces.Repositorios.INotaFiscal, Imposto.Data.Repositorio.NotaFiscalRepositorio>(lifestyle);
         
        }

    }
}
