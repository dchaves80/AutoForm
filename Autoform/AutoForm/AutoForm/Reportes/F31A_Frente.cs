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
    public partial class F31A_Frente : Form
    {
        string _Ainscripcioninicial;
        string _Acambioradicacion;
        string _Asubastadosyarmados;
        string _Arecuperorobo;
        private string _dominio;
        private string _dominioanterior;
        private string _nacionalimportado;

        string _bfechadecompra;
        string _bfechadealta;
     
        private string _reservadorentas;
        private string _marcaymodelo;
        private string _tipo;
        private string _modeloaño;
        private string _marcamotor;
        private string _marcachasis;
        private string _numeromotor;
        private string _chasisnumero;
        private string _prubro;
        private string _categoria;
        private string _pesocilindrada;
        private string _codigomarca;
        private string _combustible;
        private string _apellidoynombrerazonsocial;
        private string _numerodocumento;
        private string _dni;
        private string _le;
        private string _lc;
        private string _ci;
        private string _pas;
        private string _cuilcuit;
        private string _dfcallenombre;
        private string _dfcallenro;
        private string _dfcallepiso;
        private string _dfcalledpto;
        private string _dfbarriolocalidad;
        private string _dfcodpost;
        private string _dfprovincia;
        private string _dpcallenombre;
        private string _dpcallenro;
        private string _dpcallepiso;
        private string _dpcalledpto;
        private string _dpbarriolocalidad;
        private string _dpcodpost;
        private string _dpprovincia;

        public F31A_Frente(
            string p_Ainscripcioninicial,
string p_Acambioradicacion,
string p_Asubastadosyarmados,
string p_Arecuperorobo,
 string p_dominio,
 string p_dominioanterior,
 string p_nacionalimportado,
 
 string p_bfechadecompra,
string p_bfechadealta,
 
 string p_reservadorentas,
 string p_marcaymodelo,
 string p_tipo,
 string p_modeloaño,
 string p_marcamotor,
 string p_marcachasis,
 string p_numeromotor,
 string p_chasisnumero,
 string p_prubro,
 string p_categoria,
 string p_pesocilindrada,
 string p_codigomarca,
 string p_combustible,
 string p_apellidoynombrerazonsocial,
 string p_numerodocumento,
 string p_dni,
 string p_le,
 string p_lc,
 string p_ci,
 string p_pas,
 string p_cuilcuit,
 string p_dfcallenombre,
 string p_dfcallenro,
 string p_dfcallepiso,
 string p_dfcalledpto,
 string p_dfbarriolocalidad,
 string p_dfcodpost,
 string p_dfprovincia,
 string p_dpcallenombre,
 string p_dpcallenro,
 string p_dpcallepiso,
 string p_dpcalledpto,
 string p_dpbarriolocalidad,
 string p_dpcodpost,
 string p_dpprovincia)
        {
            _Ainscripcioninicial = p_Ainscripcioninicial;
            _Acambioradicacion = p_Acambioradicacion;
            _Asubastadosyarmados = p_Asubastadosyarmados;
            _Arecuperorobo = p_Arecuperorobo;
            _dominio = p_dominio;
            _dominioanterior = p_dominioanterior;
            _nacionalimportado = p_nacionalimportado;

            _bfechadecompra = p_bfechadecompra;
            _bfechadealta = p_bfechadealta;


            _reservadorentas = p_reservadorentas;
            _marcaymodelo = p_marcaymodelo;
            _tipo = p_tipo;
            _modeloaño = p_modeloaño;
            _marcamotor = p_marcamotor;
            _marcachasis = p_marcachasis;
            _numeromotor = p_numeromotor;
            _chasisnumero = p_chasisnumero;
            _prubro = p_prubro;
            _categoria = p_categoria;
            _pesocilindrada = p_pesocilindrada;
            _codigomarca = p_codigomarca;
            _combustible = p_combustible;
            _apellidoynombrerazonsocial = p_apellidoynombrerazonsocial;
            _numerodocumento = p_numerodocumento;
            _dni = p_dni;
            _le = p_le;
            _lc = p_lc;
            _ci = p_ci;
            _pas = p_pas;
            _cuilcuit = p_cuilcuit;
            _dfcallenombre = p_dfcallenombre;
            _dfcallenro = p_dfcallenro;
            _dfcallepiso = p_dfcallepiso;
            _dfcalledpto = p_dfcalledpto;
            _dfbarriolocalidad = p_dfbarriolocalidad;
            _dfcodpost = p_dfcodpost;
            _dfprovincia = p_dfprovincia;
            _dpcallenombre = p_dpcallenombre;
            _dpcallenro = p_dpcallenro;
            _dpcallepiso = p_dpcallepiso;
            _dpcalledpto = p_dpcalledpto;
            _dpbarriolocalidad = p_dpbarriolocalidad;
            _dpcodpost = p_dpcodpost;
            _dpprovincia = p_dpprovincia;
            InitializeComponent();
            EstablecerHandlers();
        }
        private void EstablecerHandlers()
        {
          

        }



        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {

            new Class.ReportingCalibration(reportViewer1);



        }

        private void F31A_Frente_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ainscripcioninicial", _Ainscripcioninicial));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Acambioradicacion", _Acambioradicacion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Asubastadosyarmados", _Asubastadosyarmados));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Arecuperorobo", _Arecuperorobo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dominio", _dominio));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dominioanterior", _dominioanterior));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_nacionalimportado", _nacionalimportado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_bfechadecompra", _bfechadecompra));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_bfechadealta", _bfechadealta));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_reservadorentas", _reservadorentas));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcaymodelo", _marcaymodelo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_tipo", _tipo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_modeloaño", _modeloaño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcamotor", _marcamotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_marcachasis", _marcachasis));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numeromotor", _numeromotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_chasisnumero", _chasisnumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_prubro", _prubro));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_categoria", _categoria));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_pesocilindrada", _pesocilindrada));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_codigomarca", _codigomarca));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_combustible", _combustible));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apellidoynombrerazonsocial", _apellidoynombrerazonsocial));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_numerodocumento", _numerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dni", _dni));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_le", _le));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lc", _lc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ci", _ci));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_pas", _pas));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_cuilcuit", _cuilcuit));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfcallenombre", _dfcallenombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfcallenro", _dfcallenro));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfcallepiso", _dfcallepiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfcalledpto", _dfcalledpto));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfbarriolocalidad", _dfbarriolocalidad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfcodpost", _dfcodpost));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfprovincia", _dfprovincia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpcallenombre", _dpcallenombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpcallenro", _dpcallenro));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpcallepiso", _dpcallepiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpcalledpto", _dpcalledpto));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpbarriolocalidad", _dpbarriolocalidad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpcodpost", _dpcodpost));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpprovincia", _dpprovincia));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
