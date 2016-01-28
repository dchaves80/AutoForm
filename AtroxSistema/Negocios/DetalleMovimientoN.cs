using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class DetalleMovimientoN: Entidades.DetalleMovimientoE
    {
        Datos.MovimientoD _Conexion;
        MovimientoN _Movimiento;
        ArticuloN _Articulo;


        public MovimientoN ObtenerMovimiento() 
        {
            return _Movimiento;
        }

        public ArticuloN ObtenerArticulo() 
        {
            if (_Articulo == null)
            {
                _Articulo = new ArticuloN(IdArticulo);
             
            }
            return _Articulo;

        }

        /// <summary>
        /// Crea un nuevo movimiento
        /// </summary>
        /// <param name="p_IdArticulo"></param>
        /// <param name="p_PrecioUnit"></param>
        /// <param name="p_Movimiento"></param>
        /// <param name="p_Cantidad"></param>
        public DetalleMovimientoN(int p_IdArticulo, decimal p_PrecioUnit, MovimientoN p_Movimiento, int p_Cantidad ) 
        {
            this.Cantidad = p_Cantidad;
            this.ClaveMov = p_Movimiento.Id;
            this.PrecioUnitario = p_PrecioUnit;
            this.IdArticulo = p_IdArticulo;
            this.ImporteSubtotal = p_Cantidad * p_PrecioUnit;
            _Movimiento = p_Movimiento;
        }
        /// <summary>
        /// Crea nuevo movimiento en consulta
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_clavemov"></param>
        /// <param name="p_idart"></param>
        /// <param name="p_cantidad"></param>
        /// <param name="p_preciounitario"></param>
        /// <param name="p_importesubtotal"></param>
        public DetalleMovimientoN(int p_id, int p_clavemov, int p_idart, int p_cantidad, decimal p_preciounitario, decimal p_importesubtotal, MovimientoN MOVIMIENTO)
        {
            this.Id = p_id;
            this.Cantidad = p_cantidad;
            this.ClaveMov = p_clavemov;
            this.IdArticulo = p_idart;
            this.PrecioUnitario = p_preciounitario;
            this.ImporteSubtotal = p_importesubtotal;
            _Movimiento = MOVIMIENTO;
        }


        
        /// <summary>
        /// Guarda el detalle completo del movimiento
        /// </summary>
        /// <returns></returns>
        public bool GuardarDetalle()
        {
            _Conexion = new Datos.MovimientoD();
            this.Id =_Conexion.InsertarDetalle(this.PrecioUnitario, this.ImporteSubtotal, this.IdArticulo, _Movimiento.Id, this.Cantidad, _Movimiento.IdTipoMovimiento);

            if (this.Id != 0)
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
