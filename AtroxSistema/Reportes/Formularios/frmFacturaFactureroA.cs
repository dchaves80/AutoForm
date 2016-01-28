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
    public partial class frmFacturaFactureroA : Form
    {
        public frmFacturaFactureroA(int p_ClaveMov, short p_Copias, string p_Impresora)
        {
            ChangeConnection.StringConexion = Datos.ChangeConnection.StringConexion;
            ChangeConnection.Chage();
            InitializeComponent();
            this.sPFacturaFactureroTableAdapter.Fill(this.BDAtroxDataSet.SPFacturaFacturero, p_ClaveMov);
            Imprimir.Run(rvFacturaDeFacturero, p_Copias, p_Impresora);
        }
    }
}
