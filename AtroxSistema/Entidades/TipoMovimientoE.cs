using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoMovimientoE: SuperEntity
    {
        int _IdTipoComprobante;

        public int IdTipoComprobante
        {
            get { return _IdTipoComprobante; }
            set { _IdTipoComprobante = value; }
        }

        string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        string _Signo;

        public string Signo
        {
            get { return _Signo; }
            set { _Signo = value; }
        }

        string _Numeracion;

        public string Numeracion
        {
            get { return _Numeracion; }
            set { _Numeracion = value; }
        }

        bool _MueveStock;

        public bool MueveStock
        {
            get { return _MueveStock; }
            set { _MueveStock = value; }
        }
    }
}
