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
    public partial class Inventario : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public Inventario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Inventario_Load(object sender, EventArgs e)
        {
 
            dataGridView1.DataSource = bindingsource1;
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
                dataGridView1.AutoResizeColumns();


            }
            catch (SqlException)
            {

                MessageBox.Show("Error al acceder a la base de datos", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
