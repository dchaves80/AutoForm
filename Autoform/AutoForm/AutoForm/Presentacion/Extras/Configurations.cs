using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Extras
{
    public static class Configurations
    {

        public class configuration
        {
            public string key;
            public string value;
        }

        static string path = Application.StartupPath + "\\" + "cfg.cfg";
        static List<configuration> configs = new List<configuration>();

        public static void CreateFile()
        {
            if (!File.Exists(path)) 
            {
                File.Create(path);
            }
        }


        public static List<configuration> obtainConfigurations() 
        {
            return configs;
        }

        public static Color ObtainColor(string p_key) 
        {
            string T_color = "";
            bool seeked = false;
            foreach (configuration C in configs) 
            {
                if (C.key == p_key) 
                {
                    T_color = C.value;
                    seeked = true;
                    break;
                }
                
            }

            if (seeked == true)
            {
                string[] splitter = { "," };
                string[] colors = T_color.Split(splitter, StringSplitOptions.None);
                Color CLR = new Color();
                CLR = Color.FromArgb(int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]));
                return CLR;
            }
            else 
            {
                return Color.Black;
            }
            

        } 

       /* public static string ObtainValue(string p_key)
        {
            
        }*/

        public static void loadChanges() 
        {
            CreateFile();
                configs.Clear();
                StreamReader SR = new StreamReader(path);
                while (!SR.EndOfStream)
                {
                    string[] splitter = { "=" };
                    string[] result = SR.ReadLine().Split(splitter, StringSplitOptions.None);
                    configuration t_conf = new configuration();
                    t_conf.key = result[0];
                    t_conf.value = result[1];
                    configs.Add(t_conf);

                }
                SR.Close();
            
        }

        public static void saveChanges() 
        {
            CreateFile();
            StreamWriter SW = new StreamWriter(path);

            foreach (configuration C in configs)
            {
                SW.WriteLine(C.key + "=" + C.value);
            }
            SW.Close();
            loadChanges();
        }

        public static void SaveConfig(string p_key, string p_value)
        {
            CreateFile();
            foreach (configuration C in configs) 
            {
                if (C.key == p_key) 
                {
                    configs.Remove(C);
                    break;
                }
            }
            configuration t_conf = new configuration();
            t_conf.key = p_key;
            t_conf.value = p_value;
            configs.Add(t_conf);
        }
        
    }
}
