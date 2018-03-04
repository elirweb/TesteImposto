﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Test.Entidades
{
    public class NotaFiscalItem
    {
        public int Id { get; set; }
        public int IdNotaFiscal { get; set; }
        public string Cfop { get; set; }
        public string TipoIcms { get; set; }
        public double BaseIcms { get; set; }
        public double BaseIPI { get; set; }
        public double AliquotaIcms { get; set; }
        public double AliquotaIPI { get; set; }

        public double ValorIcms { get; set; }
        public double ValorIPI { get; set; }

        public string NomeProduto { get; set; }
        public string CodigoProduto { get; set; }
        // Tiver que remover a Classe do Desconto mas já volto aqui
        public double desconto { get; set; }

    }
}
