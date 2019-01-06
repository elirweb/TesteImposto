using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Imposto.Core.Entidades;

namespace GeradorXML
{
    public class Exportar
    {
        public bool Serializar(NotaFiscal pedido, string caminho)
        {

            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Create);
                XmlSerializer serializador = new XmlSerializer(typeof(NotaFiscal));
                serializador.Serialize(stream, pedido);
                return true;
                //elirweb
            }
            catch (Exception g)
            {
                throw new Exception(g.Message);
            }


        }
    }
}

