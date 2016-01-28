using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LocalidadN:Entidades.LocalidadE
    {

        Datos.LocalidadD _conexion;

        /// <summary>
        /// Crea una nueva localidad
        /// </summary>
        /// <param name="p_Id"></param>
        /// <param name="p_Nombre"></param>
        /// <param name="p_Provincia"></param>
        public LocalidadN(int p_Id, String p_Nombre, String p_Provincia) 
        {
            Id = p_Id;
            Nombre = p_Nombre;
            Provincia = p_Provincia;
        }

        public LocalidadN(int p_Id) 
        {
            _conexion = new Datos.LocalidadD();
            DataTable _dt = _conexion.ObtenerLocalidad(p_Id);
            if (_dt != null)
            {
                Succed = true;
                Id = p_Id;
                Nombre = _dt.Rows[0]["NombreLocalidad"].ToString();
            }
            else 
            {
                Succed = false;
            }
        }
    }
}
