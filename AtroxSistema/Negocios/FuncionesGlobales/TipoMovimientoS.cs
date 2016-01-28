using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class TipoMovimientoS
    {
        public static List<TipoMovimientoN> ListarTipoMovimiento()
        {
            Datos.TipoMovimientoD t_Conexion = new Datos.TipoMovimientoD();
            DataTable DT = t_Conexion.ListarTipoMovimiento();
            if (DT != null)
            {
                List<TipoMovimientoN> t_list = new List<TipoMovimientoN>();
                for (int a = 0; a < DT.Rows.Count; a++)
                {
                    int t_Id = int.Parse(DT.Rows[a]["Id"].ToString());
                    int t_idTipoComprobante = int.Parse(DT.Rows[a]["idTipoComprobante"].ToString());
                    string t_Nombre = DT.Rows[a]["Nombre"].ToString();
                    string t_Signo = DT.Rows[a]["Signo"].ToString();
                    string t_Numeracion = DT.Rows[a]["Numeracion"].ToString();
                    bool t_MueveStock = bool.Parse(DT.Rows[a]["MueveStock"].ToString());
                    TipoMovimientoN t_TipoMovimiento = new TipoMovimientoN(t_Id, t_idTipoComprobante, t_Nombre, t_Signo, t_Numeracion, t_MueveStock);
                    t_list.Add(t_TipoMovimiento);
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
