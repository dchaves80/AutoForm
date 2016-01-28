using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class Globales
    {
        [DllImport("kernel32.dll")]
        static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        public enum Modo { Agregar, Modificar, Inicial, Consultar }

        public static int? ConvertInt(string p_str)
        {
            if (p_str == null || p_str=="")
            {
                return null;
            }
            else 
            {
                return int.Parse(p_str);
            }
        }

        public static short? ConvertShort(string p_str)
        {
            if (p_str == null || p_str == "")
            {
                return null;
            }
            else
            {
                return short.Parse(p_str);
            }
        }

        public static string FormatDate(DateTime p_dt) 
        {

            string t_dia = p_dt.Day.ToString();
            string t_mes = p_dt.Month.ToString();
            if (t_dia.Length == 1) { t_dia = "0" + t_dia; }
            if (t_mes.Length == 1) { t_mes = "0" + t_mes; }

            return p_dt.Year.ToString() + t_mes + t_dia;
        }

        public static string GenerarCode(
            string p_cuit, 
            int p_tipocomprobante, 
            int p_puntodeventa, 
            string p_cae, 
            DateTime p_fechavencimientocae)
        {
            long I = 0;
            string Cod = String.Empty;
            long Impares = 0;
            long Pares = 0;
            string strTotal;
            int Digito;
            string CodigoFinal;

            Cod =
                p_cuit.Replace("-", "") +
                p_tipocomprobante.ToString() +
                p_puntodeventa.ToString("0000") +
                p_cae + FormatDate(p_fechavencimientocae); 
             

            // Ahora analizo la cadena de caracteres:
            // Tengo que sumar todos los caracteres impares y los pares
            Pares = 0;
            Impares = 0;

            for (I = 1; I <= 39;
                I = Convert.ToInt64(I + 1))
            {
                if ((int)(I) % 2 == 0)
                {
                    // Si el valor de I es par entra por aca
                    // ISSUE: Potential Substring problem; VB6 Original: Mid(Cod, I, 1)
                    Pares = Pares + Convert.ToInt32(Cod.Substring((int)(I) - 1, 1));
                }
                else
                {
                    // Si el valor de I es impar entra por aca
                    // ISSUE: Potential Substring problem; VB6 Original: Mid(Cod, I, 1)
                    Impares = Impares + Convert.ToInt32(Cod.Substring((int)(I) - 1, 1));
                }
            }
            string Impares3;
            Impares3 = Convert.ToString(3 * Convert.ToInt32(Impares));
            strTotal = Convert.ToString(Convert.ToInt32(Pares) + Convert.ToInt32(Impares3));
            Digito = int.Parse(Convert.ToString(10 - (Convert.ToInt32(strTotal) % 10)));
            CodigoFinal = Cod + (Digito == 10 ? 0 : Digito);
            return CodigoFinal;
        }

        public static string LeerINI(string RutaArchivo, string Seccion, string Clave)
        {
            return LeerINI(RutaArchivo, Seccion, Clave, "");
        }


        public static string ObtenerParametro(string p_parametro) 
        {
            Datos.ParametroD _conexion = new Datos.ParametroD();
            
            return _conexion.GetValue(p_parametro);
            
            
        }

        public static string LeerINI(string RutaArchivo, string Seccion, string Clave, string ValorPorDefecto)
        {
            StringBuilder Valor = new StringBuilder(256);
            string Retorno = "";
            int RetornoAPI = GetPrivateProfileString(Seccion, Clave, ValorPorDefecto, Valor, Valor.Capacity, RutaArchivo);
            if ((RetornoAPI == 0))
            {
                Retorno = ValorPorDefecto;
            }
            else
            {
                Retorno = Valor.ToString();
            }
            return Retorno;
        }
    }
}
