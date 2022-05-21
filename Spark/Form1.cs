using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spark
{
    public partial class Form1 : Form
    {
        SQLControl sqlControl = new SQLControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();
            con.DataSource = "(local)\\SQLEXPRESS";
            con.InitialCatalog = "Spark";
            con.IntegratedSecurity = true;
            Global.conexion = new SqlConnection(con.ConnectionString);
            Global.conexion.Open();

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            int result = sqlControl.Login(txtUsuario.Text, txtPassword.Text);

            if (result == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();

            }
            else if(result == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectas.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
