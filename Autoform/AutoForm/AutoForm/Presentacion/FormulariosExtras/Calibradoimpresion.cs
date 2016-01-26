using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.FormulariosExtras
{


    public partial class Calibradoimpresion : Form
    {


        string path = Application.StartupPath + "\\margin.cfg";

        public Calibradoimpresion()
        {
            InitializeComponent();
        }


        private decimal separatevaluefromparameter(string completeline)
        {
           
           
            string[] splitter1 = { ":" };
            string[] chain = completeline.Split(splitter1,StringSplitOptions.None);
            string separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (separator == ",")
            {
                try
                {
                    return Convert.ToDecimal(chain[1].Replace(".", ","));
                }
                catch (Exception E) 
                {
                    return 0;
                }

            }
            else 
            {
                try
                {
                    return Convert.ToDecimal(chain[1].Replace(",", "."));
                }
                catch (Exception E) 
                {
                    return 0;
                }
            }

        }

        private void Calibradoimpresion_Load(object sender, EventArgs e)
        {

           
            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader SR = new System.IO.StreamReader(path);
                txtMS.Text = separatevaluefromparameter( SR.ReadLine()).ToString();
                txtMI.Text = separatevaluefromparameter(SR.ReadLine()).ToString();
                SR.Close();
            }
            else 
            {
                System.IO.File.Create(path).Close();
                System.IO.StreamWriter SW = System.IO.File.AppendText(path);
                SW.WriteLine("MarginTop:0,0");
                SW.WriteLine("MarginLeft:0,0");
                txtMI.Text="0,0";
                txtMS.Text = "0,0";
                SW.Close();
            }

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(path);
            txtMS.Text = txtMS.Text.Replace(".", ",");
            txtMI.Text = txtMI.Text.Replace(".", ",");
            System.IO.File.Create(path).Close();
            System.IO.StreamWriter SW = System.IO.File.AppendText(path);
            SW.WriteLine("MarginTop:" + txtMS.Text);
            SW.WriteLine("MarginLeft:" + txtMI.Text);
            SW.Close();
            if (txtMS.Text.Trim() == "") {txtMS.Text = "0,0"; }
            if (txtMI.Text.Trim() == "") {txtMI.Text = "0,0";}
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
