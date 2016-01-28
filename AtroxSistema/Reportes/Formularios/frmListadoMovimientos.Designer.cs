namespace Reportes.Formularios
{
    partial class frmListadoMovimientos
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
            this.sPListarMovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDAtroxDataSet = new Reportes.DataSet.BDAtroxDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPListarMovimientosTableAdapter = new Reportes.DataSet.BDAtroxDataSetTableAdapters.SPListarMovimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarMovimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sPListarMovimientosBindingSource
            // 
            this.sPListarMovimientosBindingSource.DataMember = "SPListarMovimientos";
            this.sPListarMovimientosBindingSource.DataSource = this.BDAtroxDataSet;
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
            reportDataSource1.Value = this.sPListarMovimientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Reportes.repListadoMovimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1084, 590);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sPListarMovimientosTableAdapter
            // 
            this.sPListarMovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 590);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Movimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoMovimientos_Load);
            this.Shown += new System.EventHandler(this.frmListadoMovimientos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.sPListarMovimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPListarMovimientosBindingSource;
        private DataSet.BDAtroxDataSet BDAtroxDataSet;
        private DataSet.BDAtroxDataSetTableAdapters.SPListarMovimientosTableAdapter sPListarMovimientosTableAdapter;
    }
}