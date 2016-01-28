namespace Reportes.Formularios
{
    partial class frmResumenCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPResumenCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDAtroxDataSet = new Reportes.DataSet.BDAtroxDataSet();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPResumenCuentaTableAdapter = new Reportes.DataSet.BDAtroxDataSetTableAdapters.SPResumenCuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPResumenCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sPResumenCuentaBindingSource
            // 
            this.sPResumenCuentaBindingSource.DataMember = "SPResumenCuenta";
            this.sPResumenCuentaBindingSource.DataSource = this.BDAtroxDataSet;
            // 
            // BDAtroxDataSet
            // 
            this.BDAtroxDataSet.DataSetName = "BDAtroxDataSet";
            this.BDAtroxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv
            // 
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.sPResumenCuentaBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Reportes.Reportes.repResumenCuenta.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(1045, 675);
            this.rv.TabIndex = 0;
            this.rv.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sPResumenCuentaTableAdapter
            // 
            this.sPResumenCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmResumenCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 675);
            this.Controls.Add(this.rv);
            this.Name = "frmResumenCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Resumen de Cuenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResumenCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPResumenCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource sPResumenCuentaBindingSource;
        private DataSet.BDAtroxDataSet BDAtroxDataSet;
        private DataSet.BDAtroxDataSetTableAdapters.SPResumenCuentaTableAdapter sPResumenCuentaTableAdapter;
    }
}