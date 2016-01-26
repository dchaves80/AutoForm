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
    public partial class F59_Dorso : Form
    {

        string _ddominio1;
        string _dtramite1;
        string _dsolicitud1;
        string _dndecontrol1;
        string _ddominio2;
        string _dtramite2;
        string _dsolicitud2;
        string _dndecontrol2;
        string _ddominio3;
        string _dtramite3;
        string _dsolicitud3;
        string _dndecontrol3;
        string _ddominio4;
        string _dtramite4;
        string _dsolicitud4;
        string _dndecontrol4;
        string _ddominio5;
        string _dtramite5;
        string _dsolicitud5;
        string _dndecontrol5;
        string _eobservaciones;
        string _glugar;
        string _gfecha;

        public F59_Dorso(
            string p_ddominio1,
string p_dtramite1,
string p_dsolicitud1,
string p_dndecontrol1,
string p_ddominio2,
string p_dtramite2,
string p_dsolicitud2,
string p_dndecontrol2,
string p_ddominio3,
string p_dtramite3,
string p_dsolicitud3,
string p_dndecontrol3,
string p_ddominio4,
string p_dtramite4,
string p_dsolicitud4,
string p_dndecontrol4,
string p_ddominio5,
string p_dtramite5,
string p_dsolicitud5,
string p_dndecontrol5,
string p_eobservaciones,
            string p_glugar,
string p_gfecha
            )
        {

            _ddominio1 = p_ddominio1;
            _dtramite1 = p_dtramite1;
            _dsolicitud1 = p_dsolicitud1;
            _dndecontrol1 = p_dndecontrol1;
            _ddominio2 = p_ddominio2;
            _dtramite2 = p_dtramite2;
            _dsolicitud2 = p_dsolicitud2;
            _dndecontrol2 = p_dndecontrol2;
            _ddominio3 = p_ddominio3;
            _dtramite3 = p_dtramite3;
            _dsolicitud3 = p_dsolicitud3;
            _dndecontrol3 = p_dndecontrol3;
            _ddominio4 = p_ddominio4;
            _dtramite4 = p_dtramite4;
            _dsolicitud4 = p_dsolicitud4;
            _dndecontrol4 = p_dndecontrol4;
            _ddominio5 = p_ddominio5;
            _dtramite5 = p_dtramite5;
            _dsolicitud5 = p_dsolicitud5;
            _dndecontrol5 = p_dndecontrol5;
            _eobservaciones = p_eobservaciones;
            _glugar = p_glugar;
            _gfecha = p_gfecha;
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

        private void F59_Dorso_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddominio1", _ddominio1));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dtramite1", _dtramite1));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsolicitud1", _dsolicitud1));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dndecontrol1", _dndecontrol1));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddominio2", _ddominio2));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dtramite2", _dtramite2));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsolicitud2", _dsolicitud2));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dndecontrol2", _dndecontrol2));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddominio3", _ddominio3));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dtramite3", _dtramite3));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsolicitud3", _dsolicitud3));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dndecontrol3", _dndecontrol3));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddominio4", _ddominio4));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dtramite4", _dtramite4));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsolicitud4", _dsolicitud4));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dndecontrol4", _dndecontrol4));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddominio5", _ddominio5));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dtramite5", _dtramite5));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsolicitud5", _dsolicitud5));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dndecontrol5", _dndecontrol5));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eobservaciones", _eobservaciones));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_glugar", _glugar));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_gfecha", _gfecha));

            this.reportViewer1.RefreshReport();
        }
    }
}
