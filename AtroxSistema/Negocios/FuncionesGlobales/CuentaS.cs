using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class CuentaS
    {
        public static List<CuentaN> ListarCuentasPorTipo(bool p_EsProveedor)
        {
            DataTable _DT = new CuentaD().ListarCuentasXTipoCuenta(p_EsProveedor);
            if (_DT != null)
            {
                List<CuentaN> ListadoCuentas = new List<CuentaN>();
                for (int a=0;a<_DT.Rows.Count;a++){
                
                ListadoCuentas.Add(new CuentaN(Convert.ToInt32(_DT.Rows[a]["IdCuenta"].ToString())));
                    }
                return ListadoCuentas;
            }
            else 
            {
                return null;
            }
        }

        public static List<CuentaN> ListadoCuentas()
        {
            Datos.CuentaD t_conexion = new Datos.CuentaD();
            DataTable _DT = t_conexion.ListarCuentas();
            if (_DT != null)
            {
                List<CuentaN> t_list = new List<CuentaN>();
                for (int a = 0; a < _DT.Rows.Count; a++)
                {
                    int t_id = int.Parse(_DT.Rows[a]["IdCuenta"].ToString());
                    string t_Nombre = _DT.Rows[a]["Nombre"].ToString();
                    string t_NombreFantasia = _DT.Rows[a]["NombreFantasia"].ToString();
                    int? t_IdCategoriaAFIP = int.Parse(_DT.Rows[a]["IdCategoriaAFIP"].ToString());
                    int? t_IdTipoDocumento = int.Parse(_DT.Rows[a]["IdTipoDocumento"].ToString());
                    string t_nroDocumento = _DT.Rows[a]["nroDocumento"].ToString();
                    string t_nroIngresosBrutos = _DT.Rows[a]["nroIngresosBrutos"].ToString();
                    int? t_IdLocalidad = int.Parse(_DT.Rows[a]["IdLocalidad"].ToString());
                    string t_Domicilio = _DT.Rows[a]["Domicilio"].ToString();
                    int? t_NroDomicilio = int.Parse(_DT.Rows[a]["NroDomicilio"].ToString());
                    int? t_Piso = int.Parse(_DT.Rows[a]["Piso"].ToString());
                    string t_Departamento = _DT.Rows[a]["Departamento"].ToString();
                    bool t_Proveedor = bool.Parse(_DT.Rows[a]["Proveedor"].ToString());
                    string t_Mail = _DT.Rows[a]["Mail"].ToString();
                    string t_Telefono = _DT.Rows[a]["Telefono"].ToString();
                    t_list.Add(new CuentaN(t_id,t_Nombre, t_NombreFantasia, t_IdCategoriaAFIP,t_IdTipoDocumento,t_nroDocumento, t_nroIngresosBrutos,
                        t_IdLocalidad, t_Domicilio, t_NroDomicilio, t_Piso, t_Departamento, t_Proveedor, t_Mail, t_Telefono));
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

