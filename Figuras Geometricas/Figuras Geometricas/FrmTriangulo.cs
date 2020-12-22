using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FrmTriangulo : Form
    {
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        private static int lado, bas, altura;
        private static string nombre;

        public int Lado
        {
            get { return lado; }
        } 

        public int Bas
        {
            get { return bas; }
        }

        public int Altura
        {
            get { return altura; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                txtLado.Enabled = true;
                txtBase.Enabled = false;
                txtAltura.Enabled = false;
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                txtBase.Enabled = true;
                txtLado.Enabled = true;
                txtAltura.Enabled = false;
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                txtAltura.Enabled = true;
                txtBase.Enabled = true;
                txtLado.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                try
                {
                    nombre = cmbTipo.Text;
                    lado = int.Parse(txtLado.Text);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } 
            }

            if (cmbTipo.SelectedIndex == 1)
            {
                try
                {
                    nombre = cmbTipo.Text;
                    lado = int.Parse(txtLado.Text);
                    bas = int.Parse(txtBase.Text);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

            if (cmbTipo.SelectedIndex == 2)
            {
                try
                {
                    nombre = cmbTipo.Text;
                    altura = int.Parse(txtAltura.Text);
                    bas = int.Parse(txtBase.Text);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {

        }
    }
}
