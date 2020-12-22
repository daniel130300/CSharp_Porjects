namespace Bienes_Inmuebles
{
    partial class FrmPrincipal
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
            System.Windows.Forms.Label ubicacionLabel;
            System.Windows.Forms.Label dimensionesLabel;
            System.Windows.Forms.Label numero_de_pisosLabel;
            System.Windows.Forms.Label numero_de_habitacionesLabel;
            System.Windows.Forms.Label numero_de_bañosLabel;
            System.Windows.Forms.Label espacios_de_estacionamiemtoLabel;
            System.Windows.Forms.Label extrasLabel;
            System.Windows.Forms.Label precioLabel;
            this.bienes_Inmuebles1DataSet = new Bienes_Inmuebles.Bienes_Inmuebles1DataSet();
            this.terrenosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terrenosTableAdapter = new Bienes_Inmuebles.Bienes_Inmuebles1DataSetTableAdapters.TerrenosTableAdapter();
            this.tableAdapterManager = new Bienes_Inmuebles.Bienes_Inmuebles1DataSetTableAdapters.TableAdapterManager();
            this.txtExtras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richtxtExtras = new System.Windows.Forms.RichTextBox();
            this.ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.dimensionesTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_pisosTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_habitacionesTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_bañosTextBox = new System.Windows.Forms.TextBox();
            this.espacios_de_estacionamiemtoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ubicacionLabel = new System.Windows.Forms.Label();
            dimensionesLabel = new System.Windows.Forms.Label();
            numero_de_pisosLabel = new System.Windows.Forms.Label();
            numero_de_habitacionesLabel = new System.Windows.Forms.Label();
            numero_de_bañosLabel = new System.Windows.Forms.Label();
            espacios_de_estacionamiemtoLabel = new System.Windows.Forms.Label();
            extrasLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bienes_Inmuebles1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrenosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Location = new System.Drawing.Point(12, 46);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(58, 13);
            ubicacionLabel.TabIndex = 2;
            ubicacionLabel.Text = "Ubicacion:";
            // 
            // dimensionesLabel
            // 
            dimensionesLabel.AutoSize = true;
            dimensionesLabel.Location = new System.Drawing.Point(11, 72);
            dimensionesLabel.Name = "dimensionesLabel";
            dimensionesLabel.Size = new System.Drawing.Size(70, 13);
            dimensionesLabel.TabIndex = 4;
            dimensionesLabel.Text = "Dimensiones:";
            // 
            // numero_de_pisosLabel
            // 
            numero_de_pisosLabel.AutoSize = true;
            numero_de_pisosLabel.Location = new System.Drawing.Point(11, 98);
            numero_de_pisosLabel.Name = "numero_de_pisosLabel";
            numero_de_pisosLabel.Size = new System.Drawing.Size(89, 13);
            numero_de_pisosLabel.TabIndex = 6;
            numero_de_pisosLabel.Text = "Numero de pisos:";
            // 
            // numero_de_habitacionesLabel
            // 
            numero_de_habitacionesLabel.AutoSize = true;
            numero_de_habitacionesLabel.Location = new System.Drawing.Point(11, 124);
            numero_de_habitacionesLabel.Name = "numero_de_habitacionesLabel";
            numero_de_habitacionesLabel.Size = new System.Drawing.Size(125, 13);
            numero_de_habitacionesLabel.TabIndex = 8;
            numero_de_habitacionesLabel.Text = "Numero de habitaciones:";
            // 
            // numero_de_bañosLabel
            // 
            numero_de_bañosLabel.AutoSize = true;
            numero_de_bañosLabel.Location = new System.Drawing.Point(11, 150);
            numero_de_bañosLabel.Name = "numero_de_bañosLabel";
            numero_de_bañosLabel.Size = new System.Drawing.Size(94, 13);
            numero_de_bañosLabel.TabIndex = 10;
            numero_de_bañosLabel.Text = "Numero de baños:";
            // 
            // espacios_de_estacionamiemtoLabel
            // 
            espacios_de_estacionamiemtoLabel.AutoSize = true;
            espacios_de_estacionamiemtoLabel.Location = new System.Drawing.Point(11, 176);
            espacios_de_estacionamiemtoLabel.Name = "espacios_de_estacionamiemtoLabel";
            espacios_de_estacionamiemtoLabel.Size = new System.Drawing.Size(150, 13);
            espacios_de_estacionamiemtoLabel.TabIndex = 12;
            espacios_de_estacionamiemtoLabel.Text = "Espacios de estacionamiemto:";
            // 
            // extrasLabel
            // 
            extrasLabel.AutoSize = true;
            extrasLabel.Location = new System.Drawing.Point(12, 228);
            extrasLabel.Name = "extrasLabel";
            extrasLabel.Size = new System.Drawing.Size(39, 13);
            extrasLabel.TabIndex = 14;
            extrasLabel.Text = "Extras:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(11, 202);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 16;
            precioLabel.Text = "Precio:";
            // 
            // bienes_Inmuebles1DataSet
            // 
            this.bienes_Inmuebles1DataSet.DataSetName = "Bienes_Inmuebles1DataSet";
            this.bienes_Inmuebles1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terrenosBindingSource
            // 
            this.terrenosBindingSource.DataMember = "Terrenos";
            this.terrenosBindingSource.DataSource = this.bienes_Inmuebles1DataSet;
            // 
            // terrenosTableAdapter
            // 
            this.terrenosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TerrenosTableAdapter = this.terrenosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bienes_Inmuebles.Bienes_Inmuebles1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtExtras
            // 
            this.txtExtras.AllowUserToAddRows = false;
            this.txtExtras.AllowUserToDeleteRows = false;
            this.txtExtras.AutoGenerateColumns = false;
            this.txtExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.txtExtras.DataSource = this.terrenosBindingSource;
            this.txtExtras.Location = new System.Drawing.Point(395, 12);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.ReadOnly = true;
            this.txtExtras.Size = new System.Drawing.Size(684, 301);
            this.txtExtras.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ubicacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dimensiones";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dimensiones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numero de pisos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pisos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numero de habitaciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "Habitaciones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numero de baños";
            this.dataGridViewTextBoxColumn6.HeaderText = "Baños";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Espacios de estacionamiemto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estacionamiemtos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Extras";
            this.dataGridViewTextBoxColumn8.HeaderText = "Extras";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn9.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richtxtExtras);
            this.panel1.Controls.Add(ubicacionLabel);
            this.panel1.Controls.Add(this.ubicacionTextBox);
            this.panel1.Controls.Add(dimensionesLabel);
            this.panel1.Controls.Add(this.dimensionesTextBox);
            this.panel1.Controls.Add(numero_de_pisosLabel);
            this.panel1.Controls.Add(this.numero_de_pisosTextBox);
            this.panel1.Controls.Add(numero_de_habitacionesLabel);
            this.panel1.Controls.Add(this.numero_de_habitacionesTextBox);
            this.panel1.Controls.Add(numero_de_bañosLabel);
            this.panel1.Controls.Add(extrasLabel);
            this.panel1.Controls.Add(this.numero_de_bañosTextBox);
            this.panel1.Controls.Add(espacios_de_estacionamiemtoLabel);
            this.panel1.Controls.Add(this.espacios_de_estacionamiemtoTextBox);
            this.panel1.Controls.Add(precioLabel);
            this.panel1.Controls.Add(this.precioTextBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 330);
            this.panel1.TabIndex = 2;
            // 
            // richtxtExtras
            // 
            this.richtxtExtras.Enabled = false;
            this.richtxtExtras.Location = new System.Drawing.Point(167, 225);
            this.richtxtExtras.Name = "richtxtExtras";
            this.richtxtExtras.Size = new System.Drawing.Size(159, 91);
            this.richtxtExtras.TabIndex = 18;
            this.richtxtExtras.Text = "";
            // 
            // ubicacionTextBox
            // 
            this.ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Ubicacion", true));
            this.ubicacionTextBox.Location = new System.Drawing.Point(167, 43);
            this.ubicacionTextBox.Name = "ubicacionTextBox";
            this.ubicacionTextBox.Size = new System.Drawing.Size(159, 20);
            this.ubicacionTextBox.TabIndex = 3;
            // 
            // dimensionesTextBox
            // 
            this.dimensionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Dimensiones", true));
            this.dimensionesTextBox.Location = new System.Drawing.Point(167, 69);
            this.dimensionesTextBox.Name = "dimensionesTextBox";
            this.dimensionesTextBox.Size = new System.Drawing.Size(159, 20);
            this.dimensionesTextBox.TabIndex = 5;
            // 
            // numero_de_pisosTextBox
            // 
            this.numero_de_pisosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Numero de pisos", true));
            this.numero_de_pisosTextBox.Enabled = false;
            this.numero_de_pisosTextBox.Location = new System.Drawing.Point(167, 95);
            this.numero_de_pisosTextBox.Name = "numero_de_pisosTextBox";
            this.numero_de_pisosTextBox.Size = new System.Drawing.Size(62, 20);
            this.numero_de_pisosTextBox.TabIndex = 7;
            // 
            // numero_de_habitacionesTextBox
            // 
            this.numero_de_habitacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Numero de habitaciones", true));
            this.numero_de_habitacionesTextBox.Enabled = false;
            this.numero_de_habitacionesTextBox.Location = new System.Drawing.Point(167, 121);
            this.numero_de_habitacionesTextBox.Name = "numero_de_habitacionesTextBox";
            this.numero_de_habitacionesTextBox.Size = new System.Drawing.Size(62, 20);
            this.numero_de_habitacionesTextBox.TabIndex = 9;
            // 
            // numero_de_bañosTextBox
            // 
            this.numero_de_bañosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Numero de baños", true));
            this.numero_de_bañosTextBox.Enabled = false;
            this.numero_de_bañosTextBox.Location = new System.Drawing.Point(167, 147);
            this.numero_de_bañosTextBox.Name = "numero_de_bañosTextBox";
            this.numero_de_bañosTextBox.Size = new System.Drawing.Size(62, 20);
            this.numero_de_bañosTextBox.TabIndex = 11;
            // 
            // espacios_de_estacionamiemtoTextBox
            // 
            this.espacios_de_estacionamiemtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Espacios de estacionamiemto", true));
            this.espacios_de_estacionamiemtoTextBox.Enabled = false;
            this.espacios_de_estacionamiemtoTextBox.Location = new System.Drawing.Point(167, 173);
            this.espacios_de_estacionamiemtoTextBox.Name = "espacios_de_estacionamiemtoTextBox";
            this.espacios_de_estacionamiemtoTextBox.Size = new System.Drawing.Size(62, 20);
            this.espacios_de_estacionamiemtoTextBox.TabIndex = 13;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(167, 199);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(62, 20);
            this.precioTextBox.TabIndex = 17;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(395, 331);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(479, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(560, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(641, 331);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(722, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1004, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo: ";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Terreno",
            "Edificio",
            "Casa"});
            this.cmbTipo.Location = new System.Drawing.Point(167, 16);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 19;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 371);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtExtras);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Bienes Inmuebles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bienes_Inmuebles1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrenosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bienes_Inmuebles1DataSet bienes_Inmuebles1DataSet;
        private System.Windows.Forms.BindingSource terrenosBindingSource;
        private Bienes_Inmuebles1DataSetTableAdapters.TerrenosTableAdapter terrenosTableAdapter;
        private Bienes_Inmuebles1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView txtExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ubicacionTextBox;
        private System.Windows.Forms.TextBox dimensionesTextBox;
        private System.Windows.Forms.TextBox numero_de_pisosTextBox;
        private System.Windows.Forms.TextBox numero_de_habitacionesTextBox;
        private System.Windows.Forms.TextBox numero_de_bañosTextBox;
        private System.Windows.Forms.TextBox espacios_de_estacionamiemtoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox richtxtExtras;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
    }
}

