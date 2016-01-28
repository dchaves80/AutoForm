using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocios
{
    public class TipoDocumentopAfipN:TipoDocumentoAfipE
    {
        /// <summary>
        /// crea nuevo tipo documento afip
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_idTipoDocumento"></param>
        /// <param name="p_Nombre"></param>
        public TipoDocumentopAfipN(int p_id, int p_idTipoDocumento, String p_Nombre) 
        {
            this.Id = p_id;
            this.IdTipoDocumentoAFIP = p_idTipoDocumento;
            this.Nombre = p_Nombre;
        }
    }
}
