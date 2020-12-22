namespace BDD_Bienes_Inmuebles
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
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label ubicacionLabel;
            System.Windows.Forms.Label dimensionesLabel;
            System.Windows.Forms.Label numero_de_pisosLabel;
            System.Windows.Forms.Label numero_de_habitacionesLabel;
            System.Windows.Forms.Label numero_de_bañosLabel;
            System.Windows.Forms.Label numero_de_estacionamientosLabel;
            System.Windows.Forms.Label extrasLabel;
            System.Windows.Forms.Label precioLabel;
            this.bienesDataSet = new BDD_Bienes_Inmuebles.BienesDataSet();
            this.bienes_InmueblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bienes_InmueblesTableAdapter = new BDD_Bienes_Inmuebles.BienesDataSetTableAdapters.Bienes_InmueblesTableAdapter();
            this.tableAdapterManager = new BDD_Bienes_Inmuebles.BienesDataSetTableAdapters.TableAdapterManager();
            this.bienes_InmueblesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richtxtExtras = new System.Windows.Forms.RichTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.dimensionesTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_pisosTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_habitacionesTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_bañosTextBox = new System.Windows.Forms.TextBox();
            this.numero_de_estacionamientosTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            tipoLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            dimensionesLabel = new System.Windows.Forms.Label();
            numero_de_pisosLabel = new System.Windows.Forms.Label();
            numero_de_habitacionesLabel = new System.Windows.Forms.Label();
            numero_de_bañosLabel = new System.Windows.Forms.Label();
            numero_de_estacionamientosLabel = new System.Windows.Forms.Label();
            extrasLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bienesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienes_InmueblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienes_InmueblesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(24, 20);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 2;
            tipoLabel.Text = "Tipo:";
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Location = new System.Drawing.Point(24, 46);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(58, 13);
            ubicacionLabel.TabIndex = 4;
            ubicacionLabel.Text = "Ubicacion:";
            // 
            // dimensionesLabel
            // 
            dimensionesLabel.AutoSize = true;
            dimensionesLabel.Location = new System.Drawing.Point(24, 72);
            dimensionesLabel.Name = "dimensionesLabel";
            dimensionesLabel.Size = new System.Drawing.Size(70, 13);
            dimensionesLabel.TabIndex = 6;
            dimensionesLabel.Text = "Dimensiones:";
            // 
            // numero_de_pisosLabel
            // 
            numero_de_pisosLabel.AutoSize = true;
            numero_de_pisosLabel.Location = new System.Drawing.Point(24, 98);
            numero_de_pisosLabel.Name = "numero_de_pisosLabel";
            numero_de_pisosLabel.Size = new System.Drawing.Size(89, 13);
            numero_de_pisosLabel.TabIndex = 8;
            numero_de_pisosLabel.Text = "Numero de pisos:";
            // 
            // numero_de_habitacionesLabel
            // 
            numero_de_habitacionesLabel.AutoSize = true;
            numero_de_habitacionesLabel.Location = new System.Drawing.Point(24, 124);
            numero_de_habitacionesLabel.Name = "numero_de_habitacionesLabel";
            numero_de_habitacionesLabel.Size = new System.Drawing.Size(125, 13);
            numero_de_habitacionesLabel.TabIndex = 10;
            numero_de_habitacionesLabel.Text = "Numero de habitaciones:";
            // 
            // numero_de_bañosLabel
            // 
            numero_de_bañosLabel.AutoSize = true;
            numero_de_bañosLabel.Location = new System.Drawing.Point(24, 150);
            numero_de_bañosLabel.Name = "numero_de_bañosLabel";
            numero_de_bañosLabel.Size = new System.Drawing.Size(94, 13);
            numero_de_bañosLabel.TabIndex = 12;
            numero_de_bañosLabel.Text = "Numero de baños:";
            // 
            // numero_de_estacionamientosLabel
            // 
            numero_de_estacionamientosLabel.AutoSize = true;
            numero_de_estacionamientosLabel.Location = new System.Drawing.Point(24, 176);
            numero_de_estacionamientosLabel.Name = "numero_de_estacionamientosLabel";
            numero_de_estacionamientosLabel.Size = new System.Drawing.Size(147, 13);
            numero_de_estacionamientosLabel.TabIndex = 14;
            numero_de_estacionamientosLabel.Text = "Numero de estacionamientos:";
            // 
            // extrasLabel
            // 
            extrasLabel.AutoSize = true;
            extrasLabel.Location = new System.Drawing.Point(25, 228);
            extrasLabel.Name = "extrasLabel";
            extrasLabel.Size = new System.Drawing.Size(39, 13);
            extrasLabel.TabIndex = 16;
            extrasLabel.Text = "Extras:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(25, 202);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 18;
            precioLabel.Text = "Precio:";
            // 
            // bienesDataSet
            // 
            this.bienesDataSet.DataSetName = "BienesDataSet";
            this.bienesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bienes_InmueblesBindingSource
            // 
            this.bienes_InmueblesBindingSource.DataMember = "Bienes Inmuebles";
            this.bienes_InmueblesBindingSource.DataSource = this.bienesDataSet;
            // 
            // bienes_InmueblesTableAdapter
            // 
            this.bienes_InmueblesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Bienes_InmueblesTableAdapter = this.bienes_InmueblesTableAdapter;
            this.tableAdapterManager.UpdateOrder = BDD_Bienes_Inmuebles.BienesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bienes_InmueblesDataGridView
            // 
            this.bienes_InmueblesDataGridView.AllowUserToAddRows = false;
            this.bienes_InmueblesDataGridView.AllowUserToDeleteRows = false;
            this.bienes_InmueblesDataGridView.AutoGenerateColumns = false;
            this.bienes_InmueblesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bienes_InmueblesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.bienes_InmueblesDataGridView.DataSource = this.bienes_InmueblesBindingSource;
            this.bienes_InmueblesDataGridView.Location = new System.Drawing.Point(377, 12);
            this.bienes_InmueblesDataGridView.Name = "bienes_InmueblesDataGridView";
            this.bienes_InmueblesDataGridView.ReadOnly = true;
            this.bienes_InmueblesDataGridView.Size = new System.Drawing.Size(683, 350);
            this.bienes_InmueblesDataGridView.TabIndex = 1;
            this.bienes_InmueblesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bienes_InmueblesDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ubicacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dimensiones";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dimensiones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numero de pisos";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pisos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numero de habitaciones";
            this.dataGridViewTextBoxColumn6.HeaderText = "Habitaciones";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Numero de baños";
            this.dataGridViewTextBoxColumn7.HeaderText = "Baños";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Numero de estacionamientos";
            this.dataGridViewTextBoxColumn8.HeaderText = "Estacionamientos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Extras";
            this.dataGridViewTextBoxColumn9.HeaderText = "Extras";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn10.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richtxtExtras);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(tipoLabel);
            this.panel1.Controls.Add(ubicacionLabel);
            this.panel1.Controls.Add(this.ubicacionTextBox);
            this.panel1.Controls.Add(dimensionesLabel);
            this.panel1.Controls.Add(this.dimensionesTextBox);
            this.panel1.Controls.Add(numero_de_pisosLabel);
            this.panel1.Controls.Add(this.numero_de_pisosTextBox);
            this.panel1.Controls.Add(numero_de_habitacionesLabel);
            this.panel1.Controls.Add(this.numero_de_habitacionesTextBox);
            this.panel1.Controls.Add(numero_de_bañosLabel);
            this.panel1.Controls.Add(this.numero_de_bañosTextBox);
            this.panel1.Controls.Add(numero_de_estacionamientosLabel);
            this.panel1.Controls.Add(this.numero_de_estacionamientosTextBox);
            this.panel1.Controls.Add(extrasLabel);
            this.panel1.Controls.Add(precioLabel);
            this.panel1.Controls.Add(this.precioTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 350);
            this.panel1.TabIndex = 2;
            // 
            // richtxtExtras
            // 
            this.richtxtExtras.Enabled = false;
            this.richtxtExtras.Location = new System.Drawing.Point(176, 225);
            this.richtxtExtras.Name = "richtxtExtras";
            this.richtxtExtras.Size = new System.Drawing.Size(170, 96);
            this.richtxtExtras.TabIndex = 21;
            this.richtxtExtras.Text = "";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Terreno",
            "Edificio",
            "Casa"});
            this.cmbTipo.Location = new System.Drawing.Point(177, 17);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 20;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ubicacionTextBox
            // 
            this.ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Ubicacion", true));
            this.ubicacionTextBox.Location = new System.Drawing.Point(177, 43);
            this.ubicacionTextBox.Name = "ubicacionTextBox";
            this.ubicacionTextBox.Size = new System.Drawing.Size(169, 20);
            this.ubicacionTextBox.TabIndex = 5;
            // 
            // dimensionesTextBox
            // 
            this.dimensionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Dimensiones", true));
            this.dimensionesTextBox.Location = new System.Drawing.Point(177, 69);
            this.dimensionesTextBox.Name = "dimensionesTextBox";
            this.dimensionesTextBox.Size = new System.Drawing.Size(169, 20);
            this.dimensionesTextBox.TabIndex = 7;
            // 
            // numero_de_pisosTextBox
            // 
            this.numero_de_pisosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Numero de pisos", true));
            this.numero_de_pisosTextBox.Enabled = false;
            this.numero_de_pisosTextBox.Location = new System.Drawing.Point(177, 95);
            this.numero_de_pisosTextBox.Name = "numero_de_pisosTextBox";
            this.numero_de_pisosTextBox.Size = new System.Drawing.Size(57, 20);
            this.numero_de_pisosTextBox.TabIndex = 9;
            // 
            // numero_de_habitacionesTextBox
            // 
            this.numero_de_habitacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Numero de habitaciones", true));
            this.numero_de_habitacionesTextBox.Enabled = false;
            this.numero_de_habitacionesTextBox.Location = new System.Drawing.Point(177, 121);
            this.numero_de_habitacionesTextBox.Name = "numero_de_habitacionesTextBox";
            this.numero_de_habitacionesTextBox.Size = new System.Drawing.Size(57, 20);
            this.numero_de_habitacionesTextBox.TabIndex = 11;
            // 
            // numero_de_bañosTextBox
            // 
            this.numero_de_bañosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Numero de baños", true));
            this.numero_de_bañosTextBox.Enabled = false;
            this.numero_de_bañosTextBox.Location = new System.Drawing.Point(177, 147);
            this.numero_de_bañosTextBox.Name = "numero_de_bañosTextBox";
            this.numero_de_bañosTextBox.Size = new System.Drawing.Size(57, 20);
            this.numero_de_bañosTextBox.TabIndex = 13;
            // 
            // numero_de_estacionamientosTextBox
            // 
            this.numero_de_estacionamientosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Numero de estacionamientos", true));
            this.numero_de_estacionamientosTextBox.Enabled = false;
            this.numero_de_estacionamientosTextBox.Location = new System.Drawing.Point(177, 173);
            this.numero_de_estacionamientosTextBox.Name = "numero_de_estacionamientosTextBox";
            this.numero_de_estacionamientosTextBox.Size = new System.Drawing.Size(57, 20);
            this.numero_de_estacionamientosTextBox.TabIndex = 15;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(176, 199);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(58, 20);
            this.precioTextBox.TabIndex = 19;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bienes_InmueblesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(177, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(377, 383);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(458, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(539, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(620, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(701, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(985, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 432);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bienes_InmueblesDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bienesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienes_InmueblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienes_InmueblesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BienesDataSet bienesDataSet;
        private System.Windows.Forms.BindingSource bienes_InmueblesBindingSource;
        private BienesDataSetTableAdapters.Bienes_InmueblesTableAdapter bienes_InmueblesTableAdapter;
        private BienesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bienes_InmueblesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richtxtExtras;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox ubicacionTextBox;
        private System.Windows.Forms.TextBox dimensionesTextBox;
        private System.Windows.Forms.TextBox numero_de_pisosTextBox;
        private System.Windows.Forms.TextBox numero_de_habitacionesTextBox;
        private System.Windows.Forms.TextBox numero_de_bañosTextBox;
        private System.Windows.Forms.TextBox numero_de_estacionamientosTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

