using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AfipE:SuperEntity
    {
        private int _IdCategoriaAFIP;
        private string _Nombre;

        public int IdCategoriaAFIP
        {
            get { return _IdCategoriaAFIP; }
            set { _IdCategoriaAFIP = value; }
        }
        

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
                

    }
}
