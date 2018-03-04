using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorXML;
using Imposto.Application.AppActions;
using Imposto.Application.Interfaces;
using Imposto.Core.Entidades;

namespace TesteImposto.UI
{
    public partial class FormImposto : Form
    {
        private Pedido pedido = new Pedido();
        private Exportar gerador = new Exportar();
        private readonly INotaFiscalAppAction nota;
        public FormImposto(INotaFiscalAppAction notaapp )
        {
            InitializeComponent();
            dataGridViewPedidos.AutoGenerateColumns = true;
            dataGridViewPedidos.DataSource = GetTablePedidos();
            ResizeColumns();

            nota = notaapp;
        }

        private void ResizeColumns()
        {
            double mediaWidth = dataGridViewPedidos.Width / dataGridViewPedidos.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            for (int i = dataGridViewPedidos.Columns.Count - 1; i >= 0; i--)
            {
                var coluna = dataGridViewPedidos.Columns[i];
                coluna.Width = Convert.ToInt32(mediaWidth);
            }
        }

        private object GetTablePedidos()
        {
            DataTable table = new DataTable("pedidos");
            table.Columns.Add(new DataColumn("Nome do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Codigo do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Valor", typeof(decimal)));
            table.Columns.Add(new DataColumn("Brinde", typeof(bool)));

            return table;
        }

        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            pedido.EstadoOrigem = txtEstadoOrigem.Text;
            pedido.EstadoDestino = txtEstadoDestino.Text;
            pedido.NomeCliente = textBoxNomeCliente.Text;

            DataTable table = (DataTable)dataGridViewPedidos.DataSource;

            foreach (DataRow row in table.Rows)
            {
                pedido.ItensDoPedido.Add(
                    new PedidoItem()
                    {
                        Brinde = Convert.ToBoolean(row["Brinde"]),
                        CodigoProduto = row["Codigo do produto"].ToString(),
                        NomeProduto = row["Nome do produto"].ToString(),
                        ValorItemPedido = Convert.ToDouble(row["Valor"].ToString())
                    });
            }

            var notafiscal = nota.GerarNotaFiscal(pedido);


            
            if (gerador.Serializar(notafiscal, System.Configuration.ConfigurationManager.AppSettings["diretorioxml"]))
            {
                nota.Adicionar(notafiscal);
                MessageBox.Show("Operação efetuada com sucesso");
            }
            else
                MessageBox.Show("Não foi possivel realizar a persistência de dados, favor entrar em contato com o Administrador");
         }

        private void btnEditarNF_Click(object sender, EventArgs e)
        {
            FormEditarNotaFiscal editar = new FormEditarNotaFiscal();
            editar.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormConsultaImposto imposto = new FormConsultaImposto(Bootstrapper.container.GetInstance<INotaFiscalAppAction>());
            imposto.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
