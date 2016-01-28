using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocios
{
    public class AfipN:AfipE
    {
        /// <summary>
        /// Detalle de afip, unicamente para instanciar en memoria
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_idAfip"></param>
        /// <param name="p_Nombre"></param>
        public AfipN(int p_id, int p_idAfip, String p_Nombre) 
        {
            this.Id = p_id;
            this.IdCategoriaAFIP = p_idAfip;
            this.Nombre = p_Nombre;
        }
    }
}
