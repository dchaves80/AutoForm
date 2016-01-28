using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaE : SuperEntity
    {
        string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        string _NombreFantasia;

        public string NombreFantasia
        {
            get { return _NombreFantasia; }
            set { _NombreFantasia = value; }
        }
        int? _IdCategoriaAfip;

        public int? IdCategoriaAfip
        {
            get { return _IdCategoriaAfip; }
            set { _IdCategoriaAfip = value; }
        }
        int? _IdTipoDocumento;

        public int? IdTipoDocumento
        {
            get { return _IdTipoDocumento; }
            set { _IdTipoDocumento = value; }
        }
        string _NroDocumento;

        public string NroDocumento
        {
            get { return _NroDocumento; }
            set { _NroDocumento = value; }
        }
        string _NroIngresosBrutos;

        public string NroIngresosBrutos
        {
            get { return _NroIngresosBrutos; }
            set { _NroIngresosBrutos = value; }
        }
        int? _IdLocalidad;

        public int? IdLocalidad
        {
            get { return _IdLocalidad; }
            set { _IdLocalidad = value; }
        }
        string _Domicilio;

        public string Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = value; }
        }
        int? _NroDomicilio;

        public int? NroDomicilio
        {
            get { return _NroDomicilio; }
            set { _NroDomicilio = value; }
        }
        int? _Piso;

        public int? Piso
        {
            get { return _Piso; }
            set { _Piso = value; }
        }
        string _Departamento;

        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        bool _Proveedor;

        public bool Proveedor
        {
            get { return _Proveedor; }
            set { _Proveedor = value; }
        }


    }
}
