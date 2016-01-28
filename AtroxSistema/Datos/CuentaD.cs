using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CuentaD : Core
    {


        public DataTable ListarCuentasXTipoCuenta(bool EsProveedor) 
        {
            BDAtroxDataSet.SPListarCuentaXTipoCuentaDataTable DT = new BDAtroxDataSet.SPListarCuentaXTipoCuentaDataTable();
            BDAtroxDataSetTableAdapters.SPListarCuentaXTipoCuentaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarCuentaXTipoCuentaTableAdapter();
            TA.Fill(DT,EsProveedor);
            if (DT.Rows.Count > 0) 
            {
                return DT;
            }
            else 
            {
                return null;
            }

        }

        public DataTable ListarCuentas()
        {
            BDAtroxDataSet.SPListarCuentasDataTable DT = new BDAtroxDataSet.SPListarCuentasDataTable();
            BDAtroxDataSetTableAdapters.SPListarCuentasTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarCuentasTableAdapter();
            TA.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else
            {
                return null;
            }

        }

        public DataTable ObtenerCuenta(int? p_id)
        {
            BDAtroxDataSet.SPObtenerCuentaDataTable DT = new BDAtroxDataSet.SPObtenerCuentaDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerCuentaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerCuentaTableAdapter();
            TA.Fill(DT, p_id);
            if (DT.Rows.Count > 0) 
            {
                return DT;
            } 
            else 
            {
                return null;
            }
        }

        public bool EliminarCuenta(int? p_IdCuenta) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPEliminarCuenta(p_IdCuenta) != 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public int GuardarCuenta(
            String p_Nombre,
            String p_NombreFantasia,
            int? p_IdCategoriaAfip,
            int? p_IdTipoDocumento,
            String p_NroDocumento,
            String p_NroIngresosBrutos,
            int? p_IdLocalidad,
            String p_Domicilio,
            int? p_NroDomicilio,
            int? p_Piso,
            string p_Departamento,
            bool p_Proveedor,
            string p_mail,
            string p_telefono
            )
        {
            BDAtroxDataSet.SPInsertarCuentaDataTable DT = new BDAtroxDataSet.SPInsertarCuentaDataTable();
            BDAtroxDataSetTableAdapters.SPInsertarCuentaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarCuentaTableAdapter();
            TA.Fill(
                DT,
                p_Nombre,
                p_NombreFantasia,
                p_IdCategoriaAfip,
                p_IdTipoDocumento,
                p_NroDocumento,
                p_NroIngresosBrutos,
                p_IdLocalidad,
                p_Domicilio,
                p_NroDomicilio,
                p_Piso,
                p_Departamento,
                p_Proveedor,p_mail,p_telefono);
            if (DT.Rows.Count > 0) { return int.Parse(DT[0][0].ToString()); } else { return 0; }
        }

        public bool ActualizarCuenta(
           String p_Nombre,
           String p_NombreFantasia,
           int? p_IdCategoriaAfip,
           int? p_IdTipoDocumento,
           String p_NroDocumento,
           String p_NroIngresosBrutos,
           int? p_IdLocalidad,
           String p_Domicilio,
           int? p_NroDomicilio,
           int? p_Piso,
           string p_Departamento,
           bool p_Proveedor,
            int? p_IdCuenta,
            string p_mail,
                string p_telefono
           )
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPModificarCuenta(
                p_IdCuenta,
                p_Nombre,
                p_NombreFantasia,
                p_IdCategoriaAfip,
                p_IdTipoDocumento,
                p_NroDocumento,
                p_NroIngresosBrutos,
                p_IdLocalidad,
                p_Domicilio,
                p_NroDomicilio,
                p_Piso,
                p_Departamento,
                p_Proveedor,p_mail,p_telefono) > 0)
            {
                return true;
            }
            else 
            {
                return false;
            };
            
        }

    }
}
