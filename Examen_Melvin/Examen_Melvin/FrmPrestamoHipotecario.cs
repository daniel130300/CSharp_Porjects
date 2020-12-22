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
    public partial class FrmPrestamoHipotecario : Form
    {
        public FrmPrestamoHipotecario()
        {
            InitializeComponent();
        }

        private int numero_catastral;
        private string ubicacion;
        private double valor_bien;

        public int Numero_catastral
        {
            get { return numero_catastral; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
        }

        public double Valor_bien
        {
            get { return valor_bien; }
        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet);

        }

        private void FrmPrestamoHipotecario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.Prestamos' table. You can move, or remove it, as needed.
            this.prestamosTableAdapter.Fill(this.bancoDataSet.Prestamos);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                numero_catastral = int.Parse(numero_catastralTextBox.Text);
                ubicacion = rchtxtUbicacion.Text;
                valor_bien = double.Parse(valor_bienTextBox.Text);
                numero_catastralTextBox.Clear();
                rchtxtUbicacion.Clear();
                valor_bienTextBox.Clear();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numero_catastralTextBox.Clear();
                rchtxtUbicacion.Clear();
                valor_bienTextBox.Clear();
                this.Close();
            }
        }
    }
}
