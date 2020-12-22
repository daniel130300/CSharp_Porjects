namespace Animales_BDD
{
    partial class FrmAve
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
            System.Windows.Forms.Label altura_VueloLabel;
            System.Windows.Forms.Label color_PlumajeLabel;
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.altura_VueloTextBox = new System.Windows.Forms.TextBox();
            this.color_PlumajeTextBox = new System.Windows.Forms.TextBox();
            altura_VueloLabel = new System.Windows.Forms.Label();
            color_PlumajeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(146, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(65, 142);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // altura_VueloTextBox
            // 
            this.altura_VueloTextBox.Location = new System.Drawing.Point(130, 75);
            this.altura_VueloTextBox.Name = "altura_VueloTextBox";
            this.altura_VueloTextBox.Size = new System.Drawing.Size(104, 20);
            this.altura_VueloTextBox.TabIndex = 30;
            // 
            // altura_VueloLabel
            // 
            altura_VueloLabel.AutoSize = true;
            altura_VueloLabel.Location = new System.Drawing.Point(50, 78);
            altura_VueloLabel.Name = "altura_VueloLabel";
            altura_VueloLabel.Size = new System.Drawing.Size(67, 13);
            altura_VueloLabel.TabIndex = 29;
            altura_VueloLabel.Text = "Altura Vuelo:";
            // 
            // color_PlumajeTextBox
            // 
            this.color_PlumajeTextBox.Location = new System.Drawing.Point(130, 49);
            this.color_PlumajeTextBox.Name = "color_PlumajeTextBox";
            this.color_PlumajeTextBox.Size = new System.Drawing.Size(104, 20);
            this.color_PlumajeTextBox.TabIndex = 28;
            // 
            // color_PlumajeLabel
            // 
            color_PlumajeLabel.AutoSize = true;
            color_PlumajeLabel.Location = new System.Drawing.Point(50, 52);
            color_PlumajeLabel.Name = "color_PlumajeLabel";
            color_PlumajeLabel.Size = new System.Drawing.Size(74, 13);
            color_PlumajeLabel.TabIndex = 27;
            color_PlumajeLabel.Text = "Color Plumaje:";
            // 
            // FrmAve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.altura_VueloTextBox);
            this.Controls.Add(altura_VueloLabel);
            this.Controls.Add(this.color_PlumajeTextBox);
            this.Controls.Add(color_PlumajeLabel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAve";
            this.Text = "Ave";
            this.Load += new System.EventHandler(this.FrmAve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox altura_VueloTextBox;
        private System.Windows.Forms.TextBox color_PlumajeTextBox;
    }
}