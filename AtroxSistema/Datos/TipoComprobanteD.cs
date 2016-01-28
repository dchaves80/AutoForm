using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoComprobanteD:Core
    {
        public DataTable ListarTipoComprobante()
        {
            BDAtroxDataSet.SPListarTipoComprobantesDataTable DT = new BDAtroxDataSet.SPListarTipoComprobantesDataTable();
            BDAtroxDataSetTableAdapters.SPListarTipoComprobantesTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarTipoComprobantesTableAdapter();
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

        public DataTable ObtenerTipoComprobante(int p_id)
        {
            BDAtroxDataSet.SPObtenerTipoComprobanteDataTable DT = new BDAtroxDataSet.SPObtenerTipoComprobanteDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerTipoComprobanteTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerTipoComprobanteTableAdapter();
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

        public int InsertarTipoComprobante(int p_Id, string p_Nombre, string p_Letra, string p_Descripcion, short p_Copias)
        {
            BDAtroxDataSetTableAdapters.SPInsertarTipoComprobanteTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarTipoComprobanteTableAdapter();
            BDAtroxDataSet.SPInsertarTipoComprobanteDataTable DT = new BDAtroxDataSet.SPInsertarTipoComprobanteDataTable();
            TA.Fill(DT, p_Id, p_Nombre, p_Letra, p_Descripcion, p_Copias);
            if (DT.Rows.Count > 0) { return int.Parse(DT.Rows[0]["Id"].ToString()); } else { return 0; }

        }

        public Boolean EliminarTipoComprobante(int p_Id)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                if (QTA.SPEliminarTipoComprobante(p_Id) > 0)
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

        public bool ActualizarTipoMovimiento(int p_Id, string p_Nombre, string p_Letra, string p_Descripcion, short p_Copias)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPModificarTipoComprobante(p_Id, p_Nombre, p_Letra, p_Descripcion, p_Copias) > 0)
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
