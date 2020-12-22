namespace Pizzeria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbMediana = new System.Windows.Forms.RadioButton();
            this.rdbPequeña = new System.Windows.Forms.RadioButton();
            this.cmbMasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkQueso = new System.Windows.Forms.CheckBox();
            this.chkTocino = new System.Windows.Forms.CheckBox();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkHongos = new System.Windows.Forms.CheckBox();
            this.chkAnchoas = new System.Windows.Forms.CheckBox();
            this.lstPizza = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGrande);
            this.groupBox1.Controls.Add(this.rdbMediana);
            this.groupBox1.Controls.Add(this.rdbPequeña);
            this.groupBox1.Location = new System.Drawing.Point(30, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño";
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(6, 76);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(60, 17);
            this.rdbGrande.TabIndex = 2;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            this.rdbGrande.CheckedChanged += new System.EventHandler(this.rdbGrande_CheckedChanged);
            // 
            // rdbMediana
            // 
            this.rdbMediana.AutoSize = true;
            this.rdbMediana.Location = new System.Drawing.Point(6, 53);
            this.rdbMediana.Name = "rdbMediana";
            this.rdbMediana.Size = new System.Drawing.Size(66, 17);
            this.rdbMediana.TabIndex = 1;
            this.rdbMediana.Text = "Mediana";
            this.rdbMediana.UseVisualStyleBackColor = true;
            this.rdbMediana.CheckedChanged += new System.EventHandler(this.rdbMediana_CheckedChanged);
            // 
            // rdbPequeña
            // 
            this.rdbPequeña.AutoSize = true;
            this.rdbPequeña.Location = new System.Drawing.Point(6, 30);
            this.rdbPequeña.Name = "rdbPequeña";
            this.rdbPequeña.Size = new System.Drawing.Size(68, 17);
            this.rdbPequeña.TabIndex = 0;
            this.rdbPequeña.Text = "Pequeña";
            this.rdbPequeña.UseVisualStyleBackColor = true;
            this.rdbPequeña.CheckedChanged += new System.EventHandler(this.rdbPequeña_CheckedChanged);
            // 
            // cmbMasa
            // 
            this.cmbMasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasa.FormattingEnabled = true;
            this.cmbMasa.Items.AddRange(new object[] {
            "Delgada",
            "Pan Pizza"});
            this.cmbMasa.Location = new System.Drawing.Point(109, 175);
            this.cmbMasa.Name = "cmbMasa";
            this.cmbMasa.Size = new System.Drawing.Size(121, 21);
            this.cmbMasa.TabIndex = 1;
            this.cmbMasa.SelectedIndexChanged += new System.EventHandler(this.cmbMasa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Masa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkQueso);
            this.groupBox2.Controls.Add(this.chkTocino);
            this.groupBox2.Controls.Add(this.chkJamon);
            this.groupBox2.Controls.Add(this.chkPepperoni);
            this.groupBox2.Controls.Add(this.chkHongos);
            this.groupBox2.Controls.Add(this.chkAnchoas);
            this.groupBox2.Location = new System.Drawing.Point(30, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // chkQueso
            // 
            this.chkQueso.AutoSize = true;
            this.chkQueso.Location = new System.Drawing.Point(110, 81);
            this.chkQueso.Name = "chkQueso";
            this.chkQueso.Size = new System.Drawing.Size(84, 17);
            this.chkQueso.TabIndex = 5;
            this.chkQueso.Text = "Extra Queso";
            this.chkQueso.UseVisualStyleBackColor = true;
            this.chkQueso.CheckedChanged += new System.EventHandler(this.chkQueso_CheckedChanged);
            // 
            // chkTocino
            // 
            this.chkTocino.AutoSize = true;
            this.chkTocino.Location = new System.Drawing.Point(110, 58);
            this.chkTocino.Name = "chkTocino";
            this.chkTocino.Size = new System.Drawing.Size(59, 17);
            this.chkTocino.TabIndex = 4;
            this.chkTocino.Text = "Tocino";
            this.chkTocino.UseVisualStyleBackColor = true;
            this.chkTocino.CheckedChanged += new System.EventHandler(this.chkTocino_CheckedChanged);
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(110, 35);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(57, 17);
            this.chkJamon.TabIndex = 3;
            this.chkJamon.Text = "Jamón";
            this.chkJamon.UseVisualStyleBackColor = true;
            this.chkJamon.CheckedChanged += new System.EventHandler(this.chkJamon_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 81);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // chkHongos
            // 
            this.chkHongos.AutoSize = true;
            this.chkHongos.Location = new System.Drawing.Point(6, 58);
            this.chkHongos.Name = "chkHongos";
            this.chkHongos.Size = new System.Drawing.Size(63, 17);
            this.chkHongos.TabIndex = 1;
            this.chkHongos.Text = "Hongos";
            this.chkHongos.UseVisualStyleBackColor = true;
            this.chkHongos.CheckedChanged += new System.EventHandler(this.chkHongos_CheckedChanged);
            // 
            // chkAnchoas
            // 
            this.chkAnchoas.AutoSize = true;
            this.chkAnchoas.Location = new System.Drawing.Point(6, 35);
            this.chkAnchoas.Name = "chkAnchoas";
            this.chkAnchoas.Size = new System.Drawing.Size(68, 17);
            this.chkAnchoas.TabIndex = 0;
            this.chkAnchoas.Text = "Anchoas";
            this.chkAnchoas.UseVisualStyleBackColor = true;
            this.chkAnchoas.CheckedChanged += new System.EventHandler(this.chkAnchoas_CheckedChanged);
            // 
            // lstPizza
            // 
            this.lstPizza.FormattingEnabled = true;
            this.lstPizza.Location = new System.Drawing.Point(259, 31);
            this.lstPizza.Name = "lstPizza";
            this.lstPizza.Size = new System.Drawing.Size(187, 199);
            this.lstPizza.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(337, 312);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(84, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtISV
            // 
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(337, 286);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(84, 20);
            this.txtISV.TabIndex = 6;
            // 
            // txtSub
            // 
            this.txtSub.Enabled = false;
            this.txtSub.Location = new System.Drawing.Point(337, 260);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(84, 20);
            this.txtSub.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subtotal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ISV: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(36, 363);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 33);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(140, 363);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(79, 33);
            this.btnVenta.TabIndex = 12;
            this.btnVenta.Text = "Nueva Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 414);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lstPizza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMasa);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizzeria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbMediana;
        private System.Windows.Forms.RadioButton rdbPequeña;
        private System.Windows.Forms.ComboBox cmbMasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkQueso;
        private System.Windows.Forms.CheckBox chkTocino;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkHongos;
        private System.Windows.Forms.CheckBox chkAnchoas;
        private System.Windows.Forms.ListBox lstPizza;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVenta;
    }
}

