using System.Data;
using System.Data.SqlClient;


namespace Model
{
    public class sqlData
    {
        public static DataTable GetDbTableSql(string DataTableName)
        {
            string connectionString = @"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFT;Integrated Security=True";
            string sql = $"select * from dbo."+DataTableName;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                return ds.Tables[0];              
            }

        }

        public static void CreationDT(string nameDT)
        {
            //string query = $"select * from dbo." + nameDT;

            SqlConnection myConn = new SqlConnection(@"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFT;Integrated Security=True");

            string str = "CREATE TABLE " + nameDT +
            "(myId INTEGER CONSTRAINT PKeyMyId PRIMARY KEY," +
            "myName CHAR(50), myAddress CHAR(255), myBalance FLOAT)";
            

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("DataBase is Created Successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString(), "MyProgram");
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }


        }

    }

}


