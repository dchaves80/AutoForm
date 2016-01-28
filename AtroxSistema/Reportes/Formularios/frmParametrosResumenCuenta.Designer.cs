namespace Reportes.Formularios
{
    partial class frmParametrosResumenCuenta
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
            this.pnlParametros.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParametros
            // 
            this.pnlParametros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.pnlParametros.Size = new System.Drawing.Size(387, 61);
            this.pnlParametros.TabIndex = 2;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(201, 38);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 23;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(14, 38);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 22;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(275, 32);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaHasta.TabIndex = 21;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(91, 32);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDesde.TabIndex = 20;
            // 
            // lblCuentaHasta
            // 
            this.lblCuentaHasta.AutoSize = true;
            this.lblCuentaHasta.Location = new System.Drawing.Point(197, 6);
            this.lblCuentaHasta.Name = "lblCuentaHasta";
            this.lblCuentaHasta.Size = new System.Drawing.Size(72, 13);
            this.lblCuentaHasta.TabIndex = 19;
            this.lblCuentaHasta.Text = "Cuenta Hasta";
            // 
            // lblCuentaDesde
            // 
            this.lblCuentaDesde.AutoSize = true;
            this.lblCuentaDesde.Location = new System.Drawing.Point(10, 6);
            this.lblCuentaDesde.Name = "lblCuentaDesde";
            this.lblCuentaDesde.Size = new System.Drawing.Size(75, 13);
            this.lblCuentaDesde.TabIndex = 18;
            this.lblCuentaDesde.Text = "Cuenta Desde";
            // 
            // txtCuentaHasta
            // 
            this.txtCuentaHasta.Location = new System.Drawing.Point(275, 3);
            this.txtCuentaHasta.Name = "txtCuentaHasta";
            this.txtCuentaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaHasta.TabIndex = 17;
            // 
            // txtCuentaDesde
            // 
            this.txtCuentaDesde.Location = new System.Drawing.Point(91, 3);
            this.txtCuentaDesde.Name = "txtCuentaDesde";
            this.txtCuentaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaDesde.TabIndex = 16;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 79);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(387, 37);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(91, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 27);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmParametrosResumenCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 127);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmParametrosResumenCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros Resumen Cuenta";
            this.Load += new System.EventHandler(this.frmParametrosResumenCuenta_Load);
            this.pnlParametros.ResumeLayout(false);
            this.pnlParametros.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}