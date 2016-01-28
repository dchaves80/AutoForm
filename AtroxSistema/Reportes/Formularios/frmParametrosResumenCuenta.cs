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
    public partial class frmParametrosResumenCuenta : Form
    {
        #region Metodos
        public frmParametrosResumenCuenta()
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmResumenCuenta Form = new frmResumenCuenta(int.Parse(txtCuentaDesde.Text), int.Parse(txtCuentaHasta.Text), DateTime.Parse(txtFechaDesde.Text), DateTime.Parse(txtFechaHasta.Text));
            Form.Show();
        }

        private void frmParametrosResumenCuenta_Load(object sender, EventArgs e)
        {
            ValoresXDefecto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ValoresXDefecto();
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
        #endregion
    }
}
