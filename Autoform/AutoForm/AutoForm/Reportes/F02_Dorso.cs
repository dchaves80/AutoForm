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
    public partial class F02_Dorso : Form
    {
        bool seted = false;
        string _diaordena;
        string _mesordena;
        string _añoordena;
        string _dialevantamiento;
        string _meslevantamiento;
        string _añolevantamiento;
        string _juzgado;
        string _secretaria;
        string _iapellidoynombretitutlar;
        string _icondominio;
        string _idninat;
        string _ilenat;
        string _ilcnat;
        string _idniext;
        string _iciext;
        string _ipasapext;
        string _inumerodocumento;
        string _iautoridad;
        string _ipersoneria;
        string _idatosinscripcion;
        string _idiainscripcion;
        string _imesinscripcion;
        string _iañoinscripcion;

        string _jporcentageentero;
        string _jporcentagedecimal;
        string _japellidoynombre;
        string _jsexo;
        string _jcalle;
        string _jdninat;
        string _jlenat;
        string _jlcnat;
        string _jdniext;
        string _jciext;
        string _jpasapext;
        string _jnumerodocumento;
        string _jautoridad;

        string _jdianac;
        string _jmesnac;
        string _jañonac;
        string _jsoltero;
        string _jcasado;
        string _jviudo;
        string _jdivorciado;
        string _jnupcianumero;
        string _japellidoynombreconyuge;
        string _jpersoneria;
        string _jdatosinscripcion;
        string _jdiainscripcion;
        string _jmesinscripcion;
        string _jañoinscripcion;


        string _kporcentageentero;
        string _kporcentagedecimal;
        string _kapellidoynombre;
        string _ksexo;
        string _kcalle;
        string _kdninat;
        string _klenat;
        string _klcnat;
        string _kdniext;
        string _kciext;
        string _kpasapext;
        string _knumerodocumento;
        string _kautoridad;

        string _kdianac;
        string _kmesnac;
        string _kañonac;
        string _ksoltero;
        string _kcasado;
        string _kviudo;
        string _kdivorciado;
        string _knupcianumero;
        string _kapellidoynombreconyuge;
        string _kpersoneria;
        string _kdatosinscripcion;
        string _kdiainscripcion;
        string _kmesinscripcion;
        string _kañoinscripcion;
        string _lapellidonombrevendedor;
            string _lfechatransferencia;
            string _lnrpamotor;
            string _lnrpachasis;
            string _mobservaciones;
            string _nlugar;
            string _nfechadia;
            string _nfechames;
            string _nfechaaño;
            string _oautorizo;
            string _otipodocumento;
            
    
        public F02_Dorso(

        string p_diaordena,
        string p_mesordena,
        string p_añoordena,
        string p_dialevantamiento,
        string p_meslevantamiento,
        string p_añolevantamiento,
        string p_juzgado,
            string p_secretaria,
            string p_iapellidoynombretitutlar,
        string p_icondominio,
        string p_idninat,
        string p_ilenat,
        string p_ilcnat,
        string p_idniext,
        string p_iciext,
        string p_ipasapext,
            string p_inumerodocumento,
        string p_iautoridad,
        string p_ipersoneria,
        string p_idatosinscripcion,
        string p_idiainscripcion,
        string p_imesinscripcion,
        string p_iañoinscripcion,

            string p_jporcentageentero,
        string p_jporcentagedecimal,
        string p_japellidoynombre,
        string p_jsexo,
        string p_jcalle,
             string p_jdninat,
        string p_jlenat,
        string p_jlcnat,
        string p_jdniext,
        string p_jciext,
        string p_jpasapext,
            string P_jnumerodocumento,
        string p_jautoridad,
            string p_jdianac,
        string p_jmesnac,
        string p_jañonac,
        string p_jsoltero,
        string p_jcasado,
        string p_jviudo,
        string p_jdivorciado,
        string p_jnupcianumero,
        string p_japellidoynombreconyuge,
        string p_jpersoneria,
        string p_jdatosinscripcion,
        string p_jdiainscripcion,
        string p_jmesinscripcion,
        string p_jañoinscripcion,

            string p_kporcentageentero,
        string p_kporcentagedecimal,
        string p_kapellidoynombre,
        string p_ksexo,
        string p_kcalle,
             string p_kdninat,
        string p_klenat,
        string p_klcnat,
        string p_kdniext,
        string p_kciext,
        string p_kpasapext,
            string p_knumerodocumento,
        string p_kautoridad,
            string p_kdianac,
        string p_kmesnac,
        string p_kañonac,
        string p_ksoltero,
        string p_kcasado,
        string p_kviudo,
        string p_kdivorciado,
        string p_knupcianumero,
        string p_kapellidoynombreconyuge,
        string p_kpersoneria,
        string p_kdatosinscripcion,
        string p_kdiainscripcion,
        string p_kmesinscripcion,
        string p_kañoinscripcion,
        string p_lapellidonombrevendedor,
            string p_lfechatransferencia,
            string p_lnrpamotor,
            string p_lnrpachasis,
            string p_mobservaciones,
            string p_nlugar,
            string p_nfechadia,
            string p_nfechames,
            string p_nfechaaño,
            string p_oautorizo,
            string p_otipodocumento


            )
        {
            _diaordena = p_diaordena;
            _mesordena = p_mesordena;
            _añoordena = p_añoordena;
            _dialevantamiento = p_dialevantamiento;
            _meslevantamiento = p_meslevantamiento;
            _añolevantamiento = p_añolevantamiento;
            _juzgado = p_juzgado;
            _secretaria = p_secretaria;
            _iapellidoynombretitutlar = p_iapellidoynombretitutlar;
            _icondominio = p_icondominio;
            _idninat = p_idninat;
            _ilenat = p_ilenat;
            _ilcnat = p_ilcnat;
            _idniext = p_idniext;
            _iciext = p_iciext;
            _ipasapext = p_ipasapext;
            _inumerodocumento = p_inumerodocumento;
            _iautoridad = p_iautoridad;
            _ipersoneria = p_ipersoneria;
            _idatosinscripcion = p_idatosinscripcion;
            _idiainscripcion = p_idiainscripcion;
            _imesinscripcion = p_imesinscripcion;
            _iañoinscripcion = p_iañoinscripcion;
            _jporcentageentero = p_jporcentageentero;
            _jporcentagedecimal = p_jporcentagedecimal;
            _japellidoynombre = p_japellidoynombre;
            _jsexo = p_jsexo;
            _jcalle = p_jcalle;
            _jdninat = p_jdninat;
            _jlenat = p_jlenat;
            _jlcnat = p_jlcnat;
            _jdniext = p_jdniext;
            _jciext = p_jciext;
            _jpasapext = p_jpasapext;
            _jnumerodocumento = P_jnumerodocumento;
            _jautoridad = p_jautoridad;

            _jdianac = p_jdianac;
            _jmesnac = p_jmesnac;
            _jañonac = p_jañonac;
            _jsoltero = p_jsoltero;
            _jcasado = p_jcasado;
            _jviudo = p_jviudo;
            _jdivorciado = p_jdivorciado;
            _jnupcianumero = p_jnupcianumero;
            _japellidoynombreconyuge = p_japellidoynombreconyuge;
            _jpersoneria = p_jpersoneria;
            _jdatosinscripcion = p_jdatosinscripcion;
            _jdiainscripcion = p_jdiainscripcion;
            _jmesinscripcion = p_jmesinscripcion;
            _jañoinscripcion = p_jañoinscripcion;



            _kporcentageentero = p_kporcentageentero;
            _kporcentagedecimal = p_kporcentagedecimal;
            _kapellidoynombre = p_kapellidoynombre;
            _ksexo = p_ksexo;
            _kcalle = p_kcalle;
            _kdninat = p_kdninat;
            _klenat = p_klenat;
            _klcnat = p_klcnat;
            _kdniext = p_kdniext;
            _kciext = p_kciext;
            _kpasapext = p_kpasapext;
            _knumerodocumento = p_knumerodocumento;
            _kautoridad = p_kautoridad;

            _kdianac = p_kdianac;
            _kmesnac = p_kmesnac;
            _kañonac = p_kañonac;
            _ksoltero = p_ksoltero;
            _kcasado = p_kcasado;
            _kviudo = p_kviudo;
            _kdivorciado = p_kdivorciado;
            _knupcianumero = p_knupcianumero;
            _kapellidoynombreconyuge = p_kapellidoynombreconyuge;
            _kpersoneria = p_kpersoneria;
            _kdatosinscripcion = p_kdatosinscripcion;
            _kdiainscripcion = p_kdiainscripcion;
            _kmesinscripcion = p_kmesinscripcion;
            _kañoinscripcion = p_kañoinscripcion;
            _lapellidonombrevendedor = p_lapellidonombrevendedor;
            _lfechatransferencia=p_lfechatransferencia;
            _lnrpamotor = p_lnrpamotor;
            _lnrpachasis = p_lnrpachasis;
            _mobservaciones=p_mobservaciones;
            _nlugar=p_nlugar;
            _nfechadia=p_nfechadia;
            _nfechames=p_nfechames;
            _nfechaaño = p_nfechaaño;
            _oautorizo=p_oautorizo;
            _otipodocumento=p_otipodocumento;

            InitializeComponent();

        }

        private void F02_Dorso_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_diaordena", _diaordena));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_mesordena", _mesordena));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_añoordena", _añoordena));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_dialevantamiento", _dialevantamiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_meslevantamiento", _meslevantamiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_añolevantamiento", _añolevantamiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_juzgado", _juzgado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_secretaria", _secretaria));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apellidoynombretitular", _iapellidoynombretitutlar));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_condominio", _icondominio));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_idninat", _idninat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ilenat", _ilenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ilcnat", _ilcnat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_idniext", _idniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_iciext", _iciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ipasapext", _ipasapext));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_inumerodocumento", _inumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_iautoridad", _iautoridad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ipersoneria", _ipersoneria));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_idatosinscripcion", _idatosinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_idiainscripcion", _idiainscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_imesinscripcion", _imesinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_iañoinscripcion", _iañoinscripcion));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jporcentageentero", _jporcentageentero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jporcentagedecimal", _jporcentagedecimal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_japellidoynombre", _japellidoynombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jsexo", _jsexo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jcalle", _jcalle));


            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jdninat", _jdninat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jlenat", _jlenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jlcnat", _jlcnat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jdniext", _jdniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jciext", _jciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jpasapext", _jpasapext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jnumerodocumento", _jnumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jautoridad", _jautoridad));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jdianac", _jdianac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jmesnac", _jmesnac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jañonac", _jañonac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jsoltero", _jsoltero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jcasado", _jcasado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jviudo", _jviudo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jdivorciado", _jdivorciado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jnupcianumero", _jnupcianumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_japellidoynombreconyuge", _japellidoynombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jpersoneria", _jpersoneria));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jdatosinscripcion", _jdatosinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jdiainscripcion", _jdianac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jmesinscripcion", _jmesinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_jañoinscripcion", _jañoinscripcion));



            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kporcentageentero", _kporcentageentero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kporcentagedecimal", _kporcentagedecimal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kapellidoynombre", _kapellidoynombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ksexo", _ksexo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kcalle", _kcalle));


            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kdninat", _kdninat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_klenat", _klenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_klcnat", _klcnat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kdniext", _kdniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kciext", _kciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kpasapext", _kpasapext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_knumerodocumento", _knumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kautoridad", _kautoridad));

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kdianac", _kdianac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kmesnac", _kmesnac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kañonac", _kañonac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ksoltero", _ksoltero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kcasado", _kcasado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kviudo", _kviudo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kdivorciado", _kdivorciado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_knupcianumero", _knupcianumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kapellidoynombreconyuge", _kapellidoynombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kpersoneria", _kpersoneria));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kdatosinscripcion", _kdatosinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kdiainscripcion", _kdianac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kmesinscripcion", _kmesinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_kañoinscripcion", _kañoinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lapellidonombrevendedor",_lapellidonombrevendedor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lfechatransferencia",_lfechatransferencia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lnrpamotor",_lnrpamotor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_lnrpachasis",_lnrpachasis));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_mobservaciones",_mobservaciones));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_nlugar",_nlugar));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_nfechadia",_nfechadia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_nfechames",_nfechames));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_nfechaaño",_nfechaaño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_oautorizo",_oautorizo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_otipodocumento", _otipodocumento));

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            
        }


        

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {


            MessageBox.Show("ORIGINAL \n centimetros left:" + reportViewer1.Margin.Left.ToString() + "\n" + "centimetros top:" + reportViewer1.Margin.Top.ToString());
            
            if (reportViewer1.GetTotalPages() > 1) 
                {
                    MessageBox.Show("El reporte contiene mas de una página, esto puede ocasionar una impresión erronea en el reporte, reduzca el contenido de los campos que se encuentran al final del formulario o campos extensos como por ejemplo observaciones o documentacion extra","Error en el reporte",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
                }

            if (seted == false) 
            {
                seted = true;
                System.Drawing.Printing.PageSettings PS = new System.Drawing.Printing.PageSettings();
                PS.Margins.Top = Convert.ToInt32(Class.Medida.ObtenerMedidaVertical() * 100m);
                PS.Margins.Left = Convert.ToInt32(Class.Medida.ObtenerMedidaHorizontal() * 100m);
                PS.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
                
                reportViewer1.SetPageSettings(PS);

                MessageBox.Show("centimetros left:" + PS.Margins.Left.ToString() + "\n" + "centimetros top:" + PS.Margins.Top.ToString());
                
            }
            
            
                
          
            
        }

        private void F02_Dorso_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Clear();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
              
           
        }

        private void reportViewer1_RenderingBegin(object sender, CancelEventArgs e)
        {
           
        }
    }
}
