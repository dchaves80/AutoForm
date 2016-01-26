using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reportes.Class
{
    public static class Medida
    {

        public class medida 
        {
            public int vertical;
            public int horizontal; 
        }


        public static string path = Application.StartupPath + "\\margin.cfg";
        public static decimal pulgada = 0.393700787403700736m;

        static decimal separatevaluefromparameter(string completeline)
        {


            string[] splitter1 = { ":" };
            string[] chain = completeline.Split(splitter1, StringSplitOptions.None);
            string separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (separator == ",")
            {
                try
                {
                    return Convert.ToDecimal(chain[1].Replace(".", ","));
                }
                catch (Exception E)
                {
                    return 0;
                }

            }
            else
            {
                try
                {
                    return Convert.ToDecimal(chain[1].Replace(",", "."));
                }
                catch (Exception E)
                {
                    return 0;
                }
            }

        }

        

        public static decimal ObtenerMedidaVertical ()
        {
            decimal vertical=0m;
            decimal horizontal=0m;
            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader SR = new System.IO.StreamReader(path);
                vertical = separatevaluefromparameter(SR.ReadLine())*pulgada;
                horizontal = separatevaluefromparameter(SR.ReadLine())*pulgada;
                
                SR.Close();
            }

            if (vertical > pulgada) 
            {
                vertical = 0.375m - (vertical - pulgada);
            }
            else if (vertical < pulgada) 
            {
                vertical = (pulgada - vertical) + 0.375m;
            }
            else if (vertical == pulgada)
            {
                vertical = 0.375m;
            }

            return vertical;
        }

        public static decimal ObtenerMedidaHorizontal()
        {
            decimal vertical = 0m;
            decimal horizontal = 0m;
            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader SR = new System.IO.StreamReader(path);
                vertical = separatevaluefromparameter(SR.ReadLine()) * pulgada;
                horizontal = separatevaluefromparameter(SR.ReadLine()) * pulgada;

                SR.Close();

            }

            if (horizontal > pulgada)
            {
                horizontal = 0.375m - (horizontal - pulgada);
            }
            else if (horizontal < pulgada)
            {
                horizontal = (pulgada - horizontal) + 0.375m;
            }
            else if (horizontal == pulgada)
            {
                horizontal = 0.375m;
            }


            return horizontal;
        }
    }
}
