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
using Negocios.FuncionesGlobales;


namespace Presentacion
{
    public partial class frmCuenta : Form
    {
        CuentaN _Cuenta;
        Negocios.FuncionesGlobales.Globales.Modo _Estado = Negocios.FuncionesGlobales.Globales.Modo.Inicial;

        public frmCuenta()
        {
            InitializeComponent();

        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {


            cmbCategoriaAFIP.DataSource = Negocios.FuncionesGlobales.AfipS.ObtenerCategoriasAfip(null);
            cmbCategoriaAFIP.DisplayMember = "Nombre";
            cmbCategoriaAFIP.ValueMember = "Idcategoriaafip";
            


            cmbTipoDoc.DataSource = Negocios.FuncionesGlobales.AfipS.ObtenerTipoDocumentoAfip(null);
            cmbTipoDoc.DisplayMember = "nombre";
            cmbTipoDoc.ValueMember = "Idtipodocumentoafip";
            



        }
        private void llenargrilla(Boolean Tipodecuenta)
        {
            List<CuentaN> Lista = Negocios.FuncionesGlobales.CuentaS.ListarCuentasPorTipo(Tipodecuenta);
            if (Lista != null)
            {
                for (int a = 0; a < Lista.Count; a++)
                {

                    dgvclipro.Rows.Add();
                    dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["ID"].Value = Lista[a].Id;
                    dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["Nombre"].Value = Lista[a].Nombre;
                    dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["Mail"].Value = Lista[a].Mail;
                    dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["Telefono"].Value = Lista[a].Telefono;

                }  
            } 
        }



        private void radiobProveedor_CheckedChanged(object sender, EventArgs e)
        {
           
            
                Limpiargrilla();
                Bloqueartxt();
                llenargrilla(true);
                txtBusqueda.Text = "";
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                Limpiarpantalla();    
            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Agregar)
                {
                    _Cuenta = new CuentaN(
                        txtNombre.Text,
                        txtNombreFantasia.Text == "" ? null : txtNombreFantasia.Text,
                        Globales.ConvertInt(cmbCategoriaAFIP.SelectedValue.ToString()),
                        Globales.ConvertInt(cmbTipoDoc.SelectedValue.ToString()),
                        txtNumeroDoc.Text == "" ? null : txtNumeroDoc.Text,
                        txtIngBrutos.Text == "" ? null : txtIngBrutos.Text,
                        Globales.ConvertInt(txtCodigoLocalidad.Text),
                        txtDomicilio.Text== "" ? null : txtDomicilio.Text,
                        Globales.ConvertInt(txtNumeroDomicilio.Text),
                        Globales.ConvertInt(txtPiso.Text),
                        txtDepartamento.Text== "" ? null : txtDepartamento.Text,
                        chkProveedor.Checked,
                        txtMail.Text== "" ? null : txtMail.Text,
                        txtTelefono.Text== "" ? null : txtTelefono.Text);


                    if (_Cuenta.Guardar())
                    {
                        dgvclipro.Rows.Add();
                        dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["ID"].Value = _Cuenta.Id;
                        dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["Nombre"].Value = _Cuenta.Nombre;
                        dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["mail"].Value = _Cuenta.Mail;
                        dgvclipro.Rows[dgvclipro.Rows.Count - 1].Cells["Telefono"].Value = _Cuenta.Telefono;

                    }
                    else
                    {
                        MessageBox.Show("La cuenta no a sido guardada, Intente nuevamente.\nDe lo contrario contacte a sus programadores.");
                    }
                }
                if (_Estado == Negocios.FuncionesGlobales.Globales.Modo.Modificar)
                {
                    _Cuenta.Departamento = txtDepartamento.Text;
                    _Cuenta.Domicilio = txtDomicilio.Text;
                    _Cuenta.NroIngresosBrutos = txtIngBrutos.Text;
                    _Cuenta.IdLocalidad = int.Parse(txtCodigoLocalidad.Text);
                    _Cuenta.Mail = txtMail.Text;
                    _Cuenta.Nombre = txtNombre.Text;
                    _Cuenta.NombreFantasia = txtNombreFantasia.Text;
                    _Cuenta.NroDocumento = txtNumeroDoc.Text;
                    _Cuenta.NroDomicilio = int.Parse(txtNumeroDomicilio.Text);
                    _Cuenta.Piso = int.Parse(txtPiso.Text);
                    _Cuenta.Telefono = txtTelefono.Text;
                    _Cuenta.IdCategoriaAfip = int.Parse(cmbCategoriaAFIP.SelectedValue.ToString());
                    _Cuenta.IdTipoDocumento = int.Parse(cmbTipoDoc.SelectedValue.ToString());
                    if (_Cuenta.Actualizar())
                    {
                        MessageBox.Show("El Registro se modifico correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El registro no se ha modificado");
                    }
                }
                Limpiarpantalla();
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                Bloqueartxt();
            }
            else
            {
                MessageBox.Show("Revise los campos campos obligatorios");
            }
        }
        private void Limpiarpantalla()
        {
            txtDepartamento.Text = "";
            txtDomicilio.Text = "";
            txtId.Text = "";
            txtIngBrutos.Text = "";
            txtNombreLocalidad.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            txtNombreFantasia.Text = "";
            txtNumeroDoc.Text = "";
            txtNumeroDomicilio.Text = "";
            txtPiso.Text = "";
            txtTelefono.Text = "";
            cmbTipoDoc.SelectedValue = 96;
            cmbCategoriaAFIP.SelectedValue = 5;

        }
        private void Limpiargrilla()
        {
            dgvclipro.Rows.Clear();

        }


        private void dgvclipro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiarpantalla();
            int Id = int.Parse(dgvclipro.Rows[e.RowIndex].Cells["id"].Value.ToString());
            _Cuenta = new CuentaN(Id);
            txtDepartamento.Text = _Cuenta.Departamento;
            txtDomicilio.Text = _Cuenta.Domicilio;
            txtId.Text = _Cuenta.Id.ToString();
            txtIngBrutos.Text = _Cuenta.NroIngresosBrutos;
            txtNombreLocalidad.Text = _Cuenta.IdLocalidad.ToString();
            txtCodigoLocalidad.Text = _Cuenta.IdLocalidad.ToString();
            txtMail.Text = _Cuenta.Mail;
            txtNombre.Text = _Cuenta.Nombre;
            txtNombreFantasia.Text = _Cuenta.NombreFantasia;
            txtNumeroDoc.Text = _Cuenta.NroDocumento;
            txtNumeroDomicilio.Text = _Cuenta.NroDomicilio.ToString();
            txtPiso.Text = _Cuenta.Piso.ToString();
            txtTelefono.Text = _Cuenta.Telefono;
            cmbCategoriaAFIP.SelectedValue = _Cuenta.IdCategoriaAfip;
            cmbTipoDoc.SelectedValue = _Cuenta.IdTipoDocumento;
            chkProveedor.Checked = _Cuenta.Proveedor;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            Bloqueartxt();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiarpantalla();
            cmbCategoriaAFIP.SelectedValue = 5;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_Cuenta.Eliminar())
            {
                MessageBox.Show("Cuenta eliminada correctamente");
                Limpiargrilla();
                if (chkProveedor.Checked)
                {
                    llenargrilla(true);
                }
                else
                {
                    llenargrilla(false);
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            _Estado = Negocios.FuncionesGlobales.Globales.Modo.Modificar;
            DesbloquearTxt();

        }

        private void radiobCliente_CheckedChanged(object sender, EventArgs e)
        {
            Limpiargrilla();
            Limpiarpantalla();
            Bloqueartxt();
            llenargrilla(false);
            txtBusqueda.Text = "";
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            chkProveedor.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvclipro.Rows.Count; i++)
            {
                if (dgvclipro.Rows[i].Cells["nombre"].Value.ToString().Contains(txtBusqueda.Text))
                {
                    dgvclipro.Rows[i].Visible = true;
                }

                else
                {
                    dgvclipro.Rows[i].Visible = false;
                }
            }
        }

        private void dgvclipro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _Estado = Negocios.FuncionesGlobales.Globales.Modo.Agregar;



            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            radiobCliente.Checked = false;
            radiobProveedor.Checked = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            chkProveedor.Checked = false;
            Limpiargrilla();
            DesbloquearTxt();
            Limpiarpantalla();
            txtNombre.Focus();
            
            
        }
        private void Bloqueartxt()
        {
            txtDepartamento.Enabled = false;
            txtDomicilio.Enabled = false;
            txtIngBrutos.Enabled = false;
            txtNombreLocalidad.Enabled = false;
            txtMail.Enabled = false;
            txtNombre.Enabled = false;
            txtNombreFantasia.Enabled = false;
            txtNumeroDoc.Enabled = false;
            txtNumeroDomicilio.Enabled = false;
            txtPiso.Enabled = false;
            txtTelefono.Enabled = false;
            cmbCategoriaAFIP.Enabled = false;
            cmbTipoDoc.Enabled = false;
            chkProveedor.Enabled = false;
            txtCodigoLocalidad.Enabled = false;

        }

        private void DesbloquearTxt()
        {
            txtDepartamento.Enabled = true;
            txtDomicilio.Enabled = true;
            txtIngBrutos.Enabled = true;
            txtNombreLocalidad.Enabled = true;
            txtMail.Enabled = true;
            txtNombre.Enabled = true;
            txtNombreFantasia.Enabled = true;
            txtNumeroDoc.Enabled = true;
            txtNumeroDomicilio.Enabled = true;
            txtPiso.Enabled = true;
            txtTelefono.Enabled = true;
            cmbCategoriaAFIP.Enabled = true;
            cmbTipoDoc.Enabled = true;
            chkProveedor.Enabled = true;
            txtCodigoLocalidad.Enabled = true;
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloLetras(e);
        }

        private void txtIngBrutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloLetras(e);
        }

        private void txtNumeroDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.NumeroConDecimal(e);
        }

        private bool ControlErrores()
        {
            bool Retorno = true;
            if (txtNombre.Text == "")
            {
                epControlCampos.SetError(txtNombre, "Debe ingresar un Nombre de Cuenta");
                Retorno = false;
            }
            else
            {
                epControlCampos.Clear();
            }
            return Retorno;
        }

        private void txtCodigoLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                List<LocalidadN> Localidades = Negocios.FuncionesGlobales.LocalidadS.ListarLocalidades();
                string[] cool = { "Id", "Nombre" };
                txtCodigoLocalidad.Parametros<LocalidadN>(Keys.F3, cool, "Id", Localidades, "Nombre");
            }
            else if (e.KeyCode == Keys.Enter && txtCodigoLocalidad.Text!="")
            {
                int _idlocalidad = int.Parse(txtCodigoLocalidad.Text);
                LocalidadN _Localidad = new LocalidadN(_idlocalidad);
                if (_Localidad.Succed == true)
                {
                    txtNombreLocalidad.ForeColor = Color.Black;
                    txtNombreLocalidad.Text = _Localidad.Nombre;
                }
                else 
                {
                    txtNombreLocalidad.ForeColor = Color.Red;
                    txtNombreLocalidad.Text = "Error en localidad...!";
                }
            }
        }
    }
}
