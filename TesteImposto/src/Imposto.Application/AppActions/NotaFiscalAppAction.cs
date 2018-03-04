using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Application.Interfaces;
using Imposto.Core.Entidades;
using Imposto.Core.Interfaces.Repositorios;

namespace Imposto.Application.AppActions
{
    public class NotaFiscalAppAction: INotaFiscalAppAction
    {
        private readonly INotaFiscal notafiscal;

        public NotaFiscalAppAction(INotaFiscal nota)
        {
            notafiscal = nota;
        }
        public void Adicionar(NotaFiscal pedido)
        {
            notafiscal.Adicionar(pedido);
        }

        public NotaFiscal GerarNotaFiscal(Pedido pedido)
        {
            NotaFiscal validacaoNF = new NotaFiscal();
            validacaoNF.EmitirNotaFiscal(pedido);
            return validacaoNF;
         }

        public IEnumerable<NotaFiscalItem> Imposto()
        {
            return notafiscal.Imposto();
        }
    }
}
