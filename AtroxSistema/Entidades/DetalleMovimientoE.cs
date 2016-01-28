using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleMovimientoE:SuperEntity
    {
        int _ClaveMov;

        public int ClaveMov
        {
            get { return _ClaveMov; }
            set { _ClaveMov = value; }
        }
        int _IdArticulo;

        public int IdArticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }
        int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        decimal _PrecioUnitario;

        public decimal PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { _PrecioUnitario = value; }
        }
        decimal _ImporteSubtotal;

        public decimal ImporteSubtotal
        {
            get { return _ImporteSubtotal; }
            set { _ImporteSubtotal = value; }
        }
    }
}
