namespace Ejercicio_2
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
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnArgegar = new System.Windows.Forms.Button();
            this.txtAprobados = new System.Windows.Forms.TextBox();
            this.txtGlobal = new System.Windows.Forms.TextBox();
            this.txtReprobados = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(72, 98);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(53, 20);
            this.txtNota2.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(72, 62);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(53, 20);
            this.txtNota1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota 1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota 3: ";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(72, 132);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(53, 20);
            this.txtNota3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Promedio: ";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(72, 168);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(53, 20);
            this.txtPromedio.TabIndex = 4;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(370, 22);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(387, 186);
            this.lstAlumnos.TabIndex = 11;
            // 
            // btnArgegar
            // 
            this.btnArgegar.Location = new System.Drawing.Point(259, 53);
            this.btnArgegar.Name = "btnArgegar";
            this.btnArgegar.Size = new System.Drawing.Size(75, 44);
            this.btnArgegar.TabIndex = 12;
            this.btnArgegar.Text = "Agregar Alumno";
            this.btnArgegar.UseVisualStyleBackColor = true;
            this.btnArgegar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAprobados
            // 
            this.txtAprobados.Enabled = false;
            this.txtAprobados.Location = new System.Drawing.Point(435, 225);
            this.txtAprobados.Name = "txtAprobados";
            this.txtAprobados.Size = new System.Drawing.Size(37, 20);
            this.txtAprobados.TabIndex = 15;
            this.txtAprobados.Text = "0";
            this.txtAprobados.TextChanged += new System.EventHandler(this.txtAprobados_TextChanged);
            // 
            // txtGlobal
            // 
            this.txtGlobal.Enabled = false;
            this.txtGlobal.Location = new System.Drawing.Point(724, 225);
            this.txtGlobal.Name = "txtGlobal";
            this.txtGlobal.Size = new System.Drawing.Size(37, 20);
            this.txtGlobal.TabIndex = 16;
            this.txtGlobal.Text = "0.00";
            // 
            // txtReprobados
            // 
            this.txtReprobados.Enabled = false;
            this.txtReprobados.Location = new System.Drawing.Point(570, 225);
            this.txtReprobados.Name = "txtReprobados";
            this.txtReprobados.Size = new System.Drawing.Size(37, 20);
            this.txtReprobados.TabIndex = 17;
            this.txtReprobados.Text = "0";
            this.txtReprobados.TextChanged += new System.EventHandler(this.txtReprobados_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Aprobados: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Reprobados: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Promedio Global: ";
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(259, 138);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 44);
            this.btnVaciar.TabIndex = 22;
            this.btnVaciar.Text = "Vaciar Listado";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 266);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReprobados);
            this.Controls.Add(this.txtGlobal);
            this.Controls.Add(this.txtAprobados);
            this.Controls.Add(this.btnArgegar);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNota2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Button btnArgegar;
        private System.Windows.Forms.TextBox txtAprobados;
        private System.Windows.Forms.TextBox txtGlobal;
        private System.Windows.Forms.TextBox txtReprobados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVaciar;
    }
}

