using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spark
{
    public partial class caja : Form
    {
        
        public caja()
        {
            InitializeComponent();
        }

        private void caja_Load(object sender, EventArgs e)
        {
            

        }
        public bool IsNumeric(string input)
        {
            float test;
            return float.TryParse(input, out test);
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_caja.Text.Length == 0 || !IsNumeric(txt_caja.Text))
            {
                MessageBox.Show("Asegurese que haya ingresado todos los datos o que sean de tipo numerico(Cantidad).", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_caja.Text = "0";
            }
            else
            {

                int cantidad = int.Parse(txt_caja.Text);
                float precio = float.Parse(txt_total.Text);
                float total = precio * cantidad;
                this.Close();
                MessageBox.Show("Total = $" + total);
            }
            
        }
    }
}
