namespace Presentacion
{
    partial class frmActualizarPrecioXCuenta
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlParametros = new System.Windows.Forms.Panel();
            this.txtCodigoCategoria = new Controls.AtroxTextBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtCuenta = new Controls.AtroxTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblCuentaDesde = new System.Windows.Forms.Label();
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.epControlCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBotones.SuspendLayout();
            this.pnlParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnActualizar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 111);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(501, 37);
            this.pnlBotones.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(148, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 27);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlParametros
            // 
            this.pnlParametros.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParametros.Controls.Add(this.txtCodigoCategoria);
            this.pnlParametros.Controls.Add(this.txtNombreCategoria);
            this.pnlParametros.Controls.Add(this.txtCuenta);
            this.pnlParametros.Controls.Add(this.lblCategoria);
            this.pnlParametros.Controls.Add(this.lblPorcentaje);
            this.pnlParametros.Controls.Add(this.txtPorcentaje);
            this.pnlParametros.Controls.Add(this.lblCuentaDesde);
            this.pnlParametros.Controls.Add(this.txtNombreCuenta);
            this.pnlParametros.Location = new System.Drawing.Point(12, 12);
            this.pnlParametros.Name = "pnlParametros";
            this.pnlParametros.Size = new System.Drawing.Size(501, 93);
            this.pnlParametros.TabIndex = 0;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Location = new System.Drawing.Point(89, 36);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoCategoria.TabIndex = 5;
            this.txtCodigoCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigocategoria_KeyDown);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Enabled = false;
            this.txtNombreCategoria.Location = new System.Drawing.Point(159, 36);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.ReadOnly = true;
            this.txtNombreCategoria.Size = new System.Drawing.Size(330, 20);
            this.txtNombreCategoria.TabIndex = 6;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(89, 10);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(64, 20);
            this.txtCuenta.TabIndex = 2;
            this.txtCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuenta_KeyDown);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(31, 39);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(25, 66);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentaje.TabIndex = 7;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(89, 63);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(64, 20);
            this.txtPorcentaje.TabIndex = 8;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // lblCuentaDesde
            // 
            this.lblCuentaDesde.AutoSize = true;
            this.lblCuentaDesde.Location = new System.Drawing.Point(27, 13);
            this.lblCuentaDesde.Name = "lblCuentaDesde";
            this.lblCuentaDesde.Size = new System.Drawing.Size(56, 13);
            this.lblCuentaDesde.TabIndex = 1;
            this.lblCuentaDesde.Text = "Proveedor";
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Enabled = false;
            this.txtNombreCuenta.Location = new System.Drawing.Point(159, 10);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.ReadOnly = true;
            this.txtNombreCuenta.Size = new System.Drawing.Size(330, 20);
            this.txtNombreCuenta.TabIndex = 3;
            // 
            // epControlCampos
            // 
            this.epControlCampos.ContainerControl = this;
            // 
            // frmActualizarPrecioXCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 160);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmActualizarPrecioXCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Precio Artículos";
            this.pnlBotones.ResumeLayout(false);
            this.pnlParametros.ResumeLayout(false);
            this.pnlParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlParametros;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblCuentaDesde;
        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.Label lblCategoria;
        private Controls.AtroxTextBox txtCuenta;
        private Controls.AtroxTextBox txtCodigoCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.ErrorProvider epControlCampos;
    }
}