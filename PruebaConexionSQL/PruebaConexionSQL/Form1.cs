using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PruebaConexionSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        Conexion c = new Conexion();

        private void rdbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAgregar.Checked)
            {
                btnAgregar.Enabled = true;
                txtID.Clear();
                txtIdentidad.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                datePickerNacimiento.Value = DateTime.Now;
            }
            else
                btnAgregar.Enabled = false;
        }

        private void rdbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbModificar.Checked)
                btnModificar.Enabled = true;
            else
                btnModificar.Enabled = false;
        }

        private void rdbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEliminar.Checked)
                btnEliminar.Enabled = true;
            else
                btnEliminar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prueba_BDDDataSet.Alumnos' table. You can move, or remove it, as needed.
            this.alumnosTableAdapter.Fill(this.prueba_BDDDataSet.Alumnos);
            Conexion c = new Conexion();
            c.cargarAlumnos(dgvAlumnos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (c.AlumnoRegistrado(txtIdentidad.Text) == 0)
            {
               MessageBox.Show(c.Insertar(txtIdentidad.Text, txtNombre.Text, txtApellido.Text, datePickerNacimiento.Value.Date));
               c.cargarAlumnos(dgvAlumnos);
               txtIdentidad.Clear();
               txtNombre.Clear();
               txtApellido.Clear();
               txtIdentidad.Focus();
            }
            else
            {
                MessageBox.Show("Este numero de identidad ya existe");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (i==1)
            {
                MessageBox.Show(c.Modificar(int.Parse(txtID.Text), txtIdentidad.Text, txtNombre.Text, txtApellido.Text, datePickerNacimiento.Value.Date));
                c.cargarAlumnos(dgvAlumnos);
            }

            i = 0;
        }

        private void dgvAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];

                if (rdbModificar.Checked || rdbEliminar.Checked)
                {
                    txtID.Text = Convert.ToString(fila.Cells[0].Value);
                    txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells[2].Value);
                    txtApellido.Text = Convert.ToString(fila.Cells[3].Value);
                    datePickerNacimiento.Value = Convert.ToDateTime(fila.Cells[4].Value.ToString());
                    i = 1;
                }
                else
                {
                    txtID.Clear();
                    txtIdentidad.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    datePickerNacimiento.Value = DateTime.Now;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            if (i==1)
            {
                MessageBox.Show(c.Eliminar(int.Parse(txtID.Text)));
                c.cargarAlumnos(dgvAlumnos);
                txtID.Clear();
                txtIdentidad.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                datePickerNacimiento.Value = DateTime.Now;
            }

            i = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            /*
            String query = "SELECT * FROM Alumnos where" + cmbFiltro.Text + "like '%" + txtBuscar.Text + "%'";
            c.BusquedaAlumno(query, ref dgvAlumnos);
            */
        }
    }
}
