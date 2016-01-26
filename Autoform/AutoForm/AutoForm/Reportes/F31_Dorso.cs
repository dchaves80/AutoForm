using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reportes
{
    public partial class F31_Dorso : Form
    {

        private string _fotocopiaautomotor;
        private string _fotocopiacomprobantepago;
        private string _fotocopiaotros;
        private string _observaciones;

        public F31_Dorso(

             string p_fotocopiaautomotor,
        string p_fotocopiacomprobantepago,
        string p_fotocopiaotros,
        string p_observaciones

            )
        {
            _fotocopiaautomotor = p_fotocopiaautomotor;
            _fotocopiacomprobantepago =p_fotocopiacomprobantepago;
            _fotocopiaotros = p_fotocopiaotros;
            _observaciones = p_observaciones;


            InitializeComponent();
            EstablecerHandlers();
        }
        private void EstablecerHandlers()
        {
            reportViewer1.RenderingComplete += reportViewer1_RenderingComplete;

        }



        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {

            if (reportViewer1.GetTotalPages() > 1)
            {
                MessageBox.Show("El reporte contiene mas de una página, esto puede ocasionar una impresión erronea en el reporte, reduzca el contenido de los campos que se encuentran al final del formulario o campos extensos como por ejemplo observaciones o documentacion extra", "Error en el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

        private void F31_Dorso_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fotocopiaautomotor", _fotocopiaautomotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fotocopiacomprobantepago", _fotocopiacomprobantepago));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fotocopiaotros", _fotocopiaotros));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_observaciones", _observaciones));

            this.reportViewer1.RefreshReport();
        }
    }
}
