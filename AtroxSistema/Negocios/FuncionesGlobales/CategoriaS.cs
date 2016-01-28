using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class CategoriaS
    {
        public static List<CategoriaN>ListarCategoria()
        {
            Datos.CategoriaD t_conexion = new Datos.CategoriaD();
            DataTable _DT = t_conexion.ListarCategoria();
            if (_DT != null)
            {
                List<CategoriaN> t_list = new List<CategoriaN>();
                for (int a = 0; a < _DT.Rows.Count; a++) 
                {
                    int t_id = int.Parse(_DT.Rows[a]["Id"].ToString());
                    string t_name = _DT.Rows[a]["Nombre"].ToString();
                    t_list.Add(new CategoriaN(t_id, t_name));
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
