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
        public static SqlConnection connection = null;
        public static DataTable ExecSQL(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);            
            da.Fill(dt);
            return dt;            
        }        
    }
}
