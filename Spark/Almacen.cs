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
    public partial class Almacen : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        int posicion;
        public Almacen()
        {


            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            lblagregar.Show();
            lbleditar.Hide();
            lbleliminar.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            lbleditar.Show();
            lblagregar.Hide();
            lbleliminar.Hide();
            LeeDatos();
            
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            lbleditar.Hide();
            lbleliminar.Hide();
            dataGridView1.DataSource = bindingsource1;
            dataGridView2.DataSource = bindingsource1;
            LeeDatos();
        }
        private void LeeDatos()
        {
            try
            {
                SqlCommand comm = new SqlCommand("SELECT Nombre_Producto, Nombre_Proveedor, Cantidad_Producto, Capacidad, Ubicacion, Fecha, Precio FROM Almacen1 ORDER BY Nombre_Producto", Global.conexion);


                dataAdapter = new SqlDataAdapter(comm);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingsource1.DataSource = table;



            }
            catch (SqlException)
            {

                MessageBox.Show("Error al acceder a la base de datos", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Tabla actualizada con éxito", "Almacén",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede actualizar los datos, revise que todos los campos sean correctos","Almacen- Editar", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
        public bool IsNumeric(string input)
        {
            float test;
            return float.TryParse(input, out test);
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }//&& 
            else if (txt_Cantidad.Text.Length == 0 || !IsNumeric(txt_Cantidad.Text))
            {
                MessageBox.Show("Asegurese que haya ingresado todos los datos o que sean de tipo numerico(Cantidad).", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//&& 
            else if (txt_precio.Text.Length == 0 || !IsNumeric(txt_precio.Text))
            {
                MessageBox.Show("Asegurese que haya ingresado todos los datos o que sean de tipo numerico(Precio).", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Capacidad.Text.Length == 0 || !IsNumeric(txt_Capacidad.Text))
            {
                MessageBox.Show("Asegurese que haya ingresado todos los datos o que sean de tipo numerico(Capacidad).", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Proveedor.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Ubicacion.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Fecha.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos.", "Almacen - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //falta fechas y revisar porque no registra

                string sql = "INSERT INTO Almacen1 (Nombre_Producto, Nombre_Proveedor, Cantidad_Producto, Capacidad, Ubicacion, Fecha, Precio) VALUES (@nombre,@nombrepro,@cantidad,@capacidad,@ubicacion,@fecha,@precio)"; 
                SqlCommand comando = new SqlCommand(sql, Global.conexion);
                comando.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                comando.Parameters.AddWithValue("@nombrepro", txt_Proveedor.Text);
                comando.Parameters.AddWithValue("@cantidad", txt_Cantidad.Text);
                comando.Parameters.AddWithValue("@capacidad", txt_Capacidad.Text);
                comando.Parameters.AddWithValue("@ubicacion", txt_Ubicacion.Text);
                comando.Parameters.AddWithValue("@fecha", txt_Fecha.Text);
                comando.Parameters.AddWithValue("@precio", txt_precio.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto agregado y guardado con éxito", "Almacén", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txt_nombre.Text + "','" + txt_Cantidad.Text + "','" + txt_Capacidad.Text + "','" + txt_Ubicacion.Text + "
                txt_Cantidad.Text = "";
                txt_Capacidad.Text = "";
                txt_Fecha.Text = "";
                txt_nombre.Text = "";
                txt_Proveedor.Text = "";
                txt_Ubicacion.Text = "";
                txt_precio.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Cantidad.Text = "";
            txt_Capacidad.Text = "";
            txt_Fecha.Text = "";
            txt_nombre.Text = "";
            txt_Proveedor.Text = "";
            txt_Ubicacion.Text = "";
            txt_precio.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            /*string eliminar = "delete datos where nombre = " +txt_Cantidad ;
            if (.executecommand(eliminar))
            {
                MessageBox.Show("Se ha eliminado correctamente")
            }
            else
            {
                MessageBox.Show("Error al eliminar");
                
            } */
        }

        private void btn_eliminar_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView2.Rows.RemoveAt(posicion);
            try
            {
                SqlCommand comm = new SqlCommand("DELETE FROM Almacen1 WHERE Nombre_Producto = '" + txt_nombre_eliminar.Text+"'", Global.conexion);
                comm.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView2.CurrentRow.Index;
            txt_nombre_eliminar.Text = dataGridView2[0, posicion].Value.ToString();
            btn_eliminar.Enabled = true;
        
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_nombre_eliminar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM Almacen1 WHERE Nombre_Producto like ('" + txt_nombre_eliminar.Text + "%')", Global.conexion);
            comm.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeeDatos();

        }

        private void Almacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
