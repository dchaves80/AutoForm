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
    public partial class Form_31_Frente : UserControl
    {
        public Form_31_Frente()
        {
            InitializeComponent();
            
        }

        private void Form_31_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.Parent.Resize += Parent_Resize;
            cmbNacionalImportado.SelectedIndex = 0;
            RedimensionarConPadre();
        }

        private void RedimensionarConPadre()
        {

            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        void Parent_Resize(object sender, EventArgs e)
        {
            if (this.Parent != null) { 
            RedimensionarConPadre();
            }
        }
    }
}
