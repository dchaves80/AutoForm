using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class MovimientoN : Entidades.MovimientoE
    {

        /// <summary>
        /// Consulta el movimiento por ID
        /// </summary>
        /// <param name="IDMovimiento"></param>
        /// 

        Datos.MovimientoD _Conexion;
        public MovimientoN(int p_IdTipoMov, int p_PuntoVenta, int p_NroMov, int p_IdCuenta)
        {
            _Conexion = new Datos.MovimientoD();
            DataTable t_dt = _Conexion.ObtenerMovimiento(p_IdTipoMov, p_PuntoVenta, p_NroMov, p_IdCuenta);
            if (t_dt != null)
            {
                try
                {
                    //Fila
                    DataRow t_dr = t_dt.Rows[0];
                    //Campos
                    Id = int.Parse(t_dr["claveMov"].ToString());
                    IdTipoMovimiento = int.Parse(t_dr["IdTipoMov"].ToString());
                    PuntoVenta = int.Parse(t_dr["PuntoVenta"].ToString());
                    NroMovimiento = int.Parse(t_dr["NroMov"].ToString());
                    Fecha = DateTime.Parse(t_dr["Fecha"].ToString());
                    ImporteNeto = decimal.Parse(t_dr["ImporteNeto"].ToString());
                    ImporteIVA = decimal.Parse(t_dr["ImporteIVA"].ToString());
                    IdCuenta = int.Parse(t_dr["IdCuenta"].ToString());
                    Observacion = t_dr["Observacion"].ToString();
                    CAE = t_dr["CAE"].ToString();
                    FechaVencimientoCAE = DateTime.Parse(t_dr["VencimientoCAE"].ToString());
                    FechaContabilizacion = DateTime.Parse(t_dr["FechaContabilizacion"].ToString());
                    CondicionDePago = int.Parse(t_dr["IdCondicionPago"].ToString());
                    Succed = true;
                    this.CargarDetalle();


                }
                catch (Exception EXC)
                {
                    Entidades.Catcher.Catcher.Agregar_Error(this.ToString(), EXC.Message);
                    Succed = false;
                }
            }
        }


        /// <summary>
        /// Crea un nuevo Movimiento pero no lo guarda en la base de datos
        /// </summary>
        /// <param name="p_IdTipoMovimiento"></param>
        /// <param name="p_PuntoVenta"></param>
        /// <param name="p_NroMovimiento"></param>
        /// <param name="p_Fecha"></param>
        /// <param name="p_ImporteNeto"></param>
        /// <param name="p_ImporteIVA"></param>
        /// <param name="p_IdCuenta"></param>
        /// <param name="p_Observacion"></param>
        /// <param name="p_CAE"></param>
        /// <param name="p_FechaVencimientoCAE"></param>
        /// <param name="p_FechaContabilizacion"></param>
        public MovimientoN(            
            int p_IdTipoMovimiento,
            int p_PuntoVenta,
            int p_NroMovimiento,
            DateTime p_Fecha,
            decimal p_ImporteNeto,
            decimal p_ImporteIVA,
            int p_IdCuenta,
            string p_Observacion,
            string p_CAE,
            DateTime p_FechaVencimientoCAE,
            DateTime p_FechaContabilizacion,
            int p_IdCondicionPago)
        {
            IdTipoMovimiento = p_IdTipoMovimiento;
            PuntoVenta = p_PuntoVenta;
            NroMovimiento = p_NroMovimiento;
            Fecha = p_Fecha;
            ImporteNeto = p_ImporteNeto;
            ImporteIVA = p_ImporteIVA;
            IdCuenta = p_IdCuenta;
            Observacion = p_Observacion;
            CAE = p_CAE;
            FechaVencimientoCAE = p_FechaVencimientoCAE;
            FechaContabilizacion = p_FechaContabilizacion;
            CondicionDePago = p_IdCondicionPago;
            
        }

        /// <summary>
        /// Carga los detalles en memoria y devuelve un listado de detalles
        /// </summary>
        /// <returns></returns>
        public List<DetalleMovimientoN> CargarDetalle() 
        {
            base.VaciarMovimientos();
            _Conexion = new Datos.MovimientoD();
            List<DetalleMovimientoN> t_list;
            DataTable t_DT = _Conexion.ObtenerDetalle(Id);
            if (t_DT != null) 
            {
                t_list = new List<DetalleMovimientoN>();
                for (int a = 0; a < t_DT.Rows.Count; a++) 
                {
                    DataRow t_DR = t_DT.Rows[a];
                    DetalleMovimientoN t_DM = new DetalleMovimientoN
                        (
                        int.Parse(t_DR["Id"].ToString()),
                        int.Parse(t_DR["ClaveMov"].ToString()),
                        int.Parse(t_DR["IdArticulo"].ToString()),
                        int.Parse(t_DR["Cantidad"].ToString()),
                        decimal.Parse(t_DR["PrecioUnitario"].ToString()),
                        decimal.Parse(t_DR["ImporteSubTotal"].ToString()),
                        this

                        );
                    t_list.Add(t_DM);
                    AgregarDetalle(t_DM);
                }
                return t_list;
            } 
            return null;
        }

        /// <summary>
        /// Guarda los detalles
        /// </summary>
        /// <returns></returns>
        public bool GuardarDetalles() 
        {
            if (ListarDetalle() != null)
            {
                if (ListarDetalle().Count > 0)
                {
                    List<DetalleMovimientoN> t_list = new List<DetalleMovimientoN>();

                    

                    for (int a = 0; a < ListarDetalle().Count; a++)
                    {
                        DetalleMovimientoN _mov = (DetalleMovimientoN) ListarDetalle()[a];
                        _mov.GuardarDetalle();

                        
                    }

                    return true;
                }
                else { return false; }

            }
            else { return false; }
        }
        /// <summary>
        /// Inserta un detalle nuevo pero no guarda cambios
        /// </summary>
        /// <param name="p_detalle"></param>
        public void InsertarDetalle(DetalleMovimientoN p_detalle) 
        {
            AgregarDetalle(p_detalle);
        }
        /// <summary>
        /// Elimina un detalle de la base de datos
        /// </summary>
        /// <param name="p_detalle"></param>
        public void EliminarDetalle(DetalleMovimientoN p_detalle) 
        {
            EliminarMovimiento(p_detalle);
        }

        /// <summary>
        /// Borra todos los detalles de memoria de la base de datos
        /// </summary>
        public void BorrarDetalles() 
        {
            VaciarMovimientos();
            _Conexion = new Datos.MovimientoD();
            _Conexion.EliminarDetalle(this.Id);
        }
        /// <summary>
        /// Lista los detalles ya consultados en la base de datos
        /// para consulta por primera vez usar CARGARDETALLE
        /// </summary>
        /// <returns></returns>
        public List<DetalleMovimientoN> ListarDetalles()
        {
            if (base.ListarDetalle() != null)
            {
                if (ListarDetalle().Count > 0)
                {
                    List<DetalleMovimientoN> t_list = new List<DetalleMovimientoN>();
                    for (int a = 0; a < ListarDetalle().Count; a++)
                    {
                        t_list.Add((DetalleMovimientoN)ListarDetalle()[a]);
                    }
                    return t_list;
                }
                else { return null; }
            }
            else { return null; }
        }
        /// <summary>
        /// Guarda el movimiento en la base de datos
        /// </summary>
        /// <returns></returns>
        /// 

        public bool Anular() 
        {
            

            List<DetalleMovimientoN> _ListaDM =  this.CargarDetalle();
            TipoMovimientoN _TipoMov = new TipoMovimientoN(this.IdTipoMovimiento);

            foreach (DetalleMovimientoN _M in _ListaDM) 
            {
                if (_M.ObtenerArticulo().LlevaStock == true ) 
                {
                    ArticuloN _art = _M.ObtenerArticulo();
                    if (_TipoMov.Signo == "A")
                    {
                        _art.Cantidad = _M.ObtenerArticulo().Cantidad + _M.Cantidad;
                    }
                    else if (_TipoMov.Signo == "B")
                    {
                       
                        _art.Cantidad = _M.ObtenerArticulo().Cantidad - _M.Cantidad;
                    }
                    _art.Actualizar();
                    this.EliminarDetalle(_M);
                }
            }

            _Conexion = new Datos.MovimientoD();
            return _Conexion.EliminarMovimiento(this.Id);
            
        }




        public bool Guardar()
        {
            _Conexion = new Datos.MovimientoD();
            Id = _Conexion.InsertarMovimientoCV(IdTipoMovimiento, PuntoVenta, NroMovimiento, Fecha, ImporteNeto, ImporteIVA, IdCuenta, Observacion, CAE, FechaVencimientoCAE, FechaContabilizacion, CondicionDePago);
            if (Id != 0)
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
