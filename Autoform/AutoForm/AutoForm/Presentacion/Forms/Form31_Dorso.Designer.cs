namespace Presentacion.Forms
{
    partial class Form31_Dorso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOtros = new System.Windows.Forms.CheckBox();
            this.chkFotocopiacomprobantedepago = new System.Windows.Forms.CheckBox();
            this.chkFotocopiatitulopropiedadautomotor = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOtros);
            this.groupBox1.Controls.Add(this.chkFotocopiacomprobantedepago);
            this.groupBox1.Controls.Add(this.chkFotocopiatitulopropiedadautomotor);
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(D) Documentación que se acompaña";
            // 
            // chkOtros
            // 
            this.chkOtros.AutoSize = true;
            this.chkOtros.Location = new System.Drawing.Point(6, 65);
            this.chkOtros.Name = "chkOtros";
            this.chkOtros.Size = new System.Drawing.Size(51, 17);
            this.chkOtros.TabIndex = 2;
            this.chkOtros.Text = "Otros";
            this.chkOtros.UseVisualStyleBackColor = true;
            // 
            // chkFotocopiacomprobantedepago
            // 
            this.chkFotocopiacomprobantedepago.AutoSize = true;
            this.chkFotocopiacomprobantedepago.Location = new System.Drawing.Point(6, 42);
            this.chkFotocopiacomprobantedepago.Name = "chkFotocopiacomprobantedepago";
            this.chkFotocopiacomprobantedepago.Size = new System.Drawing.Size(180, 17);
            this.chkFotocopiacomprobantedepago.TabIndex = 1;
            this.chkFotocopiacomprobantedepago.Text = "Fotocopia comprobante de pago";
            this.chkFotocopiacomprobantedepago.UseVisualStyleBackColor = true;
            // 
            // chkFotocopiatitulopropiedadautomotor
            // 
            this.chkFotocopiatitulopropiedadautomotor.AutoSize = true;
            this.chkFotocopiatitulopropiedadautomotor.Location = new System.Drawing.Point(6, 19);
            this.chkFotocopiatitulopropiedadautomotor.Name = "chkFotocopiatitulopropiedadautomotor";
            this.chkFotocopiatitulopropiedadautomotor.Size = new System.Drawing.Size(215, 17);
            this.chkFotocopiatitulopropiedadautomotor.TabIndex = 0;
            this.chkFotocopiatitulopropiedadautomotor.Text = "Fotocopia titulo propiedad del automotor";
            this.chkFotocopiatitulopropiedadautomotor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtobservaciones);
            this.groupBox2.Location = new System.Drawing.Point(24, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(E) Observaciones";
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(7, 20);
            this.txtobservaciones.MaxLength = 500;
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(704, 69);
            this.txtobservaciones.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.White;
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label38.Location = new System.Drawing.Point(261, 25);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(234, 26);
            this.label38.TabIndex = 6;
            this.label38.Text = "FORMULARIO 31 DORSO";
            // 
            // Form31_Dorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label38);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form31_Dorso";
            this.Size = new System.Drawing.Size(770, 376);
            this.Load += new System.EventHandler(this.Form31_Dorso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox chkOtros;
        public System.Windows.Forms.CheckBox chkFotocopiacomprobantedepago;
        public System.Windows.Forms.CheckBox chkFotocopiatitulopropiedadautomotor;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtobservaciones;
        public System.Windows.Forms.Label label38;

    }
}
