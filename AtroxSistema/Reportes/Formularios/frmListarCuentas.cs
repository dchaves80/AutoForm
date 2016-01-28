using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class frmListarCuentas : Form
    {
        public frmListarCuentas()
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
        }

        private void frmListarCuentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDAtroxDataSet.SPReporteCuentas' table. You can move, or remove it, as needed.
            this.SPReporteCuentasTableAdapter.Fill(this.BDAtroxDataSet.SPReporteCuentas, 0,99999,null);

            this.reportViewer1.RefreshReport();
        }
    }
}
