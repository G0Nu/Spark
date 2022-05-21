using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spark
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas ventas_form = new Ventas();
            this.Hide();
            ventas_form.Show();
            
        }

        private void btn_provedor_Click(object sender, EventArgs e)
        {
            Proveedores provedores_form = new Proveedores();
            this.Hide();
            provedores_form.Show();

        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {
            Almacen almacen_form = new Almacen();
            this.Hide();
            almacen_form.Show();
        }

        private void btn_cc_Click(object sender, EventArgs e)
        {
            Control_de_Calidad cc_form = new Control_de_Calidad();
            this.Hide();
            cc_form.Show();
        }
    }
}
