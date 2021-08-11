using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPEK_Przegladarka_komunikatow
{
    static class Global
    {




        //string Connectthestring = null;
        //string sql = null;
        public static SqlConnection connection = null;
        public static DataTable ExecSQL(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);            
            da.Fill(dt);
            return dt;
            
        }
        //SqlCommand command;
        //SqlDataReader dataReader;
        //public static DataTable ExecSQL(string sql)
        //{
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter da = new MySqlDataAdapter();
        //    da.SelectCommand = new MySqlCommand(sql, connection);
        //    da.Fill(dt);
        //    return dt;
        //}

        //public static void ExecQuery(SqlCommand sql)
        //{
            
        //    command.ExecuteReader();
        //}

        //try
        //{
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);

        //    command.ExecuteReader();

        //    //dataReader = command.ExecuteReader();
        //    //while (dataReader.Read())
        //    //{

        //    //}
        //    //dataReader.Close();
        //    command.Dispose();
        //    MessageBox.Show("OK");
        //    connection.Close();

        //}
        //catch (Exception)
        //{
        //    MessageBox.Show("blad");
        //}





    }
}
