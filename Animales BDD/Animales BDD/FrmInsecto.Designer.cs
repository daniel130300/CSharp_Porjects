namespace Animales_BDD
{
    partial class FrmInsecto
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
            System.Windows.Forms.Label vuelaLabel;
            this.vuelaCheckBox = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            vuelaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vuelaCheckBox
            // 
            this.vuelaCheckBox.Location = new System.Drawing.Point(83, 39);
            this.vuelaCheckBox.Name = "vuelaCheckBox";
            this.vuelaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.vuelaCheckBox.TabIndex = 22;
            this.vuelaCheckBox.Text = "Si";
            this.vuelaCheckBox.UseVisualStyleBackColor = true;
            this.vuelaCheckBox.CheckedChanged += new System.EventHandler(this.vuelaCheckBox_CheckedChanged);
            // 
            // vuelaLabel
            // 
            vuelaLabel.AutoSize = true;
            vuelaLabel.Location = new System.Drawing.Point(40, 44);
            vuelaLabel.Name = "vuelaLabel";
            vuelaLabel.Size = new System.Drawing.Size(37, 13);
            vuelaLabel.TabIndex = 21;
            vuelaLabel.Text = "Vuela:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(12, 104);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(93, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmInsecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 152);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.vuelaCheckBox);
            this.Controls.Add(vuelaLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInsecto";
            this.Text = "Insecto";
            this.Load += new System.EventHandler(this.FrmInsecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox vuelaCheckBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}