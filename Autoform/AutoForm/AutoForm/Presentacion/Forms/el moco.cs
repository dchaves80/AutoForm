using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion.Forms
{
    public class F_31:ParentForm
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTransferencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDominioAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNacionalImportado;
        private System.Windows.Forms.TextBox txtNFormulario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaUltimoTramite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaVigencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ErrorProvider epControlCampos;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button btnConfirmardatos;
        private System.Windows.Forms.Label label1;
    
        public F_31(string p_FormName) 
        {

            InitializeComponent();
            NAME = p_FormName;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTransferencia = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVigencia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNFormulario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaUltimoTramite = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNacionalImportado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDominioAnterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.epControlCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConfirmardatos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).BeginInit();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTransferencia);
            this.groupBox1.Location = new System.Drawing.Point(4, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(A) Tipo de tramite";
            // 
            // chkTransferencia
            // 
            this.chkTransferencia.AutoSize = true;
            this.chkTransferencia.Checked = true;
            this.chkTransferencia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTransferencia.Location = new System.Drawing.Point(6, 30);
            this.chkTransferencia.Name = "chkTransferencia";
            this.chkTransferencia.Size = new System.Drawing.Size(91, 17);
            this.chkTransferencia.TabIndex = 0;
            this.chkTransferencia.Text = "Transferencia";
            this.chkTransferencia.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpFechaVigencia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNFormulario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpFechaUltimoTramite);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbNacionalImportado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDominioAnterior);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDominio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(B) Datos del automotor";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(626, 183);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(168, 20);
            this.textBox13.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(556, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Combustible";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(302, 183);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(213, 20);
            this.textBox12.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(176, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Código de marca - modelo";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(100, 183);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(71, 20);
            this.textBox11.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Peso/Cilindrada";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(675, 149);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(96, 20);
            this.textBox10.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(619, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Categoria";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(675, 126);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(96, 20);
            this.textBox9.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(630, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Rubro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(672, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Reservado Rentas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Número";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(199, 149);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(228, 20);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(199, 126);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(228, 20);
            this.textBox8.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Marca";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 149);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 20);
            this.textBox6.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Chasis";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 20);
            this.textBox5.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Motor";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(698, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 20);
            this.textBox4.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Modelo/Año";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(438, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Marca y Modelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(698, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reservado Rentas";
            // 
            // dtpFechaVigencia
            // 
            this.dtpFechaVigencia.CustomFormat = "";
            this.dtpFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVigencia.Location = new System.Drawing.Point(491, 52);
            this.dtpFechaVigencia.Name = "dtpFechaVigencia";
            this.dtpFechaVigencia.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaVigencia.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Vigencia";
            // 
            // txtNFormulario
            // 
            this.txtNFormulario.Location = new System.Drawing.Point(302, 52);
            this.txtNFormulario.Name = "txtNFormulario";
            this.txtNFormulario.Size = new System.Drawing.Size(96, 20);
            this.txtNFormulario.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "N° Formulario";
            // 
            // dtpFechaUltimoTramite
            // 
            this.dtpFechaUltimoTramite.CustomFormat = "";
            this.dtpFechaUltimoTramite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaUltimoTramite.Location = new System.Drawing.Point(124, 52);
            this.dtpFechaUltimoTramite.Name = "dtpFechaUltimoTramite";
            this.dtpFechaUltimoTramite.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaUltimoTramite.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Ultimo Tramite";
            // 
            // cmbNacionalImportado
            // 
            this.cmbNacionalImportado.FormattingEnabled = true;
            this.cmbNacionalImportado.Items.AddRange(new object[] {
            "NACIONAL",
            "IMPORTADO"});
            this.cmbNacionalImportado.Location = new System.Drawing.Point(548, 24);
            this.cmbNacionalImportado.Name = "cmbNacionalImportado";
            this.cmbNacionalImportado.Size = new System.Drawing.Size(121, 21);
            this.cmbNacionalImportado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nacional Importado";
            // 
            // txtDominioAnterior
            // 
            this.txtDominioAnterior.Location = new System.Drawing.Point(254, 22);
            this.txtDominioAnterior.Name = "txtDominioAnterior";
            this.txtDominioAnterior.Size = new System.Drawing.Size(173, 20);
            this.txtDominioAnterior.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dominio Anterior";
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(62, 21);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(96, 20);
            this.txtDominio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dominio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox24);
            this.groupBox3.Controls.Add(this.textBox25);
            this.groupBox3.Controls.Add(this.textBox26);
            this.groupBox3.Controls.Add(this.textBox27);
            this.groupBox3.Controls.Add(this.textBox28);
            this.groupBox3.Controls.Add(this.textBox29);
            this.groupBox3.Controls.Add(this.textBox30);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.textBox23);
            this.groupBox3.Controls.Add(this.textBox22);
            this.groupBox3.Controls.Add(this.textBox21);
            this.groupBox3.Controls.Add(this.textBox20);
            this.groupBox3.Controls.Add(this.textBox19);
            this.groupBox3.Controls.Add(this.textBox18);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(4, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(808, 313);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(C) Datos del titular";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(629, 272);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(119, 20);
            this.textBox24.TabIndex = 47;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(489, 272);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(69, 20);
            this.textBox25.TabIndex = 46;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(129, 272);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(232, 20);
            this.textBox26.TabIndex = 45;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(703, 235);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(45, 20);
            this.textBox27.TabIndex = 44;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(573, 235);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(53, 20);
            this.textBox28.TabIndex = 43;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(461, 235);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(42, 20);
            this.textBox29.TabIndex = 42;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(68, 235);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(340, 20);
            this.textBox30.TabIndex = 41;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(575, 279);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 40;
            this.label30.Text = "Provincia";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(397, 279);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 39;
            this.label31.Text = "Codigo Postal";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(23, 279);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 13);
            this.label32.TabIndex = 38;
            this.label32.Text = "Barrio - Localidad";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(648, 238);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 13);
            this.label34.TabIndex = 37;
            this.label34.Text = "Depto.";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(520, 238);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 13);
            this.label36.TabIndex = 36;
            this.label36.Text = "Piso";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(422, 238);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 35;
            this.label39.Text = "Nro.";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(23, 238);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(30, 13);
            this.label40.TabIndex = 34;
            this.label40.Text = "Calle";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(629, 164);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(119, 20);
            this.textBox23.TabIndex = 33;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(483, 164);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(69, 20);
            this.textBox22.TabIndex = 32;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(123, 164);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(232, 20);
            this.textBox21.TabIndex = 31;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(703, 127);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(45, 20);
            this.textBox20.TabIndex = 30;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(567, 127);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(53, 20);
            this.textBox19.TabIndex = 29;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(455, 127);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(42, 20);
            this.textBox18.TabIndex = 28;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(62, 127);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(340, 20);
            this.textBox17.TabIndex = 27;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(606, 63);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(142, 20);
            this.textBox16.TabIndex = 26;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(449, 65);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(50, 17);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.Text = "PAS.";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(405, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 17);
            this.checkBox4.TabIndex = 24;
            this.checkBox4.Text = "C.I.";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(361, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(45, 17);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "L.C.";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(310, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "L.E.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(254, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "D.N.I.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(123, 62);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(119, 20);
            this.textBox15.TabIndex = 20;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(199, 26);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(549, 20);
            this.textBox14.TabIndex = 19;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(505, 66);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 13);
            this.label37.TabIndex = 16;
            this.label37.Text = "CUIT o CUIL NRO";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(17, 200);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(107, 13);
            this.label35.TabIndex = 14;
            this.label35.Text = "DOMICILIO POSTAL";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(569, 171);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Provincia";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(391, 171);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 13);
            this.label29.TabIndex = 8;
            this.label29.Text = "Codigo Postal";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 171);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 13);
            this.label28.TabIndex = 7;
            this.label28.Text = "Barrio - Localidad";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(642, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "Depto.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(514, 130);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Piso";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(416, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Nro.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Calle";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Nro. de Documento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "DOMICILIO FISCAL";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Apellido Y Nombre o Razon Social";
            // 
            // btnConfirmardatos
            // 
            this.btnConfirmardatos.Location = new System.Drawing.Point(269, 660);
            this.btnConfirmardatos.Name = "btnConfirmardatos";
            this.btnConfirmardatos.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmardatos.TabIndex = 5;
            this.btnConfirmardatos.Text = "Confirmar datos";
            this.btnConfirmardatos.UseVisualStyleBackColor = true;
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControlCampos)).EndInit();

       }

        private void F_31_Load(object sender, EventArgs e)
        {
         

        }
        
          private bool ControlErrores()
            {
                bool Retorno = true;
                if (txtDominio.Text == "")
                {
                    epControlCampos.SetError(txtDominio, "Debe ingresar un Dominio");
                    Retorno = false;
                }
            else
                {
                    epControlCampos.Clear();
                }
            return Retorno;
            }


    }
}


        
            
        




        
   
     
    

