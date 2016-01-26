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

   

    public partial class Form_02_Frente : UserControl
    {

        public Extras.LinesControl _LC;
        public Form_02_Frente()
        {
            InitializeComponent();
        }

        private void Form_02_Frente_Load(object sender, EventArgs e)
        {
            _LC = new Extras.LinesControl(txtdeclaraciones, true,500,5);
            this.MinimumSize = this.Size;
            this.Parent.Resize += Parent_Resize;
            
            RedimensionarConPadre();
        }

        private void RedimensionarConPadre()
        {

            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        void Parent_Resize(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                RedimensionarConPadre();
            }
            else 
            {
                Dispose();
            }
        }
    }
}
