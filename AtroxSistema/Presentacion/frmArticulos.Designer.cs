namespace Presentacion
{
    partial class frmArticulos
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
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtPrecioSugerido = new System.Windows.Forms.TextBox();
            this.chkLlevaStock = new System.Windows.Forms.CheckBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodBarra = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblPrecioSugerido = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProveedor = new Controls.AtroxTextBox();
            this.txtCodigo = new Controls.AtroxTextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.chkCongelarPrecio = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.epControlCampo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BDAtroxDataSet1 = new Datos.BDAtroxDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 34);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(117, 60);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(262, 20);
            this.txtCodigoBarra.TabIndex = 4;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(298, 86);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(81, 20);
            this.txtPrecioCompra.TabIndex = 8;
            this.txtPrecioCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioCompra_KeyDown);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(117, 113);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(68, 20);
            this.txtPorcentaje.TabIndex = 10;
            this.txtPorcentaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorcentaje_KeyDown);
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // txtPrecioSugerido
            // 
            this.txtPrecioSugerido.Location = new System.Drawing.Point(298, 114);
            this.txtPrecioSugerido.Name = "txtPrecioSugerido";
            this.txtPrecioSugerido.Size = new System.Drawing.Size(81, 20);
            this.txtPrecioSugerido.TabIndex = 12;
            this.txtPrecioSugerido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioSugerido_KeyPress);
            // 
            // chkLlevaStock
            // 
            this.chkLlevaStock.AutoSize = true;
            this.chkLlevaStock.Location = new System.Drawing.Point(176, 164);
            this.chkLlevaStock.Name = "chkLlevaStock";
            this.chkLlevaStock.Size = new System.Drawing.Size(83, 17);
            this.chkLlevaStock.TabIndex = 18;
            this.chkLlevaStock.Text = "Lleva Stock";
            this.chkLlevaStock.UseVisualStyleBackColor = true;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Location = new System.Drawing.Point(176, 139);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(203, 20);
            this.txtNombreProveedor.TabIndex = 15;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(89, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código Producto:";
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.AutoSize = true;
            this.lblCodBarra.Location = new System.Drawing.Point(54, 64);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(60, 13);
            this.lblCodBarra.TabIndex = 3;
            this.lblCodBarra.Text = "Cód. Barra:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(87, 90);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(27, 13);
            this.lblIVA.TabIndex = 5;
            this.lblIVA.Text = "IVA:";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(213, 90);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioCompra.TabIndex = 7;
            this.lblPrecioCompra.Text = "Precio Compra:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(53, 116);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(61, 13);
            this.lblPorcentaje.TabIndex = 9;
            this.lblPorcentaje.Text = "Porcentaje:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(30, 141);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(84, 13);
            this.lblProveedor.TabIndex = 13;
            this.lblProveedor.Text = "Cod. Proveedor:";
            // 
            // lblPrecioSugerido
            // 
            this.lblPrecioSugerido.AutoSize = true;
            this.lblPrecioSugerido.Location = new System.Drawing.Point(207, 117);
            this.lblPrecioSugerido.Name = "lblPrecioSugerido";
            this.lblPrecioSugerido.Size = new System.Drawing.Size(85, 13);
            this.lblPrecioSugerido.TabIndex = 11;
            this.lblPrecioSugerido.Text = "Precio Sugerido:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(62, 168);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(117, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 20);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtProveedor);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtIVA);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.chkCongelarPrecio);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCodigoBarra);
            this.panel1.Controls.Add(this.lblPrecioSugerido);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.txtPorcentaje);
            this.panel1.Controls.Add(this.lblPorcentaje);
            this.panel1.Controls.Add(this.lblPrecioCompra);
            this.panel1.Controls.Add(this.txtPrecioSugerido);
            this.panel1.Controls.Add(this.lblIVA);
            this.panel1.Controls.Add(this.chkLlevaStock);
            this.panel1.Controls.Add(this.lblCodBarra);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 225);
            this.panel1.TabIndex = 24;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.txtProveedor.Location = new System.Drawing.Point(117, 139);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(54, 20);
            this.txtProveedor.TabIndex = 14;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.txtCodigo.Location = new System.Drawing.Point(116, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(117, 86);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(81, 20);
            this.txtIVA.TabIndex = 6;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(59, 195);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(117, 191);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(159, 21);
            this.cmbCategoria.TabIndex = 21;
            // 
            // chkCongelarPrecio
            // 
            this.chkCongelarPrecio.AutoSize = true;
            this.chkCongelarPrecio.Location = new System.Drawing.Point(265, 165);
            this.chkCongelarPrecio.Name = "chkCongelarPrecio";
            this.chkCongelarPrecio.Size = new System.Drawing.Size(101, 17);
            this.chkCongelarPrecio.TabIndex = 19;
            this.chkCongelarPrecio.Text = "Congelar Precio";
            this.chkCongelarPrecio.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre Producto:";
            // 
            // epControlCampo
            // 
            this.epControlCampo.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGrabar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(12, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 45);
            this.panel2.TabIndex = 25;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(19, 8);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(68, 23);
            this.btnGrabar.TabIndex = 27;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 8);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(315, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 23);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(167, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BDAtroxDataSet1
            // 
            this.BDAtroxDataSet1.DataSetName = "BDAtroxDataSet";
            this.BDAtroxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BDAtroxDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtPrecioSugerido;
        private System.Windows.Forms.CheckBox chkLlevaStock;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodBarra;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblPrecioSugerido;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private Datos.BDAtroxDataSet BDAtroxDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider epControlCampo;
        private System.Windows.Forms.CheckBox chkCongelarPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIVA;
        private Controls.AtroxTextBox txtCodigo;
        private Controls.AtroxTextBox txtProveedor;
    }
}