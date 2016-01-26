using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.FormulariosExtras
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            
            List<Datos.Cliente.CLNT> MyList = Datos.Cliente.ObtenerTodosLosClientes();
            DTGVClientes.DataSource=MyList;
            Application.DoEvents();
            DTGVClientes.Columns[0].Visible = false;


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new ABMCliente().ShowDialog();
        }
    }
}
