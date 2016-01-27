using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Splash
{
    public partial class Splash : Form
    {
        int counter = 0;
        public Splash()
        {
            InitializeComponent();
            timer1.Stop();
            if (Schlüssel.Registro.comprobarregistro() == true)
            {
                timer1.Start();
            }
            else 
            {
                MessageBox.Show("El tiempo de prueba finalizo. \n Consulte con el soporte de venta para adquirir el producto");
                try { File.Delete(Application.StartupPath + "\\" + "Reportes.dll"); } catch  { }
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 3) 
            {
                Principal P = new Principal();
                P.Show();
                P.FormClosed += P_FormClosed;
                this.Hide();
                timer1.Stop();
            }
        }

        void P_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
