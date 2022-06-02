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

        public static DataTable dt = new DataTable();
        public object DT 
        {
            get { return dt; }        
            set { DT = value; }        
        }
            



        Technical Technical = new Technical();

        public static void Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFT;Integrated Security=True";
            string sql = $"select * from dbo.someInfo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dt = Technical.ConvertDataSetToDatatable(ds);
                // DataFromSqlReader dataFromSqlReader = new DataFromSqlReader(firstName, lastName, age, email);


                foreach (DataTable dataTable in ds.Tables)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        Console.Write($"{column.ColumnName}\t");
                    }
                    
                    Console.WriteLine();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (var cell in cells)
                        {                        
                            Console.Write($"{cell}\t");
                            //var val = Convert.ToString(cell);
                            //dt.Columns.Add(val);
                        }                
                        Console.WriteLine();
                    }
                }              

            }
            
            Console.Read();
        }

        public static DataTable GetSqlDT()
        {
            Main(null);
             return dt;
        }


    }


}



//public static async Task Main(string[] args)
//{
//    string connectionString = @"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFT;Integrated Security=True";
//    //SqlConnection ? connection = new SqlConnection(
//    //      @"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERDRAFTS;Integrated Security=True");

//    SqlDataAdapter adapter = new SqlDataAdapter();

//    string SqlQuery = $"select * from dbo.someInfo";

//    List<DataFromSqlReader> data = new List<DataFromSqlReader>();



//    using (SqlConnection connection = new SqlConnection(connectionString))
//    {
//        await connection.OpenAsync();
//        SqlCommand command = new SqlCommand();
//        command.CommandText = SqlQuery;
//        command.Connection = connection;
//        SqlDataReader reader = await command.ExecuteReaderAsync();

//        while (await reader.ReadAsync()) // 
//        {
//            string firstName = reader.GetString(0);
//            string lastName = reader.GetString(1);
//            string age = reader.GetString(2);
//            string email = reader.GetString(3);


//            DataFromSqlReader dataFromSqlReader = new DataFromSqlReader(firstName, lastName, age, email);

//            data.Add(dataFromSqlReader);






//            Console.WriteLine($"{firstName} \t{lastName} \t{age} \t{email} " );
//        }


//    }
//    if (data.Count > 0)
//    {   
//            var obj = data[0];
//            if (obj != null)
//            {
//                dt.Columns.Add(obj.FirstName.ToString());
//                dt.Columns.Add(obj.LastName.ToString());
//                dt.Columns.Add(obj.Age.ToString());
//                dt.Columns.Add(obj.Email.ToString());

//            }                           
//    }
//    Technical.ShowConsoleOutput(dt);



//}

