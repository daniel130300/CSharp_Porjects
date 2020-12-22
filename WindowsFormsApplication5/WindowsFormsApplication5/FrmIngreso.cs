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
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            if (txtCantidad.Text == "")
            {
                Cuenta cuenta = new Cuenta(txtTitular.Text);
                MessageBox.Show("No se ingreso una cantidad para realizar la transacción");
                this.Close();
            }
            else
            {
                Cuenta cuenta = new Cuenta(txtTitular.Text, frmPrincipal.Saldo, double.Parse(txtCantidad.Text));

                if (cuenta.Ingresar()!= 0)
                {
                    frmPrincipal.Saldo = cuenta.Ingresar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error! Ingrese un monto mayor a 0 para realizar la transacción.");
                }
            }
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
