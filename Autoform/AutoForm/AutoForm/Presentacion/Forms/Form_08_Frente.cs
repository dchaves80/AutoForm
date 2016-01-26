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
    public partial class Form_08_Frente : UserControl
    {
        public Form_08_Frente()
        {
            InitializeComponent();
        }

        private void rdbAutomotor_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstadoTodo(this, true);
            rdbMotovehiculo.Enabled = false;
            CongelarCampos();
        }


        private void CongelarCampos() 
        {
            txtBCodigoRegistro.Enabled = false;
            txtCNumeroArancel.Enabled = false;
            txtCPrecioArancel.Enabled = false;
            grpOPTA.Enabled = false;
            grpH.Enabled = false;
        }

        private void rdbMotovehiculo_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstadoTodo(this, true);
            rdbAutomotor.Enabled = false;
            CongelarCampos();
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

    }
}
