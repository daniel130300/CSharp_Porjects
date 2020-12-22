namespace Figuras_Geometricas
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
            this.rdbCirculo = new System.Windows.Forms.RadioButton();
            this.rdbRectangulo = new System.Windows.Forms.RadioButton();
            this.rdbTriangulo = new System.Windows.Forms.RadioButton();
            this.btnArea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Figura: ";
            // 
            // rdbCirculo
            // 
            this.rdbCirculo.AutoSize = true;
            this.rdbCirculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCirculo.Location = new System.Drawing.Point(191, 92);
            this.rdbCirculo.Name = "rdbCirculo";
            this.rdbCirculo.Size = new System.Drawing.Size(64, 19);
            this.rdbCirculo.TabIndex = 1;
            this.rdbCirculo.Text = "Circulo";
            this.rdbCirculo.UseVisualStyleBackColor = true;
            this.rdbCirculo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbRectangulo
            // 
            this.rdbRectangulo.AutoSize = true;
            this.rdbRectangulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectangulo.Location = new System.Drawing.Point(191, 118);
            this.rdbRectangulo.Name = "rdbRectangulo";
            this.rdbRectangulo.Size = new System.Drawing.Size(88, 19);
            this.rdbRectangulo.TabIndex = 2;
            this.rdbRectangulo.Text = "Rectangulo";
            this.rdbRectangulo.UseVisualStyleBackColor = true;
            this.rdbRectangulo.CheckedChanged += new System.EventHandler(this.rdbRectangulo_CheckedChanged);
            // 
            // rdbTriangulo
            // 
            this.rdbTriangulo.AutoSize = true;
            this.rdbTriangulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriangulo.Location = new System.Drawing.Point(191, 143);
            this.rdbTriangulo.Name = "rdbTriangulo";
            this.rdbTriangulo.Size = new System.Drawing.Size(77, 19);
            this.rdbTriangulo.TabIndex = 3;
            this.rdbTriangulo.Text = "Triangulo";
            this.rdbTriangulo.UseVisualStyleBackColor = true;
            this.rdbTriangulo.CheckedChanged += new System.EventHandler(this.rdbTriangulo_CheckedChanged);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(136, 203);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Calcular";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Instrucciones: Seleccione el tipo de figura para la cual desea calcular su area,\r" +
    "\nllene los datos que se le piden, finalmente presione el boton calcular.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.rdbTriangulo);
            this.Controls.Add(this.rdbRectangulo);
            this.Controls.Add(this.rdbCirculo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Figuras Geometricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCirculo;
        private System.Windows.Forms.RadioButton rdbRectangulo;
        private System.Windows.Forms.RadioButton rdbTriangulo;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

