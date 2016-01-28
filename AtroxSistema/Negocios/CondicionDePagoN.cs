using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CondicionDePagoN:Entidades.CondicionDePagoE
    {
        public CondicionDePagoN(int p_id, string p_nombre) 
        {
            Id = p_id;
            Nombre = p_nombre;
        }
    }
}
