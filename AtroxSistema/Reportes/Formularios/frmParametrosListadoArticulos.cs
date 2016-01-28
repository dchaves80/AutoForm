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

namespace Reportes.Formularios
{
    public partial class frmParametrosListadoArticulos : Form
    {
        #region Variables
        string Categorias;
        #endregion

        #region Metodos
        public frmParametrosListadoArticulos()
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ValoresXDefecto();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categorias = "0";
            for (int i = 0; i < dgvCategorias.RowCount; i++)
            {
                if (bool.Parse(dgvCategorias.Rows[i].Cells["Seleccionar"].Value.ToString()) == true)
                {
                    Categorias = Categorias + "," + dgvCategorias.Rows[i].Cells["Id"].Value.ToString();
                }
            }
            frmListarArticulos Form = new frmListarArticulos(int.Parse(txtArticuloDesde.Text), int.Parse(txtArticuloHasta.Text), int.Parse(txtCuentaDesde.Text), int.Parse(txtCuentaHasta.Text), Categorias);
            Form.Show();
        }

        private void frmParametrosListadoArticulos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ValoresXDefecto();
        }

        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            SeleccionarGrilla("SeleccionarTodo");
        }

        private void btnInvertirSeleccion_Click(object sender, EventArgs e)
        {
            SeleccionarGrilla("InvertirSeleccion");
        }

        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            SeleccionarGrilla("DeseleccionarTodo");
        }

        private void txtArticuloDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<ArticuloN> Articulos = Negocios.FuncionesGlobales.ArticulosS.ListarArticulos();
                    string[] cool = { "Id", "Nombre" };
                    txtArticuloDesde.Parametros<ArticuloN>(Keys.F3, cool, "Id", Articulos,"Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtArticuloHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<ArticuloN> Articulos = Negocios.FuncionesGlobales.ArticulosS.ListarArticulos();
                    string[] cool = { "Id", "Nombre" };
                    txtArticuloHasta.Parametros<ArticuloN>(Keys.F3, cool, "Id", Articulos, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtCuentaDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<CuentaN> Cuentas = Negocios.FuncionesGlobales.CuentaS.ListadoCuentas();
                    string[] cool = { "Id", "Nombre" };
                    txtCuentaDesde.Parametros<CuentaN>(Keys.F3, cool, "Id", Cuentas, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtCuentaHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    List<CuentaN> Cuentas = Negocios.FuncionesGlobales.CuentaS.ListadoCuentas();
                    string[] cool = { "Id", "Nombre" };
                    txtCuentaDesde.Parametros<CuentaN>(Keys.F3, cool, "Id", Cuentas, "Nombre");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.StackTrace);
                    throw;
                }
            }
        }

        private void txtCuentaHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCuentaDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtArticuloHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtArticuloDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Funciones
        private void ValoresXDefecto()
        {
            txtArticuloDesde.Text = "0";
            txtArticuloHasta.Text = "99999";
            txtCuentaDesde.Text = "0";
            txtCuentaHasta.Text = "99999";
            SeleccionarGrilla("SeleccionarTodo");
        }

        private void CargarGrilla()
        {
            List<CategoriaN> Lista = Negocios.FuncionesGlobales.CategoriaS.ListarCategoria();
            for (int i = 0; i < Lista.Count; i++)
            {
                dgvCategorias.Rows.Add();
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells["Id"].Value = Lista[i].Id;
                dgvCategorias.Rows[dgvCategorias.Rows.Count - 1].Cells["Nombre"].Value = Lista[i].Nombre;
            }
        }

        private void SeleccionarGrilla(string TipoSeleccion)
        {
            if (TipoSeleccion == "SeleccionarTodo")
            {

                for (int i = 0; i < dgvCategorias.RowCount; i++)
                {
                    dgvCategorias.Rows[i].Cells["Seleccionar"].Value = true;
                }
            }
            else if (TipoSeleccion == "InvertirSeleccion")
            {
                for (int i = 0; i < dgvCategorias.RowCount; i++)
                {
                    if (bool.Parse(dgvCategorias.Rows[i].Cells["Seleccionar"].Value == null ? "false" : dgvCategorias.Rows[i].Cells["Seleccionar"].Value.ToString()) == true)
                    {
                        dgvCategorias.Rows[i].Cells["Seleccionar"].Value = false;
                    }
                    else
                    {
                        dgvCategorias.Rows[i].Cells["Seleccionar"].Value = true;
                    }
                }
            }
            else if (TipoSeleccion == "DeseleccionarTodo")
            {
                for (int i = 0; i < dgvCategorias.RowCount; i++)
                {
                    dgvCategorias.Rows[i].Cells["Seleccionar"].Value = false;
                }
            }
        }
        #endregion
    }
}
