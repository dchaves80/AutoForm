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
    public partial class frmEmpresa : Form
    {
        EmpresaN _Empresa;
        Negocios.FuncionesGlobales.CUIT _CUIT;
        
        public frmEmpresa()
        {
            InitializeComponent();
            
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;

            cmbCategoriaAfip.DataSource = Negocios.FuncionesGlobales.AfipS.ObtenerCategoriasAfip(null);
            cmbCategoriaAfip.DisplayMember = "Nombre";
            cmbCategoriaAfip.ValueMember = "IdCategoriaafip";
            _Empresa = new EmpresaN();
            if (_Empresa.Succed == true)
            {
                txtNombre.Text = _Empresa.RazonSocial;
                txtIngBrut.Text = _Empresa.IngresosBrutos;
                txtNomFant.Text = _Empresa.NombreFantasia;
                txtCUIT.Text = _Empresa.Cuit;
                dtpInicioActi.Text = _Empresa.InicioActividad.ToShortDateString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                cmbCategoriaAfip.SelectedValue = _Empresa.CategoriaAFIP;
            }

            else
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("Establezca su empresa");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

   


        }

        private void LimpiarPantalla()
        {
            txtNombre.Text = "";
            txtCUIT.Text = "";
            txtIngBrut.Text = "";
            txtNomFant.Text = "";
            cmbCategoriaAfip.SelectedValue = 1;
            dtpInicioActi.Text = DateTime.Now.ToShortDateString();
        
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro permanentemente?","Eliminar registro",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
            {
                if (_Empresa.Eliminar() == true)
                {

                    LimpiarPantalla();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnGrabar.Enabled = true;
                    MessageBox.Show("El registro se elimino exitosamente");

                }
                else
                {
                    MessageBox.Show("El registro de empresa no se pudo eliminar.\nContacte a su programador");
                }    
            }
            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
            _Empresa.RazonSocial = txtNombre.Text;
            _Empresa.NombreFantasia = txtNomFant.Text;
            _Empresa.Cuit = txtCUIT.Text;
            _Empresa.IngresosBrutos = txtIngBrut.Text;
            _Empresa.InicioActividad = DateTime.Parse(dtpInicioActi.Text);
            _Empresa.CategoriaAFIP = int.Parse(cmbCategoriaAfip.SelectedValue.ToString());
            _Empresa.Actualizar();
            MessageBox.Show("Actualizado con exito");
            }
            else
            {
                MessageBox.Show("Revise los campos obligatorios\nSi el problema persiste contacte a sus programadores.");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlErrores())
            {
                _Empresa = new EmpresaN(txtNombre.Text,
                                        txtNomFant.Text, 
                                        txtCUIT.Text, 
                                        txtIngBrut.Text, 
                                        DateTime.Parse(dtpInicioActi.Text), 
                                        int.Parse(cmbCategoriaAfip.SelectedValue.ToString()));
            
                MessageBox.Show("Grabo con exito");
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnGrabar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Revise los campos e intente nuevamente.\nSi el problema persiste contacte a sus programadores");
            }
        }
        private bool ControlErrores()
        {
            bool Retorno = true;
            if (txtNombre.Text == "")
            {
                epControlCampos.SetError(txtNombre, "Debe ingresar el nombre de la Empresa");
                Retorno = false;
            }
            else
            {
                epControlCampos.Clear();
            }
            if (txtIngBrut.Text == "")
            {
                epControlCampos.SetError(txtIngBrut, "Debe ingresar el numero de Igresos Brutos");
                Retorno = false;
            }
            else
            {
                epControlCampos.Clear();
            }         
            _CUIT = new Negocios.FuncionesGlobales.CUIT(txtCUIT.Text);
            if (_CUIT.EsValido)
            {
                epControlCampos.Clear();
            }
            else
            {
                epControlCampos.SetError(txtCUIT, "Debe ingresar el numero de CUIT");
                Retorno = false;
            }
            return Retorno;
        }

        private void txtIngBrut_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.Globales.SoloNumero(e);
        }

    }

}
