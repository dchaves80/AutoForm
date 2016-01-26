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
    public partial class Form_12_Frente_Unicamente : UserControl
    {
        public Extras.LinesControl _LC;
        public Form_12_Frente_Unicamente()
        {
           
            InitializeComponent();
         
            
        }


        private void CambiarEstadoTodo(Control p_ctrl, Boolean p_estado) 
        {
            if (p_ctrl.Controls.Count>0){
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

      

        private void Form_12_Frente_Unicamente_Load(object sender, EventArgs e)
        {
            _LC = new Extras.LinesControl(txtObservacionesOConstan, false,200, 6);
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstadoTodo(this, true);
            rdbMotovehiculo.Enabled = false;
            
        }

        private void rdbMotovehiculo_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstadoTodo(this, true);
            rdbAutomotor.Enabled = false;
        }
    }
}
