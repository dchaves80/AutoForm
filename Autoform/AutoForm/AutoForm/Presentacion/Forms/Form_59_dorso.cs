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
    public partial class Form_59_dorso : UserControl
    {
        public Extras.LinesControl _LC;
        public Form_59_dorso()
        {
            InitializeComponent();
        }

        private void Form_59_dorso_Load(object sender, EventArgs e)
        {
            _LC = new Extras.LinesControl(txtEObservaciones, false,400,8);
        }
    }
}
