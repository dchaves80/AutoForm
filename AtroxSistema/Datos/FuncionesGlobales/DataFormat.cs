using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.FuncionesGlobales
{
    public static class DataFormat
    {

        public static string FormatDate(DateTime p_dt)
        {

            string t_dia = p_dt.Day.ToString();
            string t_mes = p_dt.Month.ToString();
            if (t_dia.Length == 1) { t_dia = "0" + t_dia; }
            if (t_mes.Length == 1) { t_mes = "0" + t_mes; }

            return p_dt.Year.ToString() + t_mes + t_dia;
        }

        public class Data
        {

           

            public Data(DateTime p_Date) 
            {

                string month;
                string date;

                if (p_Date.Month.ToString().Length == 1)
                {
                    month = "0" + p_Date.Month.ToString();
                }
                else 
                {
                    month = p_Date.Month.ToString();
                }


                if (p_Date.Day.ToString().Length == 1)
                {
                    date = "0" + p_Date.Day.ToString();
                }
                else
                {
                    date =p_Date.Day.ToString();
                }



                _Fecha = p_Date.Year.ToString() + "-" + month + "-" + date;
            }

            private String _Fecha;

            public String Fecha
            {
                get { return _Fecha; }
                set { _Fecha = value; }
            }
            private String _Hora;

            public String Hora
            {
                get { return _Hora; }
                set { _Hora = value; }
            }

        }
     
    }
}
