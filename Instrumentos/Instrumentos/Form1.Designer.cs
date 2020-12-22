namespace Instrumentos
{
    partial class FrmInventario
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label tipo_de_instrumentoLabel;
            System.Windows.Forms.Label estilo_de_instrumentoLabel;
            System.Windows.Forms.Label marca_InstrumentoLabel;
            System.Windows.Forms.Label fecha_de_CompraLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label observacionLabel;
            this.inventarioDataSet = new Instrumentos.InventarioDataSet();
            this.instrumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentosTableAdapter = new Instrumentos.InventarioDataSetTableAdapters.InstrumentosTableAdapter();
            this.tableAdapterManager = new Instrumentos.InventarioDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richtxtObservacion = new System.Windows.Forms.RichTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.estilo_de_instrumentoTextBox = new System.Windows.Forms.TextBox();
            this.marca_InstrumentoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_CompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.instrumentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoLabel = new System.Windows.Forms.Label();
            tipo_de_instrumentoLabel = new System.Windows.Forms.Label();
            estilo_de_instrumentoLabel = new System.Windows.Forms.Label();
            marca_InstrumentoLabel = new System.Windows.Forms.Label();
            fecha_de_CompraLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(21, 18);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // tipo_de_instrumentoLabel
            // 
            tipo_de_instrumentoLabel.AutoSize = true;
            tipo_de_instrumentoLabel.Location = new System.Drawing.Point(21, 44);
            tipo_de_instrumentoLabel.Name = "tipo_de_instrumentoLabel";
            tipo_de_instrumentoLabel.Size = new System.Drawing.Size(103, 13);
            tipo_de_instrumentoLabel.TabIndex = 4;
            tipo_de_instrumentoLabel.Text = "Tipo de instrumento:";
            // 
            // estilo_de_instrumentoLabel
            // 
            estilo_de_instrumentoLabel.AutoSize = true;
            estilo_de_instrumentoLabel.Location = new System.Drawing.Point(21, 70);
            estilo_de_instrumentoLabel.Name = "estilo_de_instrumentoLabel";
            estilo_de_instrumentoLabel.Size = new System.Drawing.Size(107, 13);
            estilo_de_instrumentoLabel.TabIndex = 6;
            estilo_de_instrumentoLabel.Text = "Estilo de instrumento:";
            // 
            // marca_InstrumentoLabel
            // 
            marca_InstrumentoLabel.AutoSize = true;
            marca_InstrumentoLabel.Location = new System.Drawing.Point(21, 96);
            marca_InstrumentoLabel.Name = "marca_InstrumentoLabel";
            marca_InstrumentoLabel.Size = new System.Drawing.Size(98, 13);
            marca_InstrumentoLabel.TabIndex = 10;
            marca_InstrumentoLabel.Text = "Marca Instrumento:";
            // 
            // fecha_de_CompraLabel
            // 
            fecha_de_CompraLabel.AutoSize = true;
            fecha_de_CompraLabel.Location = new System.Drawing.Point(21, 123);
            fecha_de_CompraLabel.Name = "fecha_de_CompraLabel";
            fecha_de_CompraLabel.Size = new System.Drawing.Size(94, 13);
            fecha_de_CompraLabel.TabIndex = 12;
            fecha_de_CompraLabel.Text = "Fecha de Compra:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(21, 148);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 14;
            estadoLabel.Text = "Estado:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(21, 174);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(70, 13);
            observacionLabel.TabIndex = 16;
            observacionLabel.Text = "Observacion:";
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "InventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentosBindingSource
            // 
            this.instrumentosBindingSource.DataMember = "Instrumentos";
            this.instrumentosBindingSource.DataSource = this.inventarioDataSet;
            // 
            // instrumentosTableAdapter
            // 
            this.instrumentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InstrumentosTableAdapter = this.instrumentosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Instrumentos.InventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richtxtObservacion);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(codigoLabel);
            this.panel1.Controls.Add(this.codigoTextBox);
            this.panel1.Controls.Add(tipo_de_instrumentoLabel);
            this.panel1.Controls.Add(estilo_de_instrumentoLabel);
            this.panel1.Controls.Add(this.estilo_de_instrumentoTextBox);
            this.panel1.Controls.Add(marca_InstrumentoLabel);
            this.panel1.Controls.Add(this.marca_InstrumentoTextBox);
            this.panel1.Controls.Add(fecha_de_CompraLabel);
            this.panel1.Controls.Add(this.fecha_de_CompraDateTimePicker);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(observacionLabel);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 275);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richtxtObservacion
            // 
            this.richtxtObservacion.Location = new System.Drawing.Point(134, 172);
            this.richtxtObservacion.Name = "richtxtObservacion";
            this.richtxtObservacion.Size = new System.Drawing.Size(200, 91);
            this.richtxtObservacion.TabIndex = 21;
            this.richtxtObservacion.Text = "";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Bueno",
            "Malo"});
            this.cmbEstado.Location = new System.Drawing.Point(134, 145);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 20;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Viento",
            "Percusion",
            "Cuerda"});
            this.cmbTipo.Location = new System.Drawing.Point(134, 40);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 18;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentosBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(134, 15);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(121, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // estilo_de_instrumentoTextBox
            // 
            this.estilo_de_instrumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentosBindingSource, "Estilo de instrumento", true));
            this.estilo_de_instrumentoTextBox.Location = new System.Drawing.Point(134, 67);
            this.estilo_de_instrumentoTextBox.Name = "estilo_de_instrumentoTextBox";
            this.estilo_de_instrumentoTextBox.Size = new System.Drawing.Size(121, 20);
            this.estilo_de_instrumentoTextBox.TabIndex = 7;
            // 
            // marca_InstrumentoTextBox
            // 
            this.marca_InstrumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentosBindingSource, "Marca Instrumento", true));
            this.marca_InstrumentoTextBox.Location = new System.Drawing.Point(134, 93);
            this.marca_InstrumentoTextBox.Name = "marca_InstrumentoTextBox";
            this.marca_InstrumentoTextBox.Size = new System.Drawing.Size(121, 20);
            this.marca_InstrumentoTextBox.TabIndex = 11;
            // 
            // fecha_de_CompraDateTimePicker
            // 
            this.fecha_de_CompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.instrumentosBindingSource, "Fecha de Compra", true));
            this.fecha_de_CompraDateTimePicker.Location = new System.Drawing.Point(134, 119);
            this.fecha_de_CompraDateTimePicker.Name = "fecha_de_CompraDateTimePicker";
            this.fecha_de_CompraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_CompraDateTimePicker.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(398, 276);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(479, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(560, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(641, 276);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(722, 276);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1026, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // instrumentosDataGridView
            // 
            this.instrumentosDataGridView.AllowUserToAddRows = false;
            this.instrumentosDataGridView.AllowUserToDeleteRows = false;
            this.instrumentosDataGridView.AutoGenerateColumns = false;
            this.instrumentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.instrumentosDataGridView.DataSource = this.instrumentosBindingSource;
            this.instrumentosDataGridView.Location = new System.Drawing.Point(398, 12);
            this.instrumentosDataGridView.Name = "instrumentosDataGridView";
            this.instrumentosDataGridView.ReadOnly = true;
            this.instrumentosDataGridView.Size = new System.Drawing.Size(703, 246);
            this.instrumentosDataGridView.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo de instrumento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo de instrumento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estilo de instrumento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estilo de instrumento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Marca Instrumento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marca Instrumento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha de Compra";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de Compra";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Observacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 311);
            this.Controls.Add(this.instrumentosDataGridView);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInventario";
            this.Text = "Inventario Instrumentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventarioDataSet inventarioDataSet;
        private System.Windows.Forms.BindingSource instrumentosBindingSource;
        private InventarioDataSetTableAdapters.InstrumentosTableAdapter instrumentosTableAdapter;
        private InventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox estilo_de_instrumentoTextBox;
        private System.Windows.Forms.TextBox marca_InstrumentoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_CompraDateTimePicker;
        private System.Windows.Forms.DataGridView instrumentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.RichTextBox richtxtObservacion;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}

