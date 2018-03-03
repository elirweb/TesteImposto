using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Core.Entidades;
using Imposto.Core.Interfaces.Repositorios;
using Imposto.Data.Conexao;

namespace Imposto.Data.Repositorio
{
    public class NotaFiscalRepositorio: INotaFiscal
    {
        private Conexao.Banco _conexao = null;  
        public void Adicionar(NotaFiscal pedido)
        {
            _conexao = new Banco();
            // vou usar o Dapper para 
            throw new NotImplementedException();
        }
    }
}
