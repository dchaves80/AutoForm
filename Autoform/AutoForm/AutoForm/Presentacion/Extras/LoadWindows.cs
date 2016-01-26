using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Extras
{
    public partial class LoadWindows : Form
    {
        public LoadWindows(int maxvalue)
        {
            
            InitializeComponent();
            progressBar1.Maximum = maxvalue;
            progressBar1.Value = 0;
        }

        public void UpdateValue(int value, string fieldvalue) 
        {
            label1.Text = "LLenando valor:" + fieldvalue;
            progressBar1.Value = value;
            progressBar1.Update();
            Application.DoEvents();

        }

        private void LoadWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
