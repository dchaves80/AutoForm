using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class frmArticulos : Form
    {
        #region Variables
        ArticuloN _Articulo;
        CuentaN _Cuenta;
        decimal PrecioCompra;
        decimal Porcentaje;
        Negocios.FuncionesGlobales.Globales.Modo _Estado = Negocios.FuncionesGlobales.Globales.Modo.Inicial;
        #endregion

        #region Metodos
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Negocios.FuncionesGlobales.CategoriaS.ListarCategoria();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedValue = -1;
            txtIVA.Text = "21,00";
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitimos solo números y  el símbolo .
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (txtPorcentaje.Text.Contains('.') || txtPorcentaje.Text.Contains(','))
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        if (txtPorcentaje.Text.Length == 0)
                        {
                            e.Handled = true;
                            txtPorcentaje.Text = "0,";
                            txtPorcentaje.SelectionStart = txtPorcentaje.Text.Length;
                        }
                        else
                        {
                            e.KeyChar = ',';
                        }
                    }
                }
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitimos solo números y  el símbolo .
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (txtPrecioCompra.Text.Contains(',') || txtPrecioCompra.Text.Contains('.'))
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        if (txtPrecioCompra.Text.Length == 0)
                        {
                            e.Handled = true;
                            txtPrecioCompra.Text = "0,";
                            txtPrecioCompra.SelectionStart = txtPrecioCompra.Text.Length;
                        }
                        else
                        {
                            e.KeyChar = ',';
                        }
                    }
                }
            }
        }

        private void txtPrecioSugerido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitimos solo números y  el símbolo .
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (txtPrecioSugerido.Text.Contains(',') || txtPrecioSugerido.Text.Contains('.'))
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        if (txtPrecioSugerido.Text.Length == 0)
                        {
                            e.Handled = true;
                            txtPrecioSugerido.Text = "0,";
                            txtPrecioSugerido.SelectionStart = txtPrecioSugerido.Text.Length;
                        }
                        else
                        {
                            e.KeyChar = ',';
                        }
                    }
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_Articulo.Eliminar())
            {
                MessageBox.Show("Articulo eliminado con exito");
                LimpiarPantalla();
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Modificar);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
                {
                    _Articulo = new ArticuloN(
                        txtNombre.Text,
                        decimal.Parse(txtIVA.Text),
                        decimal.Parse(txtPrecioCompra.Text),
                        decimal.Parse(txtPorcentaje.Text),
                        txtCodigoBarra.Text,
                        decimal.Parse(txtPrecioSugerido.Text),
                        _Cuenta,
                        chkLlevaStock.Checked,
                        int.Parse(txtCantidad.Text),
                        chkCongelarPrecio.Checked,
                        int.Parse(cmbCategoria.SelectedValue.ToString())
                        );
                    if (_Articulo.Guardar())
                    {
                        MessageBox.Show("Se grabó el Artículo con exito");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
                else if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
                {
                    _Articulo.Nombre = txtNombre.Text;
                    _Articulo.CodigoBarra = txtCodigoBarra.Text;
                    _Articulo.IVA = decimal.Parse(txtIVA.Text);
                    _Articulo.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                    _Articulo.Porcentaje = decimal.Parse(txtPorcentaje.Text);
                    _Articulo.PrecioSugerido = decimal.Parse(txtPrecioSugerido.Text);
                    _Articulo.IdCuenta = _Cuenta.Id;
                    _Articulo.Cantidad = int.Parse(txtCantidad.Text);
                    _Articulo.LlevaStock = chkLlevaStock.Checked;
                    _Articulo.BloqueaPrecio = chkCongelarPrecio.Checked;
                    _Articulo.IdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                    if (_Articulo.Actualizar())
                    {
                        MessageBox.Show("Modificado con exito");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }

            }
            else
            {
                MessageBox.Show("Revise los campos obligatorios");
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodigo.Text == "")
            {
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
            }
            else if (e.KeyCode == Keys.Enter && txtCodigo.Text != "")
            {
                _Articulo = new ArticuloN(int.Parse(txtCodigo.Text));
                if (_Articulo != null && _Articulo.IdCuenta != 0)
                {
                    txtNombre.Text = _Articulo.Nombre;
                    txtCodigoBarra.Text = _Articulo.CodigoBarra;
                    txtIVA.Text = _Articulo.IVA.ToString();
                    txtPrecioCompra.Text = _Articulo.PrecioCompra.ToString();
                    txtPorcentaje.Text = _Articulo.Porcentaje.ToString();
                    txtPrecioSugerido.Text = _Articulo.PrecioSugerido.ToString();
                    txtProveedor.Text = _Articulo.IdCuenta.ToString();
                    txtProveedor_KeyDown(sender, e);
                    txtCantidad.Text = _Articulo.Cantidad.ToString();
                    chkLlevaStock.Checked = _Articulo.LlevaStock;
                    chkCongelarPrecio.Checked = _Articulo.BloqueaPrecio;
                    cmbCategoria.SelectedValue = _Articulo.IdCategoria;
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Consultar);
                }
                else
                {
                    LimpiarPantalla();
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
                }
            }
            else if (e.KeyCode== Keys.F3)
            {
                try
                {
                    List<ArticuloN> Articulos = Negocios.FuncionesGlobales.ArticulosS.ListarArticulos();
                    string[] cool = { "Id", "Nombre" };
                    txtCodigo.Parametros<ArticuloN>(Keys.F3, cool, "Id", Articulos, "Nombre");

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (txtIVA.Text.Contains(',') || txtIVA.Text.Contains('.'))
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        if (txtIVA.Text.Length == 0)
                        {
                            e.Handled = true;
                            txtIVA.Text = "0,";
                            txtIVA.SelectionStart = txtIVA.Text.Length;
                        }
                        else
                        {
                            e.KeyChar = ',';
                        }
                    }
                }
            }
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtProveedor.Text != "")
            {
                _Cuenta = new CuentaN(int.Parse(txtProveedor.Text));
                if (_Cuenta != null)
                {
                    txtNombreProveedor.Text = _Cuenta.Nombre;
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<CuentaN> Cuentas = Negocios.FuncionesGlobales.CuentaS.ListarCuentasPorTipo(true);
                    string[] cool = { "Id" , "Nombre" };
                    txtProveedor.Parametros<CuentaN>(Keys.F3, cool, "Id", Cuentas, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtPrecioCompra.Text != "")
            {
                PrecioCompra = decimal.Round(decimal.Parse(txtPrecioCompra.Text == "" ? "0" : txtPrecioCompra.Text), 2);
                Porcentaje = decimal.Round(decimal.Parse(txtPorcentaje.Text == "" ? "0" : txtPorcentaje.Text), 2);
                txtPrecioSugerido.Text = (decimal.Round(PrecioCompra + (PrecioCompra * (Porcentaje / 100)), 2)).ToString("F");
            }
        }

        private void txtPorcentaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrecioCompra.Text != "")
            {
                PrecioCompra = decimal.Round(decimal.Parse(txtPrecioCompra.Text == "" ? "0": txtPrecioCompra.Text),2);
                Porcentaje = decimal.Round(decimal.Parse(txtPorcentaje.Text == "" ? "0" : txtPorcentaje.Text),2);
                txtPrecioSugerido.Text = (decimal.Round(PrecioCompra + (PrecioCompra * (Porcentaje / 100)),2)).ToString("F");
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }
        #endregion

        #region Funciones
        private bool ControlErrores()
        {
            bool Retorno = true;
            if (txtNombre.Text == "")
            {
                epControlCampo.SetError(txtNombre, "Debe ingresar un Nombre de Producto");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            if (txtPrecioCompra.Text == "")
            {
                epControlCampo.SetError(txtPrecioCompra, "Debe ingresar un Precio de Compra");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            if (txtPorcentaje.Text == "")
            {
                epControlCampo.SetError(txtPorcentaje, "Debe ingresar un Porcentaje");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            if (txtPrecioSugerido.Text == "")
            {
                epControlCampo.SetError(txtPrecioSugerido, "Debe ingresar un Precio Sugerido de Venta");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            if (txtProveedor.Text == "")
            {
                epControlCampo.SetError(txtNombreProveedor, "Debe ingresar un Proveedor");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            if (cmbCategoria.SelectedValue == null )
            {
                epControlCampo.SetError(cmbCategoria, "Debe seleccionar una Categoria");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            return Retorno;
        }
        private void LimpiarPantalla()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtCodigoBarra.Text = "";
            txtNombre.Text = "";
            txtNombreProveedor.Text = "";
            txtPorcentaje.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioSugerido.Text = "";
            txtProveedor.Text = "";
            txtIVA.Text = "21,00";
            chkLlevaStock.Checked = false;
            cmbCategoria.SelectedIndex = -1;
            chkCongelarPrecio.Checked = false;
            epControlCampo.Clear();
            txtCodigo.Focus();
        }
        private void CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo _Modo)
        {
            if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Inicial)
            {
                txtCodigo.Enabled = true;
                txtNombre.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtIVA.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtPorcentaje.Enabled = false;
                txtPrecioSugerido.Enabled = false;
                txtProveedor.Enabled = false;
                txtCantidad.Enabled = false;
                chkLlevaStock.Enabled = false;
                chkCongelarPrecio.Enabled = false;
                cmbCategoria.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCodigo.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Consultar)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtIVA.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtPorcentaje.Enabled = false;
                txtPrecioSugerido.Enabled = false;
                txtProveedor.Enabled = false;
                txtCantidad.Enabled = false;
                chkLlevaStock.Enabled = false;
                chkCongelarPrecio.Enabled = false;
                cmbCategoria.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                btnModificar.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Agregar )
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = true;
                txtCodigoBarra.Enabled = true;
                txtIVA.Enabled = false;
                txtPrecioCompra.Enabled = true;
                txtPorcentaje.Enabled = true;
                txtPrecioSugerido.Enabled = true;
                txtProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                chkLlevaStock.Enabled = true;
                chkCongelarPrecio.Enabled = true;
                cmbCategoria.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Agregar;
                txtNombre.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = true;
                txtCodigoBarra.Enabled = true;
                txtIVA.Enabled = false;
                txtPrecioCompra.Enabled = true;
                txtPorcentaje.Enabled = true;
                txtPrecioSugerido.Enabled = true;
                txtProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                chkLlevaStock.Enabled = true;
                chkCongelarPrecio.Enabled = true;
                cmbCategoria.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
                txtNombre.Focus();
            }
        }
        #endregion  
    }
}
