using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Test.Entidades;
using Imposto.Test.Interfaces;
using Moq;
using Xunit;

namespace Imposto.Test.Service
{
    public class NotaFiscal
    {
        [Fact]
        public void NotaFiscal_AdicionarPedidoAoBancodeDados()
        {
            // Arrange
            var repositorio = new Mock<INotaFiscalRepositorio>();
            var pedidoservice = new Domain_Service.NotaFiscal(repositorio.Object);

            var pedido = new Entidades.NotaFiscal()
            {
                NomeCliente = "Elir",
                EstadoOrigem = "SP",
                EstadoDestino = "RJ",
              
            };
            pedido.ItensDaNotaFiscal.Add(new NotaFiscalItem()
            {
                Cfop = "32323",
                NomeProduto = "Computador",
                desconto = 0.10,
                IdNotaFiscal = 1,
                CodigoProduto = "200"

            });
             
            //Act
            repositorio.Setup(r => r.AdicionaritemNoPedido(pedido));
            var retorno = pedidoservice.RetornaSucesso(pedido);

            //Assert
            Assert.True(retorno.id != 0);

        }
    }
}
