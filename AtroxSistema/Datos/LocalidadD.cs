using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LocalidadD : Core
    {


        public DataTable ObtenerLocalidad(int p_idlocalidad) 
        {
            BDAtroxDataSet.SPObtenerLocalidadDataTable DT = new BDAtroxDataSet.SPObtenerLocalidadDataTable();
            BDAtroxDataSetTableAdapters.SPObtenerLocalidadTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerLocalidadTableAdapter();
            TA.Fill(DT, p_idlocalidad);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else 
            {
                return null;
            }


        }

        public DataTable ListarLocalidad() 
        {
            BDAtroxDataSet.SPListarLocalidadDataTable DT = new BDAtroxDataSet.SPListarLocalidadDataTable();
            BDAtroxDataSetTableAdapters.SPListarLocalidadTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarLocalidadTableAdapter();
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
    }
}
