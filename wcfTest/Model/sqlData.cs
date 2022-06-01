using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Model
{
    public class sqlData
    {

        public static async Task Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFT;Integrated Security=True";
            //SqlConnection ? connection = new SqlConnection(@"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERDRAFTS;Integrated Security=True");

            SqlDataAdapter adapter = new SqlDataAdapter();

            string SqlQuery = $"select * from dbo.someInfo";





            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();
                command.CommandText = SqlQuery;
                command.Connection = connection;
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync()) // 
                {
                    object id = reader.GetValue(0);
                    object name = reader.GetValue(2);
                    object age = reader.GetValue(1);

                    Console.WriteLine($"{id} \t{name} \t{age}");
                }

            }

            

        }

//public void openConnection()
//        {
//            if (connection.State == System.Data.ConnectionState.Closed)
//            {
//                connection.Open();
//            }
//        }

//        public void closeConnection()
//        {
//            if (connection.State == System.Data.ConnectionState.Open)
//            {
//                connection.Close();
//            }
//        }

//        public SqlConnection getConnection()
//        {
//            return connection;
//        }
    }
}
