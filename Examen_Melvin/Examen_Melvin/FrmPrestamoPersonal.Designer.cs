namespace Examen_Melvin
{
    partial class FrmPrestamoPersonal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombre_Aval_1Label;
            System.Windows.Forms.Label nombre_Aval_2Label;
            System.Windows.Forms.Label sueldo_clienteLabel;
            this.bancoDataSet = new Examen_Melvin.BancoDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new Examen_Melvin.BancoDataSetTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new Examen_Melvin.BancoDataSetTableAdapters.TableAdapterManager();
            this.nombre_Aval_1TextBox = new System.Windows.Forms.TextBox();
            this.nombre_Aval_2TextBox = new System.Windows.Forms.TextBox();
            this.sueldo_clienteTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            nombre_Aval_1Label = new System.Windows.Forms.Label();
            nombre_Aval_2Label = new System.Windows.Forms.Label();
            sueldo_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "BancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.bancoDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PrestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Examen_Melvin.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nombre_Aval_1Label
            // 
            nombre_Aval_1Label.AutoSize = true;
            nombre_Aval_1Label.Location = new System.Drawing.Point(27, 28);
            nombre_Aval_1Label.Name = "nombre_Aval_1Label";
            nombre_Aval_1Label.Size = new System.Drawing.Size(89, 13);
            nombre_Aval_1Label.TabIndex = 9;
            nombre_Aval_1Label.Text = "Nombre 1er Aval:";
            // 
            // nombre_Aval_1TextBox
            // 
            this.nombre_Aval_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "Nombre_Aval_1", true));
            this.nombre_Aval_1TextBox.Location = new System.Drawing.Point(126, 25);
            this.nombre_Aval_1TextBox.Name = "nombre_Aval_1TextBox";
            this.nombre_Aval_1TextBox.Size = new System.Drawing.Size(163, 20);
            this.nombre_Aval_1TextBox.TabIndex = 10;
            // 
            // nombre_Aval_2Label
            // 
            nombre_Aval_2Label.AutoSize = true;
            nombre_Aval_2Label.Location = new System.Drawing.Point(27, 54);
            nombre_Aval_2Label.Name = "nombre_Aval_2Label";
            nombre_Aval_2Label.Size = new System.Drawing.Size(92, 13);
            nombre_Aval_2Label.TabIndex = 11;
            nombre_Aval_2Label.Text = "Nombre 2do Aval:";
            // 
            // nombre_Aval_2TextBox
            // 
            this.nombre_Aval_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "Nombre_Aval_2", true));
            this.nombre_Aval_2TextBox.Location = new System.Drawing.Point(126, 51);
            this.nombre_Aval_2TextBox.Name = "nombre_Aval_2TextBox";
            this.nombre_Aval_2TextBox.Size = new System.Drawing.Size(163, 20);
            this.nombre_Aval_2TextBox.TabIndex = 12;
            // 
            // sueldo_clienteTextBox
            // 
            this.sueldo_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "Sueldo_cliente", true));
            this.sueldo_clienteTextBox.Location = new System.Drawing.Point(126, 77);
            this.sueldo_clienteTextBox.Name = "sueldo_clienteTextBox";
            this.sueldo_clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.sueldo_clienteTextBox.TabIndex = 14;
            // 
            // sueldo_clienteLabel
            // 
            sueldo_clienteLabel.AutoSize = true;
            sueldo_clienteLabel.Location = new System.Drawing.Point(27, 80);
            sueldo_clienteLabel.Name = "sueldo_clienteLabel";
            sueldo_clienteLabel.Size = new System.Drawing.Size(77, 13);
            sueldo_clienteLabel.TabIndex = 13;
            sueldo_clienteLabel.Text = "Sueldo cliente:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(63, 124);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(170, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPrestamoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 181);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(nombre_Aval_1Label);
            this.Controls.Add(this.nombre_Aval_1TextBox);
            this.Controls.Add(nombre_Aval_2Label);
            this.Controls.Add(this.nombre_Aval_2TextBox);
            this.Controls.Add(sueldo_clienteLabel);
            this.Controls.Add(this.sueldo_clienteTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrestamoPersonal";
            this.Text = "FrmPrestamoPersonal";
            this.Load += new System.EventHandler(this.FrmPrestamoPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private BancoDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private BancoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombre_Aval_1TextBox;
        private System.Windows.Forms.TextBox nombre_Aval_2TextBox;
        private System.Windows.Forms.TextBox sueldo_clienteTextBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}