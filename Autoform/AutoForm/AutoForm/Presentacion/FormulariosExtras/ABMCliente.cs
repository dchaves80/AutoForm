using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.FormulariosExtras
{
    public partial class ABMCliente : Form
    {

        public enum Funcion {editar,nuevo}; 

        public class campo 
        {

            

            public campo(string name, Boolean hiden ) 
            {
                nombre = name;
                hide = hiden;
            }

            string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            Boolean hide;

            public Boolean Hide
            {
                get { return hide; }
                set { hide = value; }
            }
        }

        Datos.Cliente.CLNT _CLNT;

        Funcion funcion;

        public ABMCliente()
        {
            funcion = Funcion.nuevo;
            InitializeComponent();
            CrearCampos();
            Application.DoEvents();
        }


        public ABMCliente(Datos.Cliente.CLNT p_CLNT) 
        {
            funcion = Funcion.editar;
            _CLNT = p_CLNT;
            InitializeComponent();
            CrearCampos();
            Application.DoEvents();
            LlenarCampos();

        }

        private void LlenarCampos() 
        {
            dtgvABMCLiente.Rows[0].Cells[1].Value = _CLNT.Id;
            dtgvABMCLiente.Rows[1].Cells[1].Value = _CLNT.Nombre;
            dtgvABMCLiente.Rows[2].Cells[1].Value = _CLNT.Apellido;
            dtgvABMCLiente.Rows[3].Cells[1].Value = _CLNT.Telefono;
            dtgvABMCLiente.Rows[4].Cells[1].Value = _CLNT.Numerodocumento;
            dtgvABMCLiente.Rows[5].Cells[1].Value = _CLNT.Domicilio;
            dtgvABMCLiente.Rows[6].Cells[1].Value = _CLNT.Cuit;
            dtgvABMCLiente.Rows[7].Cells[1].Value = _CLNT.Cuil;
        }

        private void CrearCampos() 
        {
            List<campo> _fieldList = new List<campo>();

            _fieldList.Add(new campo("Id", true));
            _fieldList.Add(new campo("Nombre", false));
            _fieldList.Add(new campo("Apellido", false));
            _fieldList.Add(new campo("Telefono", false));
            _fieldList.Add(new campo("Numero Documento", false));
            _fieldList.Add(new campo("Domicilio", false));
            _fieldList.Add(new campo("Cuit", false));
            _fieldList.Add(new campo("Cuil", false));
            decimal Height = dtgvABMCLiente.Height/(_fieldList.Count-1);

            foreach (campo C in _fieldList)
            {
                DataGridViewRow R;
                R = new DataGridViewRow();
                R.CreateCells(dtgvABMCLiente);
                R.Cells[0].Value = C.Nombre;
                R.Cells[0].ReadOnly = true;
                R.Cells[1].Value = "";
                R.Cells[1].ReadOnly = false;
                
                R.Height = Convert.ToInt32(Height);
                if (C.Hide == true) 
                {
                    R.Visible = false;
                }
                dtgvABMCLiente.Rows.Add(R);
            }


            
        
            
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
