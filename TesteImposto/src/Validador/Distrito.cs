using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador
{
    public static class Distrito
    {
        public static bool VerificadorEstado(string est)
        {
            var retorno = false;
            string[] estado = 
                {"AC", "AL", "AP", "AM", "BA",
                    "CE","DF","ES","GO","MA","MT","MS",
                    "MG","PR","PB","PA","PE","PI","RJ","RN",
                    "RS","RO","RR","SC","SE","SP","TO" };

            foreach (var encontra in estado)
            {
                if (encontra.Equals(est))
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }
    }
}
