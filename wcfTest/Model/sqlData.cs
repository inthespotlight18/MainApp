using System.Data;
using System.Data.SqlClient;


namespace Model
{
    public class sqlData
    {
        public static DataTable GetDbTableSql()
        {
            string connectionString = @"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFT;Integrated Security=True";
            string sql = $"select * from dbo.someInfo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                return ds.Tables[0];              
            }

        }

    }

}


