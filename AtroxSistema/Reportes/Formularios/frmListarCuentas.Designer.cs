using Reportes.DataSet;
namespace Reportes
{
    partial class frmListarCuentas
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
            this.SPReporteCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDAtroxDataSet = new Reportes.DataSet.BDAtroxDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SPReporteCuentasTableAdapter = new Reportes.DataSet.BDAtroxDataSetTableAdapters.SPReporteCuentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SPReporteCuentasBindingSource
            // 
            this.SPReporteCuentasBindingSource.DataMember = "SPReporteCuentas";
            this.SPReporteCuentasBindingSource.DataSource = this.BDAtroxDataSet;
            // 
            // BDAtroxDataSet
            // 
            this.BDAtroxDataSet.DataSetName = "BDAtroxDataSet";
            this.BDAtroxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.SPReporteCuentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Reportes.repCuentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1223, 539);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // SPReporteCuentasTableAdapter
            // 
            this.SPReporteCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmListarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 539);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListarCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Cuentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListarCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SPReporteCuentasBindingSource;
        private BDAtroxDataSet BDAtroxDataSet;
        private Reportes.DataSet.BDAtroxDataSetTableAdapters.SPReporteCuentasTableAdapter SPReporteCuentasTableAdapter;
    }
}