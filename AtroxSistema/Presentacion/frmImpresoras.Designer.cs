namespace Presentacion
{
    partial class frmImpresoras
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
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblEstacion = new System.Windows.Forms.Label();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.lblImpresora = new System.Windows.Forms.Label();
            this.txtEstacion = new System.Windows.Forms.TextBox();
            this.txtNombreComprobante = new System.Windows.Forms.TextBox();
            this.cmbImpresoras = new System.Windows.Forms.ComboBox();
            this.epControlCampo = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdTipoComprobante = new Controls.AtroxTextBox();
            this.pnlBotones.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampo)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBotones.Location = new System.Drawing.Point(12, 121);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(445, 45);
            this.pnlBotones.TabIndex = 15;
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
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDatos.Controls.Add(this.txtIdTipoComprobante);
            this.pnlDatos.Controls.Add(this.cmbImpresoras);
            this.pnlDatos.Controls.Add(this.txtNombreComprobante);
            this.pnlDatos.Controls.Add(this.txtEstacion);
            this.pnlDatos.Controls.Add(this.lblImpresora);
            this.pnlDatos.Controls.Add(this.lblComprobante);
            this.pnlDatos.Controls.Add(this.lblEstacion);
            this.pnlDatos.Location = new System.Drawing.Point(12, 12);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(445, 103);
            this.pnlDatos.TabIndex = 16;
            // 
            // lblEstacion
            // 
            this.lblEstacion.AutoSize = true;
            this.lblEstacion.Location = new System.Drawing.Point(30, 16);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(48, 13);
            this.lblEstacion.TabIndex = 0;
            this.lblEstacion.Text = "Estación";
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(8, 43);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(70, 13);
            this.lblComprobante.TabIndex = 1;
            this.lblComprobante.Text = "Comprobante";
            // 
            // lblImpresora
            // 
            this.lblImpresora.AutoSize = true;
            this.lblImpresora.Location = new System.Drawing.Point(20, 70);
            this.lblImpresora.Name = "lblImpresora";
            this.lblImpresora.Size = new System.Drawing.Size(58, 13);
            this.lblImpresora.TabIndex = 2;
            this.lblImpresora.Text = "Impresoras";
            // 
            // txtEstacion
            // 
            this.txtEstacion.Enabled = false;
            this.txtEstacion.Location = new System.Drawing.Point(93, 13);
            this.txtEstacion.Name = "txtEstacion";
            this.txtEstacion.ReadOnly = true;
            this.txtEstacion.Size = new System.Drawing.Size(330, 20);
            this.txtEstacion.TabIndex = 3;
            // 
            // txtNombreComprobante
            // 
            this.txtNombreComprobante.Enabled = false;
            this.txtNombreComprobante.Location = new System.Drawing.Point(164, 40);
            this.txtNombreComprobante.Name = "txtNombreComprobante";
            this.txtNombreComprobante.ReadOnly = true;
            this.txtNombreComprobante.Size = new System.Drawing.Size(259, 20);
            this.txtNombreComprobante.TabIndex = 4;
            // 
            // cmbImpresoras
            // 
            this.cmbImpresoras.FormattingEnabled = true;
            this.cmbImpresoras.Location = new System.Drawing.Point(93, 67);
            this.cmbImpresoras.Name = "cmbImpresoras";
            this.cmbImpresoras.Size = new System.Drawing.Size(330, 21);
            this.cmbImpresoras.TabIndex = 5;
            // 
            // epControlCampo
            // 
            this.epControlCampo.ContainerControl = this;
            // 
            // txtIdTipoComprobante
            // 
            this.txtIdTipoComprobante.Location = new System.Drawing.Point(93, 40);
            this.txtIdTipoComprobante.Name = "txtIdTipoComprobante";
            this.txtIdTipoComprobante.Size = new System.Drawing.Size(65, 20);
            this.txtIdTipoComprobante.TabIndex = 6;
            this.txtIdTipoComprobante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdTipoComprobante_KeyDown);
            // 
            // frmImpresoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 181);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmImpresoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresoras por Comprobantes";
            this.Load += new System.EventHandler(this.frmImpresoras_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblImpresora;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.Label lblEstacion;
        private Controls.AtroxTextBox txtIdTipoComprobante;
        private System.Windows.Forms.ComboBox cmbImpresoras;
        private System.Windows.Forms.TextBox txtNombreComprobante;
        private System.Windows.Forms.TextBox txtEstacion;
        private System.Windows.Forms.ErrorProvider epControlCampo;
    }
}