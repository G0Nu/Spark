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
    public partial class Control_de_Calidad : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        int posicion;
        public Control_de_Calidad()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void Control_de_Calidad_Load(object sender, EventArgs e)
        {
            lbleditar.Hide();
            lbleliminar.Hide();
            dataGridView1.DataSource = bindingsource1;
            dataGridView2.DataSource = bindingsource1;
            LeeDatos();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            lblagregar.Show();
            lbleditar.Hide();
            lbleliminar.Hide();
            LeeDatos();

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            lblagregar.Hide();
            lbleditar.Show();
            lbleliminar.Hide();
            LeeDatos();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblagregar.Hide();
            lbleditar.Hide();
            lbleliminar.Show();
            LeeDatos();

        }

        private void LeeDatos()
        {
            try
            {
                SqlCommand comm = new SqlCommand("SELECT Nombre_Producto, Bajas, Nombre_Proveedor, Descripcion FROM ControlCalidad ORDER BY Nombre_Producto", Global.conexion);


                dataAdapter = new SqlDataAdapter(comm);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingsource1.DataSource = table;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);


            }
            catch (SqlException)
            {

                MessageBox.Show("Error al acceder a la base de datos", "Control de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            this.Hide();
            menu.Show();
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
                MessageBox.Show("Se deben de ingresar todos los datos(Nombre del producto).", "Control de Calidad - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }//&& 
            else if (txt_Bajas.Text.Length == 0 || !IsNumeric(txt_Bajas.Text))
            {
                MessageBox.Show("Asegurese que haya ingresado todos los datos o que sean de tipo numerico(Bajas).", "Control de Calidad - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Bajas.Focus();
            }//&& 
            else if (txt_Proveedor.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos(Proveedor).", "Control de Calidad - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Proveedor.Focus();
            }
            else if (txt_Descripcion.Text.Length == 0)
            {
                MessageBox.Show("Se deben de ingresar todos los datos(Descripcion).", "Control de Calidad - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Descripcion.Focus();
            }

            else
            {
                

                string sql = "INSERT INTO ControlCalidad (Nombre_Producto, Bajas, Nombre_Proveedor, Descripcion ) VALUES (@nombre,@bajas,@proveedor,@descripcion)"; //@fecha
                SqlCommand comando = new SqlCommand(sql, Global.conexion);
                comando.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                comando.Parameters.AddWithValue("@bajas", txt_Bajas.Text);
                comando.Parameters.AddWithValue("@proveedor", txt_Proveedor.Text);
                comando.Parameters.AddWithValue("@descripcion", txt_Descripcion.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Baja registrada", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txt_nombre.Text + "','" + txt_Cantidad.Text + "','" + txt_Capacidad.Text + "','" + txt_Ubicacion.Text + "

                txt_Bajas.Text = "";
                txt_Descripcion.Text = "";
                txt_nombre.Text = "";
                txt_Proveedor.Text = "";
                LeeDatos();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LeeDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
            LeeDatos();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update((DataTable)bindingsource1.DataSource);
                MessageBox.Show("Tabla actualizada con éxito", "Control de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede actualizar los datos, revise que todos los campos sean correctos", "Control de calidad- Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(posicion);
            try
            {
                SqlCommand comm = new SqlCommand("DELETE FROM ControlCalidad WHERE Nombre_Producto = '" + txt_eliminar.Text + "'", Global.conexion);
                comm.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente", "Control de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar", "Control de Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView2.CurrentRow.Index;
            txt_eliminar.Text = dataGridView2[0, posicion].Value.ToString();
            btn_eliminar.Enabled = true;

        }

        private void txt_eliminar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM ControlCalidad WHERE Nombre_Producto like ('" + txt_eliminar.Text + "%')", Global.conexion);
            comm.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Bajas.Text = "";
            txt_Descripcion.Text = "";
            txt_nombre.Text = "";
            txt_Proveedor.Text = "";
        }

        private void Control_de_Calidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
