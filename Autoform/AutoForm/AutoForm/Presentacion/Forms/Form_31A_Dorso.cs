using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class Form_31A_Dorso : UserControl
    {

        public Extras.LinesControl _LC;
        public Form_31A_Dorso()
        {
            InitializeComponent();
        }

        private void Form_31A_Dorso_Load(object sender, EventArgs e)
        {
            _LC = new Extras.LinesControl(txtobservaciones, false,400,6);
        }
    }
}
