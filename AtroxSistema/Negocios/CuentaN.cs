using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CuentaN : Entidades.CuentaE
    {
        private Datos.CuentaD _Cuenta;
        private Datos.ArticuloD _Articulo;

        public CuentaN(
            int p_Id,
            string p_nombre,
            string p_nombrefantasia,
            int? p_IdCategoriaAfip,
            int? p_IdTipoDocumento,
            String p_nroDocumento,
            String p_nroIngresosBrutos,
            int? p_IdLocalidad,
            String p_Domicilio,
            int? p_NroDomicilio,
            int? p_Piso,
            String p_Departamento,
            bool p_proveedor,
            String p_Mail,
            String p_telefono)
        {
            Id = p_Id;
            Nombre = p_nombre;
            NombreFantasia = p_nombrefantasia;
            IdCategoriaAfip = p_IdCategoriaAfip;
            IdTipoDocumento = p_IdTipoDocumento;
            NroDocumento = p_nroDocumento;
            NroIngresosBrutos = p_nroIngresosBrutos;
            IdLocalidad = p_IdLocalidad;
            Domicilio = p_Domicilio;
            NroDomicilio = p_NroDomicilio;
            Piso = p_Piso;
            Departamento = p_Departamento;
            Proveedor = p_proveedor;
            Mail = p_Mail;
            Telefono = p_telefono;
        }

        /// <summary>
        /// Crea una cuenta nueva con todos sus datos 
        /// </summary>
        /// <param name="p_nombre"></param>
        /// <param name="p_nombrefantasia"></param>
        /// <param name="p_IdCategoriaAfip"></param>
        /// <param name="p_IdTipoDocumento"></param>
        /// <param name="p_nroDocumento"></param>
        /// <param name="p_nroIngresosBrutos"></param>
        /// <param name="p_IdLocalidad"></param>
        /// <param name="p_Domicilio"></param>
        /// <param name="p_NroDomicilio"></param>
        /// <param name="p_Piso"></param>
        /// <param name="p_Departamento"></param>
        /// <param name="p_proveedor"></param>
        public CuentaN(
            string p_nombre,
            string p_nombrefantasia,
            int? p_IdCategoriaAfip,
            int? p_IdTipoDocumento,
            String p_nroDocumento,
            String p_nroIngresosBrutos,
            int? p_IdLocalidad,
            String p_Domicilio,
            int? p_NroDomicilio,
            int? p_Piso,
            String p_Departamento,
            bool p_proveedor,
            String p_Mail,
            String p_telefono)
        {

            Nombre = p_nombre;
            NombreFantasia = p_nombrefantasia;
            IdCategoriaAfip = p_IdCategoriaAfip;
            IdTipoDocumento = p_IdTipoDocumento;
            NroDocumento = p_nroDocumento;
            NroIngresosBrutos = p_nroIngresosBrutos;
            IdLocalidad = p_IdLocalidad;
            Domicilio = p_Domicilio;
            NroDomicilio = p_NroDomicilio;
            Piso = p_Piso;
            Departamento = p_Departamento;
            Proveedor = p_proveedor;
            Mail = p_Mail;
            Telefono = p_telefono;
        }

        /// <summary>
        /// Consulta una cuenta proporcionando el id de cuenta como parametro
        /// </summary>
        /// <param name="p_idcuenta"></param>
        public CuentaN(int? p_idcuenta)
        {
            _Cuenta = new Datos.CuentaD();
            DataTable DT = _Cuenta.ObtenerCuenta(p_idcuenta);
            if (DT != null)
            {
                DataRow _DR = DT.Rows[0];
                Id = int.Parse(_DR["IdCuenta"].ToString());
                Nombre = _DR["Nombre"].ToString();
                NombreFantasia = _DR["NombreFantasia"].ToString();
                IdCategoriaAfip = int.Parse(_DR["IdCategoriaAFIP"].ToString());
                IdTipoDocumento = int.Parse(_DR["IdTipoDocumento"].ToString());
                NroDocumento = _DR["NroDocumento"].ToString();
                NroIngresosBrutos = _DR["NroIngresosBrutos"].ToString();
                IdLocalidad = int.Parse(_DR["IdLocalidad"].ToString());
                Domicilio = _DR["Domicilio"].ToString();
                NroDomicilio = int.Parse(_DR["NroDomicilio"].ToString());
                Piso = int.Parse(_DR["Piso"].ToString());
                Departamento = _DR["Departamento"].ToString();
                Proveedor = bool.Parse(_DR["Proveedor"].ToString());
                Mail = _DR["Mail"].ToString();
                Telefono = _DR["Telefono"].ToString();
                Succed = true;
            }
            else { Succed = false; }

        }


        /// <summary>
        /// Te la manda a guardar...
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            _Cuenta = new Datos.CuentaD();
            Id = _Cuenta.GuardarCuenta(

               Nombre,
               NombreFantasia,
               IdCategoriaAfip,
               IdTipoDocumento,
               NroDocumento,
               NroIngresosBrutos,
               IdLocalidad,
               Domicilio,
               NroDomicilio,
               Piso,
               Departamento,
               Proveedor, Mail, Telefono);

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
            if (_Cuenta.EliminarCuenta(this.Id) == true)
            {
                Id = 0;
                Nombre = null;
                NombreFantasia = null;
                IdCategoriaAfip = 0;
                IdTipoDocumento = 0;
                NroDocumento = null;
                NroIngresosBrutos = null;
                IdLocalidad = 0;
                Domicilio = null;
                NroDomicilio = 0;
                Piso = 0;
                Departamento = null;
                Proveedor = false;
                Succed = false;
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<ArticuloN> ListarArticulos()
        {
            _Articulo = new Datos.ArticuloD();
            DataTable _DT = _Articulo.ListarArticulosPorCuenta(this.Id);
            List<ArticuloN> _listaART = new List<ArticuloN>();
            if (_DT != null)
            {
                for (int a = 0; a < _DT.Rows.Count; a++)
                {
                    _listaART.Add(new ArticuloN(int.Parse(_DT.Rows[a]["Id"].ToString())));
                }
                return _listaART;
            }
            else 
            {
                return null;
            }


        }

        /// <summary>
        /// Modifica la cuenta y a tu vieja...
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            if (_Cuenta.ActualizarCuenta(
                 Nombre,
                 NombreFantasia,
                 IdCategoriaAfip,
                 IdTipoDocumento,
                 NroDocumento,
                 NroIngresosBrutos,
                 IdLocalidad,
                 Domicilio,
                 NroDomicilio,
                 Piso,
                 Departamento,
                 Proveedor, this.Id, Mail, Telefono) == true)
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
