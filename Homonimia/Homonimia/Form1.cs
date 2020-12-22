using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homonimia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Suma obj = new Suma();


            if (cmbParametros.SelectedIndex == 0)
            {
                txtTotal.Text = Convert.ToString(obj.sumas(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text)));
            }

            if (cmbParametros.SelectedIndex == 1)
            {
                txtTotal.Text = Convert.ToString(obj.sumas(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), int.Parse(txtNumero3.Text)));
            }

            if (cmbParametros.SelectedIndex == 2)
            {
                txtTotal.Text = Convert.ToString(obj.sumas(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), int.Parse(txtNumero3.Text), int.Parse(txtNumero4.Text)));
            }

            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtNumero4.Clear();
        }

        private void cmbParametros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParametros.SelectedIndex == 0)
            {
                txtNumero1.Enabled = true;
                txtNumero2.Enabled = true;
                txtNumero3.Enabled = false;
                txtNumero4.Enabled = false;
            }

            if (cmbParametros.SelectedIndex == 1)
            {
                txtNumero1.Enabled = true;
                txtNumero2.Enabled = true;
                txtNumero3.Enabled = true;
                txtNumero4.Enabled = false;
            }

            if (cmbParametros.SelectedIndex == 2)
            {
                txtNumero1.Enabled = true;
                txtNumero2.Enabled = true;
                txtNumero3.Enabled = true;
                txtNumero4.Enabled = true;
            }
        }
    }
}
