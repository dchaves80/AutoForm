using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDocumentoAfipE:SuperEntity
    {

        private int _IdTipoDocumentoAFIP;
        private string _Nombre;

        public int IdTipoDocumentoAFIP
        {
            get { return _IdTipoDocumentoAFIP; }
            set { _IdTipoDocumentoAFIP = value; }
        }


        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
                
    }
}
