using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpresaE:SuperEntity
    {
        
        private Image _Logo;
        private string _RazonSocial;
        private string _NombreFantasia;
        private string _Cuit;
        private string _IngresosBrutos;
        private int _CategoriaAFIP;
        private DateTime _InicioActividad;


       
        

        public Image Logo
        {
            get { return _Logo; }
            set { _Logo = value; }
        }
        

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
        

        public string NombreFantasia
        {
            get { return _NombreFantasia; }
            set { _NombreFantasia = value; }
        }
        

        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }
        

        public string IngresosBrutos
        {
            get { return _IngresosBrutos; }
            set { _IngresosBrutos = value; }
        }
       

        public int CategoriaAFIP
        {
            get { return _CategoriaAFIP; }
            set { _CategoriaAFIP = value; }
        }
        

        public DateTime InicioActividad
        {
            get { return _InicioActividad; }
            set { _InicioActividad = value; }
        }


    }
}
