using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Application.Interfaces;
using Imposto.Core.Entidades;

namespace TesteImposto.UI
{
    public partial class FormConsultaImposto : Form
    {
        private readonly INotaFiscalAppAction nota;
        public FormConsultaImposto(INotaFiscalAppAction notaapp)
        {

            InitializeComponent();
            nota = notaapp;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CarregarGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<NotaFiscalItem> CarregarGrid()
        {
            List<NotaFiscalItem> lista = new List<NotaFiscalItem>();
            var dados = nota.Imposto();
            foreach (var itens in dados)
            {
                NotaFiscalItem n = new NotaFiscalItem()
                {
                    Cfop = itens.Cfop,
                    BaseIcms = itens.BaseIcms,
                    ValorIcms = itens.ValorIcms,
                    BaseIPI = itens.BaseIPI,
                    ValorIPI = itens.ValorIPI
                };
                lista.Add(n);
            }

            return lista;
        }


    }
}

