using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ImpresorasD : Core
    {
        public DataTable ObtenerImpresora(string p_Estacion,int p_IdTipoComprobante)
        {
            BDAtroxDataSet.SPObtenerImpresorasDataTable DT = new BDAtroxDataSet.SPObtenerImpresorasDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerImpresorasTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerImpresorasTableAdapter();
            TA.Fill(DT, p_Estacion, p_IdTipoComprobante);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else
            {
                return null;
            }

        }

        public int InsertarImpresora(string p_Estacion, int p_IdTipoComprobante, string p_Impresora)
        {
            BDAtroxDataSetTableAdapters.SPInsertarImpresorasTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarImpresorasTableAdapter();
            BDAtroxDataSet.SPInsertarImpresorasDataTable DT = new BDAtroxDataSet.SPInsertarImpresorasDataTable();
            TA.Fill(DT, p_Estacion, p_IdTipoComprobante, p_Impresora);
            if (DT.Rows.Count > 0) 
            { 
                return int.Parse(DT.Rows[0]["Id"].ToString()); 
            } 
            else 
            { 
                return 0; 
            }
        }

        public Boolean EliminarImpresora(string p_Estacion, int p_IdTipoComprobante)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                if (QTA.SPEliminarImpresoras(p_Estacion, p_IdTipoComprobante) > 0)
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

        public bool ActualizarImpresora(string p_Estacion, int p_IdTipoComprobante, string p_Impresora)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPModificarImpresoras(p_Estacion, p_IdTipoComprobante, p_Impresora) > 0)
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
