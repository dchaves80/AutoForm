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
    public partial class F08_Frente_Motovehiculo : Form
    {
        string _alugaryfechadecelebracion;
        string _apreciodecompra;
        string _adominio;
        
        string _dporcentajeentero;
        string _dporcentajedecimal;
        string _dapellidoynombreodenominacion;
        string _dsexo;
        string _demail;
        string _dtelefono;
        string _ddomiciliolegalcalle;
        string _ddomicilionumero;
        string _ddomiciliopiso;
        string _ddomiciliodepartamento;
        string _dcodigopostal;
        string _dlocalidadocaba;
        string _dpartidoodepartamento;
        string _dprovincia;
        string _ddomiciliorealcalle;
        string _ddomiciliorealnumero;
        string _ddomiciliorealpiso;
        string _ddomiciliorealdepartamento;
        string _ddomiciliorealcodigopostal;
        string _ddomicilioreallocalidad;
        string _ddomiciliorealpartidoodepartamento;
        string _ddomiciliorealprovincia;
        string _dprofesionoficiooactppal;
        string _dnatdni;
        string _dnatle;
        string _dnatlc;
        string _dextdni;
        string _dextci;
        string _dextpasap;
        string _dnumerodocumento;
        string _dautoridadopais;
        string _dcuitcuilcdi;
        string _dlugarnacimiento;
        string _dfechanacdia;
        string _dfechanacmes;
        string _dfechanacaño;
        string _dsoltero;
        string _dcasado;
        string _dviudo;
        string _ddivorciado;
        string _dnupcianumero;
        string _dapellidoynombreconyuge;
        string _dpersoneriaotorgadapor;
        string _dnumeroodatosdeinscripcionocreacion;
        string _dinscripciondia;
        string _dinscripcionmes;
        string _dinscripcionaño;
        string _dceta;

        string _eporcentajeentero;
        string _eporcentajedecimal;
        string _eapellidoynombreodenominacion;
        string _esexo;
        string _eemail;
        string _etelefono;
        string _edomiciliolegalcalle;
        string _edomicilionumero;
        string _edomiciliopiso;
        string _edomiciliodepartamento;
        string _ecodigopostal;
        string _elocalidadocaba;
        string _epartidoodepartamento;
        string _eprovincia;
        string _edomiciliorealcalle;
        string _edomiciliorealnumero;
        string _edomiciliorealpiso;
        string _edomiciliorealdepartamento;
        string _edomiciliorealcodigopostal;
        string _edomicilioreallocalidad;
        string _edomiciliorealpartidoodepartamento;
        string _edomiciliorealprovincia;
        string _eprofesionoficiooactppal;
        string _enatdni;
        string _enatle;
        string _enatlc;
        string _eextdni;
        string _eextci;
        string _eextpasap;
        string _enumerodocumento;
        string _eautoridadopais;
        string _ecuitcuilcdi;
        string _elugarnacimiento;
        string _efechanacdia;
        string _efechanacmes;
        string _efechanacaño;
        string _esoltero;
        string _ecasado;
        string _eviudo;
        string _edivorciado;
        
        string _eapellidoynombreconyuge;
        string _epersoneriaotorgadapor;
        string _enumeroodatosdeinscripcionocreacion;
        string _einscripciondia;
        string _einscripcionmes;
        string _einscripcionaño;
        string _eceta;
        string _fdominio;
string _fmarca;
string _ftipo;
string _fmodelo;
string _fmarcamotor;
string _fnumeromotor;
string _fmarcachasis;
string _fnumerochasis;
string _fuso;
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_alugaryfechadecelebracion">666</param>
        /// <param name="p_apreciodecompra">666</param>
        /// <param name="p_adominio">666</param>
        /// <param name="p_dporcentajeentero">666</param>
        /// <param name="p_dporcentajedecimal">666</param>
        /// <param name="p_dapellidoynombreodenominacion">666</param>
        /// <param name="p_dsexo">666</param>
        /// <param name="p_demail">666</param>
        /// <param name="p_dtelefono">666</param>
        /// <param name="p_ddomiciliolegalcalle">666</param>
        /// <param name="p_ddomicilionumero">666</param>
        /// <param name="p_ddomiciliopiso">666</param>
        /// <param name="p_ddomiciliodepartamento">666</param>
        /// <param name="p_dcodigopostal">666</param>
        /// <param name="p_dlocalidadocaba">666</param>
        /// <param name="p_dpartidoodepartamento">666</param>
        /// <param name="p_dprovincia">666</param>
        /// <param name="p_ddomiciliorealcalle">666</param>
        /// <param name="p_ddomiciliorealnumero">666</param>
        /// <param name="p_ddomiciliorealpiso">666</param>
        /// <param name="p_ddomiciliorealdepartamento">666</param>
        /// <param name="p_ddomiciliorealcodigopostal">666</param>
        /// <param name="p_ddomicilioreallocalidad">666</param>
        /// <param name="p_ddomiciliorealpartidoodepartamento">666</param>
        /// <param name="p_ddomiciliorealprovincia">666</param>
        /// <param name="p_dprofesionoficiooactppal">666</param>
        /// <param name="p_dnatdni">666</param>
        /// <param name="p_dnatle">666</param>
        /// <param name="p_dnatlc">666</param>
        /// <param name="p_dextdni">666</param>
        /// <param name="p_dextci">666</param>
        /// <param name="p_dextpasap">666</param>
        /// <param name="p_dnumerodocumento">666</param>
        /// <param name="p_dautoridadopais">666</param>
        /// <param name="p_dcuitcuilcdi">666</param>
        /// <param name="p_dlugarnacimiento">666</param>
        /// <param name="p_dfechanacdia">666</param>
        /// <param name="p_dfechanacmes">666</param>
        /// <param name="p_dfechanacaño">666</param>
        /// <param name="p_dsoltero">666</param>
        /// <param name="p_dcasado">666</param>
        /// <param name="p_dviudo">666</param>
        /// <param name="p_ddivorciado">666</param>
        /// <param name="p_dnupcianumero">666</param>
        /// <param name="p_dapellidoynombreconyuge">666</param>
        /// <param name="p_dpersoneriaotorgadapor">666</param>
        /// <param name="p_dnumeroodatosdeinscripcionocreacion">666</param>
        /// <param name="p_dinscripciondia">666</param>
        /// <param name="p_dinscripcionmes">666</param>
        /// <param name="p_dinscripcionaño">666</param>
        /// <param name="p_dceta">666</param>
        /// <param name="p_eporcentajeentero">666</param>
        /// <param name="p_eporcentajedecimal">666</param>
        /// <param name="p_eapellidoynombreodenominacion">666</param>
        /// <param name="p_esexo">666</param>
        /// <param name="p_eemail">666</param>
        /// <param name="p_etelefono">666</param>
        /// <param name="p_edomiciliolegalcalle">666</param>
        /// <param name="p_edomicilionumero">666</param>
        /// <param name="p_edomiciliopiso">666</param>
        /// <param name="p_edomiciliodepartamento">666</param>
        /// <param name="p_ecodigopostal">666</param>
        /// <param name="p_elocalidadocaba">666</param>
        /// <param name="p_epartidoodepartamento">666</param>
        /// <param name="p_eprovincia">666</param>
        /// <param name="p_edomiciliorealcalle">666</param>
        /// <param name="p_edomiciliorealnumero">666</param>
        /// <param name="p_edomiciliorealpiso">666</param>
        /// <param name="p_edomiciliorealdepartamento">666</param>
        /// <param name="p_edomiciliorealcodigopostal">666</param>
        /// <param name="p_edomicilioreallocalidad">666</param>
        /// <param name="p_edomiciliorealpartidoodepartamento">666</param>
        /// <param name="p_edomiciliorealprovincia">666</param>
        /// <param name="p_eprofesionoficiooactppal">666</param>
        /// <param name="p_enatdni">666</param>
        /// <param name="p_enatle">666</param>
        /// <param name="p_enatlc">666</param>
        /// <param name="p_eextdni">666</param>
        /// <param name="p_eextci">666</param>
        /// <param name="p_eextpasap">666</param>
        /// <param name="p_enumerodocumento">666</param>
        /// <param name="p_eautoridadopais">666</param>
        /// <param name="p_ecuitcuilcdi">666</param>
        /// <param name="p_elugarnacimiento">666</param>
        /// <param name="p_efechanacdia">666</param>
        /// <param name="p_efechanacmes">666</param>
        /// <param name="p_efechanacaño">666</param>
        /// <param name="p_esoltero">666</param>
        /// <param name="p_ecasado">666</param>
        /// <param name="p_eviudo">666</param>
        /// <param name="p_edivorciado">666</param>
        /// <param name="p_eapellidoynombreconyuge">666</param>
        /// <param name="p_epersoneriaotorgadapor">666</param>
        /// <param name="p_enumeroodatosdeinscripcionocreacion">666</param>
        /// <param name="p_einscripciondia">666</param>
        /// <param name="p_einscripcionmes">666</param>
        /// <param name="p_einscripcionaño">666</param>
        /// <param name="p_eceta">666</param>
        /// <param name="p_fdominio">666</param>
        /// <param name="p_fmarca">666</param>
        /// <param name="p_ftipo">666</param>
        /// <param name="p_fmodelo">666</param>
        /// <param name="p_fmarcamotor">666</param>
        /// <param name="p_fnumeromotor">666</param>
        /// <param name="p_fmarcachasis">666</param>
        /// <param name="p_fnumerochasis">666</param>
        /// <param name="p_fuso">666</param>

        public F08_Frente_Motovehiculo
            (

            string p_alugaryfechadecelebracion,
string p_apreciodecompra,
string p_adominio,
string p_dporcentajeentero,
string p_dporcentajedecimal,
string p_dapellidoynombreodenominacion,
string p_dsexo,
string p_demail,
string p_dtelefono,
string p_ddomiciliolegalcalle,
string p_ddomicilionumero,
string p_ddomiciliopiso,
string p_ddomiciliodepartamento,
string p_dcodigopostal,
string p_dlocalidadocaba,
string p_dpartidoodepartamento,
string p_dprovincia,
string p_ddomiciliorealcalle,
string p_ddomiciliorealnumero,
string p_ddomiciliorealpiso,
string p_ddomiciliorealdepartamento,
string p_ddomiciliorealcodigopostal,
string p_ddomicilioreallocalidad,
string p_ddomiciliorealpartidoodepartamento,
string p_ddomiciliorealprovincia,
string p_dprofesionoficiooactppal,
string p_dnatdni,
string p_dnatle,
string p_dnatlc,
string p_dextdni,
string p_dextci,
string p_dextpasap,
string p_dnumerodocumento,
string p_dautoridadopais,
string p_dcuitcuilcdi,
string p_dlugarnacimiento,
string p_dfechanacdia,
string p_dfechanacmes,
string p_dfechanacaño,
string p_dsoltero,
string p_dcasado,
string p_dviudo,
string p_ddivorciado,
string p_dnupcianumero,
string p_dapellidoynombreconyuge,
string p_dpersoneriaotorgadapor,
string p_dnumeroodatosdeinscripcionocreacion,
string p_dinscripciondia,
string p_dinscripcionmes,
string p_dinscripcionaño,
string p_dceta,
            string p_eporcentajeentero,
string p_eporcentajedecimal,
string p_eapellidoynombreodenominacion,
string p_esexo,
string p_eemail,
string p_etelefono,
string p_edomiciliolegalcalle,
string p_edomicilionumero,
string p_edomiciliopiso,
string p_edomiciliodepartamento,
string p_ecodigopostal,
string p_elocalidadocaba,
string p_epartidoodepartamento,
string p_eprovincia,
string p_edomiciliorealcalle,
string p_edomiciliorealnumero,
string p_edomiciliorealpiso,
string p_edomiciliorealdepartamento,
string p_edomiciliorealcodigopostal,
string p_edomicilioreallocalidad,
string p_edomiciliorealpartidoodepartamento,
string p_edomiciliorealprovincia,
string p_eprofesionoficiooactppal,
string p_enatdni,
string p_enatle,
string p_enatlc,
string p_eextdni,
string p_eextci,
string p_eextpasap,
string p_enumerodocumento,
string p_eautoridadopais,
string p_ecuitcuilcdi,
string p_elugarnacimiento,
string p_efechanacdia,
string p_efechanacmes,
string p_efechanacaño,
string p_esoltero,
string p_ecasado,
string p_eviudo,
string p_edivorciado,

string p_eapellidoynombreconyuge,
string p_epersoneriaotorgadapor,
string p_enumeroodatosdeinscripcionocreacion,
string p_einscripciondia,
string p_einscripcionmes,
string p_einscripcionaño,
string p_eceta,
            string p_fdominio,
string p_fmarca,
string p_ftipo,
string p_fmodelo,
string p_fmarcamotor,
string p_fnumeromotor,
string p_fmarcachasis,
string p_fnumerochasis,
string p_fuso

            )
        {


            _alugaryfechadecelebracion = p_alugaryfechadecelebracion;
            _apreciodecompra = p_apreciodecompra;
            _adominio = p_adominio;
            _dporcentajeentero = p_dporcentajeentero;
            _dporcentajedecimal = p_dporcentajedecimal;
            _dapellidoynombreodenominacion = p_dapellidoynombreodenominacion;
            _dsexo = p_dsexo;
            _demail = p_demail;
            _dtelefono = p_dtelefono;
            _ddomiciliolegalcalle = p_ddomiciliolegalcalle;
            _ddomicilionumero = p_ddomicilionumero;
            _ddomiciliopiso = p_ddomiciliopiso;
            _ddomiciliodepartamento = p_ddomiciliodepartamento;
            _dcodigopostal = p_dcodigopostal;
            _dlocalidadocaba = p_dlocalidadocaba;
            _dpartidoodepartamento = p_dpartidoodepartamento;
            _dprovincia = p_dprovincia;
            _ddomiciliorealcalle = p_ddomiciliorealcalle;
            _ddomiciliorealnumero = p_ddomiciliorealnumero;
            _ddomiciliorealpiso = p_ddomiciliorealpiso;
            _ddomiciliorealdepartamento = p_ddomiciliorealdepartamento;
            _ddomiciliorealcodigopostal = p_ddomiciliorealcodigopostal;
            _ddomicilioreallocalidad = p_ddomicilioreallocalidad;
            _ddomiciliorealpartidoodepartamento = p_ddomiciliorealpartidoodepartamento;
            _ddomiciliorealprovincia = p_ddomiciliorealprovincia;
            _dprofesionoficiooactppal = p_dprofesionoficiooactppal;
            _dnatdni = p_dnatdni;
            _dnatle = p_dnatle;
            _dnatlc = p_dnatlc;
            _dextdni = p_dextdni;
            _dextci = p_dextci;
            _dextpasap = p_dextpasap;
            _dnumerodocumento = p_dnumerodocumento;
            _dautoridadopais = p_dautoridadopais;
            _dcuitcuilcdi = p_dcuitcuilcdi;
            _dlugarnacimiento = p_dlugarnacimiento;
            _dfechanacdia = p_dfechanacdia;
            _dfechanacmes = p_dfechanacmes;
            _dfechanacaño = p_dfechanacaño;
            _dsoltero = p_dsoltero;
            _dcasado = p_dcasado;
            _dviudo = p_dviudo;
            _ddivorciado = p_ddivorciado;
            _dnupcianumero = p_dnupcianumero;
            _dapellidoynombreconyuge = p_dapellidoynombreconyuge;
            _dpersoneriaotorgadapor = p_dpersoneriaotorgadapor;
            _dnumeroodatosdeinscripcionocreacion = p_dnumeroodatosdeinscripcionocreacion;
            _dinscripciondia = p_dinscripciondia;
            _dinscripcionmes = p_dinscripcionmes;
            _dinscripcionaño = p_dinscripcionaño;
            _dceta = p_dceta;
            _eporcentajeentero = p_eporcentajeentero;
            _eporcentajedecimal = p_eporcentajedecimal;
            _eapellidoynombreodenominacion = p_eapellidoynombreodenominacion;
            _esexo = p_esexo;
            _eemail = p_eemail;
            _etelefono = p_etelefono;
            _edomiciliolegalcalle = p_edomiciliolegalcalle;
            _edomicilionumero = p_edomicilionumero;
            _edomiciliopiso = p_edomiciliopiso;
            _edomiciliodepartamento = p_edomiciliodepartamento;
            _ecodigopostal = p_ecodigopostal;
            _elocalidadocaba = p_elocalidadocaba;
            _epartidoodepartamento = p_epartidoodepartamento;
            _eprovincia = p_eprovincia;
            _edomiciliorealcalle = p_edomiciliorealcalle;
            _edomiciliorealnumero = p_edomiciliorealnumero;
            _edomiciliorealpiso = p_edomiciliorealpiso;
            _edomiciliorealdepartamento = p_edomiciliorealdepartamento;
            _edomiciliorealcodigopostal = p_edomiciliorealcodigopostal;
            _edomicilioreallocalidad = p_edomicilioreallocalidad;
            _edomiciliorealpartidoodepartamento = p_edomiciliorealpartidoodepartamento;
            _edomiciliorealprovincia = p_edomiciliorealprovincia;
            _eprofesionoficiooactppal = p_eprofesionoficiooactppal;
            _enatdni = p_enatdni;
            _enatle = p_enatle;
            _enatlc = p_enatlc;
            _eextdni = p_eextdni;
            _eextci = p_eextci;
            _eextpasap = p_eextpasap;
            _enumerodocumento = p_enumerodocumento;
            _eautoridadopais = p_eautoridadopais;
            _ecuitcuilcdi = p_ecuitcuilcdi;
            _elugarnacimiento = p_elugarnacimiento;
            _efechanacdia = p_efechanacdia;
            _efechanacmes = p_efechanacmes;
            _efechanacaño = p_efechanacaño;
            _esoltero = p_esoltero;
            _ecasado = p_ecasado;
            _eviudo = p_eviudo;
            _edivorciado = p_edivorciado;
          
            _eapellidoynombreconyuge = p_eapellidoynombreconyuge;
            _epersoneriaotorgadapor = p_epersoneriaotorgadapor;
            _enumeroodatosdeinscripcionocreacion = p_enumeroodatosdeinscripcionocreacion;
            _einscripciondia = p_einscripciondia;
            _einscripcionmes = p_einscripcionmes;
            _einscripcionaño = p_einscripcionaño;
            _eceta = p_eceta;
            _fdominio = p_fdominio;
            _fmarca = p_fmarca;
            _ftipo = p_ftipo;
            _fmodelo = p_fmodelo;
            _fmarcamotor = p_fmarcamotor;
            _fnumeromotor = p_fnumeromotor;
            _fmarcachasis = p_fmarcachasis;
            _fnumerochasis = p_fnumerochasis;
            _fuso = p_fuso;

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
                //this.Close();
            }



        }

        private void F08_Frente_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_alugaryfechadecelebracion", _alugaryfechadecelebracion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apreciodecompra", _apreciodecompra));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adominio", _adominio));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dporcentajeentero", _dporcentajeentero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dporcentajedecimal", _dporcentajedecimal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dapellidoynombreodenominacion", _dapellidoynombreodenominacion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsexo", _dsexo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_demail", _demail));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dtelefono", _dtelefono));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliolegalcalle", _ddomiciliolegalcalle));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomicilionumero", _ddomicilionumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliopiso", _ddomiciliopiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliodepartamento", _ddomiciliodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dcodigopostal", _dcodigopostal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dlocalidadocaba", _dlocalidadocaba));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpartidoodepartamento", _dpartidoodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dprovincia", _dprovincia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealcalle", _ddomiciliorealcalle));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealnumero", _ddomiciliorealnumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealpiso", _ddomiciliorealpiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealdepartamento", _ddomiciliorealdepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealcodigopostal", _ddomiciliorealcodigopostal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomicilioreallocalidad", _ddomicilioreallocalidad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealpartidoodepartamento", _ddomiciliorealpartidoodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddomiciliorealprovincia", _ddomiciliorealprovincia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dprofesionoficiooactppal", _dprofesionoficiooactppal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dnatdni", _dnatdni));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dnatle", _dnatle));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dnatlc", _dnatlc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dextdni", _dextdni));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dextci", _dextci));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dextpasap", _dextpasap));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dnumerodocumento", _dnumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dautoridadopais", _dautoridadopais));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dcuitcuilcdi", _dcuitcuilcdi));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dlugarnacimiento", _dlugarnacimiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfechanacdia", _dfechanacdia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfechanacmes", _dfechanacmes));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dfechanacaño", _dfechanacaño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dsoltero", _dsoltero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dcasado", _dcasado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dviudo", _dviudo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ddivorciado", _ddivorciado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dnupcianumero", _dnupcianumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dapellidoynombreconyuge", _dapellidoynombreconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dpersoneriaotorgadapor", _dpersoneriaotorgadapor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dnumeroodatosdeinscripcionocreacion", _dnumeroodatosdeinscripcionocreacion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dinscripciondia", _dinscripciondia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dinscripcionmes", _dinscripcionmes));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dinscripcionaño", _dinscripcionaño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dceta", _dceta));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eporcentajeentero", _eporcentajeentero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eporcentajedecimal", _eporcentajedecimal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eapellidoynombreodenominacion", _eapellidoynombreodenominacion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_esexo", _esexo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eemail", _eemail));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_etelefono", _etelefono));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliolegalcalle", _edomiciliolegalcalle));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomicilionumero", _edomicilionumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliopiso", _edomiciliopiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliodepartamento", _edomiciliodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ecodigopostal", _ecodigopostal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_elocalidadocaba", _elocalidadocaba));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_epartidoodepartamento", _epartidoodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eprovincia", _eprovincia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealcalle", _edomiciliorealcalle));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealnumero", _edomiciliorealnumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealpiso", _edomiciliorealpiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealdepartamento", _edomiciliorealdepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealcodigopostal", _edomiciliorealcodigopostal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomicilioreallocalidad", _edomicilioreallocalidad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealpartidoodepartamento", _edomiciliorealpartidoodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edomiciliorealprovincia", _edomiciliorealprovincia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eprofesionoficiooactppal", _eprofesionoficiooactppal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_enatdni", _enatdni));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_enatle", _enatle));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_enatlc", _enatlc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eextdni", _eextdni));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eextci", _eextci));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eextpasap", _eextpasap));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_enumerodocumento", _enumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eautoridadopais", _eautoridadopais));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ecuitcuilcdi", _ecuitcuilcdi));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_elugarnacimiento", _elugarnacimiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_efechanacdia", _efechanacdia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_efechanacmes", _efechanacmes));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_efechanacaño", _efechanacaño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_esoltero", _esoltero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ecasado", _ecasado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eviudo", _eviudo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_edivorciado", _edivorciado));
            
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eapellidoynombreconyuge", _eapellidoynombreconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_epersoneriaotorgadapor", _epersoneriaotorgadapor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_enumeroodatosdeinscripcionocreacion", _enumeroodatosdeinscripcionocreacion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_einscripciondia", _einscripciondia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_einscripcionmes", _einscripcionmes));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_einscripcionaño", _einscripcionaño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_eceta", _eceta));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fdominio", _fdominio));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fmarca", _fmarca));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ftipo", _ftipo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fmodelo", _fmodelo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fmarcamotor", _fmarcamotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fnumeromotor", _fnumeromotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fmarcachasis", _fmarcachasis));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fnumerochasis", _fnumerochasis));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_fuso", _fuso));


            this.reportViewer1.RefreshReport();
        }
    }
}
