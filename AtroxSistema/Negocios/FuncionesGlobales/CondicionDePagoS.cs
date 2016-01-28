using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class CondicionDePagoS
    {
        public static List<CondicionDePagoN> ListarCondicionesDePago()
        {
            Datos.CondicionDePagoD t_conexion = new Datos.CondicionDePagoD();
            DataTable _DT = t_conexion.ListarCondicionesDePago();
            if (_DT != null)
            {
                List<CondicionDePagoN> t_list = new List<CondicionDePagoN>();
                for (int a = 0; a < _DT.Rows.Count; a++)
                {
                    int t_Id = int.Parse(_DT.Rows[a]["Id"].ToString());
                    string t_name = _DT.Rows[a]["Nombre"].ToString();
                    t_list.Add(new CondicionDePagoN(t_Id, t_name));
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
