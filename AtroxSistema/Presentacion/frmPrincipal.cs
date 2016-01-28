using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes;
using Reportes.Formularios;


namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmEmpresa);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            frm = new frmEmpresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCuenta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
           
            frm = new frmCuenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmArticulos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            frm = new frmArticulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmParametrosListadoArticulos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            frm = new frmParametrosListadoArticulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void movimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmParametrosMovimientos);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmParametrosMovimientos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void resumenDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmParametrosResumenCuenta);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmParametrosResumenCuenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuentasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmListarCuentas);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmListarCuentas();
            
            frm.Show();
        }

        private void actualizarPrecioPorCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmActualizarPrecioXCuenta);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmActualizarPrecioXCuenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriaArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCategoria);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipoDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTipoMovimiento);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmTipoMovimiento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void movimientosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMovimientos);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmMovimientos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipoDeComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTiposComprobantes);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmTiposComprobantes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmImpresoras);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new frmImpresoras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is abAcercaDe);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            frm = new abAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
