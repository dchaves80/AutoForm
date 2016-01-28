using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCategoria : Form
    {
        #region Variables
        CategoriaN _CategoriaN;
        Negocios.FuncionesGlobales.Globales.Modo _ModoAM;
        #endregion

        #region Metodos
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_CategoriaN.Eliminar())
            {
                MessageBox.Show("El Registro se elimino correctamente ");
                LimpiarPantalla();
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Modificar);
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtId.Text == "")
            {
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
            }
            else if (e.KeyCode == Keys.Enter && txtId.Text != "")
            {
                _CategoriaN = new CategoriaN(int.Parse(txtId.Text));
                if (_CategoriaN.Nombre != null)
                {
                    txtNombre.Text = _CategoriaN.Nombre;
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Consultar);
                }
                else
                {
                    txtId.Text = ""; 
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (_ModoAM == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                _CategoriaN = new CategoriaN(txtNombre.Text);
                if (_CategoriaN.Guardar())
                {
                    if (_CategoriaN.Succed == true)
                    {
                        MessageBox.Show("Se Grabo la Categoria " + txtNombre.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo grabar la Categoria " + txtNombre.Text);
                    }
                }
            }
            else if (_ModoAM == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                _CategoriaN.Nombre = txtNombre.Text;
                if (_CategoriaN.Actualizar())
                {
                    MessageBox.Show("Se Actualizó la Categoria");
                }
                else
                {
                    MessageBox.Show("No se pudo Actulizar la Categoria");
                }
            }
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }
        #endregion

        #region Funciones
        private void LimpiarPantalla()
        {
            txtId.Text = "";
            txtNombre.Text = "";
        }
        private void CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo _Modo)
        {
            if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                txtId.Enabled = false;
                txtNombre.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _ModoAM = Negocios.FuncionesGlobales.Globales.Modo.Agregar;
                txtNombre.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Consultar)
            {
                txtId.Enabled = false;
                txtNombre.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                btnModificar.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Inicial)
            {
                txtId.Enabled = true;
                txtNombre.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                txtId.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
            {
                txtId.Enabled = false;
                txtNombre.Enabled = true; 
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _ModoAM = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
                txtNombre.Focus();
            }
        }
        #endregion
    }
}
