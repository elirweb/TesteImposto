using System;
using System.Data;
using System.Windows.Forms;
using GeradorXML;
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
            if (txtEstadoOrigem.Text != string.Empty && txtEstadoDestino.Text != string.Empty &&
                textBoxNomeCliente.Text != string.Empty && dataGridViewPedidos.RowCount > 0)
            {
                if (Validador.Distrito.VerificadorEstado(txtEstadoOrigem.Text) &&
                    Validador.Distrito.VerificadorEstado(txtEstadoDestino.Text))
                {
                    pedido.EstadoOrigem = txtEstadoOrigem.Text;
                    pedido.EstadoDestino = txtEstadoDestino.Text;
                    pedido.NomeCliente = textBoxNomeCliente.Text;

                    DataTable table = (DataTable) dataGridViewPedidos.DataSource;
                    foreach (DataRow row in table.Rows)
                    {
                       var chk = row["Brinde"].ToString() != string.Empty ? true : false;
                        pedido.ItensDoPedido.Add(
                            new PedidoItem()
                            {
                                Brinde = chk,
                                CodigoProduto = row["Codigo do produto"].ToString(),
                                NomeProduto = row["Nome do produto"].ToString(),
                                ValorItemPedido = Convert.ToDouble(row["Valor"].ToString())
                            });
                    }

                    var notafiscal = nota.GerarNotaFiscal(pedido);

                    if (gerador.Serializar(notafiscal,
                        System.Configuration.ConfigurationManager.AppSettings["diretorioxml"]))
                    {
                        nota.Adicionar(notafiscal);
                        LimparCampos();
                        MensagemBox("Operação efetuada com sucesso");
                    }
                    else
                        MensagemBox(
                            "Não foi possivel realizar a persistência de dados, favor entrar em contato com o Administrador");

                }
                else
                    MensagemBox("Ops! há algo errado, favor verificar");
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var imposto = new FormConsultaImposto(Bootstrapper.container.GetInstance<INotaFiscalAppAction>());
            imposto.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtEstadoOrigem.Text = "";
            txtEstadoDestino.Text = "";
            textBoxNomeCliente.Text = "";
            dataGridViewPedidos.DataSource = GetTablePedidos();

        }

        private void MensagemBox(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
