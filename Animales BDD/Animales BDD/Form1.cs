using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animales_BDD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        FrmInsecto Frminsecto = new FrmInsecto();
        FrmAve Frmave = new FrmAve();

        int i = 0; //Esta variable se usa para validar si se presiono el boton de modificar.

        private void animalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_AnimalesDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'base_AnimalesDataSet.Animales' table. You can move, or remove it, as needed.
            this.animalesTableAdapter.Fill(this.base_AnimalesDataSet.Animales);
        }

        private void animalesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasificacion.Text == "Ave")
            {
                DialogResult ResultadoAve = Frmave.ShowDialog();

                if (ResultadoAve == DialogResult.OK)
                {
                    Ave ClaseAve = new Ave(Frmave.Color, Frmave.Altura);
                }

                if (ResultadoAve == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbClasificacion.Text == "Insecto")
            {
                DialogResult ResultadoInsecto = Frminsecto.ShowDialog();

                if (ResultadoInsecto == DialogResult.OK)
                {
                    Insecto ClaseInsecto = new Insecto(Frminsecto.Vuela);
                }

                if (ResultadoInsecto == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cmbClasificacion.SelectedIndex = -1;
            animalesBindingSource.AddNew();
            panel1.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            codigoTextBox.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Animales ani = new Animales(); //Se crea la clase global en el boton de guardar

            ani.Codigo = int.Parse(codigoTextBox.Text); //Se le asignan los valores a las clases.
            ani.Nombre = nombreTextBox.Text;
            ani.Especie = especieTextBox.Text;
            ani.Jaula = int.Parse(jaulaTextBox.Text);
            ani.Peso = double.Parse(pesoTextBox.Text);

            if (cmbClasificacion.Text == "Mamifero")
            {
                if (MessageBox.Show("Desea ver el perfil del animal", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show(ani.QueClasedeAnimalEres(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (cmbClasificacion.Text == "Ave")
            {
                if (MessageBox.Show("Desea ver el perfil del animal", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Ave ClaseAve = new Ave(Frmave.Color, Frmave.Altura);
                    int filas = animalesDataGridView.Rows.Count - 1;
                    animalesDataGridView[6, filas].Value = Frmave.Color;
                    animalesDataGridView[7, filas].Value = Frmave.Altura;
                    MessageBox.Show(ClaseAve.QueClasedeAnimalEres(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Ave ClaseAve = new Ave(Frmave.Color, Frmave.Altura);
                    int filas = animalesDataGridView.Rows.Count - 1;
                    animalesDataGridView[6, filas].Value = Frmave.Color;
                    animalesDataGridView[7, filas].Value = Frmave.Altura;
                }
            }

            if (cmbClasificacion.Text == "Insecto")
            {
                if (MessageBox.Show("Desea ver el perfil del animal", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Insecto ins = new Insecto(Frminsecto.Vuela);
                    int filas = animalesDataGridView.Rows.Count - 1;
                    animalesDataGridView[8, filas].Value = Frminsecto.Vuela;
                    MessageBox.Show(ins.QueClasedeAnimalEres(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Insecto ins = new Insecto(Frminsecto.Vuela);
                    int filas = animalesDataGridView.Rows.Count - 1;
                    animalesDataGridView[8, filas].Value = Frminsecto.Vuela;
                }
            }

            animalesBindingSource.EndEdit();
            animalesTableAdapter.Update(base_AnimalesDataSet.Animales);
            animalesDataGridView.Refresh();
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = true;
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
            if (MessageBox.Show ("¿Desea eliminar el registro", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                animalesTableAdapter.Delete(Convert.ToInt32(codigoTextBox.Text));
                base_AnimalesDataSet.Animales.Rows.RemoveAt(animalesDataGridView.CurrentCell.RowIndex);
                animalesTableAdapter.Update(base_AnimalesDataSet.Animales);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;

            if (i == 0) //Si no se presiono el boton de modificar y si el de adicionar tiene que borrar la fila creada al presionar ese boton.
            {
                animalesDataGridView.Rows.RemoveAt(animalesDataGridView.CurrentRow.Index);
            }

            i = 0; //El valor se reinicia nuevamenente.
        }

        private void animalesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
