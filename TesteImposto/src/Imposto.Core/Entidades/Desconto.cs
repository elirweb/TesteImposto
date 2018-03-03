using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Entidades
{
    public class Desconto
    {
        public Desconto(double desc)
        {
            desconto = desc;
        }
        public double desconto { get; set; }
    }
}

