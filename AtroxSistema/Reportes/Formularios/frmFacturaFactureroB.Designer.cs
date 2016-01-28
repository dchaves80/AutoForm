namespace Reportes.Formularios
{
    partial class frmFacturaFactureroB
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
            this.sPFacturaFactureroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDAtroxDataSet = new Reportes.DataSet.BDAtroxDataSet();
            this.rvFacturaDeFacturero = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPFacturaFactureroTableAdapter = new Reportes.DataSet.BDAtroxDataSetTableAdapters.SPFacturaFactureroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturaFactureroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sPFacturaFactureroBindingSource
            // 
            this.sPFacturaFactureroBindingSource.DataMember = "SPFacturaFacturero";
            this.sPFacturaFactureroBindingSource.DataSource = this.BDAtroxDataSet;
            // 
            // BDAtroxDataSet
            // 
            this.BDAtroxDataSet.DataSetName = "BDAtroxDataSet";
            this.BDAtroxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvFacturaDeFacturero
            // 
            this.rvFacturaDeFacturero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvFacturaDeFacturero.DocumentMapWidth = 79;
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.sPFacturaFactureroBindingSource;
            this.rvFacturaDeFacturero.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFacturaDeFacturero.LocalReport.ReportEmbeddedResource = "Reportes.Reportes.repFactureroB.rdlc";
            this.rvFacturaDeFacturero.Location = new System.Drawing.Point(0, 0);
            this.rvFacturaDeFacturero.Name = "rvFacturaDeFacturero";
            this.rvFacturaDeFacturero.Size = new System.Drawing.Size(906, 405);
            this.rvFacturaDeFacturero.TabIndex = 0;
            // 
            // sPFacturaFactureroTableAdapter
            // 
            this.sPFacturaFactureroTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaFactureroB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 405);
            this.Controls.Add(this.rvFacturaDeFacturero);
            this.Name = "frmFacturaFactureroB";
            this.Text = "frmFacturaFactureroB";
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturaFactureroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFacturaDeFacturero;
        private System.Windows.Forms.BindingSource sPFacturaFactureroBindingSource;
        private DataSet.BDAtroxDataSet BDAtroxDataSet;
        private DataSet.BDAtroxDataSetTableAdapters.SPFacturaFactureroTableAdapter sPFacturaFactureroTableAdapter;
    }
}