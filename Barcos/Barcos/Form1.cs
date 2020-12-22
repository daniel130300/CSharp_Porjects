using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculos obj = new Calculos();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            obj.Eslora = int.Parse(txtEslora.Text);
            obj.Dias = int.Parse(txtDias.Text);

            DialogResult dialogResult = MessageBox.Show("Subtotal: " + obj.Calculo_Subtotal() + ", ISV: " + obj.Calculo_ISV() + ", Total: " + obj.Calculo_Total(), "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dialogResult == DialogResult.Yes)
            {
                lstEmbarcaciones.Items.Add("Identidad: " + txtIdentidad.Text + ", Nombre: " + txtNombre.Text + ", Dias: " + txtDias.Text + ", Amarre: " + txtAmarre.Text + ", Total: " + obj.Calculo_Total());
                txtIdentidad.Clear();
                txtNombre.Clear();
                txtDias.Clear();
                txtAmarre.Clear();
                txtMatricula.Clear();
                txtEslora.Clear();
                txtAnio.Clear();
                rdbVelero.Checked = false;
                rdbDeportivo.Checked = false;
                rdbYate.Checked = false;
                txtMastiles.Clear();
                txtPotencia.Clear();
                txtCamarotes.Clear();
                txtIdentidad.Focus();
            }
            else
            {
                txtIdentidad.Clear();
                txtNombre.Clear();
                txtDias.Clear();
                txtAmarre.Clear();
                txtMatricula.Clear();
                txtEslora.Clear();
                txtAnio.Clear();
                rdbVelero.Checked = false;
                rdbDeportivo.Checked = false;
                rdbYate.Checked = false;
                txtMastiles.Clear();
                txtPotencia.Clear();
                txtCamarotes.Clear();
                txtIdentidad.Focus();
            }
        }

        private void rdbVelero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVelero.Checked)
            {
                txtMastiles.Enabled = true;
                obj.Precio = 100;
            }
            else
            {
                txtMastiles.Enabled = false;
            }
        }

        private void rdbDeportivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeportivo.Checked)
            {
                txtPotencia.Enabled = true;
                obj.Precio = 200;
            }
            else
            {
                txtPotencia.Enabled = false;
            }
        }

        private void rdbYate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYate.Checked)
            {
                txtPotencia.Enabled = true;
                txtCamarotes.Enabled = true;
                obj.Precio = 300;
            }
            else
            {
                txtPotencia.Enabled = false;
                txtCamarotes.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEmbarcaciones.SelectedIndex>-1)
            {
                lstEmbarcaciones.Items.RemoveAt(lstEmbarcaciones.SelectedIndex);
                txtIdentidad.Focus();
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            lstEmbarcaciones.Items.Clear();
            txtIdentidad.Focus();
        }
    }
}
