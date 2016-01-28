using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Catcher
{
    public class Cls_Error
    {
        string _Error;

        public string Error
        {
            get { return _Error; }
            set { _Error = value; }
        }
        string _Class;

        public string Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        DateTime _Date = new DateTime();
        public Cls_Error(string p_Class, string p_Error) 
        {

            _Date = DateTime.Now;
            _Class = p_Class;
            _Error = p_Error;
        }
    }
}
