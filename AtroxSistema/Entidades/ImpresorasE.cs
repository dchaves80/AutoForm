using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ImpresorasE: SuperEntity
    {
        string _Estacion;

        public string Estacion
        {
            get { return _Estacion; }
            set { _Estacion = value; }
        }
        int _IdTipoComprobante;

        public int IdTipoComprobante
        {
            get { return _IdTipoComprobante; }
            set { _IdTipoComprobante = value; }
        }
        string _Impresora;

        public string Impresora
        {
            get { return _Impresora; }
            set { _Impresora = value; }
        }
    }
}
