using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasificacion.Text == "Mamífero")
            {

            }

            if (cmbClasificacion.Text == "Ave")
            {
                Aves ave = new Aves();
                ave.Show();
            }

            if (cmbClasificacion.Text == "Insecto")
            {
                Insectos insec = new Insectos();
                insec.Show();
            }
        }
    }
}
