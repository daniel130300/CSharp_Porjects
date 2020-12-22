using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_Bienes_Inmuebles
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        int i = 0;

        private void bienes_InmueblesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bienes_InmueblesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bienesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bienesDataSet.Bienes_Inmuebles' table. You can move, or remove it, as needed.
            this.bienes_InmueblesTableAdapter.Fill(this.bienesDataSet.Bienes_Inmuebles);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 1)
            {
                numero_de_bañosTextBox.Enabled = true;
                numero_de_estacionamientosTextBox.Enabled = true;
                numero_de_habitacionesTextBox.Enabled = true;
                numero_de_pisosTextBox.Enabled = true;
                richtxtExtras.Enabled = true;
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                numero_de_bañosTextBox.Enabled = true;
                numero_de_estacionamientosTextBox.Enabled = true;
                numero_de_habitacionesTextBox.Enabled = true;
                numero_de_pisosTextBox.Enabled = false;
                richtxtExtras.Enabled = true;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
            bienes_InmueblesBindingSource.AddNew();
            panel1.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            cmbTipo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Terreno terreno = new Terreno();

            terreno.Ubicacion = ubicacionTextBox.Text;
            terreno.Dimensiones = dimensionesTextBox.Text;
            terreno.Precio = double.Parse(precioTextBox.Text);

            if(cmbTipo.SelectedIndex == 0)
            {
                int filas = bienes_InmueblesDataGridView.Rows.Count - 1;
                bienes_InmueblesDataGridView[1, filas].Value = cmbTipo.Text;
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                Edificios edificio = new Edificios(richtxtExtras.Text, int.Parse(numero_de_pisosTextBox.Text), 
                int.Parse(numero_de_habitacionesTextBox.Text), int.Parse(numero_de_bañosTextBox.Text), int.Parse(numero_de_estacionamientosTextBox.Text));
                int filas = bienes_InmueblesDataGridView.Rows.Count - 1;
                bienes_InmueblesDataGridView[1, filas].Value = cmbTipo.Text;
                bienes_InmueblesDataGridView[8, filas].Value = richtxtExtras.Text;
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                Casa casa = new Casa (richtxtExtras.Text, int.Parse(numero_de_habitacionesTextBox.Text), 
                int.Parse(numero_de_bañosTextBox.Text), int.Parse(numero_de_estacionamientosTextBox.Text));
                int filas = bienes_InmueblesDataGridView.Rows.Count - 1;
                bienes_InmueblesDataGridView[1, filas].Value = cmbTipo.Text;
                bienes_InmueblesDataGridView[8, filas].Value = richtxtExtras.Text;
            }

            bienes_InmueblesBindingSource.EndEdit();
            bienes_InmueblesTableAdapter.Update(bienesDataSet.Bienes_Inmuebles);
            bienes_InmueblesDataGridView.Refresh();
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = true;
            richtxtExtras.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;

            if (i == 0) 
            {
               bienes_InmueblesDataGridView.Rows.RemoveAt(bienes_InmueblesDataGridView.CurrentRow.Index);
            }

            i = 0; 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            i = 1; 
            panel1.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            cmbTipo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bienes_InmueblesTableAdapter.Delete(int.Parse(idTextBox.Text));
                bienesDataSet.Bienes_Inmuebles.Rows.RemoveAt(bienes_InmueblesDataGridView.CurrentCell.RowIndex);
                bienes_InmueblesTableAdapter.Update(bienesDataSet.Bienes_Inmuebles);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bienes_InmueblesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
