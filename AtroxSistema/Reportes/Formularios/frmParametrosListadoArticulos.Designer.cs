namespace Reportes.Formularios
{
    partial class frmParametrosListadoArticulos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlParametros = new System.Windows.Forms.Panel();
            this.txtCuentaHasta = new Controls.AtroxTextBox();
            this.txtCuentaDesde = new Controls.AtroxTextBox();
            this.txtArticuloHasta = new Controls.AtroxTextBox();
            this.txtArticuloDesde = new Controls.AtroxTextBox();
            this.btnDeseleccionarTodo = new System.Windows.Forms.Button();
            this.btnInvertirSeleccion = new System.Windows.Forms.Button();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCuentaHasta = new System.Windows.Forms.Label();
            this.lblCuentaDesde = new System.Windows.Forms.Label();
            this.lblArticuloHasta = new System.Windows.Forms.Label();
            this.lblArticuloDesde = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBotones.SuspendLayout();
            this.pnlParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 369);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(387, 37);
            this.pnlBotones.TabIndex = 5;
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
            // pnlParametros
            // 
            this.pnlParametros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParametros.Controls.Add(this.txtCuentaHasta);
            this.pnlParametros.Controls.Add(this.txtCuentaDesde);
            this.pnlParametros.Controls.Add(this.txtArticuloHasta);
            this.pnlParametros.Controls.Add(this.txtArticuloDesde);
            this.pnlParametros.Controls.Add(this.btnDeseleccionarTodo);
            this.pnlParametros.Controls.Add(this.btnInvertirSeleccion);
            this.pnlParametros.Controls.Add(this.btnSeleccionarTodo);
            this.pnlParametros.Controls.Add(this.dgvCategorias);
            this.pnlParametros.Controls.Add(this.lblCuentaHasta);
            this.pnlParametros.Controls.Add(this.lblCuentaDesde);
            this.pnlParametros.Controls.Add(this.lblArticuloHasta);
            this.pnlParametros.Controls.Add(this.lblArticuloDesde);
            this.pnlParametros.Location = new System.Drawing.Point(12, 12);
            this.pnlParametros.Name = "pnlParametros";
            this.pnlParametros.Size = new System.Drawing.Size(387, 351);
            this.pnlParametros.TabIndex = 4;
            // 
            // txtCuentaHasta
            // 
            this.txtCuentaHasta.Location = new System.Drawing.Point(275, 29);
            this.txtCuentaHasta.Name = "txtCuentaHasta";
            this.txtCuentaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaHasta.TabIndex = 31;
            this.txtCuentaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuentaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuentaHasta_KeyDown);
            this.txtCuentaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaHasta_KeyPress);
            // 
            // txtCuentaDesde
            // 
            this.txtCuentaDesde.Location = new System.Drawing.Point(91, 29);
            this.txtCuentaDesde.Name = "txtCuentaDesde";
            this.txtCuentaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaDesde.TabIndex = 30;
            this.txtCuentaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuentaDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuentaDesde_KeyDown);
            this.txtCuentaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaDesde_KeyPress);
            // 
            // txtArticuloHasta
            // 
            this.txtArticuloHasta.Location = new System.Drawing.Point(275, 3);
            this.txtArticuloHasta.Name = "txtArticuloHasta";
            this.txtArticuloHasta.Size = new System.Drawing.Size(100, 20);
            this.txtArticuloHasta.TabIndex = 29;
            this.txtArticuloHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArticuloHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticuloHasta_KeyDown);
            this.txtArticuloHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticuloHasta_KeyPress);
            // 
            // txtArticuloDesde
            // 
            this.txtArticuloDesde.Location = new System.Drawing.Point(91, 3);
            this.txtArticuloDesde.Name = "txtArticuloDesde";
            this.txtArticuloDesde.Size = new System.Drawing.Size(100, 20);
            this.txtArticuloDesde.TabIndex = 28;
            this.txtArticuloDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArticuloDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticuloDesde_KeyDown);
            this.txtArticuloDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticuloDesde_KeyPress);
            // 
            // btnDeseleccionarTodo
            // 
            this.btnDeseleccionarTodo.BackgroundImage = global::Reportes.Properties.Resources.Deseleccionar;
            this.btnDeseleccionarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeseleccionarTodo.Location = new System.Drawing.Point(343, 251);
            this.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo";
            this.btnDeseleccionarTodo.Size = new System.Drawing.Size(32, 92);
            this.btnDeseleccionarTodo.TabIndex = 27;
            this.TT.SetToolTip(this.btnDeseleccionarTodo, "Deseleccionar todas las categorias");
            this.btnDeseleccionarTodo.UseVisualStyleBackColor = true;
            this.btnDeseleccionarTodo.Click += new System.EventHandler(this.btnDeseleccionarTodo_Click);
            // 
            // btnInvertirSeleccion
            // 
            this.btnInvertirSeleccion.BackgroundImage = global::Reportes.Properties.Resources.Invertir_Seleccion;
            this.btnInvertirSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvertirSeleccion.Location = new System.Drawing.Point(343, 153);
            this.btnInvertirSeleccion.Name = "btnInvertirSeleccion";
            this.btnInvertirSeleccion.Size = new System.Drawing.Size(32, 92);
            this.btnInvertirSeleccion.TabIndex = 26;
            this.TT.SetToolTip(this.btnInvertirSeleccion, "Invertir Categorias seleccionadas");
            this.btnInvertirSeleccion.UseVisualStyleBackColor = true;
            this.btnInvertirSeleccion.Click += new System.EventHandler(this.btnInvertirSeleccion_Click);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.BackgroundImage = global::Reportes.Properties.Resources.Seleccionado;
            this.btnSeleccionarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(343, 55);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(32, 92);
            this.btnSeleccionarTodo.TabIndex = 25;
            this.TT.SetToolTip(this.btnSeleccionarTodo, "Seleccionar todas las categorias");
            this.btnSeleccionarTodo.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Seleccionar});
            this.dgvCategorias.Location = new System.Drawing.Point(3, 55);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.Size = new System.Drawing.Size(334, 288);
            this.dgvCategorias.TabIndex = 24;
            // 
            // Id
            // 
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.ToolTipText = "Seleccionar todas las Categorias";
            this.Id.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 190;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 75;
            // 
            // lblCuentaHasta
            // 
            this.lblCuentaHasta.AutoSize = true;
            this.lblCuentaHasta.Location = new System.Drawing.Point(197, 32);
            this.lblCuentaHasta.Name = "lblCuentaHasta";
            this.lblCuentaHasta.Size = new System.Drawing.Size(72, 13);
            this.lblCuentaHasta.TabIndex = 23;
            this.lblCuentaHasta.Text = "Cuenta Hasta";
            // 
            // lblCuentaDesde
            // 
            this.lblCuentaDesde.AutoSize = true;
            this.lblCuentaDesde.Location = new System.Drawing.Point(10, 32);
            this.lblCuentaDesde.Name = "lblCuentaDesde";
            this.lblCuentaDesde.Size = new System.Drawing.Size(75, 13);
            this.lblCuentaDesde.TabIndex = 22;
            this.lblCuentaDesde.Text = "Cuenta Desde";
            // 
            // lblArticuloHasta
            // 
            this.lblArticuloHasta.AutoSize = true;
            this.lblArticuloHasta.Location = new System.Drawing.Point(197, 6);
            this.lblArticuloHasta.Name = "lblArticuloHasta";
            this.lblArticuloHasta.Size = new System.Drawing.Size(75, 13);
            this.lblArticuloHasta.TabIndex = 19;
            this.lblArticuloHasta.Text = "Artículo Hasta";
            // 
            // lblArticuloDesde
            // 
            this.lblArticuloDesde.AutoSize = true;
            this.lblArticuloDesde.Location = new System.Drawing.Point(10, 6);
            this.lblArticuloDesde.Name = "lblArticuloDesde";
            this.lblArticuloDesde.Size = new System.Drawing.Size(78, 13);
            this.lblArticuloDesde.TabIndex = 18;
            this.lblArticuloDesde.Text = "Artículo Desde";
            // 
            // frmParametrosListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 418);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlParametros);
            this.MaximizeBox = false;
            this.Name = "frmParametrosListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros Listado de Artículos";
            this.Load += new System.EventHandler(this.frmParametrosListadoArticulos_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlParametros.ResumeLayout(false);
            this.pnlParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlParametros;
        private System.Windows.Forms.Label lblArticuloHasta;
        private System.Windows.Forms.Label lblArticuloDesde;
        private System.Windows.Forms.Label lblCuentaHasta;
        private System.Windows.Forms.Label lblCuentaDesde;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnDeseleccionarTodo;
        private System.Windows.Forms.Button btnInvertirSeleccion;
        private System.Windows.Forms.Button btnSeleccionarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ToolTip TT;
        private Controls.AtroxTextBox txtArticuloDesde;
        private Controls.AtroxTextBox txtArticuloHasta;
        private Controls.AtroxTextBox txtCuentaHasta;
        private Controls.AtroxTextBox txtCuentaDesde;
    }
}