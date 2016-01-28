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
    public partial class BuscarMovimientos : Form
    {


        List<Negocios.MovimientoN> ListadoMovimientos;
        TextBox puntoventa; 
        TextBox nroMovimiento;
        TextBox IdCuenta;
        public event EventHandler<object> EH_DoubleClick;

        public BuscarMovimientos(List<Negocios.MovimientoN> p_movimientos, TextBox p_puntoventa, TextBox p_nroMovimiento, TextBox p_IdCuenta)
        {

            ListadoMovimientos = p_movimientos;
            puntoventa = p_puntoventa;
            nroMovimiento = p_nroMovimiento;
            IdCuenta = p_IdCuenta;
            InitializeComponent();




        }

        private void BuscarMovimientos_Load(object sender, EventArgs e)
        {
            if (ListadoMovimientos != null) 
            {
                if (ListadoMovimientos.Count != 0) 
                {
                    for (int a = 0; a < ListadoMovimientos.Count; a++) 
                    {
                        DataGridViewRow DR = new DataGridViewRow();
                        DR.CreateCells(dtgv);
                        Negocios.MovimientoN _m = ListadoMovimientos[a];
                        DR.Cells[ClmId.Index].Value = _m.Id.ToString();
                        DR.Cells[ClmPuntoVenta.Index].Value = _m.PuntoVenta.ToString();
                        DR.Cells[ClmNumeroMovimiento.Index].Value = _m.NroMovimiento.ToString();
                        DR.Cells[ClmFecha.Index].Value = _m.Fecha.ToString();
                        DR.Cells[ClmIdCuenta.Index].Value = _m.IdCuenta.ToString();
                        Negocios.CuentaN CUENTA = new Negocios.CuentaN( _m.IdCuenta);
                        DR.Cells[ClmCuenta.Index].Value = CUENTA.Nombre;
                        dtgv.Rows.Add(DR);
                    }
                }
            }
        }

        private void dtgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow _R = dtgv.Rows[e.RowIndex];
            if (puntoventa != null) { puntoventa.Text =_R.Cells[ClmPuntoVenta.Index].Value.ToString(); }
            if (nroMovimiento != null) { nroMovimiento.Text = _R.Cells[ClmNumeroMovimiento.Index].Value.ToString(); }
            if (IdCuenta != null) {IdCuenta.Text = _R.Cells[ClmIdCuenta.Index].Value.ToString(); }
            if (EH_DoubleClick != null) 
            {
                EH_DoubleClick(this,this);
            }
            this.Close();
        }
    }
}
