using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private static double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Saldo = Convert.ToDouble(lblSaldo.Text);
            FrmIngreso Ingreso = new FrmIngreso();
            DialogResult Resultado_Ingreso = Ingreso.ShowDialog();

            if (Resultado_Ingreso == DialogResult.OK)
            {
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Saldo = Convert.ToDouble(lblSaldo.Text);
            FrmRetiro Retiro = new FrmRetiro();
            DialogResult Resultado_Retiro = Retiro.ShowDialog();

            if (Resultado_Retiro == DialogResult.OK)
            {
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
