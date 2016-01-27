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
    public partial class F02_Frente : Form
    {

        private string _adominio;
        private string _dchk1;
        private string _dchk2;
        private string _dchk3;
        private string _dchk4;
        private string _dchk5;
        private string _dchk6;
        private string _dchk7;
        private string _dchk8;
        private string _dchk9;
        private string _dchk10;
        private string _dchk11;
        private string _dchk12;
        private string _dchk13;
        private string _dchk14;
        private string _dchk15;
        private string _dchk16;
        private string _dchk17;
        private string _dchk18;
        private string _dchk19;
        private string _dchk20;
        private string _edeclaraciones;
        private string _fapellidoynombresolicitante;
        private string _fappelidoynombreapoderado;
        private string _dninat;
        private string _lenat;
        private string _lcnat;
        private string _dniext;
        private string _ciext;
        private string _pasapext;
        private string _fnumerodocumento;
        private string _fautoridad;
        private string _dominio;
        private string _marca;
        private string _tipo;
        private string _modelo;
        private string _marcamotor;
        private string _numeromotor;
        private string _marcachasis;
        private string _numerochasis;

        public F02_Frente(string p_adominio,
            string p_dchk1, 
            string p_dchk2, 
            string p_dchk3, 
            string p_dchk4, 
            string p_dchk5, 
            string p_dchk6, 
            string p_dchk7, 
            string p_dchk8, 
            string p_dchk9, 
            string p_dchk10, 
            string p_dchk11, 
            string p_dchk12, 
            string p_dchk13, 
            string p_dchk14, 
            string p_dchk15, 
            string p_dchk16, 
            string p_dchk17, 
            string p_dchk18, 
            string p_dchk19, 
            string p_dchk20,
            string p_edeclaraciones,
            string p_fapellidoynombresolicitante,
            string p_fapellidoynombreapoderado,
            string p_dninat,
        string p_lenat,
        string p_lcnat,
        string p_dniext,
        string p_ciext,
        string p_pasapext,
            string p_fnumerodocumento,
            string p_fautoridad,
        string p_dominio,
        string p_marca,
        string p_tipo,
        string p_modelo,
        string p_marcamotor,
        string p_numeromotor,
        string p_marcachasis,
        string p_numerochasis
            )
        {
            _adominio = p_adominio;
            _dchk1 = p_dchk1;
            _dchk2 = p_dchk2;
            _dchk3 = p_dchk3;
            _dchk4 = p_dchk4;
            _dchk5 = p_dchk5;
            _dchk6 = p_dchk6;
            _dchk7 = p_dchk7;
            _dchk8 = p_dchk8;
            _dchk9 = p_dchk9;
            _dchk10 = p_dchk10;
            _dchk11 = p_dchk11;
            _dchk12 = p_dchk12;
            _dchk13 = p_dchk13;
            _dchk14 = p_dchk14;
            _dchk15 = p_dchk15;
            _dchk16 = p_dchk16;
            _dchk17 = p_dchk17;
            _dchk18 = p_dchk18;
            _dchk19 = p_dchk19;
            _dchk20 = p_dchk20;
            _edeclaraciones = p_edeclaraciones;
            _fapellidoynombresolicitante = p_fapellidoynombresolicitante;
            _fappelidoynombreapoderado = p_fapellidoynombreapoderado;
            _dninat = p_dninat;
            _lenat = p_lenat;
            _lcnat = p_lcnat;
            _dniext = p_dniext;
            _ciext = p_ciext;
            _pasapext = p_pasapext;
            _fnumerodocumento = p_fnumerodocumento;
            _fautoridad = p_fautoridad;
            _dominio = p_dominio;
                _marca = p_marca;
            _tipo = p_tipo;
            _modelo = p_modelo;
            _marcamotor = p_marcamotor;
            _numeromotor = p_numeromotor;
                        _marcachasis=p_marcachasis;
                        _numerochasis = p_numerochasis;

            InitializeComponent();
            EstablecerHandlers();
        }

        private void F02_Frente_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adominio", _adominio));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk1", _dchk1));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk2", _dchk2));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk3", _dchk3));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk4", _dchk4));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk5", _dchk5));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk6", _dchk6));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk7", _dchk7));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk8", _dchk8));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk9", _dchk9));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk10", _dchk10));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk11", _dchk11));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk12", _dchk12));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk13", _dchk13));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk14", _dchk14));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk15", _dchk15));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk16", _dchk16));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk17", _dchk17));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk18", _dchk18));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk19", _dchk19));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dchk20", _dchk20));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edeclaraciones", _edeclaraciones));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fapellidoynombresolicitante", _fapellidoynombresolicitante));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fapellidoynombreapoderado", _fappelidoynombreapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dninat", _dninat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lenat", _lenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lcnat", _lcnat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dniext", _dniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ciext", _ciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_pasapext", _pasapext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fnumerodocumento", _fnumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fautoridad", _fautoridad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dominio", _dominio));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marca", _marca));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_tipo", _tipo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_modelo", _modelo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcamotor", _marcamotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numeromotor", _numeromotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcachasis", _marcachasis));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numerochasis", _numerochasis));
            new Class.ReportingCalibration(reportViewer1);
        }


        private void EstablecerHandlers() 
        {
            reportViewer1.RenderingComplete+=reportViewer1_RenderingComplete;
         
        }

      

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {

          



        }

     
    }
}
