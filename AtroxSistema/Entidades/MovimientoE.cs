using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MovimientoE:SuperEntity

    {

        List<DetalleMovimientoE> _ListaDetalles=null;
        
        public List<DetalleMovimientoE> ListarDetalle()
        {
            return _ListaDetalles;
        }

        public void AgregarDetalle(DetalleMovimientoE p_detallemovimiento) 
        {
            if (_ListaDetalles == null) 
            {
                _ListaDetalles = new List<DetalleMovimientoE>();
                
            }
            _ListaDetalles.Add(p_detallemovimiento);
            
        }

        public void VaciarMovimientos() 
        {
            if (_ListaDetalles != null)
            {
                _ListaDetalles.Clear();
            }
            else 
            {
                _ListaDetalles = new List<DetalleMovimientoE>();
            }
        }

        public void EliminarMovimiento(DetalleMovimientoE p_detallemovimiento) 
        {
           _ListaDetalles.Remove(p_detallemovimiento);
        }

        int _IdTipoMovimiento;

        public int IdTipoMovimiento
        {
            get { return _IdTipoMovimiento; }
            set { _IdTipoMovimiento = value; }
        }
        int _PuntoVenta;

        public int PuntoVenta
        {
            get { return _PuntoVenta; }
            set { _PuntoVenta = value; }
        }
        int _NroMovimiento;

        public int NroMovimiento
        {
            get { return _NroMovimiento; }
            set { _NroMovimiento = value; }
        }
        DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        decimal _ImporteNeto;

        public decimal ImporteNeto
        {
            get { return _ImporteNeto; }
            set { _ImporteNeto = value; }
        }
        decimal _ImporteIVA;

        public decimal ImporteIVA
        {
            get { return _ImporteIVA; }
            set { _ImporteIVA = value; }
        }
        int _IdCuenta;

        public int IdCuenta
        {
            get { return _IdCuenta; }
            set { _IdCuenta = value; }
        }
        string _Observacion;

        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }
        string _CAE;

        public string CAE
        {
            get { return _CAE; }
            set { _CAE = value; }
        }
        DateTime _FechaVencimientoCAE;

        public DateTime FechaVencimientoCAE
        {
            get { return _FechaVencimientoCAE; }
            set { _FechaVencimientoCAE = value; }
        }
        DateTime _FechaContabilizacion;

        public DateTime FechaContabilizacion
        {
            get { return _FechaContabilizacion; }
            set { _FechaContabilizacion = value; }
        }

        int _CondicionDePago;

        public int CondicionDePago
        {
            get { return _CondicionDePago; }
            set { _CondicionDePago = value; }
        }

    }
}
