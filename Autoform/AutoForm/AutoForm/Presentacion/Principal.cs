using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        private UserControl CurrentForm = null;

        public Principal()
        {
            InitializeComponent();
            lvForms.Items.Add("(Ninguno)");
            lvForms.Items.Add("Formulario 31 - Frente");
            lvForms.Items.Add("Formulario 31 - Dorso");
            lvForms.Items.Add("Formulario 02 - Frente");
            lvForms.Items.Add("Formulario 02 - Dorso");
            lvForms.Items.Add("Formulario 12 - Frente");
            lvForms.Items.Add("Formulario 59 - Frente");
            lvForms.Items.Add("Formulario 59 - Dorso");
            lvForms.Items.Add("Formulario 31A- Frente");
            lvForms.Items.Add("Formulario 31A- Dorso");
            lvForms.Items.Add("Formulario 08 - Frente");
            lvForms.Items.Add("Formulario 08 - Dorso");

            Image IMGForm = new Bitmap(Presentacion.Properties.Resources.Form);
            Image IMGNone = new Bitmap(Presentacion.Properties.Resources.empty);

            lvForms.LargeImageList = new ImageList();
            lvForms.SmallImageList = new ImageList();

            lvForms.LargeImageList.Images.Add("formulario",IMGForm);
            lvForms.SmallImageList.Images.Add("formulario",IMGForm);
            lvForms.LargeImageList.Images.Add("ninguno", IMGNone);
            lvForms.SmallImageList.Images.Add("ninguno", IMGNone);

            foreach (ListViewItem LVI in lvForms.Items) 
            {
                if (LVI.Text.Contains("Formulario"))
                {
                    LVI.ImageKey = "formulario";
                }

                if (LVI.Text.Contains("Ninguno"))
                {
                    LVI.ImageKey = "ninguno";
                }
            }
            
        }
        private void lvForms_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CurrentForm != null)
            {
                splitContainer1.Panel2.Controls.Clear();
                if (CurrentForm != null && !CurrentForm.IsDisposed)
                {
                    CurrentForm.Dispose();
                }

            }

            if (lvForms.SelectedItems.Count > 0)
            {
                Extras.Configurations.loadChanges();

                Color t_backcolor = Extras.Configurations.ObtainColor(lvForms.SelectedItems[0].Text);

                if (lvForms.SelectedItems[0].Text == "Formulario 31 - Frente")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_31_Frente());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 31 - Dorso")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form31_Dorso());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 02 - Frente")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_02_Frente());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 02 - Dorso")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_02_Dorso());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 12 - Frente") 
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_12_Frente_Unicamente());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 59 - Frente")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_59_frente());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 59 - Dorso")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_59_dorso());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 31A- Frente")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_31A_Frente());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 31A- Dorso")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_31A_Dorso());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 08 - Frente")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_08_Frente());
                }
                if (lvForms.SelectedItems[0].Text == "Formulario 08 - Dorso")
                {
                    splitContainer1.Panel2.Controls.Add(new Forms.Form_08_Dorso());
                }
                if (lvForms.SelectedItems[0].Text == "(Ninguno)")
                {
                    CurrentForm = null;
                }
                if (t_backcolor != Color.Black) 
                {
                    if (lvForms.SelectedItems[0].Text != "(Ninguno)") 
                    {
                        splitContainer1.Panel2.Controls[0].BackColor = t_backcolor;
                    }
                }

            }

           
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                CurrentForm = (UserControl)splitContainer1.Panel2.Controls[0];
            }
        }

        string resolvechk(CheckBox p_trolo)
        {
            if (p_trolo.Checked == true)
            {
                return "X";
            }
            else
            {
                return " ";
            }
        }

        string resolvechkcirc(CheckBox p_trolo)
        {
            if (p_trolo.Checked == true)
            {
                return "O";
            }
            else
            {
                return " ";
            }
        }
        

        string resolvechkinv(CheckBox p_trolo) 
        {
            if (p_trolo.Checked == true)
            {
                return " ";
            }
            else
            {
                return "X";
            }
        }

        void CheckEmptyFields(Control p_control)
        {
            if (p_control.Controls.Count > 0)
            {
                for (int a = 0; a < p_control.Controls.Count; a++)
                {
                    CheckEmptyFields(p_control.Controls[a]);
                }

            }
            else
            {
                if (p_control.ToString().ToLower().Contains("textbox"))
                {
                    TextBox _TB = (TextBox)p_control;
                    if (_TB.Text == "")
                    {
                        _TB.Text = " ";
                    }
                    else
                    {
                        _TB.Text = _TB.Text.ToUpper();
                    }
                }

                if (p_control.ToString().ToLower().Contains("datetime")) 
                {
                   
                   
                }
            }
        }

        private void TSPrint_Click(object sender, EventArgs e)
        {

            if (lvForms.SelectedItems.Count > 0)
            {
                if (lvForms.SelectedItems[0].Text == "Formulario 31 - Frente")
                {
                    abrir31_frente();


                }

                if (lvForms.SelectedItems[0].Text == "Formulario 31 - Dorso")
                {
                    abrir31_dorso();

                }

                if (lvForms.SelectedItems[0].Text == "Formulario 02 - Frente")
                {
                    abrir02_frente();

                }

                if (lvForms.SelectedItems[0].Text == "Formulario 02 - Dorso")
                {
                    abrir02_dorso();

                }

                if (lvForms.SelectedItems[0].Text == "Formulario 12 - Frente")
                {
                    abrir12_frente();

                }
                if (lvForms.SelectedItems[0].Text == "Formulario 59 - Frente")
                {
                    abrir59_frente();

                }
                if (lvForms.SelectedItems[0].Text == "Formulario 59 - Dorso")
                {
                    abrir59_dorso();

                }
                if (lvForms.SelectedItems[0].Text == "Formulario 31A- Frente")
                {
                    abrir31A_frente();

                }

                if (lvForms.SelectedItems[0].Text == "Formulario 31A- Dorso")
                {
                    abrir31A_dorso();

                }
                if (lvForms.SelectedItems[0].Text == "Formulario 08 - Frente")
                {
                    abrir08_frente();

                }
                if (lvForms.SelectedItems[0].Text == "Formulario 08 - Dorso")
                {
                    abrir08_dorso();

                }

            }



        }

        private void abrir08_dorso()
        {
            Presentacion.Forms.Form_08_Dorso MYFORM = (Presentacion.Forms.Form_08_Dorso)CurrentForm;
             CheckEmptyFields(MYFORM);
             MYFORM._LC.EstablecerMargen();

             if (MYFORM.rdbAutomotor.Checked == true) { 
             Reportes.F08_Dorso frm = new Reportes.F08_Dorso
                 (
                 resolveporcentage(MYFORM.txtIProcentaje)[0],
                 resolveporcentage(MYFORM.txtIProcentaje)[1],
                 MYFORM.txtIApeYNomVendedor.Text,
                 resolvechk(MYFORM.chkISoltero),
                 resolvechk(MYFORM.chkISoltero),
                 resolvechk(MYFORM.chkISoltero),
                 resolvechk(MYFORM.chkISoltero),
                 MYFORM.txtINupcia.Text,
                 MYFORM.txtI1ApeYNomApoderado.Text,
                 resolvechk(MYFORM.chkI1DniNat),
                 resolvechk(MYFORM.chkI1LENat),
                 resolvechk(MYFORM.chkI1LcNat),
                 resolvechk(MYFORM.chkI1DniExt),
                 resolvechk(MYFORM.chkI1CiExt),
                 resolvechk(MYFORM.chkI1PasapExt),
                 MYFORM.txtI1documentonumero.Text,
                 MYFORM.txtI1autoridad.Text,
                 MYFORM.txtI2ApeYNomConyuge.Text,
                 MYFORM.txtI3ApeYNomApoderadoConyuge.Text,
                  resolvechk(MYFORM.chkI2DniNat),
                 resolvechk(MYFORM.chkI2LENat),
                 resolvechk(MYFORM.chkI2LcNat),
                 resolvechk(MYFORM.chkI2DniExt),
                 resolvechk(MYFORM.chkI2CiExt),
                 resolvechk(MYFORM.chkI2PasapExt),
                 MYFORM.txtI2documentonumero.Text,
                 MYFORM.txtI2autoridad.Text,
                  resolveporcentage(MYFORM.txtJProcentaje)[0],
                 resolveporcentage(MYFORM.txtJProcentaje)[1],
                 MYFORM.txtJApeYNomVendedor.Text,
                 resolvechk(MYFORM.chkJSoltero),
                 resolvechk(MYFORM.chkJSoltero),
                 resolvechk(MYFORM.chkJSoltero),
                 resolvechk(MYFORM.chkJSoltero),
                 MYFORM.txtJNupcia.Text,
                 MYFORM.txtJ1ApeYNomApoderado.Text,
                 resolvechk(MYFORM.chkJ1DniNat),
                 resolvechk(MYFORM.chkJ1LENat),
                 resolvechk(MYFORM.chkJ1LcNat),
                 resolvechk(MYFORM.chkJ1DniExt),
                 resolvechk(MYFORM.chkJ1CiExt),
                 resolvechk(MYFORM.chkJ1PasapExt),
                 MYFORM.txtJ1documentonumero.Text,
                 MYFORM.txtJ1autoridad.Text,
                 MYFORM.txtJ2ApeYNomConyuge.Text,
                 MYFORM.txtJ3ApeYNomApoderadoConyuge.Text,
                  resolvechk(MYFORM.chkJ2DniNat),
                 resolvechk(MYFORM.chkJ2LENat),
                 resolvechk(MYFORM.chkJ2LcNat),
                 resolvechk(MYFORM.chkJ2DniExt),
                 resolvechk(MYFORM.chkJ2CiExt),
                 resolvechk(MYFORM.chkJ2PasapExt),
                 MYFORM.txtJ2documentonumero.Text,
                 MYFORM.txtJ2autoridad.Text,
                 MYFORM.txtKApelYNomApoderado.Text,
                 resolvechk(MYFORM.chkKDniNat),
                 resolvechk(MYFORM.chkKLENat),
                 resolvechk(MYFORM.chkKLcNat),
                 resolvechk(MYFORM.chkKDniExt),
                 resolvechk(MYFORM.chkKCiExt),
                 resolvechk(MYFORM.chkKPasapExt),
                 MYFORM.txtKdocumentonumero.Text,
                 MYFORM.txtKautoridad.Text,
                  MYFORM.txtLApelYNomApoderado.Text,
                 resolvechk(MYFORM.chkLDniNat),
                 resolvechk(MYFORM.chkLLENat),
                 resolvechk(MYFORM.chkLLcNat),
                 resolvechk(MYFORM.chkLDniExt),
                 resolvechk(MYFORM.chkLCiExt),
                 resolvechk(MYFORM.chkLPasapExt),
                 MYFORM.txtLdocumentonumero.Text,
                 MYFORM.txtLautoridad.Text,
                 MYFORM.txtMObservaciones.Text,
                 MYFORM.txtNLugar.Text,
                 MYFORM.dtpNFecha.Value.Day.ToString(),
                 MYFORM.dtpNFecha.Value.Month.ToString(),
                 MYFORM.dtpNFecha.Value.Year.ToString().Substring(2),
                 MYFORM.txtOAutorizoA.Text,
                 MYFORM.txtOTipoDeDocYNum.Text,
                 MYFORM.txtORecibiTitulo.Text
                 );
             frm.Show();
             }

             if (MYFORM.rdbMotovehiculo.Checked == true)
             {
                 Reportes.F08_Dorso_Motovehiculo frm = new Reportes.F08_Dorso_Motovehiculo
                     (
                     resolveporcentage(MYFORM.txtIProcentaje)[0],
                     resolveporcentage(MYFORM.txtIProcentaje)[1],
                     MYFORM.txtIApeYNomVendedor.Text,
                     resolvechk(MYFORM.chkISoltero),
                     resolvechk(MYFORM.chkISoltero),
                     resolvechk(MYFORM.chkISoltero),
                     resolvechk(MYFORM.chkISoltero),
                     MYFORM.txtINupcia.Text,
                     MYFORM.txtI1ApeYNomApoderado.Text,
                     resolvechk(MYFORM.chkI1DniNat),
                     resolvechk(MYFORM.chkI1LENat),
                     resolvechk(MYFORM.chkI1LcNat),
                     resolvechk(MYFORM.chkI1DniExt),
                     resolvechk(MYFORM.chkI1CiExt),
                     resolvechk(MYFORM.chkI1PasapExt),
                     MYFORM.txtI1documentonumero.Text,
                     MYFORM.txtI1autoridad.Text,
                     MYFORM.txtI2ApeYNomConyuge.Text,
                     MYFORM.txtI3ApeYNomApoderadoConyuge.Text,
                      resolvechk(MYFORM.chkI2DniNat),
                     resolvechk(MYFORM.chkI2LENat),
                     resolvechk(MYFORM.chkI2LcNat),
                     resolvechk(MYFORM.chkI2DniExt),
                     resolvechk(MYFORM.chkI2CiExt),
                     resolvechk(MYFORM.chkI2PasapExt),
                     MYFORM.txtI2documentonumero.Text,
                     MYFORM.txtI2autoridad.Text,
                      resolveporcentage(MYFORM.txtJProcentaje)[0],
                     resolveporcentage(MYFORM.txtJProcentaje)[1],
                     MYFORM.txtJApeYNomVendedor.Text,
                     resolvechk(MYFORM.chkJSoltero),
                     resolvechk(MYFORM.chkJSoltero),
                     resolvechk(MYFORM.chkJSoltero),
                     resolvechk(MYFORM.chkJSoltero),
                     MYFORM.txtJNupcia.Text,
                     MYFORM.txtJ1ApeYNomApoderado.Text,
                     resolvechk(MYFORM.chkJ1DniNat),
                     resolvechk(MYFORM.chkJ1LENat),
                     resolvechk(MYFORM.chkJ1LcNat),
                     resolvechk(MYFORM.chkJ1DniExt),
                     resolvechk(MYFORM.chkJ1CiExt),
                     resolvechk(MYFORM.chkJ1PasapExt),
                     MYFORM.txtJ1documentonumero.Text,
                     MYFORM.txtJ1autoridad.Text,
                     MYFORM.txtJ2ApeYNomConyuge.Text,
                     MYFORM.txtJ3ApeYNomApoderadoConyuge.Text,
                      resolvechk(MYFORM.chkJ2DniNat),
                     resolvechk(MYFORM.chkJ2LENat),
                     resolvechk(MYFORM.chkJ2LcNat),
                     resolvechk(MYFORM.chkJ2DniExt),
                     resolvechk(MYFORM.chkJ2CiExt),
                     resolvechk(MYFORM.chkJ2PasapExt),
                     MYFORM.txtJ2documentonumero.Text,
                     MYFORM.txtJ2autoridad.Text,
                     MYFORM.txtKApelYNomApoderado.Text,
                     resolvechk(MYFORM.chkKDniNat),
                     resolvechk(MYFORM.chkKLENat),
                     resolvechk(MYFORM.chkKLcNat),
                     resolvechk(MYFORM.chkKDniExt),
                     resolvechk(MYFORM.chkKCiExt),
                     resolvechk(MYFORM.chkKPasapExt),
                     MYFORM.txtKdocumentonumero.Text,
                     MYFORM.txtKautoridad.Text,
                      MYFORM.txtLApelYNomApoderado.Text,
                     resolvechk(MYFORM.chkLDniNat),
                     resolvechk(MYFORM.chkLLENat),
                     resolvechk(MYFORM.chkLLcNat),
                     resolvechk(MYFORM.chkLDniExt),
                     resolvechk(MYFORM.chkLCiExt),
                     resolvechk(MYFORM.chkLPasapExt),
                     MYFORM.txtLdocumentonumero.Text,
                     MYFORM.txtLautoridad.Text,
                     MYFORM.txtMObservaciones.Text,
                     MYFORM.txtNLugar.Text,
                     MYFORM.dtpNFecha.Value.Day.ToString(),
                     MYFORM.dtpNFecha.Value.Month.ToString(),
                     MYFORM.dtpNFecha.Value.Year.ToString().Substring(2),
                     MYFORM.txtOAutorizoA.Text,
                     MYFORM.txtOTipoDeDocYNum.Text,
                     MYFORM.txtORecibiTitulo.Text
                     );
                 frm.Show();
             }



        }


        private void abrir08_frente() 
        {
            Presentacion.Forms.Form_08_Frente MYFORM = (Presentacion.Forms.Form_08_Frente)CurrentForm;
            CheckEmptyFields(MYFORM);

            if (MYFORM.rdbAutomotor.Checked == true)
            {

                Reportes.F08_Frente frm = new Reportes.F08_Frente(
                    MYFORM.txtALugar.Text,
                    MYFORM.txtAPrecioCompra.Text,
                    MYFORM.txtADominio.Text,
                    resolveporcentage(MYFORM.txtDPorcentaje)[0],
                    resolveporcentage(MYFORM.txtDPorcentaje)[1],
                    MYFORM.txtDApellidoYNombre.Text,
                    MYFORM.txtDSinEspecificar.Text,
                    MYFORM.txtDEmail.Text,
                    MYFORM.txtDTelefono.Text,
                    MYFORM.txtDDomicilioLegal.Text,
                    MYFORM.txtDNumeroCalleLegal.Text,
                    MYFORM.txtDPisoCalleLegal.Text,
                    MYFORM.txtDDeptoCalleLegal.Text,
                    MYFORM.txtDCodPostalLegal.Text,
                    MYFORM.txtDLocalidadOCABALegal.Text,
                    MYFORM.txtDPartidoODeptoLegal.Text,
                    MYFORM.txtDProvinciaLegal.Text,
                    MYFORM.txtDDomicilioReal.Text,
                    MYFORM.txtDNumCalleReal.Text,
                    MYFORM.txtDPisoCalleReal.Text,
                    MYFORM.txtDDeptoCalleReal.Text,
                    MYFORM.txtDCodPostalReal.Text,
                    MYFORM.txtDLocalidadOCABAReal.Text,
                    MYFORM.txtDPartidoODeptoReal.Text,
                    MYFORM.txtDProvinciaReal.Text,
                    MYFORM.txtDProfesionOficio.Text,
                    resolvechk(MYFORM.chkDdninat),
                    resolvechk(MYFORM.chkDlenat),
                    resolvechk(MYFORM.chkDlcnat),
                    resolvechk(MYFORM.chkDdniext),
                    resolvechk(MYFORM.chkDciext),
                    resolvechk(MYFORM.chkDpasapext),
                    MYFORM.txtDdocumentonumero.Text,
                    MYFORM.txtDautoridad.Text,
                    MYFORM.txtDCUITCUILCDI.Text,
                    MYFORM.txtDLugarNac.Text,
                    MYFORM.dtpDFechaNac.Value.Day.ToString(),
                    MYFORM.dtpDFechaNac.Value.Month.ToString(),
                    MYFORM.dtpDFechaNac.Value.Year.ToString().Substring(2),
                    resolvechk(MYFORM.chkDSoltero),
                    resolvechk(MYFORM.chkDCasado),
                    resolvechk(MYFORM.chkDViudo),
                    resolvechk(MYFORM.chkDDivorciado),
                    MYFORM.txtDNupcia.Text,
                    MYFORM.txtDApellidoYNombreConyuge.Text,
                    MYFORM.txtDPersoneriaOtorgada.Text,
                    MYFORM.txtDNumODatosDeInscripcion.Text,
                    MYFORM.dtpDFechaInscripcion.Value.Day.ToString(),
                    MYFORM.dtpDFechaInscripcion.Value.Month.ToString(),
                    MYFORM.dtpDFechaInscripcion.Value.Year.ToString().Substring(2),
                    MYFORM.txtDCETA.Text,
                    resolveporcentage(MYFORM.txtEPorcentaje)[0],
                    resolveporcentage(MYFORM.txtEPorcentaje)[1],
                    MYFORM.txtEApellidoYNombre.Text,
                    MYFORM.txtESinEspecificar.Text,
                    MYFORM.txtEEmail.Text,
                    MYFORM.txtETelefono.Text,
                    MYFORM.txtEDomicilioLegal.Text,
                    MYFORM.txtENumeroCalleLegal.Text,
                    MYFORM.txtEPisoCalleLegal.Text,
                    MYFORM.txtEDeptoCalleLegal.Text,
                    MYFORM.txtECodPostalLegal.Text,
                    MYFORM.txtELocalidadOCABALegal.Text,
                    MYFORM.txtEPartidoODeptoLegal.Text,
                    MYFORM.txtEProvinciaLegal.Text,
                    MYFORM.txtEDomicilioReal.Text,
                    MYFORM.txtENumCalleReal.Text,
                    MYFORM.txtEPisoCalleReal.Text,
                    MYFORM.txtEDeptoCalleReal.Text,
                    MYFORM.txtECodPostalReal.Text,
                    MYFORM.txtELocalidadOCABAReal.Text,
                    MYFORM.txtEPartidoODeptoReal.Text,
                    MYFORM.txtEProvinciaReal.Text,
                    MYFORM.txtEProfesionOficio.Text,
                    resolvechk(MYFORM.chkEdninat),
                    resolvechk(MYFORM.chkElenat),
                    resolvechk(MYFORM.chkElcnat),
                    resolvechk(MYFORM.chkEdniext),
                    resolvechk(MYFORM.chkEciext),
                    resolvechk(MYFORM.chkEpasapext),
                    MYFORM.txtEdocumentonumero.Text,
                    MYFORM.txtEautoridad.Text,
                    MYFORM.txtECUITCUILCDI.Text,
                    MYFORM.txtELugarNac.Text,
                    MYFORM.dtpEFechaNac.Value.Day.ToString(),
                    MYFORM.dtpEFechaNac.Value.Month.ToString(),
                    MYFORM.dtpEFechaNac.Value.Year.ToString().Substring(2),
                    resolvechk(MYFORM.chkESoltero),
                    resolvechk(MYFORM.chkECasado),
                    resolvechk(MYFORM.chkEViudo),
                    resolvechk(MYFORM.chkEDivorciado),
                    MYFORM.txtEApellidoYNombreConyuge.Text,
                    MYFORM.txtEPersoneriaOtorgada.Text,
                    MYFORM.txtENumODatosDeInscripcion.Text,
                    MYFORM.dtpEFechaInscripcion.Value.Day.ToString(),
                    MYFORM.dtpEFechaInscripcion.Value.Month.ToString(),
                    MYFORM.dtpEFechaInscripcion.Value.Year.ToString().Substring(2),
                    MYFORM.txtECETA.Text,
                    MYFORM.txtFDominio.Text,
                    MYFORM.txtFMarca.Text,
                    MYFORM.txtFTipo.Text,
                    MYFORM.txtFModelo.Text,
                    MYFORM.txtFMarcaMotor.Text,
                    MYFORM.txtFNumeroDeMotor.Text,
                    MYFORM.txtFMarcaDeChasis.Text,
                    MYFORM.txtFNumeroDeChasis.Text,
                    MYFORM.txtFUso.Text
                    );
                frm.Show();
            }

            if (MYFORM.rdbMotovehiculo.Checked == true)
            {

                Reportes.F08_Frente_Motovehiculo frm = new Reportes.F08_Frente_Motovehiculo(
                    MYFORM.txtALugar.Text,
                    MYFORM.txtAPrecioCompra.Text,
                    MYFORM.txtADominio.Text,
                    resolveporcentage(MYFORM.txtDPorcentaje)[0],
                    resolveporcentage(MYFORM.txtDPorcentaje)[1],
                    MYFORM.txtDApellidoYNombre.Text,
                    MYFORM.txtDSinEspecificar.Text,
                    MYFORM.txtDEmail.Text,
                    MYFORM.txtDTelefono.Text,
                    MYFORM.txtDDomicilioLegal.Text,
                    MYFORM.txtDNumeroCalleLegal.Text,
                    MYFORM.txtDPisoCalleLegal.Text,
                    MYFORM.txtDDeptoCalleLegal.Text,
                    MYFORM.txtDCodPostalLegal.Text,
                    MYFORM.txtDLocalidadOCABALegal.Text,
                    MYFORM.txtDPartidoODeptoLegal.Text,
                    MYFORM.txtDProvinciaLegal.Text,
                    MYFORM.txtDDomicilioReal.Text,
                    MYFORM.txtDNumCalleReal.Text,
                    MYFORM.txtDPisoCalleReal.Text,
                    MYFORM.txtDDeptoCalleReal.Text,
                    MYFORM.txtDCodPostalReal.Text,
                    MYFORM.txtDLocalidadOCABAReal.Text,
                    MYFORM.txtDPartidoODeptoReal.Text,
                    MYFORM.txtDProvinciaReal.Text,
                    MYFORM.txtDProfesionOficio.Text,
                    resolvechk(MYFORM.chkDdninat),
                    resolvechk(MYFORM.chkDlenat),
                    resolvechk(MYFORM.chkDlcnat),
                    resolvechk(MYFORM.chkDdniext),
                    resolvechk(MYFORM.chkDciext),
                    resolvechk(MYFORM.chkDpasapext),
                    MYFORM.txtDdocumentonumero.Text,
                    MYFORM.txtDautoridad.Text,
                    MYFORM.txtDCUITCUILCDI.Text,
                    MYFORM.txtDLugarNac.Text,
                    MYFORM.dtpDFechaNac.Value.Day.ToString(),
                    MYFORM.dtpDFechaNac.Value.Month.ToString(),
                    MYFORM.dtpDFechaNac.Value.Year.ToString().Substring(2),
                    resolvechk(MYFORM.chkDSoltero),
                    resolvechk(MYFORM.chkDCasado),
                    resolvechk(MYFORM.chkDViudo),
                    resolvechk(MYFORM.chkDDivorciado),
                    MYFORM.txtDNupcia.Text,
                    MYFORM.txtDApellidoYNombreConyuge.Text,
                    MYFORM.txtDPersoneriaOtorgada.Text,
                    MYFORM.txtDNumODatosDeInscripcion.Text,
                    MYFORM.dtpDFechaInscripcion.Value.Day.ToString(),
                    MYFORM.dtpDFechaInscripcion.Value.Month.ToString(),
                    MYFORM.dtpDFechaInscripcion.Value.Year.ToString().Substring(2),
                    MYFORM.txtDCETA.Text,
                    resolveporcentage(MYFORM.txtEPorcentaje)[0],
                    resolveporcentage(MYFORM.txtEPorcentaje)[1],
                    MYFORM.txtEApellidoYNombre.Text,
                    MYFORM.txtESinEspecificar.Text,
                    MYFORM.txtEEmail.Text,
                    MYFORM.txtETelefono.Text,
                    MYFORM.txtEDomicilioLegal.Text,
                    MYFORM.txtENumeroCalleLegal.Text,
                    MYFORM.txtEPisoCalleLegal.Text,
                    MYFORM.txtEDeptoCalleLegal.Text,
                    MYFORM.txtECodPostalLegal.Text,
                    MYFORM.txtELocalidadOCABALegal.Text,
                    MYFORM.txtEPartidoODeptoLegal.Text,
                    MYFORM.txtEProvinciaLegal.Text,
                    MYFORM.txtEDomicilioReal.Text,
                    MYFORM.txtENumCalleReal.Text,
                    MYFORM.txtEPisoCalleReal.Text,
                    MYFORM.txtEDeptoCalleReal.Text,
                    MYFORM.txtECodPostalReal.Text,
                    MYFORM.txtELocalidadOCABAReal.Text,
                    MYFORM.txtEPartidoODeptoReal.Text,
                    MYFORM.txtEProvinciaReal.Text,
                    MYFORM.txtEProfesionOficio.Text,
                    resolvechk(MYFORM.chkEdninat),
                    resolvechk(MYFORM.chkElenat),
                    resolvechk(MYFORM.chkElcnat),
                    resolvechk(MYFORM.chkEdniext),
                    resolvechk(MYFORM.chkEciext),
                    resolvechk(MYFORM.chkEpasapext),
                    MYFORM.txtEdocumentonumero.Text,
                    MYFORM.txtEautoridad.Text,
                    MYFORM.txtECUITCUILCDI.Text,
                    MYFORM.txtELugarNac.Text,
                    MYFORM.dtpEFechaNac.Value.Day.ToString(),
                    MYFORM.dtpEFechaNac.Value.Month.ToString(),
                    MYFORM.dtpEFechaNac.Value.Year.ToString().Substring(2),
                    resolvechk(MYFORM.chkESoltero),
                    resolvechk(MYFORM.chkECasado),
                    resolvechk(MYFORM.chkEViudo),
                    resolvechk(MYFORM.chkEDivorciado),
                    MYFORM.txtEApellidoYNombreConyuge.Text,
                    MYFORM.txtEPersoneriaOtorgada.Text,
                    MYFORM.txtENumODatosDeInscripcion.Text,
                    MYFORM.dtpEFechaInscripcion.Value.Day.ToString(),
                    MYFORM.dtpEFechaInscripcion.Value.Month.ToString(),
                    MYFORM.dtpEFechaInscripcion.Value.Year.ToString().Substring(2),
                    MYFORM.txtECETA.Text,
                    MYFORM.txtFDominio.Text,
                    MYFORM.txtFMarca.Text,
                    MYFORM.txtFTipo.Text,
                    MYFORM.txtFModelo.Text,
                    MYFORM.txtFMarcaMotor.Text,
                    MYFORM.txtFNumeroDeMotor.Text,
                    MYFORM.txtFMarcaDeChasis.Text,
                    MYFORM.txtFNumeroDeChasis.Text,
                    MYFORM.txtFUso.Text
                    );
                frm.Show();
            }

        }

        private void abrir31A_dorso()
        {
            Presentacion.Forms.Form_31A_Dorso MYFORM = (Presentacion.Forms.Form_31A_Dorso)CurrentForm;
            MYFORM._LC.EstablecerMargen();
            CheckEmptyFields(MYFORM);
            Reportes.F31A_Dorso frm = new Reportes.F31A_Dorso(
                resolvechk( MYFORM.chkFotocopiatitulopropiedadautomotor),
                resolvechk( MYFORM.chkFotocFactDeCompra),
                resolvechk( MYFORM.chkFotocopiasCertifDeFabrica),
                resolvechk( MYFORM.chkFotocDespachoAPlaza),
                resolvechk( MYFORM.chkOriginal),
                resolvechk( MYFORM.chkFotocComproDePago),
                resolvechk( MYFORM.chkOtros),
                MYFORM.txtobservaciones.Text
          );
            frm.Show();
        }


        private void abrir31A_frente()
        {
            Presentacion.Forms.Form_31A_Frente MYFORM = (Presentacion.Forms.Form_31A_Frente)CurrentForm;
            CheckEmptyFields(MYFORM);
            Reportes.F31A_Frente frm = new Reportes.F31A_Frente(
                resolvechk (MYFORM.chkAInscripcionInial),
                resolvechk(MYFORM.chkCambioDeRadicacion),
                resolvechk(MYFORM.chkSubastadosYArmados),
                resolvechk(MYFORM.chkRecuperoDeRobo),
            MYFORM.txtDominio.Text,
            MYFORM.txtDominioAnterior.Text,
            MYFORM.cmbNacionalImportado.SelectedItem.ToString(),
           MYFORM.dtpFechaCompra.Value.ToShortDateString(),
           MYFORM.dtpFechaDeAlta.Value.ToShortDateString(),
            MYFORM.txtReservadoRentas.Text,
            MYFORM.txtMarcaModelo.Text,
            MYFORM.txtTipo.Text,
            MYFORM.txtmodeloano.Text,
            MYFORM.txtmotormarca.Text,
            MYFORM.txtchasismarca.Text,
            MYFORM.txtmotornumero.Text,
            MYFORM.txtchasisnumero.Text,
            MYFORM.txtrubro.Text,
            MYFORM.txtcategoria.Text,
            MYFORM.txtpesocilindrada.Text,
            MYFORM.txtcodigomarcamodelo.Text,
            MYFORM.txtcombustible.Text,
            MYFORM.txtapellidonombreyrazonsocial.Text,
            MYFORM.txtnrodocumento.Text,
            resolvechk(MYFORM.chkdni),
            resolvechk(MYFORM.chkle),
            resolvechk(MYFORM.chklc),
            resolvechk(MYFORM.chkci),
            resolvechk(MYFORM.chkpas),
            MYFORM.txtcuitcuil.Text,
            MYFORM.txtdfcallenombre.Text,
            MYFORM.txtdfcallenro.Text,
            MYFORM.txtdfcallepiso.Text,
            MYFORM.txtdfcalledepto.Text,
            MYFORM.txtdfbarriolocalidad.Text,
            MYFORM.txtdfcodigopostal.Text,
            MYFORM.txtdfprovincia.Text,
            MYFORM.txtcallenombre.Text,
            MYFORM.txtcallenro.Text,
            MYFORM.txtcallepiso.Text,
            MYFORM.txtcalledepto.Text,
            MYFORM.txtbarrio.Text,
            MYFORM.txtcodigopostal.Text,
            MYFORM.txtprovincia.Text
          );
            frm.Show();
        }

        private void abrir59_dorso()
        {
            Presentacion.Forms.Form_59_dorso MYFORM = (Presentacion.Forms.Form_59_dorso)CurrentForm;
            MYFORM._LC.EstablecerMargen();
            CheckEmptyFields(MYFORM);
            Reportes.F59_Dorso frm = new Reportes.F59_Dorso
                (MYFORM.txtDominio1.Text,MYFORM.txtTramitePresentado1.Text,MYFORM.txtSolicitudTipo1.Text,MYFORM.txtNumeroDeControl1.Text,
                MYFORM.txtDominio2.Text, MYFORM.txtTramitePresentado2.Text, MYFORM.txtSolicitudTipo2.Text, MYFORM.txtNumeroDeControl2.Text,
                MYFORM.txtDominio3.Text, MYFORM.txtTramitePresentado3.Text, MYFORM.txtSolicitudTipo3.Text, MYFORM.txtNumeroDeControl3.Text,
                    MYFORM.txtDominio4.Text, MYFORM.txtTramitePresentado4.Text, MYFORM.txtSolicitudTipo4.Text, MYFORM.txtNumeroDeControl4.Text,
                        MYFORM.txtDominio5.Text, MYFORM.txtTramitePresentado5.Text, MYFORM.txtSolicitudTipo5.Text, MYFORM.txtNumeroDeControl5.Text,
                        MYFORM.txtEObservaciones.Text, MYFORM.txtGLugar.Text, MYFORM.dtpGFecha.Value.ToLongDateString()
                                );
            frm.Show();
        }

        private void abrir59_frente() 
        {
            Presentacion.Forms.Form_59_frente MYFORM = (Presentacion.Forms.Form_59_frente)CurrentForm;
            CheckEmptyFields(MYFORM);
            Reportes.F59_Frente frm = new Reportes.F59_Frente
                (
                resolvechk(MYFORM.chkMandatario),
                resolvechk(MYFORM.chkMandatario),
                resolvechk(MYFORM.chkComercianteHabitualista),
                MYFORM.txtAApellidoYNombre.Text,
                resolvechkinv(MYFORM.chkDNIArg),
                resolvechkinv(MYFORM.chkLE),
                resolvechkinv(MYFORM.chkLC),
                MYFORM.txtANumeroDocNac.Text,
                resolvechkinv(MYFORM.chkDNIExtranjeros),
                resolvechkinv(MYFORM.chkCI),
                resolvechkinv(MYFORM.chkPas),
                MYFORM.txtANumeroDocEx.Text,
                MYFORM.txtAutoridadOpais.Text,
                resolvechkinv(MYFORM.chkCUIT),
                resolvechkinv(MYFORM.chkCuil),
                resolvechkinv(MYFORM.chkCDi),
                MYFORM.txtCUITCUILCDI.Text,
                MYFORM.dtpFecNacimiento.Value.ToShortDateString(),
                MYFORM.txtLugarNac.Text,
                resolvechkcirc(MYFORM.chkSoltero),
                resolvechkcirc(MYFORM.chkCadaso),
                resolvechkcirc(MYFORM.chkDivorc),
                resolvechkcirc(MYFORM.chkViudo),
                MYFORM.txtNumeroNupcia.Text,
                MYFORM.txtDomicilioLegal.Text,
                MYFORM.txtNumero.Text,
                MYFORM.txtPiso.Text,
                MYFORM.txtDepto.Text,
                MYFORM.txtLocalidad.Text,
                MYFORM.txtCodPostal.Text,
                MYFORM.txtPartidoDepartamento.Text,
                MYFORM.txtProvincia.Text,
                MYFORM.txtCorreoElectronico.Text,
                MYFORM.txtTelefono.Text,
                MYFORM.txtCelular.Text,
                MYFORM.txtBNumeroMatricula1.Text,
                MYFORM.txtBNumeroMatricula2.Text,
                MYFORM.txtCCodigoInscripcion.Text,
                MYFORM.txtCApellidoNombre.Text,
                MYFORM.txtCTipoYNumeroDoc.Text
               );
            frm.Show();
        }

        private void abrir12_frente() 
        {
            Presentacion.Forms.Form_12_Frente_Unicamente MYFORM = (Presentacion.Forms.Form_12_Frente_Unicamente)CurrentForm;
            MYFORM._LC.EstablecerMargen();
            CheckEmptyFields(MYFORM);
            if (MYFORM.rdbAutomotor.Checked == true) { 
            Reportes.F12_Frente frm = new Reportes.F12_Frente(
                MYFORM.txtdominio.Text,
                MYFORM.txtMarca.Text,
            MYFORM.txtTipo.Text,
            MYFORM.txtModelo.Text,
            MYFORM.txtMarcaMotor.Text,
            MYFORM.txtNumeroMotor.Text,
            MYFORM.txtMarcaChasis.Text,
            MYFORM.txtNumeroChasis.Text,
            MYFORM.txtObservacionesOConstan.Text,
            MYFORM.txtLugar.Text,
            MYFORM.dateTimePicker1.Value.Day.ToString(),
            MYFORM.dateTimePicker1.Value.Month.ToString(),
            MYFORM.dateTimePicker1.Value.Year.ToString().Substring(2),
            MYFORM.txtApellidoNombre.Text,
            MYFORM.txtNroYTipoDoc.Text,
            MYFORM.txtCalle.Text,
            MYFORM.txtNumero.Text,
            MYFORM.txtLocalidad.Text
                );
            frm.Show();
            }


            if (MYFORM.rdbMotovehiculo.Checked == true)
            {
                Reportes.F12_Frente_Motovehiculo frm = new Reportes.F12_Frente_Motovehiculo(
                    MYFORM.txtdominio.Text,
                    MYFORM.txtMarca.Text,
                MYFORM.txtTipo.Text,
                MYFORM.txtModelo.Text,
                MYFORM.txtMarcaMotor.Text,
                MYFORM.txtNumeroMotor.Text,
                MYFORM.txtMarcaChasis.Text,
                MYFORM.txtNumeroChasis.Text,
                MYFORM.txtObservacionesOConstan.Text,
                MYFORM.txtLugar.Text,
                MYFORM.dateTimePicker1.Value.Day.ToString(),
                MYFORM.dateTimePicker1.Value.Month.ToString(),
                MYFORM.dateTimePicker1.Value.Year.ToString().Substring(2),
                MYFORM.txtApellidoNombre.Text,
                MYFORM.txtNroYTipoDoc.Text,
                MYFORM.txtCalle.Text,
                MYFORM.txtNumero.Text,
                MYFORM.txtLocalidad.Text
                    );
                frm.Show();
            }

            
        }

        private void abrir02_dorso()
        {
            Presentacion.Forms.Form_02_Dorso MYFORM = (Presentacion.Forms.Form_02_Dorso)CurrentForm;
            CheckEmptyFields(MYFORM);
            MYFORM._LC.EstablecerMargen();
            Reportes.F02_Dorso frm = new Reportes.F02_Dorso(MYFORM.idtpfechamedida.Value.Day.ToString(),
                MYFORM.idtpfechamedida.Value.Month.ToString(),
                MYFORM.idtpfechamedida.Value.Year.ToString().Substring(2),
                MYFORM.idtpfechalevantamiento.Value.Day.ToString(),
                MYFORM.idtpfechalevantamiento.Value.Month.ToString(),
                MYFORM.idtpfechalevantamiento.Value.Year.ToString().Substring(2),
                MYFORM.itxtjuzgado.Text,
                MYFORM.itxtsecretaria.Text,
                MYFORM.itxtapellidonombretitular.Text,
                MYFORM.itxtcondominioembargado.Text,
                resolvechk(MYFORM.ichkdni),
                resolvechk(MYFORM.ichkle),
                resolvechk(MYFORM.ichklc),
                resolvechk(MYFORM.ichkextdni),
                resolvechk(MYFORM.ichkextci),
                resolvechk(MYFORM.ichkextpasap),
                MYFORM.itxtnumerodocumento.Text,
                MYFORM.itxtautoridadopais.Text,
            MYFORM.itxtpersonaeria.Text,
            MYFORM.itxtdatosinscripcion.Text,
            MYFORM.idtpinscripcion.Value.Day.ToString(),
            MYFORM.idtpinscripcion.Value.Month.ToString(),
            MYFORM.idtpinscripcion.Value.Year.ToString().Substring(2),
            resolveporcentage(MYFORM.txtjporcenataje)[0],
            resolveporcentage(MYFORM.txtjporcenataje)[1],
            MYFORM.jtxtapellidonombre.Text,
            MYFORM.jtxtsexo.Text,
            MYFORM.jcalle.Text,
            resolvechk(MYFORM.jchkdni),
            resolvechk(MYFORM.jchkle),
            resolvechk(MYFORM.jchklc),
            resolvechk(MYFORM.jchkextdni),
            resolvechk(MYFORM.jchkextci),
            resolvechk(MYFORM.jchkextpasap),
            MYFORM.jtxtnumerodocumento.Text,
            MYFORM.jtxtpais.Text,
            MYFORM.jdtpfechanacimiento.Value.Day.ToString(),
            MYFORM.jdtpfechanacimiento.Value.Month.ToString(),
            MYFORM.jdtpfechanacimiento.Value.Year.ToString().Substring(2),
            resolvechk(MYFORM.jchksoltero),
            resolvechk(MYFORM.jchkcasado),
            resolvechk(MYFORM.jchkviudo),
            resolvechk(MYFORM.jchkdivor),
            MYFORM.jtxtnupcianumero.Text,
            MYFORM.jtxtnombreconyuge.Text,
            MYFORM.jtxtpersoneria.Text,
            MYFORM.jtxtdatosinscripcion.Text,
            MYFORM.jdtpfechainscripcion.Value.Day.ToString(),
            MYFORM.jdtpfechainscripcion.Value.Month.ToString(),
            MYFORM.jdtpfechainscripcion.Value.Year.ToString().Substring(2),
           
            
            resolveporcentage(MYFORM.txtkporcentaje)[0],
            resolveporcentage(MYFORM.txtkporcentaje)[1],
            MYFORM.txtkapellidoynombre.Text,
            MYFORM.txtksexo.Text,
            MYFORM.txtkcalle.Text,
            resolvechk(MYFORM.chkkdninativos),
            resolvechk(MYFORM.chkkle),
            resolvechk(MYFORM.chkklc),
            resolvechk(MYFORM.chkkextdni),
            resolvechk(MYFORM.chkkci),
            resolvechk(MYFORM.chkkpasap),
            MYFORM.txtknumerodocumento.Text,
            MYFORM.txtkautoridad.Text,
            MYFORM.dtpkfechanacimiento.Value.Day.ToString(),
            MYFORM.dtpkfechanacimiento.Value.Month.ToString(),
            MYFORM.dtpkfechanacimiento.Value.Year.ToString().Substring(2),
            resolvechk(MYFORM.chkksoltero),
            resolvechk(MYFORM.chkkcasado),
            resolvechk(MYFORM.chkkviudo),
            resolvechk(MYFORM.chkkdivor),
            MYFORM.txtknupcianumero.Text,
            MYFORM.txtknombreconyuge.Text,
            MYFORM.txtkkpersoneria.Text,
            MYFORM.txtkdatosinscripcion.Text,
            MYFORM.dtpkfechainscripcion.Value.Day.ToString(),
            MYFORM.dtpkfechainscripcion.Value.Month.ToString(),
            MYFORM.dtpkfechainscripcion.Value.Year.ToString().Substring(2),
            MYFORM.ltxtapellidonombrevendedor.Text,
            MYFORM.ldtpfechatransferencia.Value.ToLongDateString(),
            MYFORM.ltxtrpamotorasignado.Text,
            MYFORM.ltxtrpachasisasignado.Text,
            MYFORM.txtobservaciones.Text,
            MYFORM.txtlugar.Text,
            MYFORM.dtpMfecha.Value.Day.ToString(),
            MYFORM.dtpMfecha.Value.Month.ToString(),
            MYFORM.dtpMfecha.Value.Year.ToString().Substring(2),
            MYFORM.txtautorizadoa.Text,
            MYFORM.txttipodocumentonumero.Text

          );
            frm.Show();
        }

        private string[] resolveporcentage(TextBox p_textbox) 
        {
            string[] result = { " ", " " };

            if (p_textbox.Text.Contains(",") || p_textbox.Text.Contains("."))
            {
                string[] splitters = { ",", "." };
                string[] partialresult = p_textbox.Text.Split(splitters, StringSplitOptions.None);
                if (partialresult.Length == 1) 
                {
                    result[0] = partialresult[0];
                }
                if (partialresult.Length == 2)
                {
                    result[0] = partialresult[0];
                    result[1] = partialresult[1];
                }
            }
            else 
            {
                result[0] = p_textbox.Text;
            }

            return result;
            

        }

        private void abrir31_dorso()
        {
            Presentacion.Forms.Form31_Dorso MYFORM = (Presentacion.Forms.Form31_Dorso)CurrentForm;
            MYFORM._LC.EstablecerMargen();
            CheckEmptyFields(MYFORM);
            Reportes.F31_Dorso frm = new Reportes.F31_Dorso(
            resolvechk(MYFORM.chkFotocopiatitulopropiedadautomotor),
             resolvechk(MYFORM.chkFotocopiacomprobantedepago),
             resolvechk(MYFORM.chkOtros),
            MYFORM.txtobservaciones.Text
          );
            frm.Show();
        }

        private void abrir02_frente()
        {
            Presentacion.Forms.Form_02_Frente MYFORM = (Presentacion.Forms.Form_02_Frente)CurrentForm;
            MYFORM._LC.EstablecerMargen();
            CheckEmptyFields(MYFORM);
            Reportes.F02_Frente frm = new Reportes.F02_Frente
                (
                MYFORM.txtdominio.Text,
                resolvechk(MYFORM.checkBox1),
                resolvechk(MYFORM.checkBox2),
                resolvechk(MYFORM.checkBox3),
                resolvechk(MYFORM.checkBox4),
                resolvechk(MYFORM.checkBox5),
                resolvechk(MYFORM.checkBox6),
                resolvechk(MYFORM.checkBox7),
                resolvechk(MYFORM.checkBox8),
                resolvechk(MYFORM.checkBox9),
                resolvechk(MYFORM.checkBox10),
                resolvechk(MYFORM.checkBox11),
                resolvechk(MYFORM.checkBox12),
                resolvechk(MYFORM.checkBox13),
                resolvechk(MYFORM.checkBox14),
                resolvechk(MYFORM.checkBox15),
                resolvechk(MYFORM.checkBox16),
                resolvechk(MYFORM.checkBox17),
                resolvechk(MYFORM.checkBox18),
                resolvechk(MYFORM.checkBox19),
                resolvechk(MYFORM.checkBox20),
                MYFORM.txtdeclaraciones.Text,
                MYFORM.txtfapellidosolicitante.Text,
                MYFORM.txtapellidonombreapoderado.Text,
                resolvechk(MYFORM.chkdninat),
                resolvechk(MYFORM.chklenat),
                resolvechk(MYFORM.chklcnat),
                resolvechk(MYFORM.chkdniext),
                resolvechk(MYFORM.chkciext),
                resolvechk(MYFORM.chkpasapext),
                MYFORM.txtdocumentonumero.Text,
                MYFORM.txtautoridad.Text,
                MYFORM.txthdominio.Text,
                MYFORM.txtmarca.Text,
                MYFORM.txttipo.Text,
                MYFORM.txtmodelo.Text,
                MYFORM.txtmarcamotor.Text,
                MYFORM.txtnumeromotor.Text,
                MYFORM.txtmarcachasis.Text,
                MYFORM.txtnumerochasis.Text
                );
            frm.Show();
        }

        private void abrir31_frente()
        {
            Presentacion.Forms.Form_31_Frente MYFORM = (Presentacion.Forms.Form_31_Frente)CurrentForm;
            CheckEmptyFields(MYFORM);
            Reportes.F31_Frente frm = new Reportes.F31_Frente(
            MYFORM.txtDominio.Text,
            MYFORM.txtDominioAnterior.Text,
            MYFORM.cmbNacionalImportado.SelectedItem.ToString(),
            MYFORM.dtpFechaUltimoTramite.Value.ToShortDateString(),
            MYFORM.txtNFormulario.Text,
            MYFORM.dtpFechaVigencia.Value.ToShortDateString(),
            MYFORM.txtReservadoRentas.Text,
            MYFORM.txtMarcaModelo.Text,
            MYFORM.txtTipo.Text,
            MYFORM.txtmodeloano.Text,
            MYFORM.txtmotormarca.Text,
            MYFORM.txtchasismarca.Text,
            MYFORM.txtmotornumero.Text,
            MYFORM.txtchasisnumero.Text,
            MYFORM.txtrubro.Text,
            MYFORM.txtcategoria.Text,
            MYFORM.txtpesocilindrada.Text,
            MYFORM.txtcodigomarcamodelo.Text,
            MYFORM.txtcombustible.Text,
            MYFORM.txtapellidonombreyrazonsocial.Text,
            MYFORM.txtnrodocumento.Text,
            resolvechk(MYFORM.chkdni),
            resolvechk(MYFORM.chkle),
            resolvechk(MYFORM.chklc),
            resolvechk(MYFORM.chkci),
            resolvechk(MYFORM.chkpas),
            MYFORM.txtcuitcuil.Text,
            MYFORM.txtdfcallenombre.Text,
            MYFORM.txtdfcallenro.Text,
            MYFORM.txtdfcallepiso.Text,
            MYFORM.txtdfcalledepto.Text,
            MYFORM.txtdfbarriolocalidad.Text,
            MYFORM.txtdfcodigopostal.Text,
            MYFORM.txtdfprovincia.Text,
            MYFORM.txtcallenombre.Text,
            MYFORM.txtcallenro.Text,
            MYFORM.txtcallepiso.Text,
            MYFORM.txtcalledepto.Text,
            MYFORM.txtbarrio.Text,
            MYFORM.txtcodigopostal.Text,
            MYFORM.txtprovincia.Text
          );
            frm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (lvForms.SelectedItems.Count > 0)
            {
                string[] splitter = {"-"};
                string[] extension = lvForms.SelectedItems[0].Text.Split(splitter, StringSplitOptions.None);
                SFD.Title = "Guardar formulario...";
                string completeextension = extension[0].Trim().Replace(" ", "") + extension[1].Trim().Replace(" ", "");
                
                SFD.DefaultExt = completeextension;
                SFD.Filter = ("Archivo soportado (" + completeextension + ")|*" + completeextension);
                SFD.ShowDialog();
                
            }
           
        }


        private void examinarControl(Control p_control) 
        {
             
            if (p_control.Controls.Count > 0)
            {
                for (int a = 0; a < p_control.Controls.Count; a++)
                {
                    examinarControl(p_control.Controls[a]);
                }

            }
            else
            {
                if (p_control.ToString().ToLower().Contains("textbox"))
                {
                    TextBox _TB = (TextBox) p_control;
                    if (_TB.Text == "") { _TB.Text = " "; }
                    ObjectSave.Pool.InsertarObjeto(ObjectSave.Pool.TiposDeControles.textbox, _TB.Name, _TB.Text);
                }

                if (p_control.ToString().ToLower().Contains("datetime")) 
                {
                   DateTimePicker _DTP = (DateTimePicker) p_control;
                   ObjectSave.Pool.InsertarObjeto(ObjectSave.Pool.TiposDeControles.datetimepicker, _DTP.Name, _DTP.Value.ToString());
                }

                if (p_control.ToString().ToLower().Contains("checkbox")) 
                {
                    
                    CheckBox _CB = (CheckBox) p_control;
                    ObjectSave.Pool.InsertarObjeto(ObjectSave.Pool.TiposDeControles.checkbox,_CB.Name , _CB.Checked.ToString());
                }
            
        }
        }



        private void SFD_FileOk(object sender, CancelEventArgs e)
        {

            ObjectSave.Pool.LimpiarListado();
            examinarControl(CurrentForm);

            if (ObjectSave.Pool.ListaDeControles.Count > 0) {
                StreamWriter _SW = new StreamWriter(SFD.FileName);
            for (int a = 0; a < ObjectSave.Pool.ListaDeControles.Count; a++) 
            {
                string _writeString = ObjectSave.Pool.ListaDeControles[a].Name + "|" + ObjectSave.Pool.ListaDeControles[a].TipoControl1.ToString() + "|" + ObjectSave.Pool.ListaDeControles[a].Value;
                _SW.WriteLine(_writeString);
            }
            _SW.Close();
            }
            SFD.FileName = "";

           

            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (lvForms.SelectedItems.Count > 0)
            {
                string[] splitter = {"-"};
                string[] extension = lvForms.SelectedItems[0].Text.Split(splitter, StringSplitOptions.None);
                OFD.Title = "Abrir Formulario...";
                string completeextension = extension[0].Trim().Replace(" ", "") + extension[1].Trim().Replace(" ", "");
                OFD.Filter = "Archivos del formulario (" +completeextension + ")|*." + completeextension;
            OFD.ShowDialog();
                
            }
           
        }


        private void setearControl(Control p_control,string nameControl, string valueControl)
        {

            if (p_control.Controls.Count > 0)
            {
                for (int a = 0; a < p_control.Controls.Count; a++)
                {
                    setearControl(p_control.Controls[a],nameControl,valueControl);
                }

            }
            else
            {
                if (p_control.ToString().ToLower().Contains("textbox"))
                {
                    TextBox _TB = (TextBox)p_control;
                    if (nameControl == _TB.Name) 
                    {
                        _TB.Text = valueControl;
                    }
                }

                if (p_control.ToString().ToLower().Contains("datetime"))
                {
                    DateTimePicker _DTP = (DateTimePicker)p_control;
                    if (nameControl == _DTP.Name)
                    {
                        _DTP.Value = DateTime.Parse(valueControl);
                    }
                }

                if (p_control.ToString().ToLower().Contains("checkbox"))
                {

                    CheckBox _CB = (CheckBox)p_control;
                    if (nameControl == _CB.Name)
                    {
                        _CB.Checked = Boolean.Parse(valueControl);
                    }
                }

            }
        }

        private void OFD_FileOk(object sender, CancelEventArgs e)
        {



            
            System.IO.StreamReader SR1 = new StreamReader(OFD.FileName);
             System.IO.StreamReader SR2 = new StreamReader(OFD.FileName);
            
            int counter=0;
             while (SR1.EndOfStream==false){
           
            counter++;
            SR1.ReadLine();
               
           }
             SR1.Close();

             Extras.LoadWindows LW = new Extras.LoadWindows(counter);
             LW.LostFocus += LW_LostFocus;
             LW.Show();
             Application.DoEvents();
             int updatecounter = 0;
           while (SR2.EndOfStream==false){
               updatecounter++;
            string _Linea = SR2.ReadLine();
               string[] _splitter = {"|"};
               string[] _valores = _Linea.Split(_splitter, StringSplitOptions.None);
               setearControl(CurrentForm, _valores[0], _valores[2]);
               LW.UpdateValue(updatecounter,_valores[2]);
               
           }
           SR1.Close();
           LW.Close();
        }

        void LW_LostFocus(object sender, EventArgs e)
        {
            Extras.LoadWindows LW = (Extras.LoadWindows)sender;
            LW.Focus();
            LW.BringToFront();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new FormulariosExtras.Clientes().ShowDialog();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new FormulariosExtras.Calibradoimpresion().ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (CurrentForm != null)
            {
                CLD.Color = CurrentForm.BackColor;
                
            CLD.ShowDialog();
            
                CurrentForm.BackColor = CLD.Color;
                string formname = lvForms.SelectedItems[0].Text;
                string formcolor = CLD.Color.R.ToString() +"," +  CLD.Color.G.ToString()+"," + CLD.Color.B.ToString();
                Extras.Configurations.SaveConfig(formname, formcolor);
                Extras.Configurations.saveChanges();
            }
            
        }

        

    }
}
