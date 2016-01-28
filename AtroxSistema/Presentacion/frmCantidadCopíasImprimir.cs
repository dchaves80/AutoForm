using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCantidadCopíasImprimir : Form
    {
        private short _Copias = 0;

        public short Copias
        {
            get { return _Copias; }
            set { _Copias = value; }
        }

        #region Metodos
        public frmCantidadCopíasImprimir()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Copias = short.Parse(txtNumeroDeCopias.Text);
            this.Close();
        }
        #endregion

        private void frmCantidadCopíasImprimir_Load(object sender, EventArgs e)
        {
            txtNumeroDeCopias.Text = Copias.ToString();
            Copias = 0;
        }
    }
}
