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
    public partial class frmResumenCuenta : Form
    {
        #region Deficiniciones
        int CuentaDesde;
        int CuentaHasta;
        DateTime FechaDesde;
        DateTime FechaHasta;
        #endregion
        public frmResumenCuenta(int _CuentaDesde, int _CuentaHasta, DateTime _FechaDesde, DateTime _FechaHasta)
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
            CuentaDesde = _CuentaDesde;
            CuentaHasta = _CuentaHasta;
            FechaDesde = _FechaDesde;
            FechaHasta = _FechaHasta;
        }

        private void frmResumenCuenta_Load(object sender, EventArgs e)
        {
            this.sPResumenCuentaTableAdapter.Fill(this.BDAtroxDataSet.SPResumenCuenta, CuentaDesde, CuentaHasta, FechaDesde, FechaHasta);
            this.rv.RefreshReport();
        }
    }
}
