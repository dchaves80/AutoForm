using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ParametroD:Core
    {

        public string GetValue(string p_value) { 

        BDAtroxDataSetTableAdapters.SPObtenerParametroTableAdapter TA = new BDAtroxDataSetTableAdapters.SPObtenerParametroTableAdapter();
        BDAtroxDataSet.SPObtenerParametroDataTable DT = new BDAtroxDataSet.SPObtenerParametroDataTable();
        TA.Fill(DT, p_value);
        if (DT.Rows.Count > 0) 
        {
            return DT.Rows[0]["ValorParametro"].ToString();
        } else {return null;}

               }
        
    }
}
