using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double descuento;
        int i;
        Calculo obj = new Calculo();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdb15.Checked && i==1)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), descuento, 0.15)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdbExento.Checked && i==1)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), descuento, 0)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdb15.Checked && chkConsumo.Checked && chkTercera.Checked)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), 0.15, 0.25, 0.15)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdb15.Checked  && chkEmpleado.Checked && chkConsumo.Checked)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), 0.15, 0.10, 0.15)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdb15.Checked && chkEmpleado.Checked && chkTercera.Checked)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), 0.25, 0.10, 0.15)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdbExento.Checked && chkConsumo.Checked && chkTercera.Checked)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), 0.15, 0.25, 0)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdbExento.Checked && chkEmpleado.Checked && chkConsumo.Checked)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), 0.15, 0.10, 0)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }

            if (rdbExento.Checked && chkEmpleado.Checked && chkTercera.Checked)
            {
                txtTotal.Text = (obj.Calculo_factura(double.Parse(txtSubtotal.Text), 0.25, 0.10, 0)).ToString("0.00");
                txtIsv.Text = obj.Impuesto.ToString("0.00");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkTercera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTercera.Checked)
            {
                descuento = 0.25;
                i++;
            }
            else i--;
        }

        private void chkConsumo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsumo.Checked)
            {
                descuento = 0.15;
                i++;
            }
            else i--;
        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpleado.Checked)
            {
                descuento = 0.10;
                i++;
            }
            else i--;
        }

        private void rdb15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
