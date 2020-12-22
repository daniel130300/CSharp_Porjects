using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homonimia_Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double descuento;

        Calculo_Factura obj = new Calculo_Factura();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdb15.Checked && (chkTercera.Checked || chkEmpleado.Checked || chkEmpleado.Checked))
            {
                txtTotal.Text = (obj.Total_Factura(double.Parse(txtSubtotal.Text), descuento, 0.15)).ToString("0.00");
            }
        }

        private void rdb15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbExento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTercera_CheckedChanged(object sender, EventArgs e)
        {
            descuento = 0.25;
        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            descuento = 0.10;
        }

        private void chkConsumo_CheckedChanged(object sender, EventArgs e)
        {
            descuento = 0.15;
        }
    }
}
