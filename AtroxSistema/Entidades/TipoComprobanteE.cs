using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoComprobanteE:SuperEntity
    {
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Letra;
        public string Letra
        {
            get { return _Letra; }
            set { _Letra = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private short _Copias;

        public short Copias
        {
            get { return _Copias; }
            set { _Copias = value; }
        }
    }
}
