﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenEsdrasPerdomo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rentasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDRentas1DataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDRentas1DataSet.Rentas' table. You can move, or remove it, as needed.
            this.rentasTableAdapter.Fill(this.bDDRentas1DataSet.Rentas);

        }

        private void id_rentaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
