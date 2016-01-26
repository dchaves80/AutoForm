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

        public static int ObtenerMedidaVertical ()
        {
            decimal vertical=0m;
            decimal horizontal=0m;
            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader SR = new System.IO.StreamReader(path);
                vertical = separatevaluefromparameter(SR.ReadLine())*0.393701m;
                horizontal = separatevaluefromparameter(SR.ReadLine())*0.393701m;
                
                SR.Close();
            }

            if (vertical > 1m) 
            {
                vertical = 0.9525m - (vertical - 1m);
            }
            else if (vertical < 1m) 
            {
                vertical = (1m - vertical) + 0.9525m;
            }

            return Convert.ToInt32(vertical);
        }

        public static int ObtenerMedidaHorizontal()
        {
            decimal vertical = 0m;
            decimal horizontal = 0m;
            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader SR = new System.IO.StreamReader(path);
                vertical = separatevaluefromparameter(SR.ReadLine()) * 0.393701m;
                horizontal = separatevaluefromparameter(SR.ReadLine()) * 0.393701m;

                SR.Close();

            }

            if (horizontal > 1m)
            {
                horizontal = 0.9525m - (horizontal - 1m);
            }
            else if (horizontal < 1m)
            {
                vertical = (1m - horizontal) + 0.9525m;
            }


            return Convert.ToInt32(horizontal);
        }
    }
}
