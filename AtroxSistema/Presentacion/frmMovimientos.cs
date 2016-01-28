using Negocios;
using Reportes;
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
    public partial class frmMovimientos : Form
    {
        #region Definiciones
        Negocios.FuncionesGlobales.Globales.Modo _Estado;
        TipoMovimientoN _TipoMovimiento;
        MovimientoN _Movimiento;
        DetalleMovimientoN _DetalleMovimiento;
        TipoComprobanteN _TipoComprobante;
        ArticuloN _Articulo;
        ImpresorasN _ImpresoraN;
        CuentaN _Cuenta;
        public int Copias;
        int TipoComprobante;
        int ClaveMov;
        #endregion

        #region Metodos

        MovimientoN _MovimientoActual = null;

        public frmMovimientos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPuntoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtNroComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }


        private void LlenarDTGV(List<DetalleMovimientoN> p_listamovimientos)
        {

            for (int a = 0; a < p_listamovimientos.Count; a++)
            {

                dgvDetalle.Rows.Add();
                dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colIdArticulo"].Value = p_listamovimientos[a].IdArticulo;
                dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colNombreArticulo"].Value = p_listamovimientos[a].ObtenerArticulo().Nombre;
                dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colPrecioUnitario"].Value = p_listamovimientos[a].PrecioUnitario;
                dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colCantidad"].Value = p_listamovimientos[a].Cantidad;
                dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colIVA"].Value = p_listamovimientos[a].ObtenerArticulo().IVA;
                dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colSubTotal"].Value = p_listamovimientos[a].ImporteSubtotal;

            }

            dgvDetalle.ClearSelection();
            txtImporteIVA.Text = (p_listamovimientos[0].ObtenerMovimiento().ImporteIVA).ToString();
            txtImporteNeto.Text = (p_listamovimientos[0].ObtenerMovimiento().ImporteNeto).ToString();
            txtImporteTotal.Text = (p_listamovimientos[0].ObtenerMovimiento().ImporteNeto + p_listamovimientos[0].ObtenerMovimiento().ImporteIVA).ToString();



        }

        public void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCuenta.Text != "")
            {
                _Cuenta = new CuentaN(int.Parse(txtCuenta.Text));

                if (_Cuenta.Succed)
                {
                    txtNombreCuenta.Text = _Cuenta.Nombre;
                    
                }
                else
                {
                    txtCuenta.Text = "";
                    MessageBox.Show("La Cuenta ingresada no existe");
                }

                /* if (txtIdTipoMov.Text != "" && txtPuntoVenta.Text != "" && txtCuenta.Text != "" && ((txtNroComprobante.Text != "" && _TipoMovimiento.Numeracion == "M") || (txtNroComprobante.Text == "" && _TipoMovimiento.Numeracion == "A")))
                 {*/

                if (txtIdTipoMov.Text != "")
                {
                   
                    _Movimiento = new MovimientoN(int.Parse(txtIdTipoMov.Text), int.Parse(txtPuntoVenta.Text), int.Parse(txtNroComprobante.Text == "" ? "0" : txtNroComprobante.Text), int.Parse(txtCuenta.Text));
                    if (_Movimiento.Id != 0)
                    {
                        ClaveMov = _Movimiento.Id;
                        txtFechaComprobante.Text = _Movimiento.Fecha.ToShortDateString();
                        cmbCondicionPago.SelectedValue = _Movimiento.CondicionDePago;
                        txtFechaContabilizacion.Text = _Movimiento.FechaContabilizacion.ToShortDateString();
                        txtObservaciones.Text = _Movimiento.Observacion;
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Consultar);
                        if (_Movimiento.ListarDetalles().Count > 0)
                        {
                            LlenarDTGV(_Movimiento.ListarDetalles());
                        }
                        _MovimientoActual = _Movimiento;
                        btnModificar.Enabled = false;
                        btnGrabar.Enabled = false;
                        btnAnular.Enabled = true;
                    }
                    else
                    {
                        btnAnular.Enabled = false;
                        CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Agregar);
                        if (_TipoMovimiento.Numeracion == "A")
                        {
                            txtNroComprobante.Text = "";
                        }
                    }
                }
                //}
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<CuentaN> Cuentas = Negocios.FuncionesGlobales.CuentaS.ListadoCuentas();
                    string[] cool = { "Id", "Nombre" };
                    txtCuenta.Parametros<CuentaN>(Keys.F3, cool, "Id", Cuentas, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            frmCantidadCopíasImprimir Imprimir = new frmCantidadCopíasImprimir();
            _TipoComprobante = new TipoComprobanteN(TipoComprobante);
            Imprimir.Copias = _TipoComprobante.Copias;
            Imprimir.ShowDialog();
            _ImpresoraN = new ImpresorasN(Environment.MachineName, TipoComprobante);
            if (Imprimir.Copias != 0)
            {
                switch (TipoComprobante)
                {
                    case 1:
                        Reportes.Formularios.frmFacturaFactureroA FormA = new Reportes.Formularios.frmFacturaFactureroA(ClaveMov, Imprimir.Copias, _ImpresoraN.Impresora);
                        break;
                    case 6:
                        Reportes.Formularios.frmFacturaFactureroB FormB = new Reportes.Formularios.frmFacturaFactureroB(ClaveMov, Imprimir.Copias, _ImpresoraN.Impresora);
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void frmMovimientos_Load(object sender, EventArgs e)
        {
            cmbCondicionPago.DataSource = Negocios.FuncionesGlobales.CondicionDePagoS.ListarCondicionesDePago();
            cmbCondicionPago.DisplayMember = "Nombre";
            cmbCondicionPago.ValueMember = "Id";
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);

        }

        private void txtIdTipoMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtIdTipoMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtIdTipoMov.Text != "")
            {
                _TipoMovimiento = new TipoMovimientoN(int.Parse(txtIdTipoMov.Text));
                if (_TipoMovimiento != null && _TipoMovimiento.Id != 0)
                {
                    txtNombreTipoMov.Text = _TipoMovimiento.Nombre;
                    TipoComprobante = _TipoMovimiento.IdTipoComprobante;

                }
                else
                {
                    LimpiarPantalla();
                    MessageBox.Show("El Tipo Movimiento no existe");
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<TipoMovimientoN> TipoMovimientos = Negocios.FuncionesGlobales.TipoMovimientoS.ListarTipoMovimiento();
                    string[] cool = { "Id", "Nombre" };
                    txtIdTipoMov.Parametros<TipoMovimientoN>(Keys.F3, cool, "Id", TipoMovimientos, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Modificar);
        }
        #endregion

        #region Funciones
        private void LimpiarPantalla()
        {
            txtIdTipoMov.Text = "";
            txtNombreTipoMov.Text = "";
            txtPuntoVenta.Text = "";
            txtNroComprobante.Text = "";
            txtFechaComprobante.Text = DateTime.Now.ToShortDateString();
            txtCuenta.Text = "";
            txtNombreCuenta.Text = "";
            txtFechaContabilizacion.Text = DateTime.Now.ToShortDateString();
            txtObservaciones.Text = "";
            txtCodArt.Text = "";
            txtNombreArticulo.Text = "";
            dgvDetalle.Rows.Clear();
            Calculardetalle(null);
        }

        private void CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo _Modo)
        {
            if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Inicial)
            {
                txtIdTipoMov.Enabled = true;
                txtPuntoVenta.Enabled = true;
                txtNroComprobante.Enabled = true;
                txtFechaComprobante.Enabled = true;
                txtCuenta.Enabled = true;
                cmbCondicionPago.Enabled = false;
                txtFechaContabilizacion.Enabled = false;
                txtObservaciones.Enabled = false;
                dgvDetalle.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                pnlDetalle.Enabled = false;
                btnImprimir.Enabled = false;
                btnBuscarMovimiento.Enabled = true;
                txtIdTipoMov.Focus();
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Consultar)
            {
                txtIdTipoMov.Enabled = false;
                txtPuntoVenta.Enabled = false;
                txtNroComprobante.Enabled = false;
                txtFechaComprobante.Enabled = false;
                txtCuenta.Enabled = false;
                cmbCondicionPago.Enabled = false;
                txtFechaContabilizacion.Enabled = false;
                txtObservaciones.Enabled = false;
                dgvDetalle.Enabled = false;
                btnGrabar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                pnlDetalle.Enabled = false;
                btnImprimir.Enabled = true;
                btnModificar.Focus();
                btnBuscarMovimiento.Enabled = false;
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
            {
                txtIdTipoMov.Enabled = false;
                txtPuntoVenta.Enabled = false;
                txtNroComprobante.Enabled = false;
                txtFechaComprobante.Enabled = false;
                txtCuenta.Enabled = false;
                cmbCondicionPago.Enabled = true;
                txtFechaContabilizacion.Enabled = true;
                txtObservaciones.Enabled = true;
                dgvDetalle.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                pnlDetalle.Enabled = true;
                btnBuscarMovimiento.Enabled = false;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Agregar;
                cmbCondicionPago.Focus();
                
            }
            else if (_Modo == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
            {
                txtIdTipoMov.Enabled = false;
                txtPuntoVenta.Enabled = false;
                txtNroComprobante.Enabled = false;
                txtFechaComprobante.Enabled = false;
                txtCuenta.Enabled = false;
                cmbCondicionPago.Enabled = true;
                txtFechaContabilizacion.Enabled = true;
                txtObservaciones.Enabled = true;
                dgvDetalle.Enabled = true;
                btnGrabar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                pnlDetalle.Enabled = true;
                _Estado = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
                cmbCondicionPago.Focus();
            }
        }
        #endregion

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (dgvDetalle.Rows.Count != 0)
            {

                int _IdTipoMovimiento = int.Parse(txtIdTipoMov.Text);
                int _PuntoVenta = int.Parse(txtPuntoVenta.Text);
                int _NroMovimiento = int.Parse(txtNroComprobante.Text == "" ? "0" : txtNroComprobante.Text);
                DateTime _Fecha = Convert.ToDateTime(txtFechaComprobante.Text);
                decimal _ImporteNeto = decimal.Parse(txtImporteNeto.Text);
                decimal _ImporteIVA = decimal.Parse(txtImporteIVA.Text);
                int _IdCuenta = int.Parse(txtCuenta.Text);
                string _Observacion = txtObservaciones.Text;
                string _CAE = "nulaso";
                DateTime _FechaVencimientoCAE = DateTime.Now;
                DateTime _FechaContabilizacion = DateTime.Parse(txtFechaContabilizacion.Text);
                int _IdCondicionPago = int.Parse(cmbCondicionPago.SelectedValue.ToString());

                MovimientoN t_MVN = new MovimientoN(_IdTipoMovimiento, _PuntoVenta, _NroMovimiento, _Fecha, _ImporteNeto, _ImporteIVA, _IdCuenta, _Observacion, _CAE, _FechaVencimientoCAE, _FechaContabilizacion, _IdCondicionPago);

                if (t_MVN.Guardar() == true)
                {
                    for (int a = 0; a < dgvDetalle.Rows.Count; a++)
                    {
                        DataGridViewRow _DR = dgvDetalle.Rows[a];



                        int _idArt = int.Parse(_DR.Cells[colIdArticulo.Index].Value.ToString());
                        decimal _Importe = decimal.Parse(_DR.Cells[colPrecioUnitario.Index].Value.ToString());
                        int _cantidad = int.Parse(_DR.Cells[colCantidad.Index].Value.ToString());
                        decimal __importeSubTotal = decimal.Parse(_DR.Cells[colSubTotal.Index].Value.ToString());

                        t_MVN.AgregarDetalle((Entidades.DetalleMovimientoE)new Negocios.DetalleMovimientoN(_idArt, _Importe, t_MVN, _cantidad));
                        _Movimiento = t_MVN;


                    }
                    if (t_MVN.GuardarDetalles() == true)
                    {
                        MessageBox.Show("Movimiento almacenado con éxito");

                    }
                    else
                    {
                        MessageBox.Show("Problema al guardar el movimiento");
                    }

                    LimpiarPantalla();
                    CambiarModoPantalla(Negocios.FuncionesGlobales.Globales.Modo.Inicial);
                }


            }
            else
            {
                MessageBox.Show("Debe insertar un detalle en el movimiento");
                ttAyuda.Show("Inserte un articulo por medio de este boton...", btnNuevo, 2000);
            }
        }

        private void atroxTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.None)
            {
                try
                {
                    List<ArticuloN> Articulos = Negocios.FuncionesGlobales.ArticulosS.ListarArticulos();
                    string[] cool = { "Id", "Nombre", "PrecioSugerido" };
                    txtCodArt.Parametros<ArticuloN>(cool, "Id", Articulos);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }

            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<ArticuloN> Articulos = Negocios.FuncionesGlobales.ArticulosS.ListarArticulos();
                    string[] cool = { "Id", "Nombre", "PrecioSugerido" };
                    txtCodArt.Parametros<ArticuloN>(Keys.F3, cool, "Id", Articulos, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                

                    ArticuloN _Art = new ArticuloN(int.Parse(txtCodArt.Text==""?"0":txtCodArt.Text));
                if (_Art.Succed == true)
                {
                    txtNombreArticulo.Text = _Art.Nombre;
                }
            }
        }

        private void txtCodArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void btnInsertarArt_Click(object sender, EventArgs e)
        {
            if (txtCodArt.Text != "")
            {

                ArticuloN _Art = new ArticuloN(int.Parse(txtCodArt.Text));
                if (dgvDetalle.SelectedCells.Count == 0)
                {
                    if (_Art.Succed == true)
                    {
                        dgvDetalle.Rows.Add();
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colIdArticulo"].Value = _Art.Id.ToString();
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colNombreArticulo"].Value = _Art.Nombre;
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colPrecioUnitario"].Value = _Art.PrecioSugerido.ToString("#0.00");
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colCantidad"].Value = 1;
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colIVA"].Value = _Art.IVA;
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["colSubTotal"].Value = _Art.PrecioSugerido.ToString("#0.00");
                        dgvDetalle.ClearSelection();
                        Calculardetalle(null);
                        txtNombreArticulo.Text = "";
                        txtCodArt.Text = "";
                        txtCodArt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Articulo inxistente");
                    }
                }
                else
                {
                    DataGridViewRow _DR = dgvDetalle.Rows[dgvDetalle.SelectedCells[0].RowIndex];
                    _DR.Cells["colIdArticulo"].Value = _Art.Id.ToString();
                    _DR.Cells["colNombreArticulo"].Value = _Art.Nombre;
                    _DR.Cells["colPrecioUnitario"].Value = _Art.PrecioSugerido.ToString("#0.00");
                    _DR.Cells["colCantidad"].Value = 1;
                    _DR.Cells["colIVA"].Value = _Art.IVA;
                    _DR.Cells["colSubTotal"].Value = _Art.PrecioSugerido.ToString("#0.00");
                    dgvDetalle.ClearSelection();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvDetalle.ClearSelection();
            txtCodArt.Focus();
            atroxTextBox1_KeyDown(txtCodArt, new KeyEventArgs(Keys.None));
        }

        private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value != null && dgvDetalle.Rows[e.RowIndex].Cells[colPrecioUnitario.Index].Value != null && dgvDetalle.Rows[e.RowIndex].Cells[colIVA.Index].Value != null)
                {
                    if (dgvDetalle.Columns[e.ColumnIndex] == colCantidad)
                    {
                        Calculardetalle(e);
                    }
                    if (dgvDetalle.Columns[e.ColumnIndex] == colPrecioUnitario)
                    {
                        Calculardetalle(e);
                    }
                }
            }
        }

        private void Calculardetalle(DataGridViewCellEventArgs e)
        {
            if (e != null)
            {

                int _cantidad = int.Parse(dgvDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value.ToString());
                decimal _precio = decimal.Parse(dgvDetalle.Rows[e.RowIndex].Cells[colPrecioUnitario.Index].Value.ToString());
                decimal _total = _cantidad * _precio;
                dgvDetalle.Rows[e.RowIndex].Cells[colSubTotal.Index].Value = _total.ToString();
            }
            decimal _subtotales = 0;
            decimal _importeneto = 0;
            decimal _totalitativa = 0;
            for (int a = 0; a < dgvDetalle.Rows.Count; a++)
            {
                _subtotales += decimal.Parse(dgvDetalle.Rows[a].Cells[colSubTotal.Index].Value.ToString());
                _importeneto += decimal.Parse(dgvDetalle.Rows[a].Cells[colSubTotal.Index].Value.ToString()) / (decimal.Parse(dgvDetalle.Rows[a].Cells[colIVA.Index].Value.ToString()) / 100 + 1);
            }
            txtImporteIVA.Text = (_subtotales - _importeneto).ToString("#0.00");
            txtImporteNeto.Text = _importeneto.ToString("#0.00");
            txtImporteTotal.Text = _subtotales.ToString("#0.00");
        }

        private void dgvDetalle_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvDetalle.Rows[e.RowIndex].Cells[colEliminar.Index].Value = false;
                dgvDetalle.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnBuscarMovimiento_Click(object sender, EventArgs e)
        {
            if (txtIdTipoMov.Text != "") 
            {
                int _IDTIPOMOV = int.Parse(txtIdTipoMov.Text);

                Controls.BuscarMovimientos _BM = new Controls.BuscarMovimientos(Negocios.FuncionesGlobales.MovimientoS.ListarMovimientosPorIdTipoMov(_IDTIPOMOV),txtPuntoVenta,txtNroComprobante,txtCuenta);
                _BM.EH_DoubleClick += _BM_EH_DoubleClick;
                _BM.ShowDialog();
            } else 
            {

            }
        }

        void _BM_EH_DoubleClick(object sender, object e)
        {
            txtCuenta_KeyDown(this, new KeyEventArgs(Keys.Enter));
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (_MovimientoActual != null) 
            {
                DialogResult DR = MessageBox.Show("Esta seguro que desea eliminar este movimiento", "Eliminacion de movimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DR == DialogResult.Yes) 
                {
                    if (_MovimientoActual.Anular() == true)
                    {
                        MessageBox.Show("El movimiento se eliminoexitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Problema al eliminar movimiento", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
