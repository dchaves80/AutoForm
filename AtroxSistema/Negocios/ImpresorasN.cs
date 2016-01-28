using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ImpresorasN:Entidades.ImpresorasE
    {
        private Datos.ImpresorasD _ImpresorasD;

        public ImpresorasN(string p_Estacion, int p_IdTipoComprobante, string p_Impresora)
        {
            Estacion = p_Estacion;
            IdTipoComprobante = p_IdTipoComprobante;
            Impresora = p_Impresora;
        }

        public ImpresorasN(string p_Estacion, int p_IdTipoComprobante)
        {
            _ImpresorasD = new Datos.ImpresorasD();
            DataTable DT = _ImpresorasD.ObtenerImpresora(p_Estacion, p_IdTipoComprobante);
            if (DT != null) 
            {
                DataRow _DR = DT.Rows[0];
                Id = int.Parse(_DR["Id"].ToString());
                Estacion = _DR["Estacion"].ToString();
                IdTipoComprobante = int.Parse(_DR["IdTipoComprobante"].ToString());
                Impresora = _DR["Impresora"].ToString();
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
            _ImpresorasD = new Datos.ImpresorasD();
            Id = _ImpresorasD.InsertarImpresora(Estacion, IdTipoComprobante, Impresora);
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
            _ImpresorasD = new Datos.ImpresorasD();
            if (_ImpresorasD.EliminarImpresora(this.Estacion, this.IdTipoComprobante) == true)
            {
                Id = 0;
                Estacion = null;
                IdTipoComprobante = 0;
                Impresora = null;
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
            _ImpresorasD = new Datos.ImpresorasD();
            if (_ImpresorasD.ActualizarImpresora(Estacion, IdTipoComprobante, Impresora) == true)
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
