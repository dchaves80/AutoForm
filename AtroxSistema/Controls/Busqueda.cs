using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Busqueda : Form
    {

        public TextBox MyTextBox;
        public string fieldtoreturn;
        public List<DataGridViewColumn> ListaColumnas;
        public String CampoBusqueda;
        

        public Busqueda()
        {
            InitializeComponent();
            DTGV.ColumnAdded += DTGV_ColumnAdded;
            DTGV.KeyPress += DTGV_KeyPress;
            DTGV.KeyDown += DTGV_KeyDown;
        }

        void DTGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                MyTextBox.Text = DTGV.SelectedRows[0].Cells[fieldtoreturn].Value.ToString();
                this.Close();
            }
        }

        void DTGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        void DTGV_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
       
        }

        private void DTGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MyTextBox.Text =  DTGV.SelectedRows[0].Cells[fieldtoreturn].Value.ToString();
            this.Close();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }


        private void showall() 
        {
            DTGV.SuspendLayout();
            foreach (DataGridViewRow a in DTGV.Rows) 
            {
                a.Visible = true;
            }
            DTGV.ResumeLayout();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            //showall();
            DTGV.ClearSelection();
            DTGV.CurrentCell = null;
            string busqueda = txtBuscar.Text.ToLower();
            if (txtBuscar.Text != "")
            {
               
                foreach (DataGridViewRow a in DTGV.Rows)
                {
                  
                    string value = a.Cells[CampoBusqueda].Value.ToString().ToLower();

                    if (value.Contains(busqueda)){
                        a.Visible = true;
                    }
                    else
                    {
                        a.Visible = false;
                    }
                   

                }
                
            }
            else 
            {
                for (int a = 0; a < DTGV.Rows.Count; a++)
                {
                    
                        DTGV.Rows[a].Visible = true;
                }
            }



        }
    }
}
