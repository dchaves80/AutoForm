using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CategoriaN:Entidades.CategoriaE
    {

        Datos.CategoriaD _Conexion;

        /// <summary>
        /// Consulta una categoria
        /// </summary>
        /// <param name="p_id"></param>
        public CategoriaN(int p_id) 
        {
            _Conexion = new Datos.CategoriaD();
           DataTable _DT = _Conexion.ObtenerCategoria(p_id);
           if (_DT != null) 
           {
               Succed = true;
               Nombre = _DT.Rows[0]["Nombre"].ToString();
               Id = p_id;
           }
        }
        /// <summary>
        /// Crea una categoria nueva pero no guarda en la base de datos
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_Nombre"></param>
        public CategoriaN(int p_id , string p_Nombre)
        {
            Succed = true;
            Id = p_id;
            Nombre = p_Nombre;
        }
        /// <summary>
        /// crea una categoria nueva
        /// </summary>
        /// <param name="p_Nombre"></param>
        public CategoriaN(string p_Nombre) 
        {
            this.Nombre = p_Nombre;
        }
        /// <summary>
        /// guarda la categoria en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Guardar() 
        {
            _Conexion = new Datos.CategoriaD();
            this.Id = _Conexion.InsertarCategoria(this.Nombre);
            if (this.Id!=0)
            {
                Succed = true;
                return true;
            } else {
                Succed = false;
                return false;}
            
        }
        /// <summary>
        /// elimina categoria de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Eliminar() 
        {
            _Conexion = new Datos.CategoriaD();
            return _Conexion.EliminarCategoria(this.Id);
        }
        /// <summary>
        /// actualiza la categoria
        /// </summary>
        /// <returns></returns>
        public bool Actualizar() 
        {
            _Conexion = new Datos.CategoriaD();
            return _Conexion.ActualizarCategoria(this.Id, this.Nombre);
        }


    }
}
