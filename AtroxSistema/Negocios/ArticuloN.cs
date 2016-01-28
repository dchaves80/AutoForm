using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Negocios
{
    public class ArticuloN : ArticuloE
    {

        private Datos.ArticuloD _Datos;
        /// <summary>
        /// crea un nuevo articulo pero no guarda cambios
        /// </summary>
        /// <param name="p_Nombre"></param>
        /// <param name="p_IVA"></param>
        /// <param name="p_PrecioCompra"></param>
        /// <param name="p_Porcentaje"></param>
        /// <param name="p_CodigoBarra"></param>
        /// <param name="p_PrecioSugerido"></param>
        /// <param name="p_Cuenta"></param>
        /// <param name="p_LlevaStock"></param>
        /// <param name="p_cantidad"></param>
        /// <param name="p_BloqueaPrecio"></param>
        /// <param name="p_IdCategoria"></param>
        public ArticuloN(
            string p_Nombre,
            decimal p_IVA,
            decimal p_PrecioCompra,
            decimal p_Porcentaje,
            String p_CodigoBarra,
            decimal p_PrecioSugerido,
            CuentaN p_Cuenta,
            bool p_LlevaStock,
            int p_cantidad,
            bool p_BloqueaPrecio,
            int p_IdCategoria)
        {
            Nombre = p_Nombre;
            IVA = p_IVA;
            PrecioCompra = p_PrecioCompra;
            Porcentaje = p_Porcentaje;
            CodigoBarra = p_CodigoBarra;
            PrecioSugerido = p_PrecioSugerido;
            IdCuenta = p_Cuenta.Id;
            Cuenta = (CuentaE)p_Cuenta;
            LlevaStock = p_LlevaStock;
            Cantidad = p_cantidad;
            BloqueaPrecio = p_BloqueaPrecio;
            IdCategoria = p_IdCategoria;
        }

        public ArticuloN(
                   int p_Id,
                   string p_Nombre,
                   decimal p_IVA,
                   decimal p_PrecioCompra,
                   decimal p_Porcentaje,
                   String p_CodigoBarra,
                   decimal p_PrecioSugerido,
                   CuentaN p_Cuenta,
                   bool p_LlevaStock,
                   int p_cantidad,
                   bool p_BloqueaPrecio,
                   int p_IdCategoria)
        {
            Id = p_Id;
            Nombre = p_Nombre;
            IVA = p_IVA;
            PrecioCompra = p_PrecioCompra;
            Porcentaje = p_Porcentaje;
            CodigoBarra = p_CodigoBarra;
            PrecioSugerido = p_PrecioSugerido;
           
            if (p_Cuenta != null) {
                IdCuenta = p_Cuenta.Id;
                Cuenta = (CuentaE)p_Cuenta;
            }
            LlevaStock = p_LlevaStock;
            Cantidad = p_cantidad;
            BloqueaPrecio = p_BloqueaPrecio;
            IdCategoria = p_IdCategoria;
        }

        /// <summary>
        /// Consulta un articulod e la base de datos
        /// </summary>
        /// <param name="p_Id"></param>
        public ArticuloN(int p_Id) 
        {
            /*Id	
             * Nombre	
             * IVA	
             * PrecioCompra	
             * Porcentaje	
             * CodigoBarra	
             * PrecioSugerido	
             * IdCuenta	
             * LlevaStock	
             * Cantidad*/

            _Datos = new Datos.ArticuloD();
            DataTable _DT = _Datos.ObtenerArticulo(p_Id);
            if (_DT != null) 
            {
                DataRow _DR = _DT.Rows[0];
                Id= int.Parse( _DR["Id"].ToString());
                Nombre = _DR["Nombre"].ToString();
                IVA = decimal.Parse( _DR["IVA"].ToString());
                PrecioCompra = decimal.Parse(_DR["PrecioCompra"].ToString());
                Porcentaje =decimal.Parse( _DR["Porcentaje"].ToString());
                CodigoBarra = _DR["CodigoBarra"].ToString();
                PrecioSugerido =decimal.Parse( _DR["PrecioSugerido"].ToString());
                IdCuenta =int.Parse( _DR["IdCuenta"].ToString());
                LlevaStock = bool.Parse( _DR["LlevaStock"].ToString());
                Cantidad = int.Parse(_DR["Cantidad"].ToString());
                BloqueaPrecio = bool.Parse(_DR["BloquearPrecio"].ToString());
                IdCategoria = int.Parse(_DR["IdCategoria"].ToString());
                Succed = true;

            }

        }
        /// <summary>
        /// Actualiza el articulo
        /// </summary>
        /// <returns></returns>
        public bool Actualizar() 
        {
            _Datos = new Datos.ArticuloD();
            bool _result=false;
            try {
                _result= _Datos.ModificarArticulo(
                    this.Id, 
                    this.Nombre, 
                    this.IVA, 
                    this.PrecioCompra, 
                    this.Porcentaje, 
                    this.CodigoBarra, 
                    this.PrecioSugerido, 
                    this.IdCuenta, 
                    this.LlevaStock, 
                    this.Cantidad,
                    this.BloqueaPrecio,
                    this.IdCategoria
                );
                Succed = true;
            } catch(Exception EXC)
            {
                Entidades.Catcher.Catcher.Agregar_Error(this.ToString(), EXC.StackTrace);
                    Succed = false;
                }
            Succed = _result;

            return _result; 
        }
        /// <summary>
        /// Guarda un articulo nuevo
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            _Datos = new Datos.ArticuloD();
            try
            {
                DataTable _DT = _Datos.InsertarArticulo(Nombre, IVA, PrecioCompra, Porcentaje, CodigoBarra, PrecioSugerido, IdCuenta, LlevaStock, Cantidad, BloqueaPrecio, IdCategoria);
                if (_DT.Rows.Count > 0)
                {
                    Id = Convert.ToInt32(_DT.Rows[0]["Id"].ToString());
                    Succed = true;
                    return true;

                }
                else
                {
                    Succed = false;

                    return false;
                }

            }
            catch (Exception EXC) 
            {
                Entidades.Catcher.Catcher.Agregar_Error(this.ToString(), EXC.StackTrace);
                return false;
            }

        }

        /// <summary>
        /// Elimina un articulo de la base de datos
        /// </summary>
        /// <returns></returns>
        public Boolean Eliminar() 
        {
            _Datos = new Datos.ArticuloD();
            return _Datos.EliminarArticulo(this.Id);
            
        }
        /// <summary>
        /// Obtiene la cuenta a la que pertenece el articulo
        /// </summary>
        /// <returns></returns>
        public CuentaN ObtenerCuenta()
        {
            if (IdCuenta != 0)
            {
                return (CuentaN)Cuenta;
            }
            else
            {
                CuentaN t_cuenta = new CuentaN(IdCuenta);
                if (t_cuenta.Succed == true)
                {
                    Cuenta = (CuentaE)t_cuenta;

                    return (CuentaN)Cuenta;
                }
                else
                {
                    Cuenta = null;

                    return null;
                }
            }
        }

       

    }
}
