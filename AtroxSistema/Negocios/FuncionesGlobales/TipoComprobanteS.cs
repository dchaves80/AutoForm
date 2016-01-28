using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class TipoComprobanteS
    {
        public static List<TipoComprobanteN> ListarTipoComprobante()
        {
            Datos.TipoComprobanteD t_Conexion = new Datos.TipoComprobanteD();
            DataTable DT = t_Conexion.ListarTipoComprobante();
            if (DT != null)
            {
                List<TipoComprobanteN> t_list = new List<TipoComprobanteN>();
                for (int a = 0; a < DT.Rows.Count; a++)
                {
                    int t_Id = int.Parse(DT.Rows[a]["Id"].ToString());
                    string t_Nombre = DT.Rows[a]["Nombre"].ToString();
                    string t_Letra = DT.Rows[a]["Letra"].ToString();
                    string t_Descripcion = DT.Rows[a]["Descripcion"].ToString();
                    short t_Copias = short.Parse(DT.Rows[a]["Copias"].ToString());
                    TipoComprobanteN t_TipoComprobante = new TipoComprobanteN(t_Id, t_Nombre, t_Letra, t_Descripcion, t_Copias);
                    t_list.Add(t_TipoComprobante);
                }
                return t_list;
            }
            else
            {
                return null;
            }
        }
    }
}
