using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectSave
{
    public class ObjectEntity
    {

        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        ObjectSave.Pool.TiposDeControles _tipoControl;

        public ObjectSave.Pool.TiposDeControles TipoControl1
        {
            get { return _tipoControl; }
            set { _tipoControl = value; }
        }


        string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public ObjectEntity(string p_ControlName, ObjectSave.Pool.TiposDeControles p_TipoControl, string p_value) 
        {
            _name = p_ControlName;
            _tipoControl = p_TipoControl;
            _value = p_value;
        }
    }
}
