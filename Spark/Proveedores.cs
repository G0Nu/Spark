﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spark
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}