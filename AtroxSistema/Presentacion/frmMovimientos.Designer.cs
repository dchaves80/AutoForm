namespace Presentacion
{
    partial class frmMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnBuscarMovimiento = new System.Windows.Forms.Button();
            this.txtIdTipoMov = new Controls.AtroxTextBox();
            this.txtCuenta = new Controls.AtroxTextBox();
            this.cmbCondicionPago = new System.Windows.Forms.ComboBox();
            this.lblCondicionPago = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.txtFechaContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaContabilizacion = new System.Windows.Forms.Label();
            this.txtFechaComprobante = new System.Windows.Forms.DateTimePicker();
            this.lblFechaComprobante = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.txtPuntoVenta = new System.Windows.Forms.TextBox();
            this.lblNroMov = new System.Windows.Forms.Label();
            this.lblTipoMov = new System.Windows.Forms.Label();
            this.txtNombreTipoMov = new System.Windows.Forms.TextBox();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCodArt = new Controls.AtroxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertarArt = new System.Windows.Forms.Button();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImporteNeto = new System.Windows.Forms.Label();
            this.txtImporteNeto = new System.Windows.Forms.TextBox();
            this.txtImporteIVA = new System.Windows.Forms.TextBox();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAnular = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabecera.Controls.Add(this.btnBuscarMovimiento);
            this.pnlCabecera.Controls.Add(this.txtIdTipoMov);
            this.pnlCabecera.Controls.Add(this.txtCuenta);
            this.pnlCabecera.Controls.Add(this.cmbCondicionPago);
            this.pnlCabecera.Controls.Add(this.lblCondicionPago);
            this.pnlCabecera.Controls.Add(this.txtObservaciones);
            this.pnlCabecera.Controls.Add(this.lblObservaciones);
            this.pnlCabecera.Controls.Add(this.lblCuenta);
            this.pnlCabecera.Controls.Add(this.txtNombreCuenta);
            this.pnlCabecera.Controls.Add(this.txtFechaContabilizacion);
            this.pnlCabecera.Controls.Add(this.lblFechaContabilizacion);
            this.pnlCabecera.Controls.Add(this.txtFechaComprobante);
            this.pnlCabecera.Controls.Add(this.lblFechaComprobante);
            this.pnlCabecera.Controls.Add(this.txtNroComprobante);
            this.pnlCabecera.Controls.Add(this.txtPuntoVenta);
            this.pnlCabecera.Controls.Add(this.lblNroMov);
            this.pnlCabecera.Controls.Add(this.lblTipoMov);
            this.pnlCabecera.Controls.Add(this.txtNombreTipoMov);
            this.pnlCabecera.Location = new System.Drawing.Point(12, 12);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(884, 117);
            this.pnlCabecera.TabIndex = 0;
            // 
            // btnBuscarMovimiento
            // 
            this.btnBuscarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMovimiento.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarMovimiento.Image = global::Presentacion.Properties.Resources.search;
            this.btnBuscarMovimiento.Location = new System.Drawing.Point(502, 1);
            this.btnBuscarMovimiento.Name = "btnBuscarMovimiento";
            this.btnBuscarMovimiento.Size = new System.Drawing.Size(29, 28);
            this.btnBuscarMovimiento.TabIndex = 19;
            this.btnBuscarMovimiento.UseVisualStyleBackColor = true;
            this.btnBuscarMovimiento.Click += new System.EventHandler(this.btnBuscarMovimiento_Click);
            // 
            // txtIdTipoMov
            // 
            this.txtIdTipoMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.txtIdTipoMov.Location = new System.Drawing.Point(96, 3);
            this.txtIdTipoMov.Name = "txtIdTipoMov";
            this.txtIdTipoMov.Size = new System.Drawing.Size(64, 20);
            this.txtIdTipoMov.TabIndex = 2;
            this.txtIdTipoMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdTipoMov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdTipoMov_KeyDown);
            this.txtIdTipoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTipoMov_KeyPress);
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.txtCuenta.Location = new System.Drawing.Point(96, 32);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(64, 20);
            this.txtCuenta.TabIndex = 18;
            this.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuenta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            this.txtCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuenta_KeyDown);
            // 
            // cmbCondicionPago
            // 
            this.cmbCondicionPago.FormattingEnabled = true;
            this.cmbCondicionPago.Location = new System.Drawing.Point(502, 32);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(162, 21);
            this.cmbCondicionPago.TabIndex = 17;
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.AutoSize = true;
            this.lblCondicionPago.Location = new System.Drawing.Point(414, 36);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Size = new System.Drawing.Size(82, 13);
            this.lblCondicionPago.TabIndex = 16;
            this.lblCondicionPago.Text = "Condición Pago";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(96, 58);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(748, 46);
            this.txtObservaciones.TabIndex = 15;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(16, 61);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 14;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(53, 35);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 9;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Enabled = false;
            this.txtNombreCuenta.Location = new System.Drawing.Point(166, 32);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.ReadOnly = true;
            this.txtNombreCuenta.Size = new System.Drawing.Size(243, 20);
            this.txtNombreCuenta.TabIndex = 11;
            // 
            // txtFechaContabilizacion
            // 
            this.txtFechaContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaContabilizacion.Location = new System.Drawing.Point(779, 29);
            this.txtFechaContabilizacion.Name = "txtFechaContabilizacion";
            this.txtFechaContabilizacion.Size = new System.Drawing.Size(91, 20);
            this.txtFechaContabilizacion.TabIndex = 13;
            // 
            // lblFechaContabilizacion
            // 
            this.lblFechaContabilizacion.AutoSize = true;
            this.lblFechaContabilizacion.Location = new System.Drawing.Point(663, 35);
            this.lblFechaContabilizacion.Name = "lblFechaContabilizacion";
            this.lblFechaContabilizacion.Size = new System.Drawing.Size(111, 13);
            this.lblFechaContabilizacion.TabIndex = 12;
            this.lblFechaContabilizacion.Text = "Fecha Contabilización";
            // 
            // txtFechaComprobante
            // 
            this.txtFechaComprobante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaComprobante.Location = new System.Drawing.Point(779, 3);
            this.txtFechaComprobante.Name = "txtFechaComprobante";
            this.txtFechaComprobante.Size = new System.Drawing.Size(91, 20);
            this.txtFechaComprobante.TabIndex = 8;
            // 
            // lblFechaComprobante
            // 
            this.lblFechaComprobante.AutoSize = true;
            this.lblFechaComprobante.Location = new System.Drawing.Point(670, 6);
            this.lblFechaComprobante.Name = "lblFechaComprobante";
            this.lblFechaComprobante.Size = new System.Drawing.Size(103, 13);
            this.lblFechaComprobante.TabIndex = 7;
            this.lblFechaComprobante.Text = "Fecha Comprobante";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(588, 3);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(76, 20);
            this.txtNroComprobante.TabIndex = 6;
            this.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroComprobante_KeyPress);
            // 
            // txtPuntoVenta
            // 
            this.txtPuntoVenta.Location = new System.Drawing.Point(537, 3);
            this.txtPuntoVenta.Name = "txtPuntoVenta";
            this.txtPuntoVenta.Size = new System.Drawing.Size(45, 20);
            this.txtPuntoVenta.TabIndex = 5;
            this.txtPuntoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuntoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoVenta_KeyPress);
            // 
            // lblNroMov
            // 
            this.lblNroMov.AutoSize = true;
            this.lblNroMov.Location = new System.Drawing.Point(415, 6);
            this.lblNroMov.Name = "lblNroMov";
            this.lblNroMov.Size = new System.Drawing.Size(81, 13);
            this.lblNroMov.TabIndex = 4;
            this.lblNroMov.Text = "Nro Movimiento";
            // 
            // lblTipoMov
            // 
            this.lblTipoMov.AutoSize = true;
            this.lblTipoMov.Location = new System.Drawing.Point(9, 6);
            this.lblTipoMov.Name = "lblTipoMov";
            this.lblTipoMov.Size = new System.Drawing.Size(85, 13);
            this.lblTipoMov.TabIndex = 1;
            this.lblTipoMov.Text = "Tipo Movimiento";
            // 
            // txtNombreTipoMov
            // 
            this.txtNombreTipoMov.Enabled = false;
            this.txtNombreTipoMov.Location = new System.Drawing.Point(166, 3);
            this.txtNombreTipoMov.Name = "txtNombreTipoMov";
            this.txtNombreTipoMov.ReadOnly = true;
            this.txtNombreTipoMov.Size = new System.Drawing.Size(243, 20);
            this.txtNombreTipoMov.TabIndex = 3;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Controls.Add(this.groupBox1);
            this.pnlDetalle.Controls.Add(this.label3);
            this.pnlDetalle.Controls.Add(this.label2);
            this.pnlDetalle.Controls.Add(this.lblImporteNeto);
            this.pnlDetalle.Controls.Add(this.txtImporteNeto);
            this.pnlDetalle.Controls.Add(this.txtImporteIVA);
            this.pnlDetalle.Controls.Add(this.txtImporteTotal);
            this.pnlDetalle.Controls.Add(this.dgvDetalle);
            this.pnlDetalle.Location = new System.Drawing.Point(12, 135);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(884, 470);
            this.pnlDetalle.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtCodArt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsertarArt);
            this.groupBox1.Controls.Add(this.txtNombreArticulo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 45);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador de Articulos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(6, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 23);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "+";
            this.ttAyuda.SetToolTip(this.btnNuevo, "Inserte un detalle por medio de este boton.");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCodArt
            // 
            this.txtCodArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.txtCodArt.Location = new System.Drawing.Point(81, 15);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(61, 20);
            this.txtCodArt.TabIndex = 20;
            this.txtCodArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.atroxTextBox1_KeyDown);
            this.txtCodArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodArt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cod. Art.";
            // 
            // btnInsertarArt
            // 
            this.btnInsertarArt.ForeColor = System.Drawing.Color.Black;
            this.btnInsertarArt.Location = new System.Drawing.Point(404, 13);
            this.btnInsertarArt.Name = "btnInsertarArt";
            this.btnInsertarArt.Size = new System.Drawing.Size(138, 23);
            this.btnInsertarArt.TabIndex = 2;
            this.btnInsertarArt.Text = "[Insertar/Modificar]";
            this.btnInsertarArt.UseVisualStyleBackColor = true;
            this.btnInsertarArt.Click += new System.EventHandler(this.btnInsertarArt_Click);
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreArticulo.Enabled = false;
            this.txtNombreArticulo.Location = new System.Drawing.Point(147, 15);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(251, 20);
            this.txtNombreArticulo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Importe Total";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Importe IVA";
            // 
            // lblImporteNeto
            // 
            this.lblImporteNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteNeto.AutoSize = true;
            this.lblImporteNeto.Location = new System.Drawing.Point(454, 444);
            this.lblImporteNeto.Name = "lblImporteNeto";
            this.lblImporteNeto.Size = new System.Drawing.Size(68, 13);
            this.lblImporteNeto.TabIndex = 21;
            this.lblImporteNeto.Text = "Importe Neto";
            // 
            // txtImporteNeto
            // 
            this.txtImporteNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteNeto.Enabled = false;
            this.txtImporteNeto.Location = new System.Drawing.Point(528, 441);
            this.txtImporteNeto.Name = "txtImporteNeto";
            this.txtImporteNeto.ReadOnly = true;
            this.txtImporteNeto.Size = new System.Drawing.Size(64, 20);
            this.txtImporteNeto.TabIndex = 20;
            this.txtImporteNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImporteIVA
            // 
            this.txtImporteIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteIVA.Enabled = false;
            this.txtImporteIVA.Location = new System.Drawing.Point(670, 441);
            this.txtImporteIVA.Name = "txtImporteIVA";
            this.txtImporteIVA.ReadOnly = true;
            this.txtImporteIVA.Size = new System.Drawing.Size(64, 20);
            this.txtImporteIVA.TabIndex = 19;
            this.txtImporteIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(815, 441);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.ReadOnly = true;
            this.txtImporteTotal.Size = new System.Drawing.Size(64, 20);
            this.txtImporteTotal.TabIndex = 18;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEliminar,
            this.colIdArticulo,
            this.colNombreArticulo,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colIVA,
            this.colSubTotal});
            this.dgvDetalle.Location = new System.Drawing.Point(4, 67);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(875, 368);
            this.dgvDetalle.TabIndex = 17;
            this.dgvDetalle.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalle_CellMouseClick);
            this.dgvDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellValueChanged);
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Del.";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Width = 50;
            // 
            // colIdArticulo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.colIdArticulo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colIdArticulo.HeaderText = "Cód Art.";
            this.colIdArticulo.Name = "colIdArticulo";
            this.colIdArticulo.ReadOnly = true;
            this.colIdArticulo.Width = 75;
            // 
            // colNombreArticulo
            // 
            this.colNombreArticulo.HeaderText = "Descripción";
            this.colNombreArticulo.Name = "colNombreArticulo";
            this.colNombreArticulo.ReadOnly = true;
            this.colNombreArticulo.Width = 200;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 60;
            // 
            // colPrecioUnitario
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.colPrecioUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPrecioUnitario.HeaderText = "Pr. Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            // 
            // colIVA
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.colIVA.DefaultCellStyle = dataGridViewCellStyle9;
            this.colIVA.HeaderText = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.ReadOnly = true;
            this.colIVA.Width = 50;
            // 
            // colSubTotal
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotones.Controls.Add(this.btnAnular);
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnGrabar);
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Location = new System.Drawing.Point(12, 611);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(884, 45);
            this.pnlBotones.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(794, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(217, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(135, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(54, 9);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 19;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::Presentacion.Properties.Resources.Impresora;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(32, 32);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ttAyuda
            // 
            this.ttAyuda.ToolTipTitle = "Ayuda:";
            // 
            // btnAnular
            // 
            this.btnAnular.Enabled = false;
            this.btnAnular.Location = new System.Drawing.Point(379, 9);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 25;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 668);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlCabecera);
            this.MaximizeBox = false;
            this.Name = "frmMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMovimientos_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.DateTimePicker txtFechaContabilizacion;
        private System.Windows.Forms.Label lblFechaContabilizacion;
        private System.Windows.Forms.DateTimePicker txtFechaComprobante;
        private System.Windows.Forms.Label lblFechaComprobante;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.TextBox txtPuntoVenta;
        private System.Windows.Forms.Label lblNroMov;
        private System.Windows.Forms.Label lblTipoMov;
        private System.Windows.Forms.TextBox txtNombreTipoMov;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImporteNeto;
        private System.Windows.Forms.TextBox txtImporteNeto;
        private System.Windows.Forms.TextBox txtImporteIVA;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.ComboBox cmbCondicionPago;
        private System.Windows.Forms.Label lblCondicionPago;
        private Controls.AtroxTextBox txtCuenta;
        private Controls.AtroxTextBox txtIdTipoMov;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.AtroxTextBox txtCodArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarArt;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.Button btnBuscarMovimiento;
        private System.Windows.Forms.Button btnAnular;
    }
}