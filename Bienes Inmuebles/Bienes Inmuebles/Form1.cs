using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienes_Inmuebles
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void terrenosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terrenosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bienes_Inmuebles1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bienes_Inmuebles1DataSet.Terrenos' table. You can move, or remove it, as needed.
            terrenosTableAdapter.Fill(bienes_Inmuebles1DataSet.Terrenos);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                dimensionesTextBox.Enabled = true;
                ubicacionTextBox.Enabled = true;
                precioTextBox.Enabled = true;
                numero_de_pisosTextBox.Enabled = false;
                numero_de_habitacionesTextBox.Enabled = false;
                numero_de_bañosTextBox.Enabled = false;
                espacios_de_estacionamiemtoTextBox.Enabled = false;
                richtxtExtras.Enabled = false; 
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                dimensionesTextBox.Enabled = true;
                ubicacionTextBox.Enabled = true;
                precioTextBox.Enabled = true;
                numero_de_pisosTextBox.Enabled = true;
                numero_de_habitacionesTextBox.Enabled = true;
                numero_de_bañosTextBox.Enabled = true;
                espacios_de_estacionamiemtoTextBox.Enabled = true;
                richtxtExtras.Enabled = true;
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                dimensionesTextBox.Enabled = true;
                ubicacionTextBox.Enabled = true;
                precioTextBox.Enabled = true;
                numero_de_habitacionesTextBox.Enabled = true;
                numero_de_bañosTextBox.Enabled = true;
                espacios_de_estacionamiemtoTextBox.Enabled = true;
                richtxtExtras.Enabled = true;
                numero_de_pisosTextBox.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
