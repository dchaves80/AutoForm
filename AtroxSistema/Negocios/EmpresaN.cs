using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Drawing;
using System.Data;
using Datos;

namespace Negocios
{
    /// <summary>
    /// Clase de Negocio Empresa
    /// Contiene datos de la empresa y metodos para el manejo de la misma.
    /// Solo DATOS de empresa.
    /// </summary>
    public class EmpresaN: EmpresaE
    {
        /// <summary>
        /// Consulta un objeto Empresa
        /// </summary>
        /// <param name="p_Id"></param>
        /// 
        
        EmpresaD _Datos;

        /// <summary>
        /// No usar
        /// </summary>
        /// <param name="p_Id"></param>
   
        
        
        public EmpresaN(int p_Id) 
        {
            //FALTA CONSULTA POR ID
        
        }

        /// <summary>
        /// Crea un objeto Empresa
        /// </summary>
        /// <param name="p_RazonSocial"></param>
        /// <param name="p_NombreFantasia"></param>
        /// <param name="p_Cuit"></param>
        /// <param name="p_IngBrutos"></param>
        /// <param name="p_InicioActividad"></param>
        /// <param name="p_CatIVA"></param>
        /// <param name="p_Logo"></param>
        public EmpresaN(
            string p_RazonSocial, 
            string p_NombreFantasia, 
            string p_Cuit, 
            string p_IngBrutos, 
            DateTime p_InicioActividad,
            int p_CategoriaAFIP,
            Image p_Logo
            )
        {
            this.CategoriaAFIP = p_CategoriaAFIP;
            this.RazonSocial = p_RazonSocial;
            this.NombreFantasia = p_NombreFantasia;
            this.Cuit = p_Cuit;
            this.IngresosBrutos = p_IngBrutos;
            this.InicioActividad = p_InicioActividad;
            this.Logo = p_Logo;
            //FALTA DEFINIR PROPIEDAD ID CUANDO SE CONSULTE A LA BASE DE DATOS.
            
            
           
            
            
        }
        /// <summary>
        /// Obtiene la empresa de la base de datos
        /// </summary>
        public EmpresaN() 
        {
            _Datos = new Datos.EmpresaD();
            DataTable DT=null;
            try
            {
               DT  = _Datos.ObtenerEmpresa();
            }
            catch (Exception EXC) 
            {
                Entidades.Catcher.Catcher.Agregar_Error(this.ToString(), EXC.StackTrace);
            }
            
            
            if (DT != null)
            {
                try
                {
                    this.Id = Convert.ToInt32(DT.Rows[0]["Id"].ToString());
                    this.RazonSocial = DT.Rows[0]["Nombre"].ToString();
                    this.NombreFantasia = DT.Rows[0]["NombreFantasia"].ToString();
                    this.Cuit = DT.Rows[0]["CUIT"].ToString();
                    this.IngresosBrutos = DT.Rows[0]["IngresosBrutos"].ToString();
                    this.InicioActividad = Convert.ToDateTime(DT.Rows[0]["InicioACtividad"].ToString());
                    this.CategoriaAFIP = Convert.ToInt32(DT.Rows[0]["IdCategoriaAFIP"].ToString());
                    this.Succed = true;
                }
                catch (Exception EXC)
                {
                    Entidades.Catcher.Catcher.Agregar_Error(this.ToString(), EXC.StackTrace);
                    this.Succed = false;
                }
            }
            else 
            {
                this.Succed = false;
            }
        }

        public EmpresaN(
            string p_razonsocial, 
            string p_nombrefantasia, 
            string p_cuit, 
            string p_ingresosbrutos, 
            DateTime p_inicioactividad,
            int p_catafip)
        {
            _Datos = new EmpresaD();
            Id =_Datos.InsertarEmpresa(
                p_razonsocial,
                p_nombrefantasia,
                p_cuit,
                p_ingresosbrutos,
                p_inicioactividad,
                p_catafip
                );
            if ( Id!=0)
            {
                Succed = true;
            }
            else 
            {
                Succed = false;
            }

        }

        private void Limpiar() 
        {
            this.CategoriaAFIP = 0;
            this.Cuit = "";
            this.Id = 0;
            this.IngresosBrutos = "";
            this.InicioActividad = DateTime.Now;
            this.Logo = null;
            this.NombreFantasia = "";
            this.RazonSocial = "";
            this.Succed = true;
        }

        public Boolean Eliminar()
        {
            if (_Datos.EliminarEmpresa(this.Id) == true) 
            {

                Limpiar();
                return true;
            }
            else { return false; }
        }

        public Boolean Actualizar() 
        {
            if (_Datos.ActualizarEmpresa(
                this.Id,
                this.RazonSocial,
                this.NombreFantasia,
                this.Cuit,
                this.IngresosBrutos,
                this.InicioActividad,
                this.CategoriaAFIP) == true)
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
