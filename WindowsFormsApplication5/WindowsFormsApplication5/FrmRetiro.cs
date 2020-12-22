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
    public partial class FrmRetiro : Form
    {
        public FrmRetiro()
        {
            InitializeComponent();
        }

        FrmPrincipal frmPrincipal = new FrmPrincipal();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                Cuenta cuenta = new Cuenta(txtTitular.Text);
                MessageBox.Show("No se ingreso una cantidad para realizar la transacción");
                this.Close();
            }
            else
            {
                Cuenta cuenta = new Cuenta(txtTitular.Text, frmPrincipal.Saldo, double.Parse(txtCantidad.Text));
                
                if (cuenta.Retirar() != 0)
                {
                    frmPrincipal.Saldo = cuenta.Retirar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error! No cuenta con el saldo suficiente para realizar esta transacción.");
                }
            }    
        }

        private void FrmRetiro_Load(object sender, EventArgs e)
        {

        }
    }
}
