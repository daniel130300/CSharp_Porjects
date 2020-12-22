namespace Cajero
{
    partial class Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRetiro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSaldo = new System.Windows.Forms.RadioButton();
            this.rdbPagos = new System.Windows.Forms.RadioButton();
            this.rdbRetiro = new System.Windows.Forms.RadioButton();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.lstTransacciones = new System.Windows.Forms.ListBox();
            this.txtTransacciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDep_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRet_cantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbRapido = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkTelefonía = new System.Windows.Forms.CheckBox();
            this.chkAgua = new System.Windows.Forms.CheckBox();
            this.chkElectricidad = new System.Windows.Forms.CheckBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.grpbxSaldo = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpbxSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRetiro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbSaldo);
            this.groupBox1.Controls.Add(this.rdbPagos);
            this.groupBox1.Controls.Add(this.rdbRetiro);
            this.groupBox1.Controls.Add(this.rdbDeposito);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Transacción";
            // 
            // cmbRetiro
            // 
            this.cmbRetiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetiro.Enabled = false;
            this.cmbRetiro.FormattingEnabled = true;
            this.cmbRetiro.Items.AddRange(new object[] {
            "Rápido",
            "Normal"});
            this.cmbRetiro.Location = new System.Drawing.Point(95, 83);
            this.cmbRetiro.Name = "cmbRetiro";
            this.cmbRetiro.Size = new System.Drawing.Size(121, 21);
            this.cmbRetiro.TabIndex = 3;
            this.cmbRetiro.SelectedIndexChanged += new System.EventHandler(this.cmbRetiro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Retiro: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbSaldo
            // 
            this.rdbSaldo.AutoSize = true;
            this.rdbSaldo.Location = new System.Drawing.Point(10, 142);
            this.rdbSaldo.Name = "rdbSaldo";
            this.rdbSaldo.Size = new System.Drawing.Size(111, 17);
            this.rdbSaldo.TabIndex = 4;
            this.rdbSaldo.TabStop = true;
            this.rdbSaldo.Text = "Consulta de Saldo";
            this.rdbSaldo.UseVisualStyleBackColor = true;
            this.rdbSaldo.CheckedChanged += new System.EventHandler(this.rdbSaldo_CheckedChanged);
            // 
            // rdbPagos
            // 
            this.rdbPagos.AutoSize = true;
            this.rdbPagos.Location = new System.Drawing.Point(10, 116);
            this.rdbPagos.Name = "rdbPagos";
            this.rdbPagos.Size = new System.Drawing.Size(159, 17);
            this.rdbPagos.TabIndex = 3;
            this.rdbPagos.TabStop = true;
            this.rdbPagos.Text = "Pagos de Servicios Públicos";
            this.rdbPagos.UseVisualStyleBackColor = true;
            this.rdbPagos.CheckedChanged += new System.EventHandler(this.rdbPagos_CheckedChanged);
            // 
            // rdbRetiro
            // 
            this.rdbRetiro.AutoSize = true;
            this.rdbRetiro.Location = new System.Drawing.Point(10, 53);
            this.rdbRetiro.Name = "rdbRetiro";
            this.rdbRetiro.Size = new System.Drawing.Size(53, 17);
            this.rdbRetiro.TabIndex = 2;
            this.rdbRetiro.TabStop = true;
            this.rdbRetiro.Text = "Retiro";
            this.rdbRetiro.UseVisualStyleBackColor = true;
            this.rdbRetiro.CheckedChanged += new System.EventHandler(this.rdbRetiro_CheckedChanged);
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(10, 30);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(67, 17);
            this.rdbDeposito.TabIndex = 1;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Depósito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            this.rdbDeposito.CheckedChanged += new System.EventHandler(this.rdbDeposito_CheckedChanged);
            // 
            // lstTransacciones
            // 
            this.lstTransacciones.FormattingEnabled = true;
            this.lstTransacciones.Location = new System.Drawing.Point(296, 250);
            this.lstTransacciones.Name = "lstTransacciones";
            this.lstTransacciones.Size = new System.Drawing.Size(247, 238);
            this.lstTransacciones.TabIndex = 1;
            this.lstTransacciones.SelectedIndexChanged += new System.EventHandler(this.lstTransacciones_SelectedIndexChanged);
            // 
            // txtTransacciones
            // 
            this.txtTransacciones.Enabled = false;
            this.txtTransacciones.Location = new System.Drawing.Point(437, 507);
            this.txtTransacciones.Name = "txtTransacciones";
            this.txtTransacciones.Size = new System.Drawing.Size(33, 20);
            this.txtTransacciones.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Transacciones: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCuenta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDep_cantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depósito";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Location = new System.Drawing.Point(107, 36);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(134, 20);
            this.txtCuenta.TabIndex = 8;
            this.txtCuenta.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de Cuenta: ";
            // 
            // txtDep_cantidad
            // 
            this.txtDep_cantidad.Enabled = false;
            this.txtDep_cantidad.Location = new System.Drawing.Point(67, 73);
            this.txtDep_cantidad.Name = "txtDep_cantidad";
            this.txtDep_cantidad.Size = new System.Drawing.Size(79, 20);
            this.txtDep_cantidad.TabIndex = 6;
            this.txtDep_cantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRet_cantidad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 89);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retiro Normal";
            // 
            // txtRet_cantidad
            // 
            this.txtRet_cantidad.Enabled = false;
            this.txtRet_cantidad.Location = new System.Drawing.Point(67, 37);
            this.txtRet_cantidad.Name = "txtRet_cantidad";
            this.txtRet_cantidad.Size = new System.Drawing.Size(79, 20);
            this.txtRet_cantidad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbRapido);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 89);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Retiro Rápido";
            // 
            // cmbRapido
            // 
            this.cmbRapido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRapido.Enabled = false;
            this.cmbRapido.FormattingEnabled = true;
            this.cmbRapido.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cmbRapido.Location = new System.Drawing.Point(67, 37);
            this.cmbRapido.Name = "cmbRapido";
            this.cmbRapido.Size = new System.Drawing.Size(79, 21);
            this.cmbRapido.TabIndex = 6;
            this.cmbRapido.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkTelefonía);
            this.groupBox5.Controls.Add(this.chkAgua);
            this.groupBox5.Controls.Add(this.chkElectricidad);
            this.groupBox5.Location = new System.Drawing.Point(296, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 111);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pago de Servicios Públicos";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // chkTelefonía
            // 
            this.chkTelefonía.AutoSize = true;
            this.chkTelefonía.Enabled = false;
            this.chkTelefonía.Location = new System.Drawing.Point(6, 73);
            this.chkTelefonía.Name = "chkTelefonía";
            this.chkTelefonía.Size = new System.Drawing.Size(128, 17);
            this.chkTelefonía.TabIndex = 2;
            this.chkTelefonía.Text = "Servicio de Telefonía";
            this.chkTelefonía.UseVisualStyleBackColor = true;
            this.chkTelefonía.CheckedChanged += new System.EventHandler(this.chkTelefonía_CheckedChanged);
            // 
            // chkAgua
            // 
            this.chkAgua.AutoSize = true;
            this.chkAgua.Enabled = false;
            this.chkAgua.Location = new System.Drawing.Point(6, 50);
            this.chkAgua.Name = "chkAgua";
            this.chkAgua.Size = new System.Drawing.Size(146, 17);
            this.chkAgua.TabIndex = 1;
            this.chkAgua.Text = "Servicio de Agua Potable";
            this.chkAgua.UseVisualStyleBackColor = true;
            this.chkAgua.CheckedChanged += new System.EventHandler(this.chkAgua_CheckedChanged);
            // 
            // chkElectricidad
            // 
            this.chkElectricidad.AutoSize = true;
            this.chkElectricidad.Enabled = false;
            this.chkElectricidad.Location = new System.Drawing.Point(6, 27);
            this.chkElectricidad.Name = "chkElectricidad";
            this.chkElectricidad.Size = new System.Drawing.Size(137, 17);
            this.chkElectricidad.TabIndex = 0;
            this.chkElectricidad.Text = "Servicio de Electricidad";
            this.chkElectricidad.UseVisualStyleBackColor = true;
            this.chkElectricidad.CheckedChanged += new System.EventHandler(this.chkElectricidad_CheckedChanged);
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(251, 589);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(97, 53);
            this.btnRealizar.TabIndex = 12;
            this.btnRealizar.Text = "Realizar Transacción";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // grpbxSaldo
            // 
            this.grpbxSaldo.Controls.Add(this.txtSaldo);
            this.grpbxSaldo.Controls.Add(this.label7);
            this.grpbxSaldo.Location = new System.Drawing.Point(296, 140);
            this.grpbxSaldo.Name = "grpbxSaldo";
            this.grpbxSaldo.Size = new System.Drawing.Size(247, 89);
            this.grpbxSaldo.TabIndex = 10;
            this.grpbxSaldo.TabStop = false;
            this.grpbxSaldo.Text = "Saldo Actual";
            this.grpbxSaldo.Visible = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(67, 37);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(79, 20);
            this.txtSaldo.TabIndex = 6;
            this.txtSaldo.Text = "1000";
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cantidad: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 654);
            this.Controls.Add(this.grpbxSaldo);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTransacciones);
            this.Controls.Add(this.lstTransacciones);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpbxSaldo.ResumeLayout(false);
            this.grpbxSaldo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSaldo;
        private System.Windows.Forms.RadioButton rdbPagos;
        private System.Windows.Forms.RadioButton rdbRetiro;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.ListBox lstTransacciones;
        private System.Windows.Forms.ComboBox cmbRetiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransacciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDep_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRet_cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbRapido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkTelefonía;
        private System.Windows.Forms.CheckBox chkAgua;
        private System.Windows.Forms.CheckBox chkElectricidad;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.GroupBox grpbxSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label7;
    }
}

