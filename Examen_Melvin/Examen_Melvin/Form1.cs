using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Melvin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        int i = 0;

        FrmPrestamoPersonal FrmPersonal = new FrmPrestamoPersonal();
        FrmPrestamoHipotecario FrmHipotecario = new FrmPrestamoHipotecario();

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.Prestamos' table. You can move, or remove it, as needed.
            this.prestamosTableAdapter.Fill(this.bancoDataSet.Prestamos);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                DialogResult ResultadoPrestamoPersonal = FrmPersonal.ShowDialog();

                if (ResultadoPrestamoPersonal == DialogResult.OK)
                {
                    Personal personal = new Personal(FrmPersonal.Nombre_1er_aval, FrmPersonal.Nombre_2do_aval, FrmPersonal.Sueldo_cliente);
                }

                if (ResultadoPrestamoPersonal == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (cmbTipo.SelectedIndex == 1)
            {
                DialogResult ResultadoPrestamoHipotecario = FrmHipotecario.ShowDialog();

                if (ResultadoPrestamoHipotecario == DialogResult.OK)
                {
                    Hipotecario hipotecario = new Hipotecario (FrmHipotecario.Numero_catastral, FrmHipotecario.Ubicacion, FrmHipotecario.Valor_bien);
                }

                if (ResultadoPrestamoHipotecario == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
            prestamosBindingSource.AddNew();
            panel1.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            numero_prestamoTextBox.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Prestamos prestamos = new Prestamos(); 

            prestamos.Numero_prestamo = int.Parse(numero_prestamoTextBox.Text); //Se le asignan los valores a las clases.
            prestamos.Tipo_prestamo = cmbTipo.Text;
            prestamos.Nombre_cliente = nombre_clienteTextBox.Text;

            if (cmbTipo.SelectedIndex == 0)
            {
                if (MessageBox.Show("¿Desea ver la informacion del prestamo ingresado?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Personal personal = new Personal(FrmPersonal.Nombre_1er_aval, FrmPersonal.Nombre_2do_aval, FrmPersonal.Sueldo_cliente);
                    int filas = prestamosDataGridView.Rows.Count - 1;
                    prestamosDataGridView[3, filas].Value = cmbTipo.Text;
                    prestamosDataGridView[4, filas].Value = FrmPersonal.Nombre_1er_aval;
                    prestamosDataGridView[5, filas].Value = FrmPersonal.Nombre_2do_aval;
                    prestamosDataGridView[6, filas].Value = FrmPersonal.Sueldo_cliente;
                    MessageBox.Show(personal.InformacionPrestamo(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Personal personal = new Personal(FrmPersonal.Nombre_1er_aval, FrmPersonal.Nombre_2do_aval, FrmPersonal.Sueldo_cliente);
                    int filas = prestamosDataGridView.Rows.Count - 1;
                    prestamosDataGridView[3, filas].Value = cmbTipo.Text;
                    prestamosDataGridView[4, filas].Value = FrmPersonal.Nombre_1er_aval;
                    prestamosDataGridView[5, filas].Value = FrmPersonal.Nombre_2do_aval;
                    prestamosDataGridView[6, filas].Value = FrmPersonal.Sueldo_cliente;
                }
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                if (MessageBox.Show("¿Desea ver la informacion del prestamo ingresado?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Hipotecario hipotecario = new Hipotecario(FrmHipotecario.Numero_catastral, FrmHipotecario.Ubicacion, FrmHipotecario.Valor_bien);
                    int filas = prestamosDataGridView.Rows.Count - 1;
                    prestamosDataGridView[3, filas].Value = cmbTipo.Text;
                    prestamosDataGridView[7, filas].Value = FrmHipotecario.Numero_catastral;
                    prestamosDataGridView[8, filas].Value = FrmHipotecario.Ubicacion;
                    prestamosDataGridView[9, filas].Value = FrmHipotecario.Valor_bien;
                    MessageBox.Show(hipotecario.InformacionPrestamo(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Hipotecario hipotecario = new Hipotecario(FrmHipotecario.Numero_catastral, FrmHipotecario.Ubicacion, FrmHipotecario.Valor_bien);
                    int filas = prestamosDataGridView.Rows.Count - 1;
                    prestamosDataGridView[3, filas].Value = cmbTipo.Text;
                    prestamosDataGridView[7, filas].Value = FrmHipotecario.Numero_catastral;
                    prestamosDataGridView[8, filas].Value = FrmHipotecario.Ubicacion;
                    prestamosDataGridView[9, filas].Value = FrmHipotecario.Valor_bien;
                }
            }

            prestamosBindingSource.EndEdit();
            prestamosTableAdapter.Update(bancoDataSet.Prestamos);
            prestamosDataGridView.Refresh();
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = true;

            numero_prestamoTextBox.Clear();
            nombre_clienteTextBox.Clear();
            cmbTipo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;

            if (i == 0) 
            {
                prestamosDataGridView.Rows.RemoveAt(prestamosDataGridView.CurrentRow.Index);
            }

            i = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            i = 1; 
            panel1.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            numero_prestamoTextBox.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                prestamosTableAdapter.Delete(Convert.ToInt32(idTextBox.Text));
                bancoDataSet.Prestamos.Rows.RemoveAt(prestamosDataGridView.CurrentCell.RowIndex);
                prestamosTableAdapter.Update(bancoDataSet.Prestamos);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
