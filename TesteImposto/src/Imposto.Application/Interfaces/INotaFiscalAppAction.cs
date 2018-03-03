using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Core.Entidades;

namespace Imposto.Application.Interfaces
{
    public interface INotaFiscalAppAction
    {
        void Adicionar(NotaFiscal pedido);

        NotaFiscal GerarNotaFiscal(Pedido pedido);
    }
}
