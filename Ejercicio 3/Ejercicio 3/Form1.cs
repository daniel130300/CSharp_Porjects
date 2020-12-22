using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculo_costo obj = new Calculo_costo();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            obj.peso = int.Parse(txtPeso.Text);
            txtCosto.Text = obj.Calculo_peso().ToString("0.00");
        }
    }
}
