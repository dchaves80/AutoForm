namespace Presentacion
{
    partial class frmEmpresa
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNomFant = new System.Windows.Forms.TextBox();
            this.txtIngBrut = new System.Windows.Forms.TextBox();
            this.dtpInicioActi = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreFantasia = new System.Windows.Forms.Label();
            this.lblIngBrutos = new System.Windows.Forms.Label();
            this.lblIniAct = new System.Windows.Forms.Label();
            this.lblCategoriaAfip = new System.Windows.Forms.Label();
            this.cmbCategoriaAfip = new System.Windows.Forms.ComboBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.MaskedTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.epControlCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 18);
            this.txtNombre.MaxLength = 200;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(315, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtNomFant
            // 
            this.txtNomFant.Location = new System.Drawing.Point(109, 44);
            this.txtNomFant.MaxLength = 200;
            this.txtNomFant.Name = "txtNomFant";
            this.txtNomFant.Size = new System.Drawing.Size(315, 20);
            this.txtNomFant.TabIndex = 1;
            // 
            // txtIngBrut
            // 
            this.txtIngBrut.Location = new System.Drawing.Point(109, 70);
            this.txtIngBrut.MaxLength = 14;
            this.txtIngBrut.Name = "txtIngBrut";
            this.txtIngBrut.Size = new System.Drawing.Size(79, 20);
            this.txtIngBrut.TabIndex = 2;
            this.txtIngBrut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngBrut_KeyPress);
            // 
            // dtpInicioActi
            // 
            this.dtpInicioActi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioActi.Location = new System.Drawing.Point(109, 122);
            this.dtpInicioActi.Name = "dtpInicioActi";
            this.dtpInicioActi.Size = new System.Drawing.Size(102, 20);
            this.dtpInicioActi.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreFantasia
            // 
            this.lblNombreFantasia.AutoSize = true;
            this.lblNombreFantasia.Location = new System.Drawing.Point(17, 47);
            this.lblNombreFantasia.Name = "lblNombreFantasia";
            this.lblNombreFantasia.Size = new System.Drawing.Size(90, 13);
            this.lblNombreFantasia.TabIndex = 12;
            this.lblNombreFantasia.Text = "Nombre Fantasia:";
            // 
            // lblIngBrutos
            // 
            this.lblIngBrutos.AutoSize = true;
            this.lblIngBrutos.Location = new System.Drawing.Point(24, 73);
            this.lblIngBrutos.Name = "lblIngBrutos";
            this.lblIngBrutos.Size = new System.Drawing.Size(83, 13);
            this.lblIngBrutos.TabIndex = 13;
            this.lblIngBrutos.Text = "Ingresos Brutos:";
            this.lblIngBrutos.UseMnemonic = false;
            // 
            // lblIniAct
            // 
            this.lblIniAct.AutoSize = true;
            this.lblIniAct.Location = new System.Drawing.Point(12, 125);
            this.lblIniAct.Name = "lblIniAct";
            this.lblIniAct.Size = new System.Drawing.Size(93, 13);
            this.lblIniAct.TabIndex = 15;
            this.lblIniAct.Text = "Inicio Actividades:";
            // 
            // lblCategoriaAfip
            // 
            this.lblCategoriaAfip.AutoSize = true;
            this.lblCategoriaAfip.Location = new System.Drawing.Point(29, 151);
            this.lblCategoriaAfip.Name = "lblCategoriaAfip";
            this.lblCategoriaAfip.Size = new System.Drawing.Size(76, 13);
            this.lblCategoriaAfip.TabIndex = 16;
            this.lblCategoriaAfip.Text = "Categoria Afip:";
            // 
            // cmbCategoriaAfip
            // 
            this.cmbCategoriaAfip.FormattingEnabled = true;
            this.cmbCategoriaAfip.Location = new System.Drawing.Point(109, 148);
            this.cmbCategoriaAfip.Name = "cmbCategoriaAfip";
            this.cmbCategoriaAfip.Size = new System.Drawing.Size(163, 21);
            this.cmbCategoriaAfip.TabIndex = 5;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(77, 99);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(28, 13);
            this.lblCUIT.TabIndex = 14;
            this.lblCUIT.Text = "Cuit:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(109, 96);
            this.txtCUIT.Mask = "##-########-#";
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(79, 20);
            this.txtCUIT.TabIndex = 3;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(10, 184);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(91, 184);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(172, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpInicioActi);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtNomFant);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.txtIngBrut);
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtCUIT);
            this.panel1.Controls.Add(this.lblNombreFantasia);
            this.panel1.Controls.Add(this.lblCUIT);
            this.panel1.Controls.Add(this.lblIngBrutos);
            this.panel1.Controls.Add(this.cmbCategoriaAfip);
            this.panel1.Controls.Add(this.lblIniAct);
            this.panel1.Controls.Add(this.lblCategoriaAfip);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 228);
            this.panel1.TabIndex = 17;
            // 
            // epControlCampos
            // 
            this.epControlCampos.ContainerControl = this;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 252);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNomFant;
        private System.Windows.Forms.TextBox txtIngBrut;
        private System.Windows.Forms.DateTimePicker dtpInicioActi;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreFantasia;
        private System.Windows.Forms.Label lblIngBrutos;
        private System.Windows.Forms.Label lblIniAct;
        private System.Windows.Forms.Label lblCategoriaAfip;
        private System.Windows.Forms.ComboBox cmbCategoriaAfip;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.MaskedTextBox txtCUIT;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider epControlCampos;
    }
}