using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        Cajero obj = new Cajero();
        int cantidad = 0;
        string transaccion = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRapido.SelectedIndex == -1)
            {
                obj.Cantidad = 0;
            }

            if (cmbRapido.SelectedIndex == 0)
            {
                obj.Cantidad = 100;
            }

            if (cmbRapido.SelectedIndex == 1)
            {
                obj.Cantidad = 200;
            }

            if (cmbRapido.SelectedIndex == 2)
            {
                obj.Cantidad = 300;
            }

            if (cmbRapido.SelectedIndex == 3)
            {
                obj.Cantidad = 400;
            }

            if (cmbRapido.SelectedIndex == 3)
            {
                obj.Cantidad = 500;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbDeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeposito.Checked)
            {
                transaccion = "Depósito";
                txtCuenta.Enabled = true;
                txtDep_cantidad.Enabled = true;
                cmbRetiro.SelectedIndex = -1;
            }
            else
            {
                transaccion = "";
                txtCuenta.Enabled = false;
                txtDep_cantidad.Enabled = false;
            }
        }

        private void rdbRetiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRetiro.Checked)
            {
                transaccion = "Retiro";
                cmbRetiro.Enabled = true;
                cmbRetiro.SelectedIndex = -1;
            }
            else
            {
                transaccion = "";
                cmbRetiro.Enabled = false;
            }
        }

        private void cmbRetiro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbRetiro.SelectedIndex == -1)
            {
                cmbRapido.Enabled = false;
                txtRet_cantidad.Enabled = false;
            }

            if (cmbRetiro.SelectedIndex == 0)
            {
                cmbRapido.Enabled = true;
                txtRet_cantidad.Enabled = false;
            }

            if (cmbRetiro.SelectedIndex == 1)
            {
                txtRet_cantidad.Enabled = true;
                cmbRapido.Enabled = false;
            }
        }

        private void rdbPagos_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbPagos.Checked)
            {
                transaccion = "Pago de Servicio Público";
                chkAgua.Enabled = true;
                chkElectricidad.Enabled = true;
                chkTelefonía.Enabled = true;
                cmbRetiro.SelectedIndex= -1;
            }
            else
            {
                transaccion = "";
                chkAgua.Enabled = false;
                chkElectricidad.Enabled = false;
                chkTelefonía.Enabled = false;
            }
        }

        private void chkElectricidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElectricidad.Checked)
            {
                if (chkElectricidad.Checked)
                {
                    obj.Cantidad += 400;
                }
                else
                {
                    obj.Cantidad -= 400;
                }
            }
        }

        private void rdbSaldo_CheckedChanged(object sender, EventArgs e)
        {
            cmbRetiro.SelectedIndex = -1;

            if (rdbSaldo.Checked)
            {
                grpbxSaldo.Visible = true;
                transaccion = "Consulta de saldo";
            }
            else
            {
                grpbxSaldo.Visible = false;
                transaccion = "";
            }
        }

        private void chkAgua_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgua.Checked)
            {
                if (chkAgua.Checked)
                {
                    obj.Cantidad += 200;
                }
                else
                {
                    obj.Cantidad -= 200;
                }
            }
        }

        private void chkTelefonía_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTelefonía.Checked)
            {
                if (chkAgua.Checked)
                {
                    obj.Cantidad += 300;
                }
                else
                {
                    obj.Cantidad -= 300;
                }
            }
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {

            if (txtDep_cantidad.Enabled == true)
            {
                obj.Cantidad = int.Parse (txtDep_cantidad.Text);
            }

            if (txtRet_cantidad.Enabled == true)
            {
                obj.Cantidad = int.Parse(txtRet_cantidad.Text);
            }

            obj.saldo_actual = int.Parse(txtSaldo.Text);

            if(obj.Calculo_saldo() > 0)
            {
                txtSaldo.Text = Convert.ToString(obj.Calculo_saldo());
                lstTransacciones.Items.Add("Tipo de Transaccion: " + transaccion);
                cantidad++;
                txtTransacciones.Text = Convert.ToString(cantidad);
                MessageBox.Show("La transacción se ha realizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdbDeposito.Checked = false;
                rdbRetiro.Checked = false;
                rdbPagos.Checked = false;
                rdbSaldo.Checked = false;
                chkAgua.Checked = false;
                chkElectricidad.Checked = false;
                chkTelefonía.Checked = false;
                txtCuenta.Clear();
                txtDep_cantidad.Clear();
                txtRet_cantidad.Clear();
            }
            else
            {
                MessageBox.Show("No cuenta con el suficiente saldo para realizar esta transacción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rdbDeposito.Checked = false;
                rdbRetiro.Checked = false;
                rdbPagos.Checked = false;
                rdbSaldo.Checked = false;
                chkAgua.Checked = false;
                chkElectricidad.Checked = false;
                chkTelefonía.Checked = false;
                txtCuenta.Clear();
                txtDep_cantidad.Clear();
                txtRet_cantidad.Clear();
            }
    
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTransacciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
