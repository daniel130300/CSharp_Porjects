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
    public partial class FrmPrestamoPersonal : Form
    {
        public FrmPrestamoPersonal()
        {
            InitializeComponent();
        }

        private string nombre_1er_aval;
        private string nombre_2do_aval;
        private double sueldo_cliente;

        public string Nombre_1er_aval
        {
            get { return nombre_1er_aval; }
        }

        public string Nombre_2do_aval
        {
            get { return nombre_2do_aval; }
        }

        public double Sueldo_cliente
        {
            get { return sueldo_cliente; }
        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet);

        }

        private void FrmPrestamoPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.Prestamos' table. You can move, or remove it, as needed.
            this.prestamosTableAdapter.Fill(this.bancoDataSet.Prestamos);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                nombre_1er_aval = nombre_Aval_1TextBox.Text;
                nombre_2do_aval = nombre_Aval_2TextBox.Text;
                sueldo_cliente = double.Parse(sueldo_clienteTextBox.Text);
                this.Close();
                nombre_Aval_1TextBox.Clear();
                nombre_Aval_2TextBox.Clear();
                sueldo_clienteTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
