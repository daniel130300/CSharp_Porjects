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
    public partial class FrmInsecto : Form
    {
        public FrmInsecto()
        {
            InitializeComponent();
        }

        private bool vuela;

        public bool Vuela
        {
            get { return vuela; }
        }

        private void vuelaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmInsecto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vuelaCheckBox.Checked)
                {
                    vuela = true;
                }
                else
                {
                    vuela = false;
                }

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
