namespace Examen_Melvin
{
    partial class FrmPrestamoHipotecario
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
            System.Windows.Forms.Label numero_catastralLabel;
            System.Windows.Forms.Label ubicacionLabel;
            System.Windows.Forms.Label valor_bienLabel;
            this.bancoDataSet = new Examen_Melvin.BancoDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new Examen_Melvin.BancoDataSetTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new Examen_Melvin.BancoDataSetTableAdapters.TableAdapterManager();
            this.numero_catastralTextBox = new System.Windows.Forms.TextBox();
            this.valor_bienTextBox = new System.Windows.Forms.TextBox();
            this.rchtxtUbicacion = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            numero_catastralLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            valor_bienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_catastralLabel
            // 
            numero_catastralLabel.AutoSize = true;
            numero_catastralLabel.Location = new System.Drawing.Point(23, 26);
            numero_catastralLabel.Name = "numero_catastralLabel";
            numero_catastralLabel.Size = new System.Drawing.Size(90, 13);
            numero_catastralLabel.TabIndex = 15;
            numero_catastralLabel.Text = "Numero catastral:";
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Location = new System.Drawing.Point(23, 52);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(58, 13);
            ubicacionLabel.TabIndex = 17;
            ubicacionLabel.Text = "Ubicacion:";
            // 
            // valor_bienLabel
            // 
            valor_bienLabel.AutoSize = true;
            valor_bienLabel.Location = new System.Drawing.Point(24, 161);
            valor_bienLabel.Name = "valor_bienLabel";
            valor_bienLabel.Size = new System.Drawing.Size(57, 13);
            valor_bienLabel.TabIndex = 19;
            valor_bienLabel.Text = "Valor bien:";
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
            // numero_catastralTextBox
            // 
            this.numero_catastralTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "Numero_catastral", true));
            this.numero_catastralTextBox.Location = new System.Drawing.Point(122, 23);
            this.numero_catastralTextBox.Name = "numero_catastralTextBox";
            this.numero_catastralTextBox.Size = new System.Drawing.Size(100, 20);
            this.numero_catastralTextBox.TabIndex = 16;
            // 
            // valor_bienTextBox
            // 
            this.valor_bienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "Valor_bien", true));
            this.valor_bienTextBox.Location = new System.Drawing.Point(123, 158);
            this.valor_bienTextBox.Name = "valor_bienTextBox";
            this.valor_bienTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_bienTextBox.TabIndex = 20;
            // 
            // rchtxtUbicacion
            // 
            this.rchtxtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchtxtUbicacion.Location = new System.Drawing.Point(122, 52);
            this.rchtxtUbicacion.Name = "rchtxtUbicacion";
            this.rchtxtUbicacion.Size = new System.Drawing.Size(242, 96);
            this.rchtxtUbicacion.TabIndex = 21;
            this.rchtxtUbicacion.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(217, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(110, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmPrestamoHipotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 252);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rchtxtUbicacion);
            this.Controls.Add(numero_catastralLabel);
            this.Controls.Add(this.numero_catastralTextBox);
            this.Controls.Add(ubicacionLabel);
            this.Controls.Add(valor_bienLabel);
            this.Controls.Add(this.valor_bienTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrestamoHipotecario";
            this.Text = "FrmPrestamoHipotecario";
            this.Load += new System.EventHandler(this.FrmPrestamoHipotecario_Load);
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
        private System.Windows.Forms.TextBox numero_catastralTextBox;
        private System.Windows.Forms.TextBox valor_bienTextBox;
        private System.Windows.Forms.RichTextBox rchtxtUbicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}