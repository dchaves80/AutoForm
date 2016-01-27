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
    public partial class F59_Frente : Form
    {

        string _MeroMandatario;
        string _Mandatario;
        string _ComercianteHabitualista;
        string _aapellidoynombre;
        string _adni;
        string _ale;
        string _alc;
        string _anumerodocumento;
        string _adniext;
        string _aciext;
        string _apasext;
        string _anumeroext;
        string _aautoridad;
        string _acuit;
        string _acuil;
        string _acdi;
        string _acuitnumero;
        string _afechanacimiento;
        string _alugarnacimiento;
        string _aESTCS;
        string _aESTCC;
        string _aESTCD;
        string _aESTCV;
        string _anupcianumero;
        string _adomiciliolegal;
        string _anumerodomicilio;
        string _apiso;
        string _adepartamento;
        string _alocalidad;
        string _acodpost;
        string _apartidodepartamento;
        string _aprovincia;
        string _acorreoelectronico;
        string _atelefono;
        string _acelular;
        string _bmatriculanumero;
        string _bmatriculadelmandatarionumero;
        string _ccodigoinscripcion;
        string _capellidosynombres;
        string _ctipoynumerodocumentop;

        public F59_Frente
            (
            string p_MeroMandatario,
string p_Mandatario,
string p_ComercianteHabitualista,
string p_aapellidoynombre,
string p_adni,
string p_ale,
string p_alc,
string p_anumerodocumento,
string p_adniext,
string p_aciext,
string p_apasext,
string p_anumeroext,
string p_aautoridad,
string p_acuit,
string p_acuil,
string p_acdi,
string p_acuitnumero,
string p_afechanacimiento,
string p_alugarnacimiento,
string p_aESTCS,
string p_aESTCC,
string p_aESTCD,
string p_aESTCV,
string p_anupcianumero,
string p_adomiciliolegal,
string p_anumerodomicilio,
string p_apiso,
string p_adepartamento,
string p_alocalidad,
string p_acodpost,
string p_apartidodepartamento,
string p_aprovincia,
string p_acorreoelectronico,
string p_atelefono,
string p_acelular,
string p_bmatriculanumero,
string p_bmatriculadelmandatarionumero,
string p_ccodigoinscripcion,
string p_capellidosynombres,
string p_ctipoynumerodocumentop
            )
        {

            _MeroMandatario = p_MeroMandatario;
            _Mandatario = p_Mandatario;
            _ComercianteHabitualista = p_ComercianteHabitualista;
            _aapellidoynombre = p_aapellidoynombre;
            _adni = p_adni;
            _ale = p_ale;
            _alc = p_alc;
            _anumerodocumento = p_anumerodocumento;
            _adniext = p_adniext;
            _aciext = p_aciext;
            _apasext = p_apasext;
            _anumeroext = p_anumeroext;
            _aautoridad = p_aautoridad;
            _acuit = p_acuit;
            _acuil = p_acuil;
            _acdi = p_acdi;
            _acuitnumero = p_acuitnumero;
            _afechanacimiento = p_afechanacimiento;
            _alugarnacimiento = p_alugarnacimiento;
            _aESTCS = p_aESTCS;
            _aESTCC = p_aESTCC;
            _aESTCD = p_aESTCD;
            _aESTCV = p_aESTCV;
            _anupcianumero = p_anupcianumero;
            _adomiciliolegal = p_adomiciliolegal;
            _anumerodomicilio = p_anumerodomicilio;
            _apiso = p_apiso;
            _adepartamento = p_adepartamento;
            _alocalidad = p_alocalidad;
            _acodpost = p_acodpost;
            _apartidodepartamento = p_apartidodepartamento;
            _aprovincia = p_aprovincia;
            _acorreoelectronico = p_acorreoelectronico;
            _atelefono = p_atelefono;
            _acelular = p_acelular;
            _bmatriculanumero = p_bmatriculanumero;
            _bmatriculadelmandatarionumero = p_bmatriculadelmandatarionumero;
            _ccodigoinscripcion = p_ccodigoinscripcion;
            _capellidosynombres = p_capellidosynombres;
            _ctipoynumerodocumentop = p_ctipoynumerodocumentop;

            InitializeComponent();
            EstablecerHandlers();
        }
        private void EstablecerHandlers()
        {
          

        }



        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {

           



        }

        private void F59_Frente_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_MeroMandatario", _MeroMandatario));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_Mandatario", _Mandatario));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ComercianteHabitualista", _ComercianteHabitualista));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aapellidoynombre", _aapellidoynombre));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adni", _adni));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ale", _ale));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_alc", _alc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_anumerodocumento", _anumerodocumento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adniext", _adniext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aciext", _aciext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apasext", _apasext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_anumeroext", _anumeroext));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aautoridad", _aautoridad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acuit", _acuit));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acuil", _acuil));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acdi", _acdi));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acuitnumero", _acuitnumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_afechanacimiento", _afechanacimiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_alugarnacimiento", _alugarnacimiento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aESTCS", _aESTCS));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aESTCC", _aESTCC));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aESTCD", _aESTCD));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aESTCV", _aESTCV));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_anupcianumero", _anupcianumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adomiciliolegal", _adomiciliolegal));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_anumerodomicilio", _anumerodomicilio));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apiso", _apiso));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_adepartamento", _adepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_alocalidad", _alocalidad));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acodpost", _acodpost));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_apartidodepartamento", _apartidodepartamento));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_aprovincia", _aprovincia));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acorreoelectronico", _acorreoelectronico));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_atelefono", _atelefono));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_acelular", _acelular));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_bmatriculanumero", _bmatriculanumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_bmatriculadelmandatarionumero", _bmatriculadelmandatarionumero));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ccodigoinscripcion", _ccodigoinscripcion));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_capellidosynombres", _capellidosynombres));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("p_ctipoynumerodocumentop", _ctipoynumerodocumentop));

            new Class.ReportingCalibration(reportViewer1);
        }
    }
}
