using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArticuloD:Core
    {
        public DataTable InsertarArticulo(string p_Nombre, decimal p_IVA, decimal p_PrecioCompra, decimal p_Porcentaje, String p_CodigoBarra, decimal p_PrecioSugerido, int p_IdCuenta, bool p_LlevaStock, int p_cantidad, bool p_BloquearPrecio, int p_IdCategoria ) 
        {
            BDAtroxDataSet.SPInsertarArticuloDataTable DT = new BDAtroxDataSet.SPInsertarArticuloDataTable();
            BDAtroxDataSetTableAdapters.SPInsertarArticuloTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarArticuloTableAdapter();
            TA.Fill(DT, p_Nombre, p_IVA, p_PrecioCompra, p_Porcentaje, p_CodigoBarra, p_PrecioSugerido, p_IdCuenta, p_LlevaStock, p_cantidad, p_BloquearPrecio, p_IdCategoria);
            if (DT.Rows.Count > 0) { return DT; } else { return null; }

            }

        public DataTable ObtenerArticulo(int p_Id) 
        {
            BDAtroxDataSet.SPObtenerArticuloDataTable DT = new BDAtroxDataSet.SPObtenerArticuloDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerArticuloTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerArticuloTableAdapter();
            TA.Fill(DT, p_Id);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }
        }


        public Boolean EliminarArticulo(int p_Id) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            int _result = QTA.SPEliminarArticulo(p_Id);
            if (_result != 0) 
            {
                return true;
            }
            else 
            { 
                return true;
            }
        }

        public Boolean ModificarArticulo(int p_Id, string p_Nombre, decimal p_IVA, decimal p_PrecioCompra, decimal p_Porcentaje, String p_CodigoBarra, decimal p_PrecioSugerido, int p_IdCuenta, bool p_LlevaStock, int p_cantidad, bool p_BloqueaPrecio, int p_IdCategoria) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            int _result = QTA.SPModificarArticulo(p_Id, p_Nombre, p_IVA, p_PrecioCompra, p_Porcentaje, p_CodigoBarra, p_PrecioSugerido, p_IdCuenta, p_LlevaStock, p_cantidad, p_BloqueaPrecio, p_IdCategoria);
            if (_result != 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public DataTable ListarArticulosPorCuenta(int p_IdCuenta)
        {
            BDAtroxDataSet.SPListarArticulosPorCuentaDataTable DT = new BDAtroxDataSet.SPListarArticulosPorCuentaDataTable();
            BDAtroxDataSetTableAdapters.SPListarArticulosPorCuentaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarArticulosPorCuentaTableAdapter();
            TA.Fill(DT, p_IdCuenta);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }
        }

        public DataTable ListarArticulos() 
        {
            BDAtroxDataSet.SPListarArticulosDataTable DT = new BDAtroxDataSet.SPListarArticulosDataTable();
            BDAtroxDataSetTableAdapters.SPListarArticulosTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarArticulosTableAdapter();
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

        public Boolean ActualizarPrecioPorCuenta(decimal p_Porcentaje, int p_IdCuenta, int p_IdCategoria)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            int _result = QTA.SPActualizarPrecioPorProveedor(p_IdCuenta,p_IdCategoria,p_Porcentaje);
            if (_result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
