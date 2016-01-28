namespace Presentacion
{
    partial class frmCantidadCopíasImprimir
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtNumeroDeCopias = new System.Windows.Forms.TextBox();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDatos.Controls.Add(this.btnAceptar);
            this.pnlDatos.Controls.Add(this.lblNro);
            this.pnlDatos.Controls.Add(this.txtNumeroDeCopias);
            this.pnlDatos.Location = new System.Drawing.Point(12, 12);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(234, 46);
            this.pnlDatos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(139, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(17, 18);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(59, 13);
            this.lblNro.TabIndex = 1;
            this.lblNro.Text = "Nro Copias";
            // 
            // txtNumeroDeCopias
            // 
            this.txtNumeroDeCopias.Location = new System.Drawing.Point(82, 15);
            this.txtNumeroDeCopias.Name = "txtNumeroDeCopias";
            this.txtNumeroDeCopias.Size = new System.Drawing.Size(51, 20);
            this.txtNumeroDeCopias.TabIndex = 0;
            // 
            // frmCantidadCopíasImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 72);
            this.Controls.Add(this.pnlDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCantidadCopíasImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad de Copias";
            this.Load += new System.EventHandler(this.frmCantidadCopíasImprimir_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtNumeroDeCopias;
    }
}