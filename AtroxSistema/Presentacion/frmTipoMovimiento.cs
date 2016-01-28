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
    public partial class frmTipoMovimiento : Form
    {
        #region Variables
        TipoMovimientoN _TipoMovimiento;
        TipoComprobanteN _TipoComprobante;
        Negocios.FuncionesGlobales.Globales.Modo _Estado = Negocios.FuncionesGlobales.Globales.Modo.Inicial;
        #endregion

        #region Metodos
        public frmTipoMovimiento()
        {
            InitializeComponent();
        }

        private void frmTipoMovimiento_Load(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodigo.Text != "")
            {
                _TipoMovimiento = new TipoMovimientoN(int.Parse(txtCodigo.Text));
                if (_TipoMovimiento != null && _TipoMovimiento.Id != 0)
                {
                    txtNombreTipoMovimiento.Text = _TipoMovimiento.Nombre;
                    txtIdTipoComprobante.Text = _TipoMovimiento.IdTipoComprobante.ToString();
                    txtIdTipoComprobante_KeyDown(sender, e);
                    if (_TipoMovimiento.Signo == "D")
                    {
                        rbDebita.Checked = true;
                        rbAcredita.Checked = false;
                    }
                    else
                    {
                        rbAcredita.Checked = true;
                        rbDebita.Checked = false;
                    }
                    if (_TipoMovimiento.Numeracion == "M")
                    {
                        rbManual.Checked = true;
                        rbAutomatica.Checked = false;
                    }
                    else
                    {
                        rbAutomatica.Checked = true;
                        rbManual.Checked = false;
                    }
                    chkMueveStock.Checked = _TipoMovimiento.MueveStock;
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Consultar);
                }
                else
                {
                    LimpiarPantalla();
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
                }
            }
            else if (e.KeyCode == Keys.Enter && txtCodigo.Text == "")
            {
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<TipoMovimientoN> TipoMovimientos = Negocios.FuncionesGlobales.TipoMovimientoS.ListarTipoMovimiento();
                    string[] cool = { "Id", "Nombre" };
                    txtCodigo.Parametros<TipoMovimientoN>(Keys.F3, cool, "Id", TipoMovimientos,"Nombre");

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtIdTipoComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtIdTipoComprobante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtIdTipoComprobante.Text != "")
            {
                _TipoComprobante = new TipoComprobanteN(int.Parse(txtIdTipoComprobante.Text));
                if (_TipoComprobante != null && _TipoComprobante.Id != 0)
                {
                    txtNombreComprobante.Text = _TipoComprobante.Nombre;
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<TipoComprobanteN> TipoComprobante = Negocios.FuncionesGlobales.TipoComprobanteS.ListarTipoComprobante();
                    string[] cool = { "Id", "Nombre" };
                    txtIdTipoComprobante.Parametros<TipoComprobanteN>(Keys.F3, cool, "Id", TipoComprobante, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
                {
                    _TipoMovimiento = new TipoMovimientoN(int.Parse(txtIdTipoComprobante.Text),
                                                          txtNombreTipoMovimiento.Text,
                                                          rbDebita.Checked == true ? "D" : "A",
                                                          rbAutomatica.Checked == true ? "A" : "M",
                                                          chkMueveStock.Checked);
                    if (_TipoMovimiento.Guardar())
                    {
                        MessageBox.Show("Se Creó el Tipo Movimiento " + txtNombreTipoMovimiento.Text + " con Exito");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
                else if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
                {
                    _TipoMovimiento = new TipoMovimientoN(int.Parse(txtCodigo.Text), int.Parse(txtIdTipoComprobante.Text),
                                      txtNombreTipoMovimiento.Text,
                                      rbDebita.Checked == true ? "D" : "A",
                                      rbAutomatica.Checked == true ? "A" : "M",
                                      chkMueveStock.Checked);
                    if (_TipoMovimiento.Actualizar())
                    {
                        MessageBox.Show("Se Actualizó el Tipo Movimiento " + txtNombreTipoMovimiento.Text + " con Exito");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
            }
        }

        private void rbDebita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebita.Checked == true)
            {
                rbAcredita.Checked = false;
            }
        }

        private void rbAcredita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcredita.Checked == true)
            {
                rbDebita.Checked = false;
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked == true)
            {
                rbAutomatica.Checked = false;
            }
        }

        private void rbAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomatica.Checked == true)
            {
                rbManual.Checked = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_TipoMovimiento.Eliminar())
            {
                MessageBox.Show("El Tipo de movimiento fue  eliminado con exito");
                LimpiarPantalla();
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
            }
        }
        #endregion

        #region Funciones
        private void LimpiarPantalla()
        {
            txtCodigo.Text = "";
            txtNombreTipoMovimiento.Text = "";
            txtIdTipoComprobante.Text = "";
            txtNombreComprobante.Text = "";
            rbDebita.Checked = true;
            rbAcredita.Checked = false;
            rbManual.Checked = true;
            rbAutomatica.Checked = false;
            chkMueveStock.Checked = false;
        }

        private void CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo _Modo)
        {
            if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Inicial)
            {
                txtCodigo.Enabled = true;
                txtNombreTipoMovimiento.Enabled = false;
                txtIdTipoComprobante.Enabled = false;
                txtNombreTipoMovimiento.Enabled = false;
                gbSigno.Enabled = false;
                gbNumeracion.Enabled = false;
                chkMueveStock.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCodigo.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Consultar)
            {
                txtCodigo.Enabled = false;
                txtNombreTipoMovimiento.Enabled = false;
                txtIdTipoComprobante.Enabled = false;
                txtNombreTipoMovimiento.Enabled = false;
                gbSigno.Enabled = false;
                gbNumeracion.Enabled = false;
                chkMueveStock.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                btnModificar.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                txtCodigo.Enabled = false;
                txtNombreTipoMovimiento.Enabled = true;
                txtIdTipoComprobante.Enabled = true;
                txtNombreTipoMovimiento.Enabled = true;
                gbSigno.Enabled = true;
                gbNumeracion.Enabled = true;
                chkMueveStock.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Agregar;
                txtNombreTipoMovimiento.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
            {
                txtCodigo.Enabled = false;
                txtNombreTipoMovimiento.Enabled = true;
                txtIdTipoComprobante.Enabled = true;
                txtNombreTipoMovimiento.Enabled = true;
                gbSigno.Enabled = true;
                gbNumeracion.Enabled = true;
                chkMueveStock.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
                txtNombreTipoMovimiento.Focus();
            }
        }

        private bool ControlErrores()
        {
            bool Retorno = true;
            if (txtNombreTipoMovimiento.Text =="")
            {
                epControlCampo.SetError(txtNombreTipoMovimiento, "Debe igresar un Nombre de Tipo de Movimiento");
                Retorno = false;
            }
            else
            {
                epControlCampo.Clear();
            }
            if (txtIdTipoComprobante.Text=="")
            {
                epControlCampo.SetError(txtIdTipoComprobante, "Debe Ingresar un Tipo de Comprobante");
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
