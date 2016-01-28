using Reportes.DataSet;
namespace Reportes
{
    partial class frmListarArticulos
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
            this.SPReporteArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDAtroxDataSet = new Reportes.DataSet.BDAtroxDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SPReporteArticulosTableAdapter = new Reportes.DataSet.BDAtroxDataSetTableAdapters.SPReporteArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SPReporteArticulosBindingSource
            // 
            this.SPReporteArticulosBindingSource.DataMember = "SPReporteArticulos";
            this.SPReporteArticulosBindingSource.DataSource = this.BDAtroxDataSet;
            // 
            // BDAtroxDataSet
            // 
            this.BDAtroxDataSet.DataSetName = "BDAtroxDataSet";
            this.BDAtroxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 64;
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.SPReporteArticulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Reportes.repArticulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1234, 495);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // SPReporteArticulosTableAdapter
            // 
            this.SPReporteArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // frmListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 495);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SPReporteArticulosBindingSource;
        private BDAtroxDataSet BDAtroxDataSet;
        private Reportes.DataSet.BDAtroxDataSetTableAdapters.SPReporteArticulosTableAdapter SPReporteArticulosTableAdapter;
    }
}