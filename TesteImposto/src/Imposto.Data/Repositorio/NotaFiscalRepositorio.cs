using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Imposto.Core.Entidades;
using Imposto.Core.Interfaces.Repositorios;
using Imposto.Data.Conexao;

namespace Imposto.Data.Repositorio
{
    public class NotaFiscalRepositorio: INotaFiscal
    {
        private readonly string bd = @"Data Source=DESKTOP-S6C9UFP;Initial Catalog=TESTE;User ID=sa;password=elirweb";

        public void Adicionar(NotaFiscal pedido)
        {
            using (var conn = new SqlConnection(bd))
            {
                var p = new DynamicParameters();
                p.Add("@pId", 0);
                p.Add("@pNumeroNotaFiscal", pedido.NumeroNotaFiscal);
                p.Add("@pSerie", pedido.Serie);
                p.Add("@pNomeCliente", pedido.NomeCliente);
                p.Add("@pEstadoDestino", pedido.EstadoDestino);
                p.Add("@pEstadoOrigem", pedido.EstadoOrigem);
                conn.Execute("P_NOTA_FISCAL", p, commandType: CommandType.StoredProcedure);
            }
            if (pedido.ItensDaNotaFiscal.Count > 0)
            {
                SalvarItems(pedido.ItensDaNotaFiscal);
            }
        }

        public void SalvarItems(List<NotaFiscalItem> pedido)
        {
            foreach (var itens in pedido)
            {
                using (var conn = new SqlConnection(bd))
                {
                    var p = new DynamicParameters();
                    p.Add("@pId",0);
                    p.Add("@pIdNotaFiscal", itens.IdNotaFiscal);
                    p.Add("@pCfop", itens.Cfop);
                    p.Add("@pTipoIcms", itens.TipoIcms);
                    p.Add("@pBaseIcms", itens.BaseIcms);
                    p.Add("@pAliquotaIcms", itens.AliquotaIcms);
                    p.Add("@pValorIcms", itens.ValorIcms);
                    p.Add("@pNomeProduto", itens.NomeProduto);
                    p.Add("@pCodigoProduto", itens.CodigoProduto);
                    p.Add("@pBaseIPI", itens.BaseIPI);
                    p.Add("@pValorIPI", itens.ValorIPI);
                    p.Add("@pDesconto", itens.desconto);

                    conn.Execute("P_NOTA_FISCAL_ITEM", p, commandType: CommandType.StoredProcedure);


                }

            }
        }


        }
    
}
