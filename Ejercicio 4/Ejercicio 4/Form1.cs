using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class lstEmbarcaciones : Form
    {
        public lstEmbarcaciones()
        {
            InitializeComponent();
            txtIdentidad.Focus();
        }

        Alquiler obj = new Alquiler();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.Dias = int.Parse(txtDias.Text);
            obj.Eslora = int.Parse(txtEslora.Text);

            if (rdbVelero.Checked)
                obj.Precio = 100;

            if (rdbDeportivo.Checked)
                obj.Precio = 200;

            if (rdbYate.Checked)
                obj.Precio = 300;

            txtSubtotal.Text = obj.Calculo_alquiler().ToString("Lps 0.00");
            txtISV.Text = (obj.Calculo_alquiler() * 0.15).ToString(" Lps 0.00");
            txtTotal.Text = (obj.Calculo_alquiler() * 1.15).ToString("Lps 0.00");
        }

        private void rdbVelero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVelero.Checked)
                txtMastiles.Enabled = true;
            else
                txtMastiles.Enabled = false;
                
            
        }

        private void rdbDeportivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeportivo.Checked)
                txtPotencia.Enabled = true;
            else
                txtPotencia.Enabled = false;
        }

        private void rdbYate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYate.Checked)
            {
                txtPotencia.Enabled = true;
                txtCamarotes.Enabled = true;
            }
            else
            {
                txtPotencia.Enabled = false;
                txtCamarotes.Enabled = false;
            }
        }

        private void txtISV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstBarcos.Items.Add("Identidad: " + txtIdentidad.Text + ", Nombre: " + txtNombre.Text + ", Dias: " + txtDias.Text + ", Amarre: " + txtPosicion.Text + ", Total: "+ txtTotal.Text);

            txtIdentidad.Clear();
            txtNombre.Clear();
            txtDias.Clear();
            txtPosicion.Clear();
            txtMatricula.Clear();
            txtNom.Clear();
            txtEslora.Clear();
            txtAño.Clear();
            rdbVelero.Checked = false;
            rdbDeportivo.Checked = false;
            rdbYate.Checked = false;
            txtMastiles.Clear();
            txtPotencia.Clear();
            txtCamarotes.Clear();
            txtSubtotal.Clear();
            txtISV.Clear();
            txtTotal.Clear();
            txtIdentidad.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstBarcos.SelectedIndex > -1)
                lstBarcos.Items.RemoveAt(lstBarcos.SelectedIndex);

            txtIdentidad.Clear();
            txtNombre.Clear();
            txtDias.Clear();
            txtPosicion.Clear();
            txtMatricula.Clear();
            txtNom.Clear();
            txtEslora.Clear();
            txtAño.Clear();
            rdbVelero.Checked = false;
            rdbDeportivo.Checked = false;
            rdbYate.Checked = false;
            txtMastiles.Clear();
            txtPotencia.Clear();
            txtCamarotes.Clear();
            txtSubtotal.Clear();
            txtISV.Clear();
            txtTotal.Clear();
            txtIdentidad.Focus();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            lstBarcos.Items.Clear();
            txtIdentidad.Clear();
            txtNombre.Clear();
            txtDias.Clear();
            txtPosicion.Clear();
            txtMatricula.Clear();
            txtNom.Clear();
            txtEslora.Clear();
            txtAño.Clear();
            rdbVelero.Checked = false;
            rdbDeportivo.Checked = false;
            rdbYate.Checked = false;
            txtMastiles.Clear();
            txtPotencia.Clear();
            txtCamarotes.Clear();
            txtSubtotal.Clear();
            txtISV.Clear();
            txtTotal.Clear();
            txtIdentidad.Focus();
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
