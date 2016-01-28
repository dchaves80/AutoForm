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
    public partial class frmListadoMovimientos : Form
    {
        #region Deficiniciones
        int CuentaDesde;
        int CuentaHasta;
        DateTime FechaDesde;
        DateTime FechaHasta;
        string TipoMovimiento;
        #endregion

        #region Metodos
        public frmListadoMovimientos(int _CuentaDesde, int _CuentaHasta, DateTime _FechaDesde, DateTime _FechaHasta, string _TipoMovimiento)
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
            CuentaDesde = _CuentaDesde;
            CuentaHasta = _CuentaHasta;
            FechaDesde = _FechaDesde;
            FechaHasta = _FechaHasta;
            TipoMovimiento = _TipoMovimiento;
        }

        private void frmListadoMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                this.sPListarMovimientosTableAdapter.Fill(this.BDAtroxDataSet.SPListarMovimientos, CuentaDesde, CuentaHasta, FechaDesde, FechaHasta, TipoMovimiento);
            }
            catch (Exception E) 
            {
                MessageBox.Show(E.Message);
            }
           
        }
        #endregion

        private void frmListadoMovimientos_Shown(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
