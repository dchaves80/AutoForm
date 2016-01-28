using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class LocalidadS
    {
        public static List<LocalidadN> ListarLocalidades()
        {
            Datos.LocalidadD t_Conexion = new Datos.LocalidadD();
            DataTable DT = t_Conexion.ListarLocalidad();
            if (DT != null)
            {
                List<LocalidadN> t_list = new List<LocalidadN>();
                for (int a = 0; a < DT.Rows.Count; a++)
                {
                    int t_idlocalidad = int.Parse(DT.Rows[a]["Id"].ToString());
                    string t_nombrelocalidad = DT.Rows[a]["Nombre"].ToString();
                    string t_nombreprovincia = DT.Rows[a]["NombreProvincia"].ToString();
                    LocalidadN t_Localidad = new LocalidadN(t_idlocalidad, t_nombrelocalidad, t_nombreprovincia);
                    t_list.Add(t_Localidad);
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
