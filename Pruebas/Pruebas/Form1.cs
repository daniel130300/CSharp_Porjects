using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private System.Windows.Forms.TextBox AgregarTextbox() //Funcion para agregar un nuevo textbox
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = a * 100;
            txt.Left = 15;
            txt.Width = 300;
            txt.Text = "";
            a++;
            return txt;
        }

        private System.Windows.Forms.NumericUpDown AgregarNumeric()
        {
            NumericUpDown numUpDown = new NumericUpDown();
            this.Controls.Add(numUpDown);
            numUpDown.Top = a * 70;
            numUpDown.Left = 400;
            numUpDown.Width = 40;
            numUpDown.Minimum = 1;
            numUpDown.Maximum = 4;
            return numUpDown;
        }

        private System.Windows.Forms.Label AgregarLabel()
        {
            Label lbl = new Label ();
            this.Controls.Add(lbl);
            lbl.Top = a * 71;
            lbl.Left = 175;
            lbl.Text = "Cuantas opciones desea para esta pregunta: ";
            lbl.Width = 230;
            return lbl;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i =0; i<numUpDown.Value; i++)
            {
                AgregarTextbox();
                AgregarNumeric();
                AgregarLabel();
            }

            btnGenerar.Enabled = false;
        }


    }
}
