using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SuperEntity
    {
        private int _Id;
        private Boolean _Succed;
       

      

        public Boolean Succed
    {
        get { return _Succed; }
        set { _Succed = value; }
    }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

       
        
    }
}
