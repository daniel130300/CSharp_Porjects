namespace WindowsFormsApplication2
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
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdbExento = new System.Windows.Forms.RadioButton();
            this.chkTercera = new System.Windows.Forms.CheckBox();
            this.chkConsumo = new System.Windows.Forms.CheckBox();
            this.chkEmpleado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(85, 30);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(30, 196);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 37);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISV:  ";
            // 
            // txtIsv
            // 
            this.txtIsv.Location = new System.Drawing.Point(251, 189);
            this.txtIsv.Name = "txtIsv";
            this.txtIsv.Size = new System.Drawing.Size(100, 20);
            this.txtIsv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(251, 217);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExento);
            this.groupBox1.Controls.Add(this.rdb15);
            this.groupBox1.Location = new System.Drawing.Point(30, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impuesto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEmpleado);
            this.groupBox2.Controls.Add(this.chkConsumo);
            this.groupBox2.Controls.Add(this.chkTercera);
            this.groupBox2.Location = new System.Drawing.Point(207, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descuento";
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Location = new System.Drawing.Point(13, 29);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(45, 17);
            this.rdb15.TabIndex = 0;
            this.rdb15.TabStop = true;
            this.rdb15.Text = "15%";
            this.rdb15.UseVisualStyleBackColor = true;
            this.rdb15.CheckedChanged += new System.EventHandler(this.rdb15_CheckedChanged);
            // 
            // rdbExento
            // 
            this.rdbExento.AutoSize = true;
            this.rdbExento.Location = new System.Drawing.Point(13, 52);
            this.rdbExento.Name = "rdbExento";
            this.rdbExento.Size = new System.Drawing.Size(58, 17);
            this.rdbExento.TabIndex = 1;
            this.rdbExento.TabStop = true;
            this.rdbExento.Text = "Exento";
            this.rdbExento.UseVisualStyleBackColor = true;
            // 
            // chkTercera
            // 
            this.chkTercera.AutoSize = true;
            this.chkTercera.Location = new System.Drawing.Point(8, 29);
            this.chkTercera.Name = "chkTercera";
            this.chkTercera.Size = new System.Drawing.Size(91, 17);
            this.chkTercera.TabIndex = 0;
            this.chkTercera.Text = "Tercera Edad";
            this.chkTercera.UseVisualStyleBackColor = true;
            this.chkTercera.CheckedChanged += new System.EventHandler(this.chkTercera_CheckedChanged);
            // 
            // chkConsumo
            // 
            this.chkConsumo.AutoSize = true;
            this.chkConsumo.Location = new System.Drawing.Point(8, 51);
            this.chkConsumo.Name = "chkConsumo";
            this.chkConsumo.Size = new System.Drawing.Size(70, 17);
            this.chkConsumo.TabIndex = 1;
            this.chkConsumo.Text = "Consumo";
            this.chkConsumo.UseVisualStyleBackColor = true;
            this.chkConsumo.CheckedChanged += new System.EventHandler(this.chkConsumo_CheckedChanged);
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.Location = new System.Drawing.Point(8, 74);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Size = new System.Drawing.Size(73, 17);
            this.chkEmpleado.TabIndex = 2;
            this.chkEmpleado.Text = "Empleado";
            this.chkEmpleado.UseVisualStyleBackColor = true;
            this.chkEmpleado.CheckedChanged += new System.EventHandler(this.chkEmpleado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbExento;
        private System.Windows.Forms.RadioButton rdb15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkConsumo;
        private System.Windows.Forms.CheckBox chkTercera;
        private System.Windows.Forms.CheckBox chkEmpleado;
    }
}

