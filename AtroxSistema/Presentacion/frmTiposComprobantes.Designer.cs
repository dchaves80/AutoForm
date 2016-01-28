namespace Presentacion
{
    partial class frmTiposComprobantes
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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.epControlCampo = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCopias = new System.Windows.Forms.Label();
            this.txtCopias = new System.Windows.Forms.TextBox();
            this.txtId = new Controls.AtroxTextBox();
            this.pnlBotones.SuspendLayout();
            this.pnlCampos.SuspendLayout();
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
            this.pnlBotones.Location = new System.Drawing.Point(12, 103);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(445, 45);
            this.pnlBotones.TabIndex = 10;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(10, 10);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 23);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(92, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(344, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(176, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.lblCopias);
            this.pnlCampos.Controls.Add(this.txtCopias);
            this.pnlCampos.Controls.Add(this.lblDescripcion);
            this.pnlCampos.Controls.Add(this.lblLetra);
            this.pnlCampos.Controls.Add(this.txtLetra);
            this.pnlCampos.Controls.Add(this.txtDescripcion);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtNombre);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Location = new System.Drawing.Point(12, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(445, 85);
            this.pnlCampos.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(108, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(16, 38);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(31, 13);
            this.lblLetra.TabIndex = 4;
            this.lblLetra.Text = "Letra";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(53, 35);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(49, 20);
            this.txtLetra.TabIndex = 5;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(177, 35);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // epControlCampo
            // 
            this.epControlCampo.ContainerControl = this;
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Location = new System.Drawing.Point(8, 63);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(39, 13);
            this.lblCopias.TabIndex = 8;
            this.lblCopias.Text = "Copias";
            // 
            // txtCopias
            // 
            this.txtCopias.Location = new System.Drawing.Point(53, 60);
            this.txtCopias.Name = "txtCopias";
            this.txtCopias.Size = new System.Drawing.Size(49, 20);
            this.txtCopias.TabIndex = 9;
            this.txtCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCopias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCopias_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(53, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 2;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // frmTiposComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 160);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTiposComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Comprobantes";
            this.Load += new System.EventHandler(this.frmTiposComprobantes_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private Controls.AtroxTextBox txtId;
        private System.Windows.Forms.ErrorProvider epControlCampo;
        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.TextBox txtCopias;
    }
}