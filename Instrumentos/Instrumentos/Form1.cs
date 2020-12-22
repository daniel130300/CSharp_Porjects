using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instrumentos
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        int i = 0;
        FrmViento frmviento = new FrmViento();
        FrmCuerda frmcuerda = new FrmCuerda();

        private void instrumentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instrumentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventarioDataSet.Instrumentos' table. You can move, or remove it, as needed.
            this.instrumentosTableAdapter.Fill(this.inventarioDataSet.Instrumentos);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            instrumentosBindingSource.AddNew();
            panel1.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            codigoTextBox.Focus();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Viento
            Percusion
            Cuerda*/

            if (cmbTipo.SelectedIndex == 0)
            {
                DialogResult ResultadoViento = frmviento.ShowDialog();

                if (ResultadoViento == DialogResult.OK)
                {
                    Viento viento = new Viento(frmviento.Material);
                }

                if (ResultadoViento == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                DialogResult ResultadoCuerda = frmcuerda.ShowDialog();

                if (ResultadoCuerda == DialogResult.OK)
                {
                    Cuerdas cuerdas = new Cuerdas(frmcuerda.Numero);
                }

                if (ResultadoCuerda == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Informacion_general instru = new Informacion_general(); 

            instru.Codigo = codigoTextBox.Text;
            instru.Estado = cmbEstado.Text;
            instru.Estilo = estilo_de_instrumentoTextBox.Text;
            instru.Fecha_compra = fecha_de_CompraDateTimePicker.Text;
            instru.Marca = marca_InstrumentoTextBox.Text;
            instru.Estado = cmbEstado.Text;
            instru.Observacion = richtxtObservacion.Text;
            instru.Tipo = cmbTipo.Text;

            int filas = instrumentosDataGridView.Rows.Count - 1;
            instrumentosDataGridView[2, filas].Value = cmbTipo.Text;
            instrumentosDataGridView[6, filas].Value = cmbEstado.Text;
            instrumentosDataGridView[7, filas].Value = richtxtObservacion.Text;

            if (cmbTipo.SelectedIndex == 0)
            {
                if (MessageBox.Show("Desea ver la informacion del instrumento ingresado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Viento viento = new Viento(frmviento.Material);
                    MessageBox.Show(viento.Mensaje(), "Instrumento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Viento viento = new Viento(frmviento.Material);
                }
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                if (MessageBox.Show("Desea ver la informacion del instrumento ingresado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show(instru.Mensaje(), "Instrumento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                if (MessageBox.Show("Desea ver la informacion del instrumento ingresado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Cuerdas cuerdas = new Cuerdas(frmcuerda.Numero);
                    MessageBox.Show(cuerdas.Mensaje(), "Instrumento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cuerdas cuerdas = new Cuerdas(frmcuerda.Numero);
                }
            }

            instrumentosBindingSource.EndEdit();
            instrumentosTableAdapter.Update(inventarioDataSet.Instrumentos);
            instrumentosDataGridView.Refresh();
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = true;
            richtxtObservacion.Clear();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;

            if (i == 0) //Si no se presiono el boton de modificar y si el de adicionar tiene que borrar la fila creada al presionar ese boton.
            {
                instrumentosDataGridView.Rows.RemoveAt(instrumentosDataGridView.CurrentRow.Index);
            }

            i = 0; //El valor se reinicia nuevamenente.
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            i = 1; //Si se presiono el boton modificar el valor cambia a 1.
            panel1.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            codigoTextBox.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                instrumentosTableAdapter.Delete(codigoTextBox.Text);
                inventarioDataSet.Instrumentos.Rows.RemoveAt(instrumentosDataGridView.CurrentCell.RowIndex);
                instrumentosTableAdapter.Update(inventarioDataSet.Instrumentos);
            }
        }
    }
}
