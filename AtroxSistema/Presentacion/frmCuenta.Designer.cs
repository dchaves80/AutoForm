namespace Presentacion
{
    partial class frmCuenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvclipro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlClienteProvee = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCodigoLocalidad = new Controls.AtroxTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkProveedor = new System.Windows.Forms.CheckBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumeroDomicilio = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.txtIngBrutos = new System.Windows.Forms.TextBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.cmbCategoriaAFIP = new System.Windows.Forms.ComboBox();
            this.txtNombreFantasia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDpto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNroDomicilio = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNroIngBru = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCatAFIP = new System.Windows.Forms.Label();
            this.lblNombreF = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.radiobCliente = new System.Windows.Forms.RadioButton();
            this.radiobProveedor = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.epControlCampos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclipro)).BeginInit();
            this.PnlClienteProvee.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclipro
            // 
            this.dgvclipro.AllowUserToAddRows = false;
            this.dgvclipro.AllowUserToDeleteRows = false;
            this.dgvclipro.AllowUserToResizeRows = false;
            this.dgvclipro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclipro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvclipro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclipro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Mail,
            this.Telefono});
            this.dgvclipro.Location = new System.Drawing.Point(22, 111);
            this.dgvclipro.MultiSelect = false;
            this.dgvclipro.Name = "dgvclipro";
            this.dgvclipro.ReadOnly = true;
            this.dgvclipro.RowHeadersVisible = false;
            this.dgvclipro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclipro.Size = new System.Drawing.Size(334, 410);
            this.dgvclipro.TabIndex = 29;
            this.dgvclipro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclipro_CellContentClick);
            this.dgvclipro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclipro_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DividerWidth = 2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DividerWidth = 2;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.DividerWidth = 2;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DividerWidth = 2;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // PnlClienteProvee
            // 
            this.PnlClienteProvee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlClienteProvee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlClienteProvee.Controls.Add(this.txtId);
            this.PnlClienteProvee.Controls.Add(this.txtCodigoLocalidad);
            this.PnlClienteProvee.Controls.Add(this.btnSalir);
            this.PnlClienteProvee.Controls.Add(this.btnCancelar);
            this.PnlClienteProvee.Controls.Add(this.btnEliminar);
            this.PnlClienteProvee.Controls.Add(this.btnModificar);
            this.PnlClienteProvee.Controls.Add(this.btnGuardar);
            this.PnlClienteProvee.Controls.Add(this.chkProveedor);
            this.PnlClienteProvee.Controls.Add(this.cmbTipoDoc);
            this.PnlClienteProvee.Controls.Add(this.txtDepartamento);
            this.PnlClienteProvee.Controls.Add(this.txtPiso);
            this.PnlClienteProvee.Controls.Add(this.txtMail);
            this.PnlClienteProvee.Controls.Add(this.txtTelefono);
            this.PnlClienteProvee.Controls.Add(this.txtNumeroDomicilio);
            this.PnlClienteProvee.Controls.Add(this.txtDomicilio);
            this.PnlClienteProvee.Controls.Add(this.txtNombreLocalidad);
            this.PnlClienteProvee.Controls.Add(this.txtIngBrutos);
            this.PnlClienteProvee.Controls.Add(this.txtNumeroDoc);
            this.PnlClienteProvee.Controls.Add(this.cmbCategoriaAFIP);
            this.PnlClienteProvee.Controls.Add(this.txtNombreFantasia);
            this.PnlClienteProvee.Controls.Add(this.txtNombre);
            this.PnlClienteProvee.Controls.Add(this.lblNombre);
            this.PnlClienteProvee.Controls.Add(this.lblDpto);
            this.PnlClienteProvee.Controls.Add(this.lblPiso);
            this.PnlClienteProvee.Controls.Add(this.lblMail);
            this.PnlClienteProvee.Controls.Add(this.lblTelefono);
            this.PnlClienteProvee.Controls.Add(this.lblNroDomicilio);
            this.PnlClienteProvee.Controls.Add(this.lblDomicilio);
            this.PnlClienteProvee.Controls.Add(this.lblLocalidad);
            this.PnlClienteProvee.Controls.Add(this.lblNroIngBru);
            this.PnlClienteProvee.Controls.Add(this.lblNroDoc);
            this.PnlClienteProvee.Controls.Add(this.lblTipoDoc);
            this.PnlClienteProvee.Controls.Add(this.lblCatAFIP);
            this.PnlClienteProvee.Controls.Add(this.lblNombreF);
            this.PnlClienteProvee.Controls.Add(this.lblId);
            this.PnlClienteProvee.Location = new System.Drawing.Point(386, 48);
            this.PnlClienteProvee.Name = "PnlClienteProvee";
            this.PnlClienteProvee.Size = new System.Drawing.Size(349, 473);
            this.PnlClienteProvee.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(109, 15);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 38;
            // 
            // txtCodigoLocalidad
            // 
            this.txtCodigoLocalidad.Enabled = false;
            this.txtCodigoLocalidad.Location = new System.Drawing.Point(110, 209);
            this.txtCodigoLocalidad.Name = "txtCodigoLocalidad";
            this.txtCodigoLocalidad.Size = new System.Drawing.Size(62, 20);
            this.txtCodigoLocalidad.TabIndex = 37;
            this.txtCodigoLocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoLocalidad_KeyDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(274, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(208, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(142, 425);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(76, 425);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(10, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkProveedor
            // 
            this.chkProveedor.AutoSize = true;
            this.chkProveedor.Enabled = false;
            this.chkProveedor.Location = new System.Drawing.Point(109, 375);
            this.chkProveedor.Name = "chkProveedor";
            this.chkProveedor.Size = new System.Drawing.Size(75, 17);
            this.chkProveedor.TabIndex = 29;
            this.chkProveedor.Text = "Proveedor";
            this.chkProveedor.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.Enabled = false;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(109, 109);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(63, 21);
            this.cmbTipoDoc.TabIndex = 18;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(310, 275);
            this.txtDepartamento.MaxLength = 10;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(24, 20);
            this.txtDepartamento.TabIndex = 26;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            // 
            // txtPiso
            // 
            this.txtPiso.Enabled = false;
            this.txtPiso.Location = new System.Drawing.Point(109, 275);
            this.txtPiso.MaxLength = 10;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(26, 20);
            this.txtPiso.TabIndex = 25;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiso_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(109, 308);
            this.txtMail.MaxLength = 200;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(225, 20);
            this.txtMail.TabIndex = 27;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(109, 341);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(225, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNumeroDomicilio
            // 
            this.txtNumeroDomicilio.Enabled = false;
            this.txtNumeroDomicilio.Location = new System.Drawing.Point(290, 242);
            this.txtNumeroDomicilio.MaxLength = 20;
            this.txtNumeroDomicilio.Name = "txtNumeroDomicilio";
            this.txtNumeroDomicilio.Size = new System.Drawing.Size(44, 20);
            this.txtNumeroDomicilio.TabIndex = 24;
            this.txtNumeroDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDomicilio_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Location = new System.Drawing.Point(109, 242);
            this.txtDomicilio.MaxLength = 200;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 23;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreLocalidad.Enabled = false;
            this.txtNombreLocalidad.Location = new System.Drawing.Point(178, 209);
            this.txtNombreLocalidad.MaxLength = 200;
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(153, 20);
            this.txtNombreLocalidad.TabIndex = 22;
            // 
            // txtIngBrutos
            // 
            this.txtIngBrutos.Enabled = false;
            this.txtIngBrutos.Location = new System.Drawing.Point(109, 176);
            this.txtIngBrutos.MaxLength = 14;
            this.txtIngBrutos.Name = "txtIngBrutos";
            this.txtIngBrutos.Size = new System.Drawing.Size(100, 20);
            this.txtIngBrutos.TabIndex = 21;
            this.txtIngBrutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngBrutos_KeyPress);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Enabled = false;
            this.txtNumeroDoc.Location = new System.Drawing.Point(249, 110);
            this.txtNumeroDoc.MaxLength = 13;
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(85, 20);
            this.txtNumeroDoc.TabIndex = 19;
            this.txtNumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoc_KeyPress);
            // 
            // cmbCategoriaAFIP
            // 
            this.cmbCategoriaAFIP.Enabled = false;
            this.cmbCategoriaAFIP.FormattingEnabled = true;
            this.cmbCategoriaAFIP.Location = new System.Drawing.Point(109, 144);
            this.cmbCategoriaAFIP.Name = "cmbCategoriaAFIP";
            this.cmbCategoriaAFIP.Size = new System.Drawing.Size(225, 21);
            this.cmbCategoriaAFIP.TabIndex = 20;
            // 
            // txtNombreFantasia
            // 
            this.txtNombreFantasia.Enabled = false;
            this.txtNombreFantasia.Location = new System.Drawing.Point(109, 77);
            this.txtNombreFantasia.MaxLength = 200;
            this.txtNombreFantasia.Name = "txtNombreFantasia";
            this.txtNombreFantasia.Size = new System.Drawing.Size(225, 20);
            this.txtNombreFantasia.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(109, 44);
            this.txtNombre.MaxLength = 200;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 20);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(215, 282);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(77, 13);
            this.lblDpto.TabIndex = 14;
            this.lblDpto.Text = "Departamento:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(73, 282);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 9;
            this.lblPiso.Text = "Piso:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(74, 315);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(51, 348);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblNroDomicilio
            // 
            this.lblNroDomicilio.AutoSize = true;
            this.lblNroDomicilio.Location = new System.Drawing.Point(215, 249);
            this.lblNroDomicilio.Name = "lblNroDomicilio";
            this.lblNroDomicilio.Size = new System.Drawing.Size(75, 13);
            this.lblNroDomicilio.TabIndex = 13;
            this.lblNroDomicilio.Text = "Nro. Domicilio:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(51, 249);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(52, 13);
            this.lblDomicilio.TabIndex = 8;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(47, 216);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblNroIngBru
            // 
            this.lblNroIngBru.AutoSize = true;
            this.lblNroIngBru.Location = new System.Drawing.Point(2, 183);
            this.lblNroIngBru.Name = "lblNroIngBru";
            this.lblNroIngBru.Size = new System.Drawing.Size(101, 13);
            this.lblNroIngBru.TabIndex = 6;
            this.lblNroIngBru.Text = "Numero Ing. Brutos:\r\n";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(178, 117);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(73, 13);
            this.lblNroDoc.TabIndex = 12;
            this.lblNroDoc.Text = "Numero Doc.:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(46, 117);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(57, 13);
            this.lblTipoDoc.TabIndex = 4;
            this.lblTipoDoc.Text = "Tipo Doc.:";
            // 
            // lblCatAFIP
            // 
            this.lblCatAFIP.AutoSize = true;
            this.lblCatAFIP.Location = new System.Drawing.Point(22, 150);
            this.lblCatAFIP.Name = "lblCatAFIP";
            this.lblCatAFIP.Size = new System.Drawing.Size(81, 13);
            this.lblCatAFIP.TabIndex = 5;
            this.lblCatAFIP.Text = "Categoria AFIP:";
            // 
            // lblNombreF
            // 
            this.lblNombreF.AutoSize = true;
            this.lblNombreF.Location = new System.Drawing.Point(13, 84);
            this.lblNombreF.Name = "lblNombreF";
            this.lblNombreF.Size = new System.Drawing.Size(90, 13);
            this.lblNombreF.TabIndex = 3;
            this.lblNombreF.Text = "Nombre Fantasia:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(82, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.lblFiltro);
            this.pnlBusqueda.Controls.Add(this.txtBusqueda);
            this.pnlBusqueda.Controls.Add(this.radiobCliente);
            this.pnlBusqueda.Controls.Add(this.radiobProveedor);
            this.pnlBusqueda.Location = new System.Drawing.Point(22, 48);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(334, 58);
            this.pnlBusqueda.TabIndex = 30;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 33);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(49, 30);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(261, 20);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radiobCliente
            // 
            this.radiobCliente.AutoSize = true;
            this.radiobCliente.Location = new System.Drawing.Point(187, 7);
            this.radiobCliente.Name = "radiobCliente";
            this.radiobCliente.Size = new System.Drawing.Size(57, 17);
            this.radiobCliente.TabIndex = 1;
            this.radiobCliente.TabStop = true;
            this.radiobCliente.Text = "Cliente";
            this.radiobCliente.UseVisualStyleBackColor = true;
            this.radiobCliente.CheckedChanged += new System.EventHandler(this.radiobCliente_CheckedChanged);
            // 
            // radiobProveedor
            // 
            this.radiobProveedor.AutoSize = true;
            this.radiobProveedor.Location = new System.Drawing.Point(86, 7);
            this.radiobProveedor.Name = "radiobProveedor";
            this.radiobProveedor.Size = new System.Drawing.Size(74, 17);
            this.radiobProveedor.TabIndex = 0;
            this.radiobProveedor.TabStop = true;
            this.radiobProveedor.Text = "Proveedor";
            this.radiobProveedor.UseVisualStyleBackColor = true;
            this.radiobProveedor.CheckedChanged += new System.EventHandler(this.radiobProveedor_CheckedChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(491, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(147, 23);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "Nueva Cuenta";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // epControlCampos
            // 
            this.epControlCampos.ContainerControl = this;
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(766, 546);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.PnlClienteProvee);
            this.Controls.Add(this.dgvclipro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.frmCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclipro)).EndInit();
            this.PnlClienteProvee.ResumeLayout(false);
            this.PnlClienteProvee.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Panel PnlClienteProvee;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNroDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblNroIngBru;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCatAFIP;
        private System.Windows.Forms.Label lblNombreF;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNumeroDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.TextBox txtIngBrutos;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.ComboBox cmbCategoriaAFIP;
        private System.Windows.Forms.TextBox txtNombreFantasia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton radiobCliente;
        private System.Windows.Forms.RadioButton radiobProveedor;
        private System.Windows.Forms.CheckBox chkProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider epControlCampos;
        private Controls.AtroxTextBox txtCodigoLocalidad;
        private System.Windows.Forms.TextBox txtId;
    }
}