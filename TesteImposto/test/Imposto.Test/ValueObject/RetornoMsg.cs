using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Test.ValueObject
{
    public class RetornoMsg
    {
        public string Mensagem { get; set; }
        public int id;
        public RetornoMsg(string msg,int i)
        {
            Mensagem = msg;
            id = new Random().Next(Int32.MaxValue);
        }
    }

    
            
    }
}
