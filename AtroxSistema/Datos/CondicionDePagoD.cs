using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CondicionDePagoD : Core
    {
        public DataTable ListarCondicionesDePago() 
        {
            
            BDAtroxDataSet.SPListarCondicionPagoDataTable DT = new BDAtroxDataSet.SPListarCondicionPagoDataTable();
            BDAtroxDataSetTableAdapters.SPListarCondicionPagoTableAdapter TA = new BDAtroxDataSetTableAdapters.SPListarCondicionPagoTableAdapter();
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
