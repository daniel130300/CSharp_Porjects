namespace Sucursales
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbNinguno = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbMulti = new System.Windows.Forms.RadioButton();
            this.rdbCity = new System.Windows.Forms.RadioButton();
            this.rdbCentro = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkPHP = new System.Windows.Forms.CheckBox();
            this.chkVisual = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkVisual);
            this.groupBox1.Controls.Add(this.chkJava);
            this.groupBox1.Controls.Add(this.chkPHP);
            this.groupBox1.Controls.Add(this.chkC);
            this.groupBox1.Location = new System.Drawing.Point(144, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbEmpleado);
            this.groupBox2.Controls.Add(this.rdbCliente);
            this.groupBox2.Controls.Add(this.rdbNinguno);
            this.groupBox2.Location = new System.Drawing.Point(47, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descuentos";
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.Location = new System.Drawing.Point(6, 74);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rdbEmpleado.TabIndex = 6;
            this.rdbEmpleado.TabStop = true;
            this.rdbEmpleado.Text = "Empleado";
            this.rdbEmpleado.UseVisualStyleBackColor = true;
            this.rdbEmpleado.CheckedChanged += new System.EventHandler(this.rdbEmpleado_CheckedChanged);
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(6, 51);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(108, 17);
            this.rdbCliente.TabIndex = 5;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente Frecuente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.CheckedChanged += new System.EventHandler(this.rdbCliente_CheckedChanged);
            // 
            // rdbNinguno
            // 
            this.rdbNinguno.AutoSize = true;
            this.rdbNinguno.Location = new System.Drawing.Point(6, 28);
            this.rdbNinguno.Name = "rdbNinguno";
            this.rdbNinguno.Size = new System.Drawing.Size(65, 17);
            this.rdbNinguno.TabIndex = 4;
            this.rdbNinguno.TabStop = true;
            this.rdbNinguno.Text = "Ninguno";
            this.rdbNinguno.UseVisualStyleBackColor = true;
            this.rdbNinguno.CheckedChanged += new System.EventHandler(this.rdbNinguno_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbMulti);
            this.groupBox3.Controls.Add(this.rdbCity);
            this.groupBox3.Controls.Add(this.rdbCentro);
            this.groupBox3.Location = new System.Drawing.Point(241, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 106);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sucursales";
            // 
            // rdbMulti
            // 
            this.rdbMulti.AutoSize = true;
            this.rdbMulti.Location = new System.Drawing.Point(6, 74);
            this.rdbMulti.Name = "rdbMulti";
            this.rdbMulti.Size = new System.Drawing.Size(72, 17);
            this.rdbMulti.TabIndex = 2;
            this.rdbMulti.TabStop = true;
            this.rdbMulti.Text = "Multiplaza";
            this.rdbMulti.UseVisualStyleBackColor = true;
            this.rdbMulti.CheckedChanged += new System.EventHandler(this.rdbMulti_CheckedChanged);
            // 
            // rdbCity
            // 
            this.rdbCity.AutoSize = true;
            this.rdbCity.Location = new System.Drawing.Point(6, 51);
            this.rdbCity.Name = "rdbCity";
            this.rdbCity.Size = new System.Drawing.Size(64, 17);
            this.rdbCity.TabIndex = 1;
            this.rdbCity.TabStop = true;
            this.rdbCity.Text = "City Mall";
            this.rdbCity.UseVisualStyleBackColor = true;
            this.rdbCity.CheckedChanged += new System.EventHandler(this.rdbCity_CheckedChanged);
            // 
            // rdbCentro
            // 
            this.rdbCentro.AutoSize = true;
            this.rdbCentro.Location = new System.Drawing.Point(6, 28);
            this.rdbCentro.Name = "rdbCentro";
            this.rdbCentro.Size = new System.Drawing.Size(56, 17);
            this.rdbCentro.TabIndex = 0;
            this.rdbCentro.TabStop = true;
            this.rdbCentro.Text = "Centro";
            this.rdbCentro.UseVisualStyleBackColor = true;
            this.rdbCentro.CheckedChanged += new System.EventHandler(this.rdbCentro_CheckedChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(83, 327);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(78, 29);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(83, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 29);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(302, 392);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtISV
            // 
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(302, 366);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(85, 20);
            this.txtISV.TabIndex = 11;
            this.txtISV.TextChanged += new System.EventHandler(this.txtISV_TextChanged);
            // 
            // txtSub
            // 
            this.txtSub.Enabled = false;
            this.txtSub.Location = new System.Drawing.Point(302, 314);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(85, 20);
            this.txtSub.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ISV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(302, 340);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(85, 20);
            this.txtDescuento.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Descuento: ";
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(6, 27);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(49, 17);
            this.chkJava.TabIndex = 4;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            this.chkJava.CheckedChanged += new System.EventHandler(this.chkJava_CheckedChanged);
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(6, 50);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(40, 17);
            this.chkC.TabIndex = 5;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            this.chkC.CheckedChanged += new System.EventHandler(this.chkC_CheckedChanged);
            // 
            // chkPHP
            // 
            this.chkPHP.AutoSize = true;
            this.chkPHP.Location = new System.Drawing.Point(78, 27);
            this.chkPHP.Name = "chkPHP";
            this.chkPHP.Size = new System.Drawing.Size(48, 17);
            this.chkPHP.TabIndex = 18;
            this.chkPHP.Text = "PHP";
            this.chkPHP.UseVisualStyleBackColor = true;
            this.chkPHP.CheckedChanged += new System.EventHandler(this.chkPHP_CheckedChanged);
            // 
            // chkVisual
            // 
            this.chkVisual.AutoSize = true;
            this.chkVisual.Location = new System.Drawing.Point(78, 50);
            this.chkVisual.Name = "chkVisual";
            this.chkVisual.Size = new System.Drawing.Size(83, 17);
            this.chkVisual.TabIndex = 19;
            this.chkVisual.Text = "Visual Basic";
            this.chkVisual.UseVisualStyleBackColor = true;
            this.chkVisual.CheckedChanged += new System.EventHandler(this.chkVisual_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cursos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbEmpleado;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbNinguno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbMulti;
        private System.Windows.Forms.RadioButton rdbCity;
        private System.Windows.Forms.RadioButton rdbCentro;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkPHP;
        private System.Windows.Forms.CheckBox chkVisual;
    }
}

