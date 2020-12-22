using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instrumentos
{
    public partial class FrmViento : Form
    {
        public FrmViento()
        {
            InitializeComponent();
        }

        private static string material;
        
        public string Material
        {
            get { return material; }
        }

        private void FrmViento_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                material = cmbMaterial.Text;
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
