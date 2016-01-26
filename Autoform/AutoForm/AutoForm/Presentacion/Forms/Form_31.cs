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
    public partial class Form_31 : UserControl
    {
        public Form_31()
        {
            InitializeComponent();
            
        }

        private void Form_31_Load(object sender, EventArgs e)
        {
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
            RedimensionarConPadre();
        }
    }
}
