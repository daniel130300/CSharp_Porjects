namespace Barcos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmarre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEslora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbVelero = new System.Windows.Forms.RadioButton();
            this.rdbDeportivo = new System.Windows.Forms.RadioButton();
            this.rdbYate = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMastiles = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCamarotes = new System.Windows.Forms.TextBox();
            this.lstEmbarcaciones = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(73, 31);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(209, 20);
            this.txtIdentidad.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias: ";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(73, 106);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(39, 20);
            this.txtDias.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amarre: ";
            // 
            // txtAmarre
            // 
            this.txtAmarre.Location = new System.Drawing.Point(73, 139);
            this.txtAmarre.Name = "txtAmarre";
            this.txtAmarre.Size = new System.Drawing.Size(39, 20);
            this.txtAmarre.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtAmarre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.txtIdentidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Alquiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCamarotes);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPotencia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMastiles);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtAnio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEslora);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 385);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Embarcación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Matricula: ";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(73, 35);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(209, 20);
            this.txtMatricula.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eslora (Mts): ";
            // 
            // txtEslora
            // 
            this.txtEslora.Location = new System.Drawing.Point(89, 69);
            this.txtEslora.Name = "txtEslora";
            this.txtEslora.Size = new System.Drawing.Size(39, 20);
            this.txtEslora.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Año de Fabricación: ";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(122, 102);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(57, 20);
            this.txtAnio.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbYate);
            this.groupBox3.Controls.Add(this.rdbDeportivo);
            this.groupBox3.Controls.Add(this.rdbVelero);
            this.groupBox3.Location = new System.Drawing.Point(14, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 107);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Barco";
            // 
            // rdbVelero
            // 
            this.rdbVelero.AutoSize = true;
            this.rdbVelero.Location = new System.Drawing.Point(6, 28);
            this.rdbVelero.Name = "rdbVelero";
            this.rdbVelero.Size = new System.Drawing.Size(55, 17);
            this.rdbVelero.TabIndex = 0;
            this.rdbVelero.TabStop = true;
            this.rdbVelero.Text = "Velero";
            this.rdbVelero.UseVisualStyleBackColor = true;
            this.rdbVelero.CheckedChanged += new System.EventHandler(this.rdbVelero_CheckedChanged);
            // 
            // rdbDeportivo
            // 
            this.rdbDeportivo.AutoSize = true;
            this.rdbDeportivo.Location = new System.Drawing.Point(6, 51);
            this.rdbDeportivo.Name = "rdbDeportivo";
            this.rdbDeportivo.Size = new System.Drawing.Size(71, 17);
            this.rdbDeportivo.TabIndex = 1;
            this.rdbDeportivo.TabStop = true;
            this.rdbDeportivo.Text = "Deportivo";
            this.rdbDeportivo.UseVisualStyleBackColor = true;
            this.rdbDeportivo.CheckedChanged += new System.EventHandler(this.rdbDeportivo_CheckedChanged);
            // 
            // rdbYate
            // 
            this.rdbYate.AutoSize = true;
            this.rdbYate.Location = new System.Drawing.Point(6, 74);
            this.rdbYate.Name = "rdbYate";
            this.rdbYate.Size = new System.Drawing.Size(47, 17);
            this.rdbYate.TabIndex = 2;
            this.rdbYate.TabStop = true;
            this.rdbYate.Text = "Yate";
            this.rdbYate.UseVisualStyleBackColor = true;
            this.rdbYate.CheckedChanged += new System.EventHandler(this.rdbYate_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número de Mastiles: ";
            // 
            // txtMastiles
            // 
            this.txtMastiles.Enabled = false;
            this.txtMastiles.Location = new System.Drawing.Point(134, 265);
            this.txtMastiles.Name = "txtMastiles";
            this.txtMastiles.Size = new System.Drawing.Size(39, 20);
            this.txtMastiles.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Potencia (CV): ";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Enabled = false;
            this.txtPotencia.Location = new System.Drawing.Point(134, 297);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(39, 20);
            this.txtPotencia.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Número de Camarotes: ";
            // 
            // txtCamarotes
            // 
            this.txtCamarotes.Enabled = false;
            this.txtCamarotes.Location = new System.Drawing.Point(134, 330);
            this.txtCamarotes.Name = "txtCamarotes";
            this.txtCamarotes.Size = new System.Drawing.Size(39, 20);
            this.txtCamarotes.TabIndex = 19;
            // 
            // lstEmbarcaciones
            // 
            this.lstEmbarcaciones.FormattingEnabled = true;
            this.lstEmbarcaciones.Location = new System.Drawing.Point(335, 12);
            this.lstEmbarcaciones.Name = "lstEmbarcaciones";
            this.lstEmbarcaciones.Size = new System.Drawing.Size(432, 433);
            this.lstEmbarcaciones.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(385, 463);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 49);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Registro";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(507, 463);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 49);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(626, 463);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(90, 49);
            this.btnVaciar.TabIndex = 14;
            this.btnVaciar.Text = "Vaciar Registro";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 612);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstEmbarcaciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Alquiler de Embarcaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmarre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCamarotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMastiles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbYate;
        private System.Windows.Forms.RadioButton rdbDeportivo;
        private System.Windows.Forms.RadioButton rdbVelero;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEslora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstEmbarcaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
    }
}

