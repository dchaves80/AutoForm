using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class TipoMovimientoN: Entidades.TipoMovimientoE
    {
        #region Variables
        Datos.TipoMovimientoD _Conexion;
        private Datos.TipoMovimientoD _Datos;
        #endregion

        /// <summary>
        /// crea nuevo tipo movimiento
        /// </summary>
        /// <param name="p_Id"></param>
        /// <param name="p_idTipoComprobante"></param>
        /// <param name="p_Nombre"></param>
        /// <param name="p_Signo"></param>
        /// <param name="p_Numeracion"></param>
        /// <param name="p_MueveStock"></param>
        public TipoMovimientoN(int p_Id, int p_idTipoComprobante, string p_Nombre, string p_Signo, string p_Numeracion, bool p_MueveStock)
        {
            Id = p_Id;
            IdTipoComprobante = p_idTipoComprobante;
            Nombre = p_Nombre;
            Signo = p_Signo;
            Numeracion = p_Numeracion;
            MueveStock = p_MueveStock;
        }

        public TipoMovimientoN(int p_idTipoComprobante, string p_Nombre, string p_Signo, string p_Numeracion, bool p_MueveStock)
        {
            IdTipoComprobante = p_idTipoComprobante;
            Nombre = p_Nombre;
            Signo = p_Signo;
            Numeracion = p_Numeracion;
            MueveStock = p_MueveStock;
        }

        public TipoMovimientoN(int p_Id) 
        {
             _Datos = new Datos.TipoMovimientoD();
            DataTable _DT = _Datos.ObtenerTipoMovimiento(p_Id);
            if (_DT != null) 
            {
                DataRow _DR = _DT.Rows[0];
                Id= int.Parse( _DR["Id"].ToString());
                IdTipoComprobante = int.Parse(_DR["IdTipoComprobante"].ToString());
                Nombre = _DR["Nombre"].ToString();
                Signo = _DR["Signo"].ToString();
                Numeracion = _DR["Numeracion"].ToString();
                MueveStock = bool.Parse(_DR["MueveStock"].ToString());
                Succed = true;

            }

        }

        public bool Guardar()
        {
            _Conexion = new Datos.TipoMovimientoD();
            this.Id = _Conexion.InsertarTipoMovimiento(this.IdTipoComprobante, this.Nombre, this.Signo, this.Numeracion, this.MueveStock);
            if (this.Id != 0)
            {
                return true;
            }
            else { return false; }

        }
        /// <summary>
        /// elimina categoria de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Eliminar()
        {
            _Conexion = new Datos.TipoMovimientoD();
            return _Conexion.EliminarTipoMovimiento(this.Id);
        }
        /// <summary>
        /// actualiza la categoria
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            _Conexion = new Datos.TipoMovimientoD();
            return _Conexion.ActualizarTipoMovimiento(this.Id, this.IdTipoComprobante, this.Nombre, this.Signo, this.Numeracion, this.MueveStock);
        }
    }
}
