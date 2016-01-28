using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class AfipS
    {
        public static List<AfipN> ObtenerCategoriasAfip(Entidades.SuperEntity p_SE) 
        {
             Datos.AfipD t_AFIP = new Datos.AfipD();
                DataTable t_DT=null;
            try
            {
               t_DT = t_AFIP.ObtenerCategoriasAFIP();
            }
            catch (Exception EXC) 
            {
                Entidades.Catcher.Catcher.Agregar_Error("AfipS", EXC.StackTrace);
            }
            if (t_DT != null) 
            {
                
                List<AfipN> t_listaafip = new List<AfipN>();

                for (int a=0;a<t_DT.Rows.Count;a++)
                {
                    int t_id = Convert.ToInt32( t_DT.Rows[a]["Id"].ToString());
                    int t_idcatafip = Convert.ToInt32(t_DT.Rows[a]["IdCategoriaAFIP"].ToString());
                    String t_nombre=t_DT.Rows[a]["Nombre"].ToString();
                    t_listaafip.Add(new AfipN(t_id,t_idcatafip,t_nombre));
                }
                return t_listaafip;

            }
            else { return null; }
        }

        public static List<TipoDocumentopAfipN> ObtenerTipoDocumentoAfip(Entidades.SuperEntity p_SE)
        {
            Datos.AfipD t_AFIP = new Datos.AfipD();
            DataTable t_DT = null;
            try
            {
                t_DT = t_AFIP.ObtenerTipoDocumentoAfip();
            }
            catch (Exception EXC)
            {
                Entidades.Catcher.Catcher.Agregar_Error("AfipS", EXC.StackTrace);
            }
            if (t_DT != null)
            {

                List<TipoDocumentopAfipN> t_listaafip = new List<TipoDocumentopAfipN>();

                for (int a = 0; a < t_DT.Rows.Count; a++)
                {
                    int t_id = Convert.ToInt32(t_DT.Rows[a]["Id"].ToString());
                    int t_idcatafip = Convert.ToInt32(t_DT.Rows[a]["IdTipoDocumento"].ToString());
                    String t_nombre = t_DT.Rows[a]["Nombre"].ToString();
                    t_listaafip.Add(new TipoDocumentopAfipN(t_id, t_idcatafip, t_nombre));
                }
                return t_listaafip;

            }
            else { return null; }
        }
    }
}
