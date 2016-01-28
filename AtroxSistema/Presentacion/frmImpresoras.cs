using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmImpresoras : Form
    {
        #region Variables
        TipoComprobanteN _TipoComprobante;
        ImpresorasN _ImpresoraN;
        Negocios.FuncionesGlobales.Globales.Modo _Estado;
        #endregion

        #region Metodos
        public frmImpresoras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImpresoras_Load(object sender, EventArgs e)
        {
            txtEstacion.Text = Environment.MachineName;

            String impresorasInstaladas;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                impresorasInstaladas = PrinterSettings.InstalledPrinters[i];
                cmbImpresoras.Items.Add(impresorasInstaladas);
            }
        }

        private void txtIdTipoComprobante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtIdTipoComprobante.Text != "")
            {
                _TipoComprobante = new TipoComprobanteN(int.Parse(txtIdTipoComprobante.Text));
                if (_TipoComprobante != null && _TipoComprobante.Id != 0)
                {
                    txtNombreComprobante.ForeColor = Color.Black;
                    txtNombreComprobante.Text = _TipoComprobante.Nombre;

                    _ImpresoraN = new ImpresorasN(txtEstacion.Text, int.Parse(txtIdTipoComprobante.Text));
                    if (_ImpresoraN != null && _ImpresoraN.Id != 0)
                    {
                        cmbImpresoras.SelectedItem = _ImpresoraN.Impresora;
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Consultar);
                    }
                    else
                    {
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
                    }
                }
                else
                {
                    txtNombreComprobante.ForeColor = Color.Red;
                    txtNombreComprobante.Text = "El Comprobante no Existe";
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<TipoComprobanteN> TipoComprobante = Negocios.FuncionesGlobales.TipoComprobanteS.ListarTipoComprobante();
                    string[] cool = { "Id", "Nombre" };
                    txtIdTipoComprobante.Parametros<TipoComprobanteN>(Keys.F3, cool, "Id", TipoComprobante,"Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_ImpresoraN.Eliminar())
            {
                MessageBox.Show("Se eliminó la impresora correctamente");
                LimpiarPantalla();
                CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Modificar);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
                {
                    _ImpresoraN = new ImpresorasN(txtEstacion.Text, int.Parse(txtIdTipoComprobante.Text), cmbImpresoras.Text);
                    if (_ImpresoraN.Guardar())
                    {
                        MessageBox.Show("Se Grabó la impresora Correctamente");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
                else if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
                {
                    _ImpresoraN = new ImpresorasN(txtEstacion.Text, int.Parse(txtIdTipoComprobante.Text), cmbImpresoras.Text);
                    if (_ImpresoraN.Actualizar())
                    {
                        MessageBox.Show("Se Actualizó la impresora Correctamente");
                        LimpiarPantalla();
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                    }
                }
            }
        }
        #endregion

        #region Funciones
        private void LimpiarPantalla()
        {
            txtIdTipoComprobante.Text = "";
            txtNombreComprobante.Text = "";
            cmbImpresoras.SelectedIndex = -1;
        }

        private void CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo _Modo)
        {
            if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Inicial)
            {
                txtIdTipoComprobante.Enabled = true;
                cmbImpresoras.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                txtIdTipoComprobante.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Consultar)
            {
                txtIdTipoComprobante.Enabled = false;
                cmbImpresoras.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                btnModificar.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                txtIdTipoComprobante.Enabled = false;
                cmbImpresoras.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Agregar;
                cmbImpresoras.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
            {
                txtIdTipoComprobante.Enabled = false;
                cmbImpresoras.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
                cmbImpresoras.Focus();
            }
        }

        private bool ControlErrores()
        {
            bool Retorno = true;
            if (cmbImpresoras.Text == "")
            {
                epControlCampo.SetError(cmbImpresoras, "Debe Seleccionar una Impresora");
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
