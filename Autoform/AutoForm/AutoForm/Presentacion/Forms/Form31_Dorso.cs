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
    public partial class Form31_Dorso : UserControl
    {

        public Extras.LinesControl _LC;
        public Form31_Dorso()
        {
            InitializeComponent();
        }

        private void Form31_Dorso_Load(object sender, EventArgs e)
        {
            _LC = new Extras.LinesControl(txtobservaciones, false,400,6);
            this.MinimumSize = this.Size;
            this.Parent.Resize += Parent_Resize;
            
            RedimensionarConPadre();
        }

        void Parent_Resize(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                RedimensionarConPadre();
            }
        }

        private void RedimensionarConPadre()
        {

            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }
    }
}
