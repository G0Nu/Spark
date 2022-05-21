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
    public partial class Proveedores : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        int posicion;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lbleliminar.Show();
            lblagregar.Hide();
            lbleditar.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            lbleliminar.Hide();
            lblagregar.Show();
            lbleditar.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            lbleliminar.Hide();
            lblagregar.Hide();
            lbleditar.Show();
            LeeDatos();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
           
            lbleditar.Hide();
            lbleliminar.Hide();
            dataGridView1.DataSource = bindingsource1;
            dataGridView2.DataSource = bindingsource1;
            LeeDatos();
        }
        public bool IsNumeric(string input)
        {
            float test;
            return float.TryParse(input, out test);
        }
        private void LeeDatos()
        {
            try
            {
                SqlCommand comm = new SqlCommand("SELECT Nombre_Proveedor, Telefono, Correo, Direccion, Nombre_Producto FROM Proveedores ORDER BY Nombre_Proveedor", Global.conexion);


                dataAdapter = new SqlDataAdapter(comm);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingsource1.DataSource = table;
                dataGridView1.AutoResizeColumns();
                dataGridView2.AutoResizeColumns();



            }
            catch (SqlException)
            {

                MessageBox.Show("Error al acceder a la base de datos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Proveedores - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }//&& 
            else if (txt_telefono.Text.Length == 0 || !IsNumeric(txt_telefono.Text))
            {
                MessageBox.Show("Asegurese que haya ingresado todos los datos o que sean de tipo numerico(Telefono).", "Proveedores - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
            }//&& 
            else if (txt_Producto.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Proveedores - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Producto.Focus();
            }
            else if (txt_Direccion.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Proveedores - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Direccion.Focus();
            }
            else if (txt_correo.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Proveedores - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_correo.Focus();
            }
            else
            {
                //falta fechas y revisar porque no registra

                string sql = "INSERT INTO Proveedores (Nombre_Proveedor, Telefono, Correo, Direccion, Nombre_Producto) VALUES (@nombre,@telefono,@correo,@direccion,@nombrepro)"; //@fecha
                SqlCommand comando = new SqlCommand(sql, Global.conexion);
                comando.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                comando.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                comando.Parameters.AddWithValue("@correo", txt_correo.Text);
                comando.Parameters.AddWithValue("@direccion", txt_Direccion.Text);
                comando.Parameters.AddWithValue("@nombrepro", txt_Producto.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor agregado y guardado con éxito", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txt_nombre.Text + "','" + txt_Cantidad.Text + "','" + txt_Capacidad.Text + "','" + txt_Ubicacion.Text + "
          
                txt_Producto.Text = "";
                txt_correo.Text = "";
                txt_nombre.Text = "";
                txt_telefono.Text = "";
                txt_Direccion.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Producto.Text = "";
            txt_correo.Text = "";
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            txt_Direccion.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LeeDatos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                dataAdapter.Update((DataTable)bindingsource1.DataSource);
                MessageBox.Show("Tabla actualizada con éxito", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede actualizar los datos, revise que todos los campos sean correctos", "Almacen- Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(posicion);
            try
            {
                SqlCommand comm = new SqlCommand("DELETE FROM Proveedores WHERE Nombre_Proveedor = '" + txt_nombre_eliminar.Text + "'", Global.conexion);
                comm.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_nombre_eliminar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM Proveedores WHERE Nombre_Proveedor like ('" + txt_nombre_eliminar.Text + "%')", Global.conexion);
            comm.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView2.CurrentRow.Index;
            txt_nombre_eliminar.Text = dataGridView2[0, posicion].Value.ToString();
            btn_eliminar.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeeDatos();

        }

        private void Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
