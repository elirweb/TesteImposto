using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Core.Entidades;
using Imposto.Core.Interfaces.Repositorios;
using Imposto.Test.Interfaces;
using Imposto.Test.ValueObject;

namespace Imposto.Test.Domain_Service
{
    public class NotaFiscal: Interfaces.INotaFiscal
    {
        private readonly INotaFiscalRepositorio reposi;
        public NotaFiscal(INotaFiscalRepositorio repo)
        {
            reposi = repo;
        }
        public void AdicionaritemNoPedido(Entidades.NotaFiscal n)
        {
            reposi.AdicionaritemNoPedido(n);
        }

        public RetornoMsg RetornaSucesso(Entidades.NotaFiscal pedido)
        {

            if (pedido == null) return new RetornoMsg("Erro na gravação de dados",0);
            return new RetornoMsg("Dados Gravado com sucesso",pedido.Id);
        }
    }
}
