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


        private void CambiarEstadoTodo(Control p_ctrl, Boolean p_estado)
        {
            if (p_ctrl.Controls.Count > 0)
            {
                foreach (Control i_control in p_ctrl.Controls)
                {
                    if (i_control.Controls.Count > 0)
                    {
                        CambiarEstadoTodo(i_control, p_estado);

                    }
                    i_control.Enabled = p_estado;
                }
            }
            p_ctrl.Enabled = p_estado;
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

        private void rdbAutomotor_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstadoTodo(this, true);
            grp.Enabled = true;
        }

        private void rdbMotovehiculo_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstadoTodo(this, true);
            grp.Enabled = true;
        }
    }
}
