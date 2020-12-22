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
    public partial class FrmRectangulo : Form
    {
        public FrmRectangulo()
        {
            InitializeComponent();
        }

        private int bas, alt;

        public int Bas
        {
            get { return bas; }
        }

        public int Alt
        {
            get { return alt; }
        }

        private void FrmRectangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bas = int.Parse(txtBase.Text);
                alt = int.Parse(txtAltura.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error ocurrio un error guardando los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
