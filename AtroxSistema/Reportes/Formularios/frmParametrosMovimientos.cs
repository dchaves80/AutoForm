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


namespace Reportes.Formularios
{
    public partial class frmParametrosMovimientos : Form
    {
        #region Definiciones
        string TipoMovimientos;
        #endregion

        #region Metodos
        public frmParametrosMovimientos()
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
        }

        private void frmParametrosMovimientos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ValoresXDefecto();
            SeleccionarGrilla("SeleccionarTodo");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SeleccionarGrilla("SeleccionarTodo");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TipoMovimientos = "0";
            for (int i = 0; i < dgvTipoMovimientos.RowCount; i++)
            {
                if (bool.Parse(dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value.ToString()) == true)
                {
                    TipoMovimientos = TipoMovimientos + "," + dgvTipoMovimientos.Rows[i].Cells["Id"].Value.ToString();
                }
            }
            frmListadoMovimientos Form = new frmListadoMovimientos(int.Parse(txtCuentaDesde.Text), int.Parse(txtCuentaHasta.Text), DateTime.Parse(txtFechaDesde.Text), DateTime.Parse(txtFechaHasta.Text), TipoMovimientos);
            Form.Show();
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
        #endregion

        #region Funciones
        private void ValoresXDefecto()
        {
            txtCuentaDesde.Text = "0";
            txtCuentaHasta.Text = "99999";
            txtFechaDesde.Text = DateTime.Now.ToShortDateString();
            txtFechaHasta.Text = DateTime.Now.ToShortDateString();
        }

        private void SeleccionarGrilla(string TipoSeleccion)
        {
            if (TipoSeleccion == "SeleccionarTodo")
            {
                
                for (int i = 0; i < dgvTipoMovimientos.RowCount; i++)
                {
                    dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value = true;
                }
            }
            else if (TipoSeleccion == "InvertirSeleccion")
            {
                for (int i = 0; i < dgvTipoMovimientos.RowCount ; i++)
                {
                    if (bool.Parse(dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value == null ? "false" : dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value.ToString()) == true)
                    {
                        dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value = false;
                    }
                    else
                    {
                        dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value = true;
                    }
                }
            }
            else if (TipoSeleccion == "DeseleccionarTodo")
            {
                for (int i = 0; i < dgvTipoMovimientos.RowCount ; i++)
                {
                    dgvTipoMovimientos.Rows[i].Cells["Seleccionar"].Value = false;
                }
            }
        }

        private void CargarGrilla()
        {
            List<TipoMovimientoN> Lista = Negocios.FuncionesGlobales.TipoMovimientoS.ListarTipoMovimiento();
            for (int i = 0; i < Lista.Count; i++)
            {
                dgvTipoMovimientos.Rows.Add();
                dgvTipoMovimientos.Rows[dgvTipoMovimientos.Rows.Count - 1].Cells["Id"].Value = Lista[i].Id;
                dgvTipoMovimientos.Rows[dgvTipoMovimientos.Rows.Count - 1].Cells["Nombre"].Value = Lista[i].Nombre;
            }
        }
        #endregion
    }
}