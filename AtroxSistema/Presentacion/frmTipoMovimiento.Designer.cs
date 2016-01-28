namespace Presentacion
{
    partial class frmTipoMovimiento
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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.chkMueveStock = new System.Windows.Forms.CheckBox();
            this.gbNumeracion = new System.Windows.Forms.GroupBox();
            this.rbAutomatica = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.gbSigno = new System.Windows.Forms.GroupBox();
            this.rbAcredita = new System.Windows.Forms.RadioButton();
            this.rbDebita = new System.Windows.Forms.RadioButton();
            this.txtNombreComprobante = new System.Windows.Forms.TextBox();
            this.txtNombreTipoMovimiento = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.epControlCampo = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdTipoComprobante = new Controls.AtroxTextBox();
            this.txtCodigo = new Controls.AtroxTextBox();
            this.pnlCampos.SuspendLayout();
            this.gbNumeracion.SuspendLayout();
            this.gbSigno.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.label1);
            this.pnlCampos.Controls.Add(this.lblTipoMovimiento);
            this.pnlCampos.Controls.Add(this.chkMueveStock);
            this.pnlCampos.Controls.Add(this.gbNumeracion);
            this.pnlCampos.Controls.Add(this.gbSigno);
            this.pnlCampos.Controls.Add(this.txtNombreComprobante);
            this.pnlCampos.Controls.Add(this.txtNombreTipoMovimiento);
            this.pnlCampos.Controls.Add(this.txtIdTipoComprobante);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Location = new System.Drawing.Point(12, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(445, 127);
            this.pnlCampos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Comprobante";
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(12, 6);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(85, 13);
            this.lblTipoMovimiento.TabIndex = 1;
            this.lblTipoMovimiento.Text = "Tipo Movimiento";
            // 
            // chkMueveStock
            // 
            this.chkMueveStock.AutoSize = true;
            this.chkMueveStock.Location = new System.Drawing.Point(103, 102);
            this.chkMueveStock.Name = "chkMueveStock";
            this.chkMueveStock.Size = new System.Drawing.Size(90, 17);
            this.chkMueveStock.TabIndex = 13;
            this.chkMueveStock.Text = "Mueve Stock";
            this.chkMueveStock.UseVisualStyleBackColor = true;
            // 
            // gbNumeracion
            // 
            this.gbNumeracion.Controls.Add(this.rbAutomatica);
            this.gbNumeracion.Controls.Add(this.rbManual);
            this.gbNumeracion.Location = new System.Drawing.Point(249, 55);
            this.gbNumeracion.Name = "gbNumeracion";
            this.gbNumeracion.Size = new System.Drawing.Size(168, 41);
            this.gbNumeracion.TabIndex = 10;
            this.gbNumeracion.TabStop = false;
            this.gbNumeracion.Text = "Numeración";
            // 
            // rbAutomatica
            // 
            this.rbAutomatica.AutoSize = true;
            this.rbAutomatica.Location = new System.Drawing.Point(72, 18);
            this.rbAutomatica.Name = "rbAutomatica";
            this.rbAutomatica.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatica.TabIndex = 12;
            this.rbAutomatica.TabStop = true;
            this.rbAutomatica.Text = "Automática";
            this.rbAutomatica.UseVisualStyleBackColor = true;
            this.rbAutomatica.CheckedChanged += new System.EventHandler(this.rbAutomatica_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(6, 19);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 11;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // gbSigno
            // 
            this.gbSigno.Controls.Add(this.rbAcredita);
            this.gbSigno.Controls.Add(this.rbDebita);
            this.gbSigno.Location = new System.Drawing.Point(103, 55);
            this.gbSigno.Name = "gbSigno";
            this.gbSigno.Size = new System.Drawing.Size(140, 41);
            this.gbSigno.TabIndex = 7;
            this.gbSigno.TabStop = false;
            this.gbSigno.Text = "Signo";
            // 
            // rbAcredita
            // 
            this.rbAcredita.AutoSize = true;
            this.rbAcredita.Location = new System.Drawing.Point(68, 18);
            this.rbAcredita.Name = "rbAcredita";
            this.rbAcredita.Size = new System.Drawing.Size(64, 17);
            this.rbAcredita.TabIndex = 9;
            this.rbAcredita.TabStop = true;
            this.rbAcredita.Text = "Acredita";
            this.rbAcredita.UseVisualStyleBackColor = true;
            this.rbAcredita.CheckedChanged += new System.EventHandler(this.rbAcredita_CheckedChanged);
            // 
            // rbDebita
            // 
            this.rbDebita.AutoSize = true;
            this.rbDebita.Location = new System.Drawing.Point(6, 18);
            this.rbDebita.Name = "rbDebita";
            this.rbDebita.Size = new System.Drawing.Size(56, 17);
            this.rbDebita.TabIndex = 8;
            this.rbDebita.TabStop = true;
            this.rbDebita.Text = "Debita";
            this.rbDebita.UseVisualStyleBackColor = true;
            this.rbDebita.CheckedChanged += new System.EventHandler(this.rbDebita_CheckedChanged);
            // 
            // txtNombreComprobante
            // 
            this.txtNombreComprobante.Enabled = false;
            this.txtNombreComprobante.Location = new System.Drawing.Point(158, 29);
            this.txtNombreComprobante.Name = "txtNombreComprobante";
            this.txtNombreComprobante.ReadOnly = true;
            this.txtNombreComprobante.Size = new System.Drawing.Size(259, 20);
            this.txtNombreComprobante.TabIndex = 6;
            // 
            // txtNombreTipoMovimiento
            // 
            this.txtNombreTipoMovimiento.Location = new System.Drawing.Point(158, 3);
            this.txtNombreTipoMovimiento.Name = "txtNombreTipoMovimiento";
            this.txtNombreTipoMovimiento.Size = new System.Drawing.Size(259, 20);
            this.txtNombreTipoMovimiento.TabIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnGrabar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 145);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(445, 45);
            this.pnlBotones.TabIndex = 14;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(10, 10);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 23);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(92, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(344, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(176, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // epControlCampo
            // 
            this.epControlCampo.ContainerControl = this;
            // 
            // txtIdTipoComprobante
            // 
            this.txtIdTipoComprobante.Location = new System.Drawing.Point(103, 29);
            this.txtIdTipoComprobante.Name = "txtIdTipoComprobante";
            this.txtIdTipoComprobante.Size = new System.Drawing.Size(49, 20);
            this.txtIdTipoComprobante.TabIndex = 5;
            this.txtIdTipoComprobante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdTipoComprobante_KeyDown);
            this.txtIdTipoComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTipoComprobante_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // frmTipoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 202);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTipoMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Movimiento";
            this.Load += new System.EventHandler(this.frmTipoMovimiento_Load);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.gbNumeracion.ResumeLayout(false);
            this.gbNumeracion.PerformLayout();
            this.gbSigno.ResumeLayout(false);
            this.gbSigno.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.CheckBox chkMueveStock;
        private System.Windows.Forms.GroupBox gbNumeracion;
        private System.Windows.Forms.RadioButton rbAutomatica;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.GroupBox gbSigno;
        private System.Windows.Forms.RadioButton rbAcredita;
        private System.Windows.Forms.RadioButton rbDebita;
        private System.Windows.Forms.TextBox txtNombreComprobante;
        private System.Windows.Forms.TextBox txtNombreTipoMovimiento;
        private Controls.AtroxTextBox txtIdTipoComprobante;
        private Controls.AtroxTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider epControlCampo;
    }
}