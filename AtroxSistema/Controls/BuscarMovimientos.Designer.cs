namespace Controls
{
    partial class BuscarMovimientos
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.ClmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPuntoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNumeroMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmId,
            this.ClmPuntoVenta,
            this.ClmNumeroMovimiento,
            this.ClmIdCuenta,
            this.ClmCuenta,
            this.ClmImporte,
            this.ClmFecha});
            this.dtgv.Location = new System.Drawing.Point(12, 12);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(615, 238);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentDoubleClick);
            // 
            // ClmId
            // 
            this.ClmId.HeaderText = "Id";
            this.ClmId.Name = "ClmId";
            this.ClmId.ReadOnly = true;
            // 
            // ClmPuntoVenta
            // 
            this.ClmPuntoVenta.HeaderText = "P. de Venta";
            this.ClmPuntoVenta.Name = "ClmPuntoVenta";
            this.ClmPuntoVenta.ReadOnly = true;
            // 
            // ClmNumeroMovimiento
            // 
            this.ClmNumeroMovimiento.HeaderText = "Num. Mov.";
            this.ClmNumeroMovimiento.Name = "ClmNumeroMovimiento";
            this.ClmNumeroMovimiento.ReadOnly = true;
            // 
            // ClmIdCuenta
            // 
            this.ClmIdCuenta.HeaderText = "IdCuenta";
            this.ClmIdCuenta.Name = "ClmIdCuenta";
            this.ClmIdCuenta.ReadOnly = true;
            this.ClmIdCuenta.Visible = false;
            // 
            // ClmCuenta
            // 
            this.ClmCuenta.HeaderText = "Nombre Cuenta";
            this.ClmCuenta.Name = "ClmCuenta";
            this.ClmCuenta.ReadOnly = true;
            // 
            // ClmImporte
            // 
            this.ClmImporte.HeaderText = "Importe";
            this.ClmImporte.Name = "ClmImporte";
            this.ClmImporte.ReadOnly = true;
            // 
            // ClmFecha
            // 
            this.ClmFecha.HeaderText = "Fecha";
            this.ClmFecha.Name = "ClmFecha";
            this.ClmFecha.ReadOnly = true;
            // 
            // BuscarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 262);
            this.Controls.Add(this.dtgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Movimientos";
            this.Load += new System.EventHandler(this.BuscarMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPuntoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumeroMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFecha;
    }
}