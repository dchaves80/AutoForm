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
using Negocios.FuncionesGlobales;

namespace Presentacion
{
    public partial class frmActualizarPrecioXCuenta : Form
    {
        #region Definiciones
        CuentaN _Cuenta;
        CategoriaN _Categoria;
        #endregion

        #region Metodos
        public frmActualizarPrecioXCuenta()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                if (ArticulosS.ActualizarPrecioPorCuenta(decimal.Parse(txtPorcentaje.Text), int.Parse(txtCuenta.Text == "" ? "0" : txtCuenta.Text), int.Parse(txtCodigoCategoria.Text == "" ? "0" : txtCodigoCategoria.Text)))
                {
                    MessageBox.Show("Se actualizaron los precios correctamente");
                    LimpiarPantalla();
                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar los precios");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.NumeroConDecimal(e);
        }

        private void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCuenta.Text != "")
            {
                _Cuenta = new CuentaN(int.Parse(txtCuenta.Text));

                if (_Cuenta.Succed)
                {
                    txtNombreCuenta.Text = _Cuenta.Nombre;
                    epControlCampos.Clear();
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<CuentaN> Cuentas = Negocios.FuncionesGlobales.CuentaS.ListarCuentasPorTipo(true);
                    string[] cool = { "Id", "Nombre" };
                    txtCuenta.Parametros<CuentaN>(Keys.F3, cool, "Id", Cuentas,"Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtCodigocategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodigoCategoria.Text != "")
            {
                _Categoria = new CategoriaN(int.Parse(txtCodigoCategoria.Text));

                if (_Categoria.Succed)
                {
                    txtNombreCategoria.Text = _Categoria.Nombre;
                    epControlCampos.Clear();
                }
            }
            else if (e.KeyCode == Keys.Enter && txtCodigoCategoria.Text == "")
	    	{
                txtNombreCategoria.Text = "";
	        }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<CategoriaN> Categoria = Negocios.FuncionesGlobales.CategoriaS.ListarCategoria();
                    string[] cool = { "Id", "Nombre" };
                    txtCodigoCategoria.Parametros<CategoriaN>(Keys.F3, cool, "Id", Categoria, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }
        #endregion

        #region Funciones
        private void LimpiarPantalla()
        {
            txtCuenta.Text = "";
            txtNombreCuenta.Text = "";
            txtPorcentaje.Text = "";
            txtCodigoCategoria.Text = "";
            txtNombreCategoria.Text = "";
        }

        private bool ControlErrores()
        {
            bool Retorno = true;
            if (txtPorcentaje.Text == "")
            {
                epControlCampos.SetError(txtPorcentaje, "Debe ingresar un porcentaje");
                Retorno = false;
            }
            else
            {
                epControlCampos.Clear();
            }
            if (txtCuenta.Text == "" && txtCodigoCategoria.Text == "")
            {
                epControlCampos.SetError(txtCuenta, "Debe ingresar una Cuenta o una Categoria");
                epControlCampos.SetError(txtCodigoCategoria, "Debe ingresar una Cuenta o una Categoria");
                Retorno = false;
            }
            else
            {
                epControlCampos.Clear();
            }
            return Retorno;
        }
        #endregion
    }
}
