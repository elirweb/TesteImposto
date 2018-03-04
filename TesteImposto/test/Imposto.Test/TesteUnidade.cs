using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Core.Entidades;
using Xunit;

namespace Imposto.Test
{
    public class TesteUnidade
    {
        /*
         Lista de Tarefas de Validação
         1 - Validar se NomeCliente,EstadoOrigem e EstadoDestino estão preenchido
         2 - Validar se Tem itens no Pedido
         3 - Validar se existe o caminho da pasta 
         3 - Validar se foi gerado o Xml 
         */
        [Fact]
        public void NotaFiscal_Verificar_NomeClienteFoiPreenchido_vazio()
        {
            // Arrange
            var nota = new NotaFiscal();

            //Act
            nota.NomeCliente = "Elir";
            //Assert
            Assert.Empty(nota.NomeCliente);
        }

        [Fact]
        public void NotaFiscal_VerificarEstadoOrigEEstadoDest_vazio()
        {
            // Arrange
            var nota = new NotaFiscal();

            //Act
            nota.EstadoOrigem = "";
            nota.EstadoDestino = "";
            //Assert
            Assert.Empty(nota.EstadoOrigem);
            Assert.Empty(nota.EstadoDestino);
            
        }

        [Fact]
        public void NotaFiscal_PreencherDadosNFEVerificarSeTemItens()
        {
            // Arrange
            var nota = new NotaFiscal();

            //Act
            nota.Id = 1;
            nota.NomeCliente = "Elir";
            nota.NumeroNotaFiscal = 44444;
            nota.Serie = 33333;
            nota.EstadoDestino = "SP";
            nota.EstadoDestino = "RJ";

            nota.ItensDaNotaFiscal.Add(new NotaFiscalItem()
            {
                Cfop =  "4434343",
                IdNotaFiscal = 4,
                NomeProduto =  "Computador",
                CodigoProduto = "3",
                AliquotaIPI = 0.10
            });

            nota.ItensDaNotaFiscal.Add(new NotaFiscalItem()
            {
                Cfop = "667777",
                IdNotaFiscal = 4,
                NomeProduto = "Roupa",
                CodigoProduto = "7",
                AliquotaIPI = 0.40
            });

            //Assert
            Assert.True(nota.ItensDaNotaFiscal.Count > 0);
            Assert.True(nota.ItensDaNotaFiscal.Count > 0 && nota != null);

        }

        [Fact]
        public void NotaFiscal_PossuiDiretorio_true()
        {
            //Arrange
            var diretorio = string.Empty;

            //Act
            diretorio = "pasta base ";
            //Assert
            Assert.NotEmpty(diretorio);
        }
    }
}
