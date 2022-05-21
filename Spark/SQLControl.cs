using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Spark
{
    
    class SQLControl
    {

        SqlConnection cnn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Spark;Integrated Security=True");
        public int Login(string usuario, string pass)
        {
            try
            {
                cnn.Open();
                

                SqlCommand cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        } 

    }
}
