using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Peso_ideal obj = new Peso_ideal();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string msj = "";

            obj.Estatura = Convert.ToDouble(txtEstatura.Text);
            obj.Peso = Convert.ToDouble(txtPeso.Text);

            if (obj.Peso < obj.Calculo_peso())
                msj = "bajo peso";
            if (obj.Peso > obj.Calculo_peso())
                msj = "sobre peso";
            if (obj.Peso == obj.Calculo_peso())
                msj = "peso ideal";

            MessageBox.Show("Usted tiene: " + msj + " su peso ideal es: " + obj.Calculo_peso().ToString("0.00"), "Mensaje");

        }
    }
}
