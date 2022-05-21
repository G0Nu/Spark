using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spark
{
    public partial class Calculadora : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ".";

        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Text = "";
                operacion = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("No puso ningun valor");

            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Text = "";
                operacion = 2;
            }
            catch (Exception)
            {
                MessageBox.Show("No puso ningun valor");

            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Text = "";
                operacion = 3;
            }
            catch (Exception)
            {
                MessageBox.Show("No puso ningun valor");
                
            }

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            //boton igual 
            try
            {



                valor2 = Convert.ToDouble(tbDisplay.Text);
                switch (operacion)
                {
                    case 1:
                        resultado = valor1 + valor2;
                        break;
                    case 2:
                        resultado = valor1 - valor2;
                        break;
                    case 3:
                        resultado = valor1 * valor2;
                        break;
                    case 4:
                        resultado = valor1 / valor2;
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No puso ningun valor");
            }

            tbDisplay.Text = resultado.ToString();

        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Text = "";
                operacion = 4;
            }
            catch (Exception)
            {
                MessageBox.Show("No puso ningun valor");

            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }
    }
}
