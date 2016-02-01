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
    public partial class F08_Dorso : Form
    {


        string _Iporcentajeentero;
        string _Iporcentajedecimal;
        string _Iapellidoynombrevendedor;
        string _Isoltero;
        string _Icasado;
        string _Iviudo;
        string _Idivorc;
        string _Inupcianumero;
        string _Iapellidoynombreapoderado;
        string _Idniapoderadonat;
        string _Ileapoderadonat;
        string _Ilcapoderadonat;
        string _Idniapoderadoext;
        string _Iciapoderadoext;
        string _Ipasapapoderadoext;
        string _Inumerodocumentoapoderado;
        string _Iautoridadapoderado;
        string _Iapellidoynombreconyuge;
        string _Iapellidoynombreapoderadoconyuge;
        string _Idniapoderadoconyugenat;
        string _Ileapoderadoconyugenat;
        string _Ilcapoderadoconyugenat;
        string _Idniapoderadoconyugeext;
        string _Iciapoderadoconyugeext;
        string _Ipasapapoderadoconyugeext;
        string _Inumerodocumentoapoderadoconyuge;
        string _Iautoridadapoderadoconyuge;
        string _Jporcentajeentero;
        string _Jporcentajedecimal;
        string _Japellidoynombrevendedor;
        string _Jsoltero;
        string _Jcasado;
        string _Jviudo;
        string _Jdivorc;
        string _Jnupcianumero;
        string _Japellidoynombreapoderado;
        string _Jdniapoderadonat;
        string _Jleapoderadonat;
        string _Jlcapoderadonat;
        string _Jdniapoderadoext;
        string _Jciapoderadoext;
        string _Jpasapapoderadoext;
        string _Jnumerodocumentoapoderado;
        string _Jautoridadapoderado;
        string _Japellidoynombreconyuge;
        string _Japellidoynombreapoderadoconyuge;
        string _Jdniapoderadoconyugenat;
        string _Jleapoderadoconyugenat;
        string _Jlcapoderadoconyugenat;
        string _Jdniapoderadoconyugeext;
        string _Jciapoderadoconyugeext;
        string _Jpasapapoderadoconyugeext;
        string _Jnumerodocumentoapoderadoconyuge;
        string _Jautoridadapoderadoconyuge;
        string _Kapellidoynombreapoderado;
        string _Kdninat;
        string _Klenat;
        string _Klcnat;
        string _Kdniext;
        string _Kciext;
        string _Kpasapext;
        string _Knumerodocumento;
        string _Kautoridad;
        string _Lapellidoynombreapoderado;
        string _Ldninat;
        string _Llenat;
        string _Llcnat;
        string _Ldniext;
        string _Lciext;
        string _Lpasapext;
        string _Lnumerodocumento;
        string _Lautoridad;
        string _Mobservaciones;
        string _NLugar;
        string _Ndia;
        string _Nmes;
        string _Naño;
        string _Oautorizoa;
        string _Otipodedocumentoynumero;
        string _Orecibi;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="p_Iporcentajeentero">666</param>
      /// <param name="p_Iporcentajedecimal">666</param>
      /// <param name="p_Iapellidoynombrevendedor">666</param>
      /// <param name="p_Isoltero">666</param>
      /// <param name="p_Icasado">666</param>
      /// <param name="p_Iviudo">666</param>
      /// <param name="p_Inupcianumero">666</param>
      /// <param name="p_Idivorc">666</param>
      /// <param name="p_Iapellidoynombreapoderado">666</param>
      /// <param name="p_Idniapoderadonat">666</param>
      /// <param name="p_Ileapoderadonat">666</param>
      /// <param name="p_Ilcapoderadonat">666</param>
      /// <param name="p_Idniapoderadoext">666</param>
      /// <param name="p_Iciapoderadoext">666</param>
      /// <param name="p_Ipasapapoderadoext">666</param>
      /// <param name="p_Inumerodocumentoapoderado">666</param>
      /// <param name="p_Iautoridadapoderado">666</param>
      /// <param name="p_Iapellidoynombreconyuge">666</param>
      /// <param name="p_Iapellidoynombreapoderadoconyuge">666</param>
      /// <param name="p_Idniapoderadoconyugenat">666</param>
      /// <param name="p_Ileapoderadoconyugenat">666</param>
      /// <param name="p_Ilcapoderadoconyugenat">666</param>
      /// <param name="p_Idniapoderadoconyugeext">666</param>
      /// <param name="p_Iciapoderadoconyugeext">666</param>
      /// <param name="p_Ipasapapoderadoconyugeext">666</param>
      /// <param name="p_Inumerodocumentoapoderadoconyuge">666</param>
      /// <param name="p_Iautoridadapoderadoconyuge">666</param>
      /// <param name="p_Jporcentajeentero">666</param>
      /// <param name="p_Jporcentajedecimal">666</param>
      /// <param name="p_Japellidoynombrevendedor">666</param>
      /// <param name="p_Jsoltero">666</param>
      /// <param name="p_Jcasado">666</param>
      /// <param name="p_Jviudo">666</param>
      /// <param name="p_Jnupcianumero">666</param>
      /// <param name="p_Jdivorc">666</param>
      /// <param name="p_Japellidoynombreapoderado">666</param>
      /// <param name="p_Jdniapoderadonat">666</param>
      /// <param name="p_Jleapoderadonat">666</param>
      /// <param name="p_Jlcapoderadonat">666</param>
      /// <param name="p_Jdniapoderadoext">666</param>
      /// <param name="p_Jciapoderadoext">666</param>
      /// <param name="p_Jpasapapoderadoext">666</param>
      /// <param name="p_Jnumerodocumentoapoderado">666</param>
      /// <param name="p_Jautoridadapoderado">666</param>
      /// <param name="p_Japellidoynombreconyuge">666</param>
      /// <param name="p_Japellidoynombreapoderadoconyuge">666</param>
      /// <param name="p_Jdniapoderadoconyugenat">666</param>
      /// <param name="p_Jleapoderadoconyugenat">666</param>
      /// <param name="p_Jlcapoderadoconyugenat">666</param>
      /// <param name="p_Jdniapoderadoconyugeext">666</param>
      /// <param name="p_Jciapoderadoconyugeext">666</param>
      /// <param name="p_Jpasapapoderadoconyugeext">666</param>
      /// <param name="p_Jnumerodocumentoapoderadoconyuge">666</param>
      /// <param name="p_Jautoridadapoderadoconyuge">666</param>
      /// <param name="p_Kapellidoynombreapoderado">666</param>
      /// <param name="p_Kdninat">666</param>
      /// <param name="p_Klenat">666</param>
      /// <param name="p_Klcnat">666</param>
      /// <param name="p_Kdniext">666</param>
      /// <param name="p_Kciext">666</param>
      /// <param name="p_Kpasapext">666</param>
      /// <param name="p_Knumerodocumento">666</param>
      /// <param name="p_Kautoridad">666</param>
      /// <param name="p_Lapellidoynombreapoderado">666</param>
      /// <param name="p_Ldninat">666</param>
      /// <param name="p_Llenat">666</param>
      /// <param name="p_Llcnat">666</param>
      /// <param name="p_Ldniext">666</param>
      /// <param name="p_Lciext">666</param>
      /// <param name="p_Lpasapext">666</param>
      /// <param name="p_Lnumerodocumento">666</param>
      /// <param name="p_Lautoridad">666</param>
      /// <param name="p_Mobservaciones">666</param>
      /// <param name="p_NLugar">666</param>
      /// <param name="p_Ndia">666</param>
      /// <param name="p_Nmes">666</param>
      /// <param name="p_Naño">666</param>
      /// <param name="p_Oautorizoa">666</param>
      /// <param name="p_Otipodedocumentoynumero">666</param>
      /// <param name="p_Orecibi">666</param>
        public F08_Dorso(
            string p_Iporcentajeentero,
string p_Iporcentajedecimal,
string p_Iapellidoynombrevendedor,
string p_Isoltero,
string p_Icasado,
string p_Iviudo,
string p_Inupcianumero,
string p_Idivorc,
string p_Iapellidoynombreapoderado,
string p_Idniapoderadonat,
string p_Ileapoderadonat,
string p_Ilcapoderadonat,
string p_Idniapoderadoext,
string p_Iciapoderadoext,
string p_Ipasapapoderadoext,
string p_Inumerodocumentoapoderado,
string p_Iautoridadapoderado,
string p_Iapellidoynombreconyuge,
string p_Iapellidoynombreapoderadoconyuge,
string p_Idniapoderadoconyugenat,
string p_Ileapoderadoconyugenat,
string p_Ilcapoderadoconyugenat,
string p_Idniapoderadoconyugeext,
string p_Iciapoderadoconyugeext,
string p_Ipasapapoderadoconyugeext,
string p_Inumerodocumentoapoderadoconyuge,
string p_Iautoridadapoderadoconyuge,
             string p_Jporcentajeentero,
string p_Jporcentajedecimal,
string p_Japellidoynombrevendedor,
string p_Jsoltero,
string p_Jcasado,
string p_Jviudo,
string p_Jnupcianumero,
string p_Jdivorc,
string p_Japellidoynombreapoderado,
string p_Jdniapoderadonat,
string p_Jleapoderadonat,
string p_Jlcapoderadonat,
string p_Jdniapoderadoext,
string p_Jciapoderadoext,
string p_Jpasapapoderadoext,
string p_Jnumerodocumentoapoderado,
string p_Jautoridadapoderado,
string p_Japellidoynombreconyuge,
string p_Japellidoynombreapoderadoconyuge,
string p_Jdniapoderadoconyugenat,
string p_Jleapoderadoconyugenat,
string p_Jlcapoderadoconyugenat,
string p_Jdniapoderadoconyugeext,
string p_Jciapoderadoconyugeext,
string p_Jpasapapoderadoconyugeext,
string p_Jnumerodocumentoapoderadoconyuge,
string p_Jautoridadapoderadoconyuge,
            string p_Kapellidoynombreapoderado,
string p_Kdninat,
string p_Klenat,
string p_Klcnat,
string p_Kdniext,
string p_Kciext,
string p_Kpasapext,
string p_Knumerodocumento,
string p_Kautoridad,
            string p_Lapellidoynombreapoderado,
            string p_Ldninat,
string p_Llenat,
string p_Llcnat,
string p_Ldniext,
string p_Lciext,
string p_Lpasapext,
string p_Lnumerodocumento,
string p_Lautoridad,
            string p_Mobservaciones,
string p_NLugar,
string p_Ndia,
string p_Nmes,
string p_Naño,
string p_Oautorizoa,
string p_Otipodedocumentoynumero,
string p_Orecibi
            
            )
        {
            _Iporcentajeentero = p_Iporcentajeentero;
            _Iporcentajedecimal = p_Iporcentajedecimal;
            _Iapellidoynombrevendedor = p_Iapellidoynombrevendedor;
            _Isoltero = p_Isoltero;
            _Icasado = p_Icasado;
            _Iviudo = p_Iviudo;
            _Idivorc = p_Idivorc;
            _Inupcianumero = p_Inupcianumero;
            _Iapellidoynombreapoderado = p_Iapellidoynombreapoderado;
            _Idniapoderadonat = p_Idniapoderadonat;
            _Ileapoderadonat = p_Ileapoderadonat;
            _Ilcapoderadonat = p_Ilcapoderadonat;
            _Idniapoderadoext = p_Idniapoderadoext;
            _Iciapoderadoext = p_Iciapoderadoext;
            _Ipasapapoderadoext = p_Ipasapapoderadoext;
            _Inumerodocumentoapoderado = p_Inumerodocumentoapoderado;
            _Iautoridadapoderado = p_Iautoridadapoderado;
            _Iapellidoynombreconyuge = p_Iapellidoynombreconyuge;
            _Iapellidoynombreapoderadoconyuge = p_Iapellidoynombreapoderadoconyuge;
            _Idniapoderadoconyugenat = p_Idniapoderadoconyugenat;
            _Ileapoderadoconyugenat = p_Ileapoderadoconyugenat;
            _Ilcapoderadoconyugenat = p_Ilcapoderadoconyugenat;
            _Idniapoderadoconyugeext = p_Idniapoderadoconyugeext;
            _Iciapoderadoconyugeext = p_Iciapoderadoconyugeext;
            _Ipasapapoderadoconyugeext = p_Ipasapapoderadoconyugeext;
            _Inumerodocumentoapoderadoconyuge = p_Inumerodocumentoapoderadoconyuge;
            _Iautoridadapoderadoconyuge = p_Iautoridadapoderadoconyuge;
            _Jporcentajeentero = p_Jporcentajeentero;
            _Jporcentajedecimal = p_Jporcentajedecimal;
            _Japellidoynombrevendedor = p_Japellidoynombrevendedor;
            _Jsoltero = p_Jsoltero;
            _Jcasado = p_Jcasado;
            _Jviudo = p_Jviudo;
            _Jdivorc = p_Jdivorc;
            _Jnupcianumero = p_Jnupcianumero;
            _Japellidoynombreapoderado = p_Japellidoynombreapoderado;
            _Jdniapoderadonat = p_Jdniapoderadonat;
            _Jleapoderadonat = p_Jleapoderadonat;
            _Jlcapoderadonat = p_Jlcapoderadonat;
            _Jdniapoderadoext = p_Jdniapoderadoext;
            _Jciapoderadoext = p_Jciapoderadoext;
            _Jpasapapoderadoext = p_Jpasapapoderadoext;
            _Jnumerodocumentoapoderado = p_Jnumerodocumentoapoderado;
            _Jautoridadapoderado = p_Jautoridadapoderado;
            _Japellidoynombreconyuge = p_Japellidoynombreconyuge;
            _Japellidoynombreapoderadoconyuge = p_Japellidoynombreapoderadoconyuge;
            _Jdniapoderadoconyugenat = p_Jdniapoderadoconyugenat;
            _Jleapoderadoconyugenat = p_Jleapoderadoconyugenat;
            _Jlcapoderadoconyugenat = p_Jlcapoderadoconyugenat;
            _Jdniapoderadoconyugeext = p_Jdniapoderadoconyugeext;
            _Jciapoderadoconyugeext = p_Jciapoderadoconyugeext;
            _Jpasapapoderadoconyugeext = p_Jpasapapoderadoconyugeext;
            _Jnumerodocumentoapoderadoconyuge = p_Jnumerodocumentoapoderadoconyuge;
            _Jautoridadapoderadoconyuge = p_Jautoridadapoderadoconyuge;
            _Kapellidoynombreapoderado = p_Kapellidoynombreapoderado;
            _Kdninat = p_Kdninat;
            _Klenat = p_Klenat;
            _Klcnat = p_Klcnat;
            _Kdniext = p_Kdniext;
            _Kciext = p_Kciext;
            _Kpasapext = p_Kpasapext;
            _Knumerodocumento = p_Knumerodocumento;
            _Kautoridad = p_Kautoridad;
            _Lapellidoynombreapoderado = p_Lapellidoynombreapoderado;
            _Ldninat = p_Ldninat;
            _Llenat = p_Llenat;
            _Llcnat = p_Llcnat;
            _Ldniext = p_Ldniext;
            _Lciext = p_Lciext;
            _Lpasapext = p_Lpasapext;
            _Lnumerodocumento = p_Lnumerodocumento;
            _Lautoridad = p_Lautoridad;
            _Mobservaciones = p_Mobservaciones;
            _NLugar = p_NLugar;
            _Ndia = p_Ndia;
            _Nmes = p_Nmes;
            _Naño = p_Naño;
            _Oautorizoa = p_Oautorizoa;
            _Otipodedocumentoynumero = p_Otipodedocumentoynumero;
            _Orecibi = p_Orecibi;
            
            InitializeComponent();
            EstablecerHandlers();
        }
        private void EstablecerHandlers()
        {
            reportViewer1.RenderingComplete += reportViewer1_RenderingComplete;

        }



        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {


        }

        private void F08_Dorso_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iporcentajeentero", _Iporcentajeentero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iporcentajedecimal", _Iporcentajedecimal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iapellidoynombrevendedor", _Iapellidoynombrevendedor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Isoltero", _Isoltero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Icasado", _Icasado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iviudo", _Iviudo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Idivorc", _Idivorc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Inupcianumero", _Inupcianumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iapellidoynombreapoderado", _Iapellidoynombreapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Idniapoderadonat", _Idniapoderadonat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ileapoderadonat", _Ileapoderadonat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ilcapoderadonat", _Ilcapoderadonat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Idniapoderadoext", _Idniapoderadoext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iciapoderadoext", _Iciapoderadoext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ipasapapoderadoext", _Ipasapapoderadoext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Inumerodocumentoapoderado", _Inumerodocumentoapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iautoridadapoderado", _Iautoridadapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iapellidoynombreconyuge", _Iapellidoynombreconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iapellidoynombreapoderadoconyuge", _Iapellidoynombreapoderadoconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Idniapoderadoconyugenat", _Idniapoderadoconyugenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ileapoderadoconyugenat", _Ileapoderadoconyugenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ilcapoderadoconyugenat", _Ilcapoderadoconyugenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Idniapoderadoconyugeext", _Idniapoderadoconyugeext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iciapoderadoconyugeext", _Iciapoderadoconyugeext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ipasapapoderadoconyugeext", _Ipasapapoderadoconyugeext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Inumerodocumentoapoderadoconyuge", _Inumerodocumentoapoderadoconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Iautoridadapoderadoconyuge", _Iautoridadapoderadoconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jporcentajeentero", _Jporcentajeentero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jporcentajedecimal", _Jporcentajedecimal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Japellidoynombrevendedor", _Japellidoynombrevendedor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jsoltero", _Jsoltero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jcasado", _Jcasado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jviudo", _Jviudo));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jdivorc", _Jdivorc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jnupcianumero", _Jnupcianumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Japellidoynombreapoderado", _Japellidoynombreapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jdniapoderadonat", _Jdniapoderadonat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jleapoderadonat", _Jleapoderadonat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jlcapoderadonat", _Jlcapoderadonat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jdniapoderadoext", _Jdniapoderadoext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jciapoderadoext", _Jciapoderadoext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jpasapapoderadoext", _Jpasapapoderadoext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jnumerodocumentoapoderado", _Jnumerodocumentoapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jautoridadapoderado", _Jautoridadapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Japellidoynombreconyuge", _Japellidoynombreconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Japellidoynombreapoderadoconyuge", _Japellidoynombreapoderadoconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jdniapoderadoconyugenat", _Jdniapoderadoconyugenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jleapoderadoconyugenat", _Jleapoderadoconyugenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jlcapoderadoconyugenat", _Jlcapoderadoconyugenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jdniapoderadoconyugeext", _Jdniapoderadoconyugeext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jciapoderadoconyugeext", _Jciapoderadoconyugeext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jpasapapoderadoconyugeext", _Jpasapapoderadoconyugeext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jnumerodocumentoapoderadoconyuge", _Jnumerodocumentoapoderadoconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Jautoridadapoderadoconyuge", _Jautoridadapoderadoconyuge));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Kapellidoynombreapoderado", _Kapellidoynombreapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Kdninat", _Kdninat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Klenat", _Klenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Klcnat", _Klcnat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Kdniext", _Kdniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Kciext", _Kciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Kpasapext", _Kpasapext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Knumerodocumento", _Knumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Kautoridad", _Kautoridad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Lapellidoynombreapoderado", _Lapellidoynombreapoderado));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ldninat", _Ldninat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Llenat", _Llenat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Llcnat", _Llcnat));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ldniext", _Ldniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Lciext", _Lciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Lpasapext", _Lpasapext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Lnumerodocumento", _Lnumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Lautoridad", _Lautoridad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Mobservaciones", _Mobservaciones));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_NLugar", _NLugar));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Ndia", _Ndia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Nmes", _Nmes));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Naño", _Naño));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Oautorizoa", _Oautorizoa));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Otipodedocumentoynumero", _Otipodedocumentoynumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Orecibi", _Orecibi));
            new Class.ReportingCalibration(reportViewer1);
        }
    }
}
