using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Datos.ChangeConnection.StringConexion = Negocios.FuncionesGlobales.Globales.LeerINI((Environment.CurrentDirectory + ("\\" + "CS.reg")), "Conexion", "StringConexion");

            //cool
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
           Application.Run(new frmPrincipal());
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {

            
            if (Entidades.Catcher.Catcher.GetErrors().Count > 0) 
            {

                List<Entidades.Catcher.Cls_Error>ErrorList  = Entidades.Catcher.Catcher.GetErrors();

                

                string path = Application.StartupPath + "\\" + "Errors.Log";
                if (File.Exists(path) == true)
                {

                    FileStream FS = new FileStream(path, FileMode.Append);
                    
                    
                  /*  for (int a = 0; a < ErrorList.Count; a++)
                    {
                        string Chain = Environment.NewLine + "[Class: " + ErrorList[a].Class + "]" + " Message[" + DateTime.Now.ToShortDateString() +"<" + DateTime.Now.ToShortTimeString() +">]:" + ErrorList[a].Error + "\n";

                        Char[] CHR = Chain.ToCharArray();
                        for (int b = 0; b < CHR.Length; b++)
                        {
                            FS.WriteByte(Convert.ToByte(CHR[b]));
                        }
                        FS.Close();
                    }*/

                }
                else 
                {

                    FileStream FS = File.Create(path);
                    for (int a = 0; a < ErrorList.Count; a++)
                    {
                        string Chain = "[Class:  " + ErrorList[a].Class + "]" + " Message:" + ErrorList[a].Error + "\n";
                        Char[] CHR = Chain.ToCharArray();
                        for (int b = 0; b < CHR.Length; b++)
                        {
                            FS.WriteByte(Convert.ToByte(CHR[b]));
                        }
                        FS.Close();
                    }
                }
               
            }
        }
    }
}
