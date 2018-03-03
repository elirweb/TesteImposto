using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteImposto.UI
{
    public partial class FormConsultaImposto : Form
    {
        public FormConsultaImposto()
        {

            // Este form responsavel por trazer informação dos imposto
            // SELECT CFOP,BASEICMS,VALORICMS,BASEIPI,VALORIPI  FROM NOTAFISCALITEM
            // montar a estrutura para trazer estar informação do banco de dados
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

