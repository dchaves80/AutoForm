using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class TipoComprobanteN:Entidades.TipoComprobanteE
    {
        private Datos.TipoComprobanteD _TipoComprobante;
           

        public TipoComprobanteN(int p_Id, string p_Nombre, string p_Letra, string p_Descripcion, short p_Copias)
        {
            Id = p_Id;
            Nombre = p_Nombre;
            Letra = p_Letra;
            Descripcion = p_Descripcion;
            Copias = p_Copias;
        }


        public TipoComprobanteN(int p_Id) 
        {
            _TipoComprobante = new Datos.TipoComprobanteD();
            DataTable DT = _TipoComprobante.ObtenerTipoComprobante(p_Id);
            if (DT != null) 
            {
                DataRow _DR = DT.Rows[0];
                Id = int.Parse(_DR["Id"].ToString());
                Nombre = _DR["Nombre"].ToString();
                Letra = _DR["Letra"].ToString();
                Descripcion = _DR["Descripcion"].ToString();
                Copias = short.Parse(_DR["Copias"].ToString());
                Succed = true;
            }
            else 
            { 
                Succed = false; 
            }
        }


        /// <summary>
        /// Te la manda a guardar...
        /// </summary>
        /// <returns></returns>
        public bool Guardar() 
        {
            _TipoComprobante = new Datos.TipoComprobanteD();
            Id = _TipoComprobante.InsertarTipoComprobante(Id, Nombre, Letra, Descripcion, Copias);
            if (Id != 0) 
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }


        /// <summary>
        /// Elimina la cuenta destruyendo todas sus propiedades y el mundo
        /// </summary>
        /// <returns></returns>
        public bool Eliminar() 
        {
            _TipoComprobante = new Datos.TipoComprobanteD();
            if (_TipoComprobante.EliminarTipoComprobante(this.Id) == true)
            {
                Id = 0;
                Nombre = null;
                Letra = null;
                Descripcion = null;
                Succed = false;
                return true;
            }
            else 
            {
                return false;
            }
        }


        /// <summary>
        /// Modifica la cuenta y a tu vieja...
        /// </summary>
        /// <returns></returns>
        public bool Actualizar() 
        {
            _TipoComprobante = new Datos.TipoComprobanteD();
            if (_TipoComprobante.ActualizarTipoMovimiento(Id, Nombre, Letra, Descripcion,Copias) == true)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
