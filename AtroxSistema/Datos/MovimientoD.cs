using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.FuncionesGlobales;
using System.Data;

namespace Datos
{
    public class MovimientoD : Core
    {


        public bool EliminarMovimiento(int p_idmovimiento) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter Q = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (Q.SPEliminarMovimiento(p_idmovimiento) > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public DataTable ListarMovimientosPorIdTipoMov(int IdTipoMov) 
        {
            BDAtroxDataSet.SPListarMovimientosDataTable DT = new BDAtroxDataSet.SPListarMovimientosDataTable();
            BDAtroxDataSetTableAdapters.SPListarMovimientosTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarMovimientosTableAdapter();
            TA.Fill(DT, IdTipoMov);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }
        }

        public DataTable ObtenerMovimiento(int p_IdTipoMov, int p_PuntoVenta, int p_NroMov, int p_IdCuenta) 
        {
            BDAtroxDataSet.SPObtenerMovimientoDataTable DT = new BDAtroxDataSet.SPObtenerMovimientoDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerMovimientoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerMovimientoTableAdapter();
            TA.Fill(DT, p_IdTipoMov, p_PuntoVenta, p_NroMov, p_IdCuenta);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }
        }

        public DataTable ObtenerDetalle(int IDMov) 
        {
            BDAtroxDataSet.SPObtenerDetalleMovimientoDataTable DT = new BDAtroxDataSet.SPObtenerDetalleMovimientoDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerDetalleMovimientoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerDetalleMovimientoTableAdapter();
            TA.Fill(DT, IDMov);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }
        }

        public int InsertarMovimientoCV(
            int p_IdTipoMov, 
            int p_PuntoVenta, 
            int  p_NroMovimiento, 
            DateTime p_Fecha, 
            decimal p_ImporteNeto, 
            decimal p_ImporteIVA, 
            int p_IdCuenta, 
            string p_Observacion,  
            string p_CAE, 
            DateTime p_VencimientoCAE,
            DateTime p_FechaContabilizacion,
            int p_CondicionDePago

            ) 
        {

          

            BDAtroxDataSetTableAdapters.SPInsertarMovimientoCVTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarMovimientoCVTableAdapter();
            BDAtroxDataSet.SPInsertarMovimientoCVDataTable DT = new BDAtroxDataSet.SPInsertarMovimientoCVDataTable();
            TA.Fill(DT, p_IdTipoMov, p_PuntoVenta, p_NroMovimiento, p_Fecha, p_ImporteNeto, p_ImporteIVA, p_IdCuenta, p_Observacion, p_CAE, p_VencimientoCAE, p_FechaContabilizacion,p_CondicionDePago);
            if (DT.Rows.Count > 0) { return int.Parse(DT.Rows[0]["Id"].ToString()); } else { return 0; } 
            
        }

        public Boolean EliminarTipoMovimiento(int p_Id) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                if (QTA.SPEliminarTipoMovimiento(p_Id) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }

        }

        public int InsertarDetalle(decimal p_PrecioUnitario, decimal p_ImporteSubTotal, int p_IdArt, int p_IdMovimiento, int p_Cantidad, int p_tipomov) 
        {
            BDAtroxDataSet.SPInsertarDetalleMovimientoDataTable DT = new BDAtroxDataSet.SPInsertarDetalleMovimientoDataTable();
            BDAtroxDataSetTableAdapters.SPInsertarDetalleMovimientoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarDetalleMovimientoTableAdapter();
            TA.Fill(DT, p_IdMovimiento, p_tipomov, p_IdArt, p_Cantidad, p_PrecioUnitario, p_ImporteSubTotal);

            if (DT.Rows.Count > 0) 
            {
                return int.Parse(DT.Rows[0]["Column1"].ToString());
                            } else { return 0; } 
        }

        public bool EliminarDetalle(int p_id) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPEliminarDetalleMovimiento(p_id) > 0) { return true; } else { return false; }
        }

    }
}
