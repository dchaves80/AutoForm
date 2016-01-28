using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Entidades
{
    public class ArticuloE : SuperEntity
    {

        CuentaE _Cuenta;

        public CuentaE Cuenta
        {
            get { return _Cuenta; }
            set { _Cuenta = value; }
        }

        string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        decimal _IVA;

        public decimal IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }
        decimal _PrecioCompra;

        public decimal PrecioCompra
        {
            get { return _PrecioCompra; }
            set { _PrecioCompra = value; }
        }
        decimal _Porcentaje;

        public decimal Porcentaje
        {
            get { return _Porcentaje; }
            set { _Porcentaje = value; }
        }
        String _CodigoBarra;

        public String CodigoBarra
        {
            get { return _CodigoBarra; }
            set { _CodigoBarra = value; }
        }
        decimal _PrecioSugerido;

        public decimal PrecioSugerido
        {
            get { return _PrecioSugerido; }
            set { _PrecioSugerido = value; }
        }
        int _IdCuenta;

        public int IdCuenta
        {
            get { return _IdCuenta; }
            set { _IdCuenta = value; }
        }
        bool _LlevaStock;

        public bool LlevaStock
        {
            get { return _LlevaStock; }
            set { _LlevaStock = value; }
        }
        int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


        bool _BloqueaPrecio;
        public bool BloqueaPrecio
        {
            get { return _BloqueaPrecio; }
            set { _BloqueaPrecio = value; }
        }

        int _IdCategoria;
        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }
    }
}
