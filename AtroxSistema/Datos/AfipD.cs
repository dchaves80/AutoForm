using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AfipD : Core
    {
        
        public DataTable ObtenerTipoDocumentoAfip() 
        {
            BDAtroxDataSet.SPListarTipoDocumentoAFIPDataTable DT = new BDAtroxDataSet.SPListarTipoDocumentoAFIPDataTable();
            BDAtroxDataSetTableAdapters.SPListarTipoDocumentoAFIPTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarTipoDocumentoAFIPTableAdapter();
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

        public DataTable ObtenerCategoriasAFIP()
        {
            
            BDAtroxDataSet.SPListarCategoriaAFIPDataTable DT = new BDAtroxDataSet.SPListarCategoriaAFIPDataTable();
            BDAtroxDataSetTableAdapters.SPListarCategoriaAFIPTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarCategoriaAFIPTableAdapter();
            //ChangeConnection.Chage();
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

        public Boolean EliminarCategoriaAfip(int p_Id) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                if (QTA.SPEliminarCategoriaAFIP(p_Id) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch 
            {
                return false;
            }
        }


        public int InsertarCategoriaAfip(string p_Nombre, int p_IdAfip)
        {
            BDAtroxDataSet.SPInsertarCategoriaAFIPDataTable DT = new BDAtroxDataSet.SPInsertarCategoriaAFIPDataTable();
            BDAtroxDataSetTableAdapters.SPInsertarCategoriaAFIPTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarCategoriaAFIPTableAdapter();
            TA.Fill(DT, p_Nombre, p_IdAfip);
            if (DT.Rows.Count > 0)
            {
                return int.Parse(DT.Rows[0]["Id"].ToString());
            }
            else 
            {
                return 0;
            }
        }

        public Boolean EliminarTipoDocumentoAfip(int p_Id) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                if (
                QTA.SPEliminarTipoDocumentoAFIP(p_Id) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch{

         
                return false;
            }
        }
    }
}
