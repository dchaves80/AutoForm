using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoMovimientoD:Core
    {
        public DataTable ListarTipoMovimiento()
        {
            BDAtroxDataSet.SPListarTipoMovimientoDataTable DT = new BDAtroxDataSet.SPListarTipoMovimientoDataTable();
            BDAtroxDataSetTableAdapters.SPListarTipoMovimientoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarTipoMovimientoTableAdapter();
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

        public DataTable ObtenerTipoMovimiento(int p_id)
        {
            BDAtroxDataSet.SPObtenerTipoMovimientoDataTable DT = new BDAtroxDataSet.SPObtenerTipoMovimientoDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerTipoMovimientoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerTipoMovimientoTableAdapter();
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

        public int InsertarTipoMovimiento(int p_IdTipoComprobante, string p_Nombre, string p_Signo, string p_Numeracion, bool p_MueveStock)
        {
            BDAtroxDataSetTableAdapters.SPInsertarTipoMovimientoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarTipoMovimientoTableAdapter();
            BDAtroxDataSet.SPInsertarTipoMovimientoDataTable DT = new BDAtroxDataSet.SPInsertarTipoMovimientoDataTable();
            TA.Fill(DT, p_IdTipoComprobante, p_Nombre, p_Signo, p_Numeracion, p_MueveStock);
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

        public bool ActualizarTipoMovimiento(int p_Id, int p_IdTipoComprobante, string p_Nombre, string p_Signo, string p_Numeracion, bool p_MueveStock)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPModificarTipoMovimiento(p_Id, p_IdTipoComprobante, p_Nombre, p_Signo, p_Numeracion, p_MueveStock) > 0)
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
