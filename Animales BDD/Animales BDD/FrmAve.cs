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
    public partial class FrmAve : Form
    {
        public FrmAve()
        {
            InitializeComponent();
        }

        private string color;
        private double altura;

        public string Color
        {
            get { return color; }
        }

        public double Altura
        {
            get { return altura; }
        }

        private void FrmAve_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                color = color_PlumajeTextBox.Text;
                altura = double.Parse(altura_VueloTextBox.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
