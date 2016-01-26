using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectSave
{
    public static class Pool
    {

        public enum TiposDeControles { textbox, checkbox, datetimepicker };
        public static List<ObjectEntity> ListaDeControles;
        public static void InsertarObjeto(TiposDeControles TipoControl, String Name, String Value)
        {
            if (ListaDeControles == null)
            {
                ListaDeControles = new List<ObjectEntity>();
            }
            ListaDeControles.Add(new ObjectEntity(Name, TipoControl, Value));
        }

        public static void LimpiarListado() 
        {
            if (ListaDeControles == null)
            {
                ListaDeControles = new List<ObjectEntity>();
            }
            else 
            {
                ListaDeControles.Clear();
            }
        }

    }
}
