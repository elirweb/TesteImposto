﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Core.Entidades;

namespace Imposto.Core.Interfaces.Repositorios
{
    public interface INotaFiscal
    {
        void Adicionar(NotaFiscal pedido);

        IEnumerable<NotaFiscalItem> Imposto();
    }
}
