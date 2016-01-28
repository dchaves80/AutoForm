using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaD : Core
    {

        public DataTable ObtenerCategoria(int p_id) 
        {
            BDAtroxDataSet.SPObtenerCategoriaDataTable DT = new BDAtroxDataSet.SPObtenerCategoriaDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerCategoriaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerCategoriaTableAdapter();
            TA.Fill(DT,p_id);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }

        }

        public DataTable ListarCategoria()
        {
            BDAtroxDataSet.SPListarCategoriasDataTable DT = new BDAtroxDataSet.SPListarCategoriasDataTable();
            BDAtroxDataSetTableAdapters.SPListarCategoriasTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarCategoriasTableAdapter();
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

        public int InsertarCategoria(string p_Nombre)
        {
            BDAtroxDataSetTableAdapters.SPInsertarCategoriaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarCategoriaTableAdapter();
            BDAtroxDataSet.SPInsertarCategoriaDataTable DT = new BDAtroxDataSet.SPInsertarCategoriaDataTable();
            TA.Fill(DT, p_Nombre);
            if (DT.Rows.Count > 0) { return int.Parse(DT.Rows[0]["Id"].ToString()); } else { return 0; }

        }

        public Boolean EliminarCategoria(int p_Id)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                if (QTA.SPEliminarCategoria(p_Id) > 0)
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

        public bool ActualizarCategoria(int p_Id, string p_Nombre)
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPModificarCategoria(p_Id, p_Nombre) > 0)
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
