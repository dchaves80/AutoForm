using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Catcher
{
    public static class Catcher
    {
        
            private static List<Cls_Error> _Errores = new List<Cls_Error>();
        public static void Agregar_Error(String p_Class, String p_Error)
        {
            _Errores.Add(new Cls_Error(p_Class, p_Error));

        }

        public static List<Cls_Error> GetErrors() 
        {
            return _Errores;
        }

    }
}
