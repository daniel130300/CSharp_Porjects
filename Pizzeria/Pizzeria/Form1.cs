using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pizza obj = new Pizza();

        int centinela = 0;

        private void rdbPequeña_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPequeña.Checked)
            {
                lstPizza.Items.Add(rdbPequeña.Text);
                 obj.Subtotal+= 50;
            }
            else
            {
                lstPizza.Items.Remove(rdbPequeña.Text);
                obj.Subtotal -= 50;
            }
        }

        private void rdbMediana_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMediana.Checked)
            {
                lstPizza.Items.Add(rdbMediana.Text);
                obj.Subtotal += 60;
            }
            else
            {
                lstPizza.Items.Remove(rdbMediana.Text);
                obj.Subtotal -= 60;
            }

        }

        private void rdbGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGrande.Checked)
            {
                lstPizza.Items.Add(rdbGrande.Text);
                obj.Subtotal += 70;
            }
            else
            {
                lstPizza.Items.Remove(rdbGrande.Text);
                obj.Subtotal -= 70;
            }
        }

        private void cmbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMasa.SelectedIndex == 0 && centinela == 0)
            {
                lstPizza.Items.Add("Tipo de Masa: " + cmbMasa.Text);
                lstPizza.Items.Remove("Tipo de Masa: Pan Pizza");
                centinela = 1;
            }
            
            if (cmbMasa.SelectedIndex == 1 && centinela == 1)
            {
                lstPizza.Items.Add("Tipo de Masa: " + cmbMasa.Text);
                lstPizza.Items.Remove("Tipo de Masa: Delgada");
                centinela = 0;
            }
        }

        private void chkAnchoas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnchoas.Checked)
            {
                lstPizza.Items.Add(chkAnchoas.Text);
                obj.Subtotal += 10;
            }
            else
            {
                lstPizza.Items.Remove(chkAnchoas.Text);
                obj.Subtotal -= 10;
            }
        }

        private void chkHongos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHongos.Checked)
            {
                lstPizza.Items.Add(chkHongos.Text);
                obj.Subtotal += 10;
            }
            else
            {
                lstPizza.Items.Remove(chkHongos.Text);
                obj.Subtotal -= 10;
            }
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepperoni.Checked)
            {
                lstPizza.Items.Add(chkPepperoni.Text);
                obj.Subtotal += 10;
            }
            else
            {
                lstPizza.Items.Remove(chkPepperoni.Text);
                obj.Subtotal -= 10;
            }
        }

        private void chkJamon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJamon.Checked)
            {
                lstPizza.Items.Add(chkJamon.Text);
                obj.Subtotal += 10;
            }
            else
            {
                lstPizza.Items.Remove(chkJamon.Text);
                obj.Subtotal -= 10;
            }
        }

        private void chkTocino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTocino.Checked)
            {
                lstPizza.Items.Add(chkTocino.Text);
                obj.Subtotal += 10;
            }
            else
            {
                lstPizza.Items.Remove(chkTocino.Text);
                obj.Subtotal -= 10;
            }
        }

        private void chkQueso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueso.Checked)
            {
                lstPizza.Items.Add(chkQueso.Text);
                obj.Subtotal += 15;
            }
            else
            {
                lstPizza.Items.Remove(chkQueso.Text);
                obj.Subtotal -= 15;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtSub.Text = obj.Subtotal.ToString("0.00");
            txtISV.Text = obj.Calculo_Isv().ToString("0.00");
            txtTotal.Text = obj.Calculo_Total().ToString("0.00");
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            lstPizza.Items.Clear();
            rdbPequeña.Checked = false;
            rdbMediana.Checked = false;
            rdbGrande.Checked = false;
            cmbMasa.SelectedIndex = -1;
            chkAnchoas.Checked = false;
            chkHongos.Checked = false;
            chkPepperoni.Checked = false;
            chkJamon.Checked = false;
            chkTocino.Checked = false;
            chkQueso.Checked = false;
            txtSub.Clear();
            txtISV.Clear();
            txtTotal.Clear();
        }
    }
}
