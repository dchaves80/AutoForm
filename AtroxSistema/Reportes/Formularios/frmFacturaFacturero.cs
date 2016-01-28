using Reportes.Clases;
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
    public partial class frmFacturaFacturero : Form
    {
        public frmFacturaFacturero(int p_ClaveMov, short p_Copias, string p_Impresora, int p_IdComprobante)
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
            switch (p_IdComprobante)
            {
                //FACTURA A
                case 1:
                    this.sPFacturaFactureroTableAdapter.Fill(this.BDAtroxDataSet.SPFacturaFacturero, p_ClaveMov);
                    Imprimir.Run(rvFacturaDeFacturero, p_Copias, p_Impresora);
                    break;
                default:
                    break;
            }
        }
    }
}
