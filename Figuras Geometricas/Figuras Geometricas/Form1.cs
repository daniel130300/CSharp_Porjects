using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCirculo.Checked)
            {
                FrmCirculo Frmcirculo = new FrmCirculo();

                DialogResult ResultadoCirculo = Frmcirculo.ShowDialog();

                if (ResultadoCirculo == DialogResult.OK)
                {
                    Circulo circulo = new Circulo();
                    circulo.Radio = Frmcirculo.Rad;
                }

                if (ResultadoCirculo == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbCirculo.Checked = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRectangulo.Checked)
            {

                FrmRectangulo Frmrectangulo = new FrmRectangulo();

                DialogResult ResultadoRectangulo = Frmrectangulo.ShowDialog();

                if (ResultadoRectangulo == DialogResult.OK)
                {
                    Rectangulo rectangulo = new Rectangulo();
                    rectangulo.Altura = Frmrectangulo.Alt;
                    rectangulo.Bas = Frmrectangulo.Bas;
                }

                if (ResultadoRectangulo == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbRectangulo.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            FrmTriangulo Frmtriangulo = new FrmTriangulo();

            DialogResult ResultadoTriangulo = Frmtriangulo.ShowDialog();

            if (ResultadoTriangulo == DialogResult.OK)
            {
                Triangulo triangulo = new Triangulo();
                triangulo.Nombre = Frmtriangulo.Nombre;
            }

            if (ResultadoTriangulo == DialogResult.Cancel)
            {
                MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdbTriangulo.Checked = false;
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {

            if (rdbCirculo.Checked)
            {
                Circulo circulo = new Circulo();

                MessageBox.Show("El area del circulo es: " + circulo.Calculo_Area(), "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rdbRectangulo.Checked)
            {
                Rectangulo rectangulo = new Rectangulo();
                MessageBox.Show("El area del rectangulo es: " + rectangulo.Calculo_Area(), "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rdbTriangulo.Checked == true)
            {
                FrmTriangulo Frmtriangulo = new FrmTriangulo();

                if (Frmtriangulo.Nombre == "Equilatero")
                {
                    Equilatero equilatero = new Equilatero(Frmtriangulo.Lado);
                    MessageBox.Show(equilatero.Area(), "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Frmtriangulo.Nombre == "Escaleno")
                {
                    Escaleno escaleno = new Escaleno(Frmtriangulo.Bas, Frmtriangulo.Altura);
                    MessageBox.Show(escaleno.Area(), "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Frmtriangulo.Nombre == "Isosceles")
                {
                    Isosceles isosceles = new Isosceles(Frmtriangulo.Lado, Frmtriangulo.Bas);
                    MessageBox.Show(isosceles.Area(), "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            rdbTriangulo.Checked = false;
            rdbRectangulo.Checked = false;
            rdbCirculo.Checked = false;
        }
    }
}
