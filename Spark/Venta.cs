using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Spark
{
    public partial class Venta : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        int posicion;

        public Venta()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void LeeDatos()
        {
            try
            {
                SqlCommand comm = new SqlCommand("SELECT Nombre_Producto, Cantidad_Producto, Precio FROM Almacen1 ORDER BY Nombre_Producto", Global.conexion);


                dataAdapter = new SqlDataAdapter(comm);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingsource1.DataSource = table;
                dataGridView1.AutoResizeColumns();

            }
            catch (SqlException)
            {

                MessageBox.Show("Error al acceder a la base de datos", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu formmenu = new Menu();
            this.Hide();
            formmenu.Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Inventario invent = new Inventario();
            invent.Show();
        }



        private void Venta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingsource1;
            LeeDatos();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Calculadora calcu = new Calculadora();
            calcu.Show();
        }

        private void txt_nombre_eliminar_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM Almacen1 WHERE Nombre_Producto like ('" + txt_nombre_eliminar.Text + "%')", Global.conexion);
            comm.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            txt_nombre_eliminar.Text = dataGridView1[0, posicion].Value.ToString();
            txt_total.Text = dataGridView1[2, posicion].Value.ToString();
            txt_cantidad.Text = dataGridView1[1, posicion].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txt_total.Text.Length == 0)
            {
                MessageBox.Show("Verifique que previamente haya seleccionado un producto", "Ventas - Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                caja fcaja = new caja();

                fcaja.txt_caja.Text = txt_cantidad.Text;
                fcaja.txt_total.Text = txt_total.Text;
                fcaja.Show();
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeeDatos();
            txt_total.Text = "";
            txt_cantidad.Text = "";
            txt_nombre_eliminar.Text = "";
        }

        private void Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
