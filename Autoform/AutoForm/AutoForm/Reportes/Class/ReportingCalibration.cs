using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Reportes.Class
{
    public class ReportingCalibration
    {

        bool seted;

        ReportViewer reportViewer1;
        public ReportingCalibration(ReportViewer p_R) 
        {
            reportViewer1 = p_R;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            p_R.RenderingComplete += p_R_RenderingComplete;
            seted = false;

        }

        void p_R_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            //MessageBox.Show("ORIGINAL \n centimetros left:" + reportViewer1.Margin.Left.ToString() + "\n" + "centimetros top:" + reportViewer1.Margin.Top.ToString());

            //if (reportViewer1.GetTotalPages() > 1)
            //{
            //    MessageBox.Show("El reporte contiene mas de una página, esto puede ocasionar una impresión erronea en el reporte, reduzca el contenido de los campos que se encuentran al final del formulario o campos extensos como por ejemplo observaciones o documentacion extra", "Error en el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    reportViewer1.ParentForm.Close();
            //}




            if (seted == false)
            {
                seted = true;
                System.Drawing.Printing.PageSettings PS = new System.Drawing.Printing.PageSettings();
                PS.Margins.Top = Convert.ToInt32(Class.Medida.ObtenerMedidaVertical() * 100m);
                PS.Margins.Left = Convert.ToInt32(Class.Medida.ObtenerMedidaHorizontal() * 100m);
                PS.Margins.Bottom = 0;
                PS.Margins.Right = 0;
              /*  PS.HardMarginX = 0;
                PS.HardMarginY = 0;*/
                PS.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
                reportViewer1.RenderingComplete += reportViewer1_RenderingComplete;
                reportViewer1.SetPageSettings(PS);
                
                reportViewer1.RefreshReport();

                //MessageBox.Show("centimetros left:" + PS.Margins.Left.ToString() + "\n" + "centimetros top:" + PS.Margins.Top.ToString());

            }
            else 
            {
                int INDEXPDF = 0;

                for (int a = 0; a < reportViewer1.LocalReport.ListRenderingExtensions().Length; a++)
                {

                    if (reportViewer1.LocalReport.ListRenderingExtensions()[a].Name.Contains("PDF"))
                    {
                        INDEXPDF = a;
                        break;
                    }
                }
                reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[INDEXPDF], "", "c:\\hola.pdf");
            }
        }

        void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {

          

        }
    }
}
