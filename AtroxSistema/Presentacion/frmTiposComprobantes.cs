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
    public partial class frmTiposComprobantes : Form
    {
        #region Variables
        Negocios.FuncionesGlobales.Globales.Modo _ModoAM;
        TipoComprobanteN _TipoComprobante;
        #endregion

        #region Metodos
        public frmTiposComprobantes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void frmTiposComprobantes_Load(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Modificar);
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtId.Text != "")
            {
                _TipoComprobante = new TipoComprobanteN(int.Parse(txtId.Text));
                if (_TipoComprobante != null && _TipoComprobante.Id != 0)
                {
                    txtNombre.Text = _TipoComprobante.Nombre;
                    txtLetra.Text = _TipoComprobante.Letra;
                    txtDescripcion.Text = _TipoComprobante.Descripcion;
                    txtCopias.Text = _TipoComprobante.Copias.ToString();
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Consultar);
                }
                else
                {
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<TipoComprobanteN> TipoComprobante = Negocios.FuncionesGlobales.TipoComprobanteS.ListarTipoComprobante();
                    string[] cool = { "Id", "Nombre" };
                    txtId.Parametros<TipoComprobanteN>(Keys.F3, cool, "Id", TipoComprobante,"Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_TipoComprobante.Eliminar())
            {
                MessageBox.Show("Se eliminó correctamente el Tipo de Comprobante");
                LimpiarPantalla();
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                if (_ModoAM == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
                {
                    _TipoComprobante = new TipoComprobanteN(int.Parse(txtId.Text), txtNombre.Text, txtLetra.Text, txtDescripcion.Text, short.Parse(txtCopias.Text));
                    if (_TipoComprobante.Guardar())
                    {
                        MessageBox.Show("Se Creó el Tipo Comprobante en forma exitosa");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
                else if (_ModoAM == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
                {
                    _TipoComprobante = new TipoComprobanteN(int.Parse(txtId.Text), txtNombre.Text, txtLetra.Text, txtDescripcion.Text, short.Parse(txtCopias.Text));
                    if (_TipoComprobante.Actualizar())
                    {
                        MessageBox.Show("Se Actualizó el Tipo Comprobante en forma exitosa");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
            }
        }

        private void txtCopias_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }
        #endregion

        #region Funciones
        private void LimpiarPantalla()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtLetra.Text = "";
            txtDescripcion.Text = "";
            txtCopias.Text = "";
        }

        private void CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo _Modo)
        {
            if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                txtId.Enabled = false;
                txtNombre.Enabled = true;
                txtLetra.Enabled = true;
                txtDescripcion.Enabled = true;
                txtCopias.Enabled = true;
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
                txtLetra.Enabled = false;
                txtDescripcion.Enabled = false;
                txtCopias.Enabled = false;
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
                txtLetra.Enabled = false;
                txtDescripcion.Enabled = false;
                txtCopias.Enabled = false;
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
                txtLetra.Enabled = true;
                txtDescripcion.Enabled = true;
                txtCopias.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _ModoAM = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
                txtNombre.Focus();
            }
        }

        private bool ControlErrores()
        {
            bool Retorno = true;
            if (txtNombre.Text == "")
            {
                epControlCampo.SetError(txtNombre, "Debe ingresar un Nombre del Tipo de Comprobante");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            return Retorno;
        }
        #endregion
    }
}
