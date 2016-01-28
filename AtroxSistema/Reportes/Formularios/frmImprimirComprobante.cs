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
    public partial class frmImprimirComprobante : Form
    {
        int ClaveMovimiento;
        string CodBar;
        public frmImprimirComprobante(int _ClaveMovimiento, string _CodBar)
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
            ClaveMovimiento = _ClaveMovimiento;
            CodBar = _CodBar;
        }

        private void frmImprimirComprobante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDAtroxDataSet.SPImprimirMovimiento' table. You can move, or remove it, as needed.
            this.SPImprimirMovimientoTableAdapter.Fill(this.BDAtroxDataSet.SPImprimirMovimiento, ClaveMovimiento, CodBar);

            this.rv.RefreshReport();
        }
    }
}
