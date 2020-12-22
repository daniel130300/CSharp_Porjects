using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int aprobados = 0, reprobados = 0, cont = 0;
        double global = 0, acum = 0;

        Calcular_promedio obj = new Calcular_promedio();

        private void button1_Click(object sender, EventArgs e)
        {

            obj.Nota1 = int.Parse(txtNota1.Text);
            obj.Nota2 = int.Parse(txtNota2.Text);
            obj.Nota3 = int.Parse(txtNota3.Text);

            txtPromedio.Text = obj.Calculo_promedio().ToString("0.00");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont++;
            acum += obj.Calculo_promedio();

            lstAlumnos.Items.Add(Convert.ToString("Nombre: " + txtNombre.Text + " , Promedio: " + txtPromedio.Text));

            if (obj.Calculo_promedio() > 70)
                aprobados++;

            if (obj.Calculo_promedio() < 70)
                reprobados++;

            global = acum/cont;

            txtAprobados.Text = Convert.ToString(aprobados);
            txtReprobados.Text = Convert.ToString(reprobados);
            txtGlobal.Text = global.ToString("0.00");

            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();

            txtNombre.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedIndex > -1)
            {
                lstAlumnos.Items.RemoveAt(lstAlumnos.SelectedIndex);
            }

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            lstAlumnos.Items.Clear();
            txtAprobados.Clear();
            txtReprobados.Clear();
            txtGlobal.Clear();
            aprobados = 0;
            reprobados = 0;
            cont = 0;
            acum = 0;

            txtNombre.Focus();
        }

        private void txtAprobados_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtReprobados_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
