using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LocalidadE:SuperEntity
    {

        String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        String _Provincia;

        public String Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }
    }
}
