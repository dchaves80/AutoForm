using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmpresaD : Core
    {



        public DataTable ObtenerEmpresa(int p_Id = 0)
        {
            BDAtroxDataSet.SPObtenerEmpresaDataTable DT = new BDAtroxDataSet.SPObtenerEmpresaDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerEmpresaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerEmpresaTableAdapter();
            TA.Fill(DT,p_Id);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }
        }

        public int InsertarEmpresa(String p_nombre, String p_nombreempresa, String p_Cuit, String p_IngBrutos,DateTime p_InicioACtividad, int p_IdTipoInsc) 
        {

            String _Date = new FuncionesGlobales.DataFormat.Data(p_InicioACtividad).Fecha;

            BDAtroxDataSet.SPInsertarEmpresaDataTable DT = new BDAtroxDataSet.SPInsertarEmpresaDataTable();
            BDAtroxDataSetTableAdapters.SPInsertarEmpresaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPInsertarEmpresaTableAdapter();
            TA.Fill(
                DT, 
                p_nombre, 
                p_nombreempresa, 
                p_Cuit, 
                p_IngBrutos, 
                _Date, 
                p_IdTipoInsc);
            if (DT.Rows.Count > 0)
            {
                return int.Parse(DT.Rows[0][0].ToString());
            }
            else 
            { return 0; }

        }

        public bool ActualizarEmpresa(int IdEmpresa, String p_nombre, String p_nombreempresa, String p_Cuit, String p_IngBrutos,DateTime p_InicioACtividad, int p_IdTipoInsc) 
    {
        BDAtroxDataSetTableAdapters.SPModificarEmpresaTableAdapter TA = new BDAtroxDataSetTableAdapters.SPModificarEmpresaTableAdapter();
        BDAtroxDataSet.SPModificarEmpresaDataTable DT = new BDAtroxDataSet.SPModificarEmpresaDataTable();
        string str_InicioACtividad = new FuncionesGlobales.DataFormat.Data(p_InicioACtividad).Fecha;
            TA.Fill(DT,p_nombre,p_nombreempresa,p_Cuit,p_IngBrutos,str_InicioACtividad,p_IdTipoInsc,IdEmpresa);

        if (DT.Rows.Count > 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
        public bool EliminarEmpresa(int IdEmpresa) 
        {
            BDAtroxDataSetTableAdapters.QueriesTableAdapter QTA = new BDAtroxDataSetTableAdapters.QueriesTableAdapter();
            if (QTA.SPEliminarEmpresa(IdEmpresa) > 0)
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
