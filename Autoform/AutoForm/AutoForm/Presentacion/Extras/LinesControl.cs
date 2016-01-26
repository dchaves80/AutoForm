using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Extras
{
    public class LinesControl
    {

        TextBox _TB;
        Boolean _margeninicial;
        int characterCount;
        int lineCounts;

        public LinesControl(System.Windows.Forms.TextBox _ptb, Boolean p_margeninicial, int p_characterCount, int p_linesCount) 
        {
            _margeninicial = p_margeninicial;
            _ptb.KeyPress += _ptb_KeyPress;
            _TB = _ptb;
            lineCounts = p_linesCount;
            characterCount = p_characterCount;
        }

        public void EstablecerMargen() 
        {
            
            if (!_TB.Text.Contains("                         ") && _margeninicial==true)
            {
                _TB.Text.Trim();
                _TB.Text = "                         " + _TB.Text;
                MessageBox.Show("Se establecio un margen inicial para este campo...");
            }
            else 
            {

            }
        }

        void _ptb_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            

            if (_TB.Text.Length > characterCount-1)
            {
                e.KeyChar = '\0';
                MessageBox.Show("Sobrepasa el limite de caracteres para este campo");
                
            }
            else 
            {
                string[] splitter = { "\r" };
                string[] linecounts = _TB.Text.Split(splitter, StringSplitOptions.None);
                if (linecounts.Length > lineCounts-1 && e.KeyChar == '\r') 
                {
                    e.KeyChar = '\0';
                    MessageBox.Show("Sobrepasa el limite de lineas para este campo");
                }
            }
        }
    }
}
