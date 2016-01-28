using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class ArticulosS
    {
        public static bool ActualizarPrecioPorCuenta(decimal p_Porcentaje, int p_IdCuenta, int p_IdCategoria)
        {
            Datos.ArticuloD _Datos = new Datos.ArticuloD();
            bool Retorno = false;
            _Datos = new Datos.ArticuloD();
            Retorno = _Datos.ActualizarPrecioPorCuenta(p_Porcentaje, p_IdCuenta, p_IdCategoria);
            return Retorno;
        }

        public static List<ArticuloN> ListarArticulos()
        {
            Datos.ArticuloD t_conexion = new Datos.ArticuloD();
            DataTable _DT = t_conexion.ListarArticulos();
            if (_DT != null)
            {
                List<ArticuloN> t_list = new List<ArticuloN>();
                for (int a = 0; a < _DT.Rows.Count; a++) 
                {
                    int t_id = int.Parse(_DT.Rows[a]["Id"].ToString());
                    string t_name = _DT.Rows[a]["Nombre"].ToString();
                    decimal t_IVA = decimal.Parse(_DT.Rows[a]["IVA"].ToString());
                    decimal t_PrecioCompra = decimal.Parse(_DT.Rows[a]["PrecioCompra"].ToString());
                    decimal t_Porcentaje = decimal.Parse(_DT.Rows[a]["Porcentaje"].ToString());
                    string t_CodigoBarra=_DT.Rows[a]["CodigoBarra"].ToString();
                    decimal t_PrecioSugerido = decimal.Parse(_DT.Rows[a]["PrecioSugerido"].ToString());
                    int t_Cuenta = int.Parse(_DT.Rows[a]["IdCuenta"].ToString());
                    bool t_LlevaStock= bool.Parse(_DT.Rows[a]["LlevaStock"].ToString());
                    int t_cantidad= int.Parse(_DT.Rows[a]["Cantidad"].ToString());
                    bool t_BloquearPrecio = bool.Parse(_DT.Rows[a]["BloquearPrecio"].ToString());
                    int t_IdCategoria = int.Parse(_DT.Rows[a]["IdCategoria"].ToString());
                    t_list.Add(new ArticuloN(t_id, t_name, t_IVA, t_PrecioCompra, t_Porcentaje, t_CodigoBarra, t_PrecioSugerido, null, t_LlevaStock, t_cantidad, t_BloquearPrecio,t_IdCategoria));
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
