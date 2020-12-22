using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucursales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Java: 200
        //C#: 150
        //PHP: 250
        //Visual: 100

        Calculos obj = new Calculos();

        int cursos = 0;
        string sucursal="";

        private void button1_Click(object sender, EventArgs e)
        {
            txtSub.Text = string.Concat("Lps.", obj.Subtotal.ToString("0.00"));
            txtDescuento.Text = string.Concat("Lps.", obj.Calculo_descuento().ToString("0.00"));
            txtISV.Text = string.Concat("Lps.", obj.Calculo_ISV().ToString("0.00"));
            txtTotal.Text = string.Concat("Lps.", obj.Calculo_Total().ToString("0.00"));
            MessageBox.Show(txtNombre.Text + " esta cursando " + cursos + " clases en la sucursal del " + sucursal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            chkJava.Checked = false;
            chkVisual.Checked = false;
            chkC.Checked = false;
            chkPHP.Checked = false;
            rdbCentro.Checked = false;
            rdbMulti.Checked = false;
            rdbCity.Checked = false;
            rdbNinguno.Checked = false;
            rdbEmpleado.Checked = false;
            rdbCliente.Checked = false;
            txtSub.Clear();
            txtDescuento.Clear();
            txtISV.Clear();
            txtTotal.Clear();
            txtNombre.Focus();
        }

        private void rdbJava_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void rdbC_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void rdbPHP_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void rdbVisual_CheckedChanged(object sender, EventArgs e)
        {
   

        }

        private void rdbNinguno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNinguno.Checked)
            {
                obj.Descuento = 0;
            }
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                obj.Descuento = 0.10;
            }
        }

        private void rdbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEmpleado.Checked)
            {
                obj.Descuento = 0.15;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbCentro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCentro.Checked)
            {
                sucursal = "Centro";
            }
        }

        private void rdbCity_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCity.Checked)
            {
                sucursal = "City Mall";
            }
        }

        private void rdbMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMulti.Checked)
            {
                sucursal = "Multiplaza";
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISV_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkJava_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJava.Checked)
            {
                obj.Subtotal += 200;
                cursos++;
            }
            else
            {
                obj.Subtotal -= 200;
                cursos--;
            }
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC.Checked)
            {
                obj.Subtotal += 150;
                cursos++;
            }
            else
            {
                obj.Subtotal -= 150;
                cursos--;
            }
        }

        private void chkPHP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPHP.Checked)
            {
                obj.Subtotal += 250;
                cursos++;
            }
            else
            {
                obj.Subtotal -= 250;
                cursos--;
            }
        }

        private void chkVisual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisual.Checked)
            {
                obj.Subtotal += 100;
                cursos++;
            }
            else
            {
                obj.Subtotal -= 100;
                cursos--;
            }
        }
    }
}
