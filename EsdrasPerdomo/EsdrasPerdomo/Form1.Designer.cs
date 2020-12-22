namespace EsdrasPerdomo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_rentaLabel;
            System.Windows.Forms.Label placaLabel;
            System.Windows.Forms.Label tipo_vehiculoLabel;
            System.Windows.Forms.Label cantidad_kilometros_inicialesLabel;
            System.Windows.Forms.Label cantidad_kilometros_finalesLabel;
            System.Windows.Forms.Label precio_diaLabel;
            System.Windows.Forms.Label dias_rentaLabel;
            System.Windows.Forms.Label estadoLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDRentas1DataSet = new EsdrasPerdomo.BDDRentas1DataSet();
            this.rentasTableAdapter = new EsdrasPerdomo.BDDRentas1DataSetTableAdapters.RentasTableAdapter();
            this.tableAdapterManager = new EsdrasPerdomo.BDDRentas1DataSetTableAdapters.TableAdapterManager();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.bntModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rentasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rentaTextBox = new System.Windows.Forms.TextBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_kilometros_inicialesTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_kilometros_finalesTextBox = new System.Windows.Forms.TextBox();
            this.precio_diaTextBox = new System.Windows.Forms.TextBox();
            this.dias_rentaTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            id_rentaLabel = new System.Windows.Forms.Label();
            placaLabel = new System.Windows.Forms.Label();
            tipo_vehiculoLabel = new System.Windows.Forms.Label();
            cantidad_kilometros_inicialesLabel = new System.Windows.Forms.Label();
            cantidad_kilometros_finalesLabel = new System.Windows.Forms.Label();
            precio_diaLabel = new System.Windows.Forms.Label();
            dias_rentaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDRentas1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(id_rentaLabel);
            this.panel1.Controls.Add(this.id_rentaTextBox);
            this.panel1.Controls.Add(placaLabel);
            this.panel1.Controls.Add(this.placaTextBox);
            this.panel1.Controls.Add(tipo_vehiculoLabel);
            this.panel1.Controls.Add(cantidad_kilometros_inicialesLabel);
            this.panel1.Controls.Add(this.cantidad_kilometros_inicialesTextBox);
            this.panel1.Controls.Add(cantidad_kilometros_finalesLabel);
            this.panel1.Controls.Add(this.cantidad_kilometros_finalesTextBox);
            this.panel1.Controls.Add(precio_diaLabel);
            this.panel1.Controls.Add(this.precio_diaTextBox);
            this.panel1.Controls.Add(dias_rentaLabel);
            this.panel1.Controls.Add(this.dias_rentaTextBox);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(this.estadoCheckBox);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 244);
            this.panel1.TabIndex = 2;
            // 
            // rentasBindingSource
            // 
            this.rentasBindingSource.DataMember = "Rentas";
            this.rentasBindingSource.DataSource = this.bDDRentas1DataSet;
            // 
            // bDDRentas1DataSet
            // 
            this.bDDRentas1DataSet.DataSetName = "BDDRentas1DataSet";
            this.bDDRentas1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentasTableAdapter
            // 
            this.rentasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RentasTableAdapter = this.rentasTableAdapter;
            this.tableAdapterManager.UpdateOrder = EsdrasPerdomo.BDDRentas1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(336, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(428, 411);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bntModificar
            // 
            this.bntModificar.Location = new System.Drawing.Point(520, 411);
            this.bntModificar.Name = "bntModificar";
            this.bntModificar.Size = new System.Drawing.Size(75, 23);
            this.bntModificar.TabIndex = 5;
            this.bntModificar.Text = "Modificar";
            this.bntModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(616, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(713, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rentasDataGridView
            // 
            this.rentasDataGridView.AllowUserToAddRows = false;
            this.rentasDataGridView.AllowUserToDeleteRows = false;
            this.rentasDataGridView.AutoGenerateColumns = false;
            this.rentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.rentasDataGridView.DataSource = this.rentasBindingSource;
            this.rentasDataGridView.Location = new System.Drawing.Point(336, 33);
            this.rentasDataGridView.Name = "rentasDataGridView";
            this.rentasDataGridView.ReadOnly = true;
            this.rentasDataGridView.Size = new System.Drawing.Size(842, 354);
            this.rentasDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_renta";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_renta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "placa";
            this.dataGridViewTextBoxColumn2.HeaderText = "placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo_vehiculo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo_vehiculo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad_kilometros_iniciales";
            this.dataGridViewTextBoxColumn4.HeaderText = "cantidad_kilometros_iniciales";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidad_kilometros_finales";
            this.dataGridViewTextBoxColumn5.HeaderText = "cantidad_kilometros_finales";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio_dia";
            this.dataGridViewTextBoxColumn6.HeaderText = "precio_dia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dias_renta";
            this.dataGridViewTextBoxColumn7.HeaderText = "dias_renta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn8.HeaderText = "subtotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "isv";
            this.dataGridViewTextBoxColumn9.HeaderText = "isv";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn10.HeaderText = "total";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // id_rentaLabel
            // 
            id_rentaLabel.AutoSize = true;
            id_rentaLabel.Location = new System.Drawing.Point(24, 25);
            id_rentaLabel.Name = "id_rentaLabel";
            id_rentaLabel.Size = new System.Drawing.Size(46, 13);
            id_rentaLabel.TabIndex = 0;
            id_rentaLabel.Text = "Id renta:";
            // 
            // id_rentaTextBox
            // 
            this.id_rentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentasBindingSource, "id_renta", true));
            this.id_rentaTextBox.Enabled = false;
            this.id_rentaTextBox.Location = new System.Drawing.Point(171, 22);
            this.id_rentaTextBox.Name = "id_rentaTextBox";
            this.id_rentaTextBox.Size = new System.Drawing.Size(54, 20);
            this.id_rentaTextBox.TabIndex = 1;
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new System.Drawing.Point(24, 51);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(37, 13);
            placaLabel.TabIndex = 2;
            placaLabel.Text = "Placa:";
            // 
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentasBindingSource, "placa", true));
            this.placaTextBox.Location = new System.Drawing.Point(171, 48);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(104, 20);
            this.placaTextBox.TabIndex = 3;
            // 
            // tipo_vehiculoLabel
            // 
            tipo_vehiculoLabel.AutoSize = true;
            tipo_vehiculoLabel.Location = new System.Drawing.Point(24, 77);
            tipo_vehiculoLabel.Name = "tipo_vehiculoLabel";
            tipo_vehiculoLabel.Size = new System.Drawing.Size(74, 13);
            tipo_vehiculoLabel.TabIndex = 4;
            tipo_vehiculoLabel.Text = "Tipo vehiculo:";
            // 
            // cantidad_kilometros_inicialesLabel
            // 
            cantidad_kilometros_inicialesLabel.AutoSize = true;
            cantidad_kilometros_inicialesLabel.Location = new System.Drawing.Point(24, 103);
            cantidad_kilometros_inicialesLabel.Name = "cantidad_kilometros_inicialesLabel";
            cantidad_kilometros_inicialesLabel.Size = new System.Drawing.Size(142, 13);
            cantidad_kilometros_inicialesLabel.TabIndex = 6;
            cantidad_kilometros_inicialesLabel.Text = "Cantidad kilometros iniciales:";
            // 
            // cantidad_kilometros_inicialesTextBox
            // 
            this.cantidad_kilometros_inicialesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentasBindingSource, "cantidad_kilometros_iniciales", true));
            this.cantidad_kilometros_inicialesTextBox.Location = new System.Drawing.Point(171, 100);
            this.cantidad_kilometros_inicialesTextBox.Name = "cantidad_kilometros_inicialesTextBox";
            this.cantidad_kilometros_inicialesTextBox.Size = new System.Drawing.Size(104, 20);
            this.cantidad_kilometros_inicialesTextBox.TabIndex = 7;
            // 
            // cantidad_kilometros_finalesLabel
            // 
            cantidad_kilometros_finalesLabel.AutoSize = true;
            cantidad_kilometros_finalesLabel.Location = new System.Drawing.Point(24, 129);
            cantidad_kilometros_finalesLabel.Name = "cantidad_kilometros_finalesLabel";
            cantidad_kilometros_finalesLabel.Size = new System.Drawing.Size(135, 13);
            cantidad_kilometros_finalesLabel.TabIndex = 8;
            cantidad_kilometros_finalesLabel.Text = "Cantidad kilometros finales:";
            // 
            // cantidad_kilometros_finalesTextBox
            // 
            this.cantidad_kilometros_finalesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentasBindingSource, "cantidad_kilometros_finales", true));
            this.cantidad_kilometros_finalesTextBox.Location = new System.Drawing.Point(171, 126);
            this.cantidad_kilometros_finalesTextBox.Name = "cantidad_kilometros_finalesTextBox";
            this.cantidad_kilometros_finalesTextBox.Size = new System.Drawing.Size(104, 20);
            this.cantidad_kilometros_finalesTextBox.TabIndex = 9;
            // 
            // precio_diaLabel
            // 
            precio_diaLabel.AutoSize = true;
            precio_diaLabel.Location = new System.Drawing.Point(24, 155);
            precio_diaLabel.Name = "precio_diaLabel";
            precio_diaLabel.Size = new System.Drawing.Size(57, 13);
            precio_diaLabel.TabIndex = 10;
            precio_diaLabel.Text = "Precio dia:";
            // 
            // precio_diaTextBox
            // 
            this.precio_diaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentasBindingSource, "precio_dia", true));
            this.precio_diaTextBox.Location = new System.Drawing.Point(171, 152);
            this.precio_diaTextBox.Name = "precio_diaTextBox";
            this.precio_diaTextBox.Size = new System.Drawing.Size(104, 20);
            this.precio_diaTextBox.TabIndex = 11;
            // 
            // dias_rentaLabel
            // 
            dias_rentaLabel.AutoSize = true;
            dias_rentaLabel.Location = new System.Drawing.Point(24, 181);
            dias_rentaLabel.Name = "dias_rentaLabel";
            dias_rentaLabel.Size = new System.Drawing.Size(58, 13);
            dias_rentaLabel.TabIndex = 12;
            dias_rentaLabel.Text = "Dias renta:";
            // 
            // dias_rentaTextBox
            // 
            this.dias_rentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentasBindingSource, "dias_renta", true));
            this.dias_rentaTextBox.Location = new System.Drawing.Point(171, 178);
            this.dias_rentaTextBox.Name = "dias_rentaTextBox";
            this.dias_rentaTextBox.Size = new System.Drawing.Size(104, 20);
            this.dias_rentaTextBox.TabIndex = 13;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(24, 209);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 14;
            estadoLabel.Text = "Estado:";
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.rentasBindingSource, "estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(171, 204);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoCheckBox.TabIndex = 15;
            this.estadoCheckBox.Text = "Si";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Autobus",
            "Tractor"});
            this.cmbTipo.Location = new System.Drawing.Point(171, 73);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(104, 21);
            this.cmbTipo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 460);
            this.Controls.Add(this.rentasDataGridView);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bntModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDRentas1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDDRentas1DataSet bDDRentas1DataSet;
        private System.Windows.Forms.BindingSource rentasBindingSource;
        private BDDRentas1DataSetTableAdapters.RentasTableAdapter rentasTableAdapter;
        private BDDRentas1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button bntModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView rentasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox id_rentaTextBox;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox cantidad_kilometros_inicialesTextBox;
        private System.Windows.Forms.TextBox cantidad_kilometros_finalesTextBox;
        private System.Windows.Forms.TextBox precio_diaTextBox;
        private System.Windows.Forms.TextBox dias_rentaTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

