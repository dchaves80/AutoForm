namespace Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPrecioPorCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.actualizarPrecioPorCuentaToolStripMenuItem,
            this.categoriaArticuloToolStripMenuItem,
            this.tipoDeComprobantesToolStripMenuItem,
            this.impresorasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icoCuentas;
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // actualizarPrecioPorCuentaToolStripMenuItem
            // 
            this.actualizarPrecioPorCuentaToolStripMenuItem.Name = "actualizarPrecioPorCuentaToolStripMenuItem";
            this.actualizarPrecioPorCuentaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.actualizarPrecioPorCuentaToolStripMenuItem.Text = "Actualizar Precio por Cuenta";
            this.actualizarPrecioPorCuentaToolStripMenuItem.Click += new System.EventHandler(this.actualizarPrecioPorCuentaToolStripMenuItem_Click);
            // 
            // categoriaArticuloToolStripMenuItem
            // 
            this.categoriaArticuloToolStripMenuItem.Name = "categoriaArticuloToolStripMenuItem";
            this.categoriaArticuloToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.categoriaArticuloToolStripMenuItem.Text = "Categoria Articulo";
            this.categoriaArticuloToolStripMenuItem.Click += new System.EventHandler(this.categoriaArticuloToolStripMenuItem_Click);
            // 
            // tipoDeComprobantesToolStripMenuItem
            // 
            this.tipoDeComprobantesToolStripMenuItem.Name = "tipoDeComprobantesToolStripMenuItem";
            this.tipoDeComprobantesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.tipoDeComprobantesToolStripMenuItem.Text = "Tipo de Comprobantes";
            this.tipoDeComprobantesToolStripMenuItem.Click += new System.EventHandler(this.tipoDeComprobantesToolStripMenuItem_Click);
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.Impresora;
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            this.impresorasToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.impresorasToolStripMenuItem.Text = "Impresoras";
            this.impresorasToolStripMenuItem.Click += new System.EventHandler(this.impresorasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeMovimientoToolStripMenuItem,
            this.movimientosToolStripMenuItem2});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // tipoDeMovimientoToolStripMenuItem
            // 
            this.tipoDeMovimientoToolStripMenuItem.Name = "tipoDeMovimientoToolStripMenuItem";
            this.tipoDeMovimientoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tipoDeMovimientoToolStripMenuItem.Text = "Tipo de Movimiento";
            this.tipoDeMovimientoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeMovimientoToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem2
            // 
            this.movimientosToolStripMenuItem2.Name = "movimientosToolStripMenuItem2";
            this.movimientosToolStripMenuItem2.Size = new System.Drawing.Size(182, 22);
            this.movimientosToolStripMenuItem2.Text = "Movimientos";
            this.movimientosToolStripMenuItem2.Click += new System.EventHandler(this.movimientosToolStripMenuItem2_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.cuentasToolStripMenuItem1,
            this.movimientosToolStripMenuItem1});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icoListados;
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem1
            // 
            this.cuentasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem2,
            this.resumenDeCuentasToolStripMenuItem});
            this.cuentasToolStripMenuItem1.Image = global::Presentacion.Properties.Resources.icoListados;
            this.cuentasToolStripMenuItem1.Name = "cuentasToolStripMenuItem1";
            this.cuentasToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.cuentasToolStripMenuItem1.Text = "Cuentas";
            // 
            // cuentasToolStripMenuItem2
            // 
            this.cuentasToolStripMenuItem2.Image = global::Presentacion.Properties.Resources.icoListados;
            this.cuentasToolStripMenuItem2.Name = "cuentasToolStripMenuItem2";
            this.cuentasToolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.cuentasToolStripMenuItem2.Text = "Cuentas";
            this.cuentasToolStripMenuItem2.Click += new System.EventHandler(this.cuentasToolStripMenuItem2_Click);
            // 
            // resumenDeCuentasToolStripMenuItem
            // 
            this.resumenDeCuentasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icoListados;
            this.resumenDeCuentasToolStripMenuItem.Name = "resumenDeCuentasToolStripMenuItem";
            this.resumenDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.resumenDeCuentasToolStripMenuItem.Text = "Resumen de Cuentas";
            this.resumenDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.resumenDeCuentasToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem1
            // 
            this.movimientosToolStripMenuItem1.Image = global::Presentacion.Properties.Resources.icoListados;
            this.movimientosToolStripMenuItem1.Name = "movimientosToolStripMenuItem1";
            this.movimientosToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.movimientosToolStripMenuItem1.Text = "Movimientos";
            this.movimientosToolStripMenuItem1.Click += new System.EventHandler(this.movimientosToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 389);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resumenDeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPrecioPorCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tipoDeComprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}