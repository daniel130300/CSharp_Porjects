using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class FrmVehiculos : Form
    {
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Vehiculos obj = new Vehiculos();

            MessageBox.Show(obj.UnVehiculo(txtColor.Text, txtMarca.Text, txtModelo.Text), "Polimorfismo Parametrizado");
            obj.UnVehiculo();
        }
    }
}
