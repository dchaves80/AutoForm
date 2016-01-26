using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class ParentForm : UserControl
    {
        private string _Name;
        private bool _init = false;

        public string NAME
        {
            get { return _Name; }
            set { 
                _Name = value;
                lblTitle.Text = _Name;
            }
        }

       


        public ParentForm()
        {
           InitializeComponent();
           _init=true;
        }

        public void InitAll()
        {
            if (_init==false)
            {
                InitializeComponent();
                _init=true;
            }
        }

         
    }
}
