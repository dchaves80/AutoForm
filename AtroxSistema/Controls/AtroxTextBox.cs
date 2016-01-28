using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controls
{
    public class AtroxTextBox : TextBox
    {
        Keys OpenSearch;
        object _ListaAPasar;
        string[] showColumns;
        string returnfield;
        string CampoBusqueda;

        

        public AtroxTextBox()
        {
            this.KeyUp += AtroxTextBox_KeyUp;
            
            this.BackColor = Color.FromArgb(0, 163,163);

           
        }

        public void Parametros<T>(string[] p_matrizamostrar, string campodevolucion, List<T> p_ListaAPasar)
        {
            OpenSearch = Keys.None;
            _ListaAPasar = p_ListaAPasar;
            showColumns = p_matrizamostrar;
            returnfield = campodevolucion;
            AtroxTextBox_KeyUp(this, new KeyEventArgs(Keys.None));
        }

        public void Parametros<T>(Keys p_TeclaDeBusqueda, string[] p_matrizamostrar, string campodevolucion, List<T> p_ListaAPasar, string p_CampoBusqueda)
        {
            OpenSearch = p_TeclaDeBusqueda;
            _ListaAPasar = p_ListaAPasar;
            showColumns = p_matrizamostrar;
            returnfield = campodevolucion;
            CampoBusqueda = p_CampoBusqueda;
        }



        void AtroxTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == OpenSearch)
            {
                Busqueda frm_busqueda = new Busqueda();
                frm_busqueda.StartPosition = FormStartPosition.CenterScreen;
                frm_busqueda.FormClosed += frm_busqueda_FormClosed;
                frm_busqueda.MyTextBox = this;
                frm_busqueda.fieldtoreturn = returnfield;
                frm_busqueda.CampoBusqueda = CampoBusqueda;
                frm_busqueda.DTGV.DataSource = _ListaAPasar;
                frm_busqueda.DTGV.Columns[frm_busqueda.DTGV.Columns.Count - 1].DisplayIndex = 0;
                for (int a = 0; a < frm_busqueda.DTGV.Columns.Count; a++)
                {
                    frm_busqueda.DTGV.Columns[a].Visible = false;
                }
                for (int a = 0; a < showColumns.Length; a++)
                {
                    DataGridView _DT = frm_busqueda.DTGV;
                    _DT.Columns[showColumns[a]].Visible = true;
                }
                frm_busqueda.ShowDialog();
            }
        }

        void frm_busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.OnKeyDown(new KeyEventArgs(Keys.Enter));
        }
    }
}
