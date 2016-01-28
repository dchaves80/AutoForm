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
    public partial class frmListarArticulos : Form
    {
        #region Definiciones
        int ArticuloDesde;
        int ArticuloHasta;
        int CuentaDesde;
        int CuentaHasta;
        string Categorias;
        #endregion

        public frmListarArticulos(int _ArticuloDesde, int _ArticuloHasta, int _CuentaDesde, int _CuentaHasta, string _Categorias)
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
            ArticuloDesde = _ArticuloDesde;
            ArticuloHasta = _ArticuloHasta;
            CuentaDesde = _CuentaDesde;
            CuentaHasta = _CuentaHasta;
            Categorias = _Categorias;
        }

        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDAtroxDataSet.SPReporteArticulos' table. You can move, or remove it, as needed.
            this.SPReporteArticulosTableAdapter.Fill(this.BDAtroxDataSet.SPReporteArticulos,ArticuloDesde,ArticuloHasta,CuentaDesde,CuentaHasta, Categorias);

            this.reportViewer1.RefreshReport();
        }
    }
}
