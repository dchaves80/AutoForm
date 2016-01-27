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
    public partial class F12_Frente : Form
    {

        string _dominio;
        string _marca;
        string _tipo;
        string _modelo;
        string _marcamotor;
        string _numeromotor;
        string _marcachasis;
        string _numerochasis;
        string _observaciones;
        string _lugar;
        string _dia;
        string _mes;
        string _año;
        string _apellidonombre;
        string _tipodocumento;
        string _calle;
        string _numero;
        string _localidad;


        public F12_Frente(
            string p_dominio,
             string p_marca,
        string p_tipo,
        string p_modelo,
        string p_marcamotor,
        string p_numeromotor,
        string p_marcachasis,
        string p_numerochasis,
        string p_observaciones,
        string p_lugar,
        string p_dia,
        string p_mes,
        string p_año,
        string p_apellidonombre,
        string p_tipodocumento,
        string p_calle,
        string p_numero,
        string p_localidad
           
            )
        {
            _dominio = p_dominio;
             _marca=p_marca;
             _tipo=p_tipo;
             _modelo=p_modelo;
             _marcamotor=p_marcamotor;
             _numeromotor=p_numeromotor;
             _marcachasis=p_marcachasis;
             _numerochasis=p_numerochasis;
             _observaciones=p_observaciones;
             _lugar=p_lugar;
             _dia=p_dia;
             _mes=p_mes;
             _año=p_año;
             _apellidonombre=p_apellidonombre;
             _tipodocumento=p_tipodocumento;
             _calle=p_calle;
             _numero=p_numero;
             _localidad=p_localidad;

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

        private void F12_Frente_Load(object sender, EventArgs e)
        {

            //reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adominio", ));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dominio", _dominio));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marca",_marca));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_tipo",_tipo ));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_modelo", _modelo));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcamotor", _marcamotor));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numeromotor",_numeromotor ));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcachasis",_marcachasis ));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numerochasis", _numerochasis));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_observaciones",_observaciones ));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lugar",_lugar ));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dia", _dia));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_mes", _mes));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_año", _año));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apellidonombre",_apellidonombre ));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_tipodocumento", _tipodocumento));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_calle", _calle));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numero", _numero));
             reportViewer1.LocalReport.SetParameters(new ReportParameter("p_localidad", _localidad));

             new Class.ReportingCalibration(reportViewer1);
        }
    }
}
