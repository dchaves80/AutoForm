using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace Schlüssel
{
    public static class Registro
    {
        public static bool comprobarregistro ()
        {
            String Usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String Prefix = "Palladium";
            Usuario = encryptstring(Usuario);
            RegistryKey RK = Registry.CurrentUser.OpenSubKey(Prefix + Usuario,true);
            bool bromatodearmonio = false;

            if (RK == null)
            {
                RegistryKey R = Registry.CurrentUser.CreateSubKey(Prefix + Usuario);
                R.SetValue("1", encryptstring(DateTime.Now.ToString()));
                R.SetValue("2", encryptstring(DateTime.Now.ToString()));
                bromatodearmonio = true;
            }
            else 
            {
                DateTime value1 =  DateTime.Parse( decryptstring( RK.GetValue("1").ToString()));
                DateTime value2 = DateTime.Parse( decryptstring( RK.GetValue("2").ToString()));
                TimeSpan TS = DateTime.Now - value1;
                if (TS.Days < 10)
                {
                    if (value2 < DateTime.Now)
                    {
                        
                        RK.DeleteValue("2");
                        RK.SetValue("2", encryptstring(DateTime.Now.ToString()));
                        bromatodearmonio = true;
                    }
                    else 
                    {

                        bromatodearmonio = false;
                    }
                }
                else 
                {
                    bromatodearmonio = false;
                }
                


            }

            return bromatodearmonio;
        }

        private static string encryptstring(string p_decryptedstring) 
        {
            string Hi = "";
            foreach (char C in p_decryptedstring) 
            {
                
                Hi = Hi + Convert.ToChar(Convert.ToByte(C) + 1);
            }
            return Hi;
        }

        private static string decryptstring(string p_encryptedstring)
        {
            string Hi = "";
            foreach (char C in p_encryptedstring)
            {

                Hi = Hi + Convert.ToChar(Convert.ToByte(C) - 1);
            }
            return Hi;
        }

       
    }
}
