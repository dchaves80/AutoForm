namespace Reportes.Formularios
{
    partial class frmParametrosMovimientos
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
            this.pnlTipoMov = new System.Windows.Forms.Panel();
            this.btnDeseleccionarTodo = new System.Windows.Forms.Button();
            this.btnInvertirSeleccion = new System.Windows.Forms.Button();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            this.pnlParametros = new System.Windows.Forms.Panel();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblCuentaHasta = new System.Windows.Forms.Label();
            this.lblCuentaDesde = new System.Windows.Forms.Label();
            this.txtCuentaHasta = new System.Windows.Forms.TextBox();
            this.txtCuentaDesde = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvTipoMovimientos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTipoMov.SuspendLayout();
            this.pnlParametros.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTipoMov
            // 
            this.pnlTipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTipoMov.Controls.Add(this.dgvTipoMovimientos);
            this.pnlTipoMov.Controls.Add(this.btnDeseleccionarTodo);
            this.pnlTipoMov.Controls.Add(this.btnInvertirSeleccion);
            this.pnlTipoMov.Controls.Add(this.btnSeleccionarTodo);
            this.pnlTipoMov.Location = new System.Drawing.Point(12, 79);
            this.pnlTipoMov.Name = "pnlTipoMov";
            this.pnlTipoMov.Size = new System.Drawing.Size(690, 466);
            this.pnlTipoMov.TabIndex = 0;
            // 
            // btnDeseleccionarTodo
            // 
            this.btnDeseleccionarTodo.BackgroundImage = global::Reportes.Properties.Resources.Deseleccionar;
            this.btnDeseleccionarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeseleccionarTodo.Location = new System.Drawing.Point(650, 199);
            this.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo";
            this.btnDeseleccionarTodo.Size = new System.Drawing.Size(32, 92);
            this.btnDeseleccionarTodo.TabIndex = 3;
            this.btnDeseleccionarTodo.UseVisualStyleBackColor = true;
            this.btnDeseleccionarTodo.Click += new System.EventHandler(this.btnDeseleccionarTodo_Click);
            // 
            // btnInvertirSeleccion
            // 
            this.btnInvertirSeleccion.BackgroundImage = global::Reportes.Properties.Resources.Invertir_Seleccion;
            this.btnInvertirSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvertirSeleccion.Location = new System.Drawing.Point(650, 101);
            this.btnInvertirSeleccion.Name = "btnInvertirSeleccion";
            this.btnInvertirSeleccion.Size = new System.Drawing.Size(32, 92);
            this.btnInvertirSeleccion.TabIndex = 2;
            this.btnInvertirSeleccion.UseVisualStyleBackColor = true;
            this.btnInvertirSeleccion.Click += new System.EventHandler(this.btnInvertirSeleccion_Click);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.BackgroundImage = global::Reportes.Properties.Resources.Seleccionado;
            this.btnSeleccionarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(650, 3);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(32, 92);
            this.btnSeleccionarTodo.TabIndex = 1;
            this.btnSeleccionarTodo.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // pnlParametros
            // 
            this.pnlParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParametros.Controls.Add(this.lblFechaHasta);
            this.pnlParametros.Controls.Add(this.lblFechaDesde);
            this.pnlParametros.Controls.Add(this.txtFechaHasta);
            this.pnlParametros.Controls.Add(this.txtFechaDesde);
            this.pnlParametros.Controls.Add(this.lblCuentaHasta);
            this.pnlParametros.Controls.Add(this.lblCuentaDesde);
            this.pnlParametros.Controls.Add(this.txtCuentaHasta);
            this.pnlParametros.Controls.Add(this.txtCuentaDesde);
            this.pnlParametros.Location = new System.Drawing.Point(12, 12);
            this.pnlParametros.Name = "pnlParametros";
            this.pnlParametros.Size = new System.Drawing.Size(690, 61);
            this.pnlParametros.TabIndex = 1;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(353, 40);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 23;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(166, 40);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 22;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(427, 34);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaHasta.TabIndex = 21;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(243, 34);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDesde.TabIndex = 20;
            // 
            // lblCuentaHasta
            // 
            this.lblCuentaHasta.AutoSize = true;
            this.lblCuentaHasta.Location = new System.Drawing.Point(349, 8);
            this.lblCuentaHasta.Name = "lblCuentaHasta";
            this.lblCuentaHasta.Size = new System.Drawing.Size(72, 13);
            this.lblCuentaHasta.TabIndex = 19;
            this.lblCuentaHasta.Text = "Cuenta Hasta";
            // 
            // lblCuentaDesde
            // 
            this.lblCuentaDesde.AutoSize = true;
            this.lblCuentaDesde.Location = new System.Drawing.Point(162, 8);
            this.lblCuentaDesde.Name = "lblCuentaDesde";
            this.lblCuentaDesde.Size = new System.Drawing.Size(75, 13);
            this.lblCuentaDesde.TabIndex = 18;
            this.lblCuentaDesde.Text = "Cuenta Desde";
            // 
            // txtCuentaHasta
            // 
            this.txtCuentaHasta.Location = new System.Drawing.Point(427, 5);
            this.txtCuentaHasta.Name = "txtCuentaHasta";
            this.txtCuentaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaHasta.TabIndex = 17;
            // 
            // txtCuentaDesde
            // 
            this.txtCuentaDesde.Location = new System.Drawing.Point(243, 5);
            this.txtCuentaDesde.Name = "txtCuentaDesde";
            this.txtCuentaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaDesde.TabIndex = 16;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 547);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(690, 37);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(349, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(243, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 27);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvTipoMovimientos
            // 
            this.dgvTipoMovimientos.AllowUserToAddRows = false;
            this.dgvTipoMovimientos.AllowUserToDeleteRows = false;
            this.dgvTipoMovimientos.AllowUserToResizeRows = false;
            this.dgvTipoMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Seleccionar});
            this.dgvTipoMovimientos.Location = new System.Drawing.Point(3, 3);
            this.dgvTipoMovimientos.Name = "dgvTipoMovimientos";
            this.dgvTipoMovimientos.RowHeadersVisible = false;
            this.dgvTipoMovimientos.Size = new System.Drawing.Size(641, 458);
            this.dgvTipoMovimientos.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 450;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 75;
            // 
            // frmParametrosMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 596);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlParametros);
            this.Controls.Add(this.pnlTipoMov);
            this.MaximizeBox = false;
            this.Name = "frmParametrosMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros Listado de Movimientos";
            this.Load += new System.EventHandler(this.frmParametrosMovimientos_Load);
            this.pnlTipoMov.ResumeLayout(false);
            this.pnlParametros.ResumeLayout(false);
            this.pnlParametros.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTipoMov;
        private System.Windows.Forms.Button btnDeseleccionarTodo;
        private System.Windows.Forms.Button btnInvertirSeleccion;
        private System.Windows.Forms.Button btnSeleccionarTodo;
        private System.Windows.Forms.Panel pnlParametros;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label lblCuentaHasta;
        private System.Windows.Forms.Label lblCuentaDesde;
        private System.Windows.Forms.TextBox txtCuentaHasta;
        private System.Windows.Forms.TextBox txtCuentaDesde;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvTipoMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ToolTip TT;
    }
}