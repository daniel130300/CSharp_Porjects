using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsdrasPerdomo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rentasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDRentas1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDRentas1DataSet.Rentas' table. You can move, or remove it, as needed.
            this.rentasTableAdapter.Fill(this.bDDRentas1DataSet.Rentas);

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                cantidad_kilometros_finalesTextBox.Enabled = true;
                cantidad_kilometros_inicialesTextBox.Enabled = true;
                estadoCheckBox.Enabled = true;
                precio_diaTextBox.Enabled = false;
                dias_rentaTextBox.Enabled = false;
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                cantidad_kilometros_finalesTextBox.Enabled = false;
                cantidad_kilometros_inicialesTextBox.Enabled = false;
                estadoCheckBox.Enabled = true;
                precio_diaTextBox.Enabled = true;
                dias_rentaTextBox.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
            rentasBindingSource.AddNew();
            panel1.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            placaTextBox.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.Placa = placaTextBox.Text;

            if (cmbTipo.SelectedIndex == 0)
            {
                Autobus bus = new Autobus();
                bus.Kilometos_inciales = Convert.ToInt32(cantidad_kilometros_finalesTextBox.Text);
                bus.Kilometros_finales = Convert.ToInt32(cantidad_kilometros_finalesTextBox.Text);

                int filas = rentasDataGridView.Rows.Count - 1;
                rentasDataGridView[1, filas].Value = placaTextBox.Text;
                rentasDataGridView[2, filas].Value = cmbTipo.Text;
                rentasDataGridView[3, filas].Value = 
            }


            if (cmbTipo.SelectedIndex == 1)
            {
                Tractor tractor = new Tractor();
                tractor.Precio_dia = Convert.ToInt32(precio_diaTextBox.Text);
                tractor.Cantidad_dias = Convert.ToInt32(dias_rentaTextBox.Text);

                int filas = rentasDataGridView.Rows.Count - 1;
                rentasDataGridView[2, filas].Value = cmbTipo.Text;
            }

            rentasBindingSource.EndEdit();
            rentasTableAdapter.Update(bDDRentas1DataSet.Rentas);
            rentasDataGridView.Refresh();
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = true;
        }
    }
}
