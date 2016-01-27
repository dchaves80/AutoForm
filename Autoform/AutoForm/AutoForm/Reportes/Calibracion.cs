using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Calibracion : Form
    {
        public Calibracion()
        {
            InitializeComponent();
        }

        private void Calibracion_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

      
    }
}
