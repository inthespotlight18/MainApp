using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace ModelLib
{
    public class MainLib
    {

        static void Main(string[] args)
        {
            damTest DT = new damTest();
            string file = @"\MainApp\MainApp\test.xlsx";

            var dataSet = damTest.GetDataSetFromExcelFile(file);

            Console.WriteLine(string.Format("reading file: {0}", file));
            Console.WriteLine(string.Format("coloums: {0}", dataSet.Tables[0].Columns.Count));
            Console.WriteLine(string.Format("rows: {0}", dataSet.Tables[0].Rows.Count));
            Console.ReadKey();


            DataTable dt = new DataTable();

            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Age", typeof(int));

            dt.Rows.Add("Gordon", "Simon", "gsimon@garnet.ca", 63);
            dt.Rows.Add("Daniil", "Zlenko", "dzlenko0922@gmail.com", 18);
            dt.Rows.Add("Bogdan", "Cerbulescu", "someemail@fghj.hjj", 35);

            //ShowConsoleOutput(dt);

            string html = GetHtmlOutput(dt);
            File.WriteAllText("mydzout.html", html);


            Console.WriteLine();
            Console.WriteLine("Enter any key to exit !");
            Console.ReadKey();
        }








        // SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-R94KE44G\SQLEXPRESS;Initial Catalog=USERSDRAFTS;Integrated Security=True");

        // SqlDataAdapter adapter = new SqlDataAdapter();

        // string sqlQuery = $"select * from dbo.someInfo";


        // public void openConnection()
        // {
        //     if(connection.State == System.Data.ConnectionState.Closed)
        //     {
        //         connection.Open();
        //     }
        // }

        // public void closeConnection()
        // {
        //     if(connection.State == System.Data.ConnectionState.Open)
        //     {
        //         connection.Close();
        //     }
        // }

        // public SqlConnection getConnection()
        // {
        //     return connection;
        // }





        /*******************************************************************************************************************\

   *                                                                                                                *

  \*******************************************************************************************************************/


        static void ShowConsoleOutput(DataTable dt)
        {

            foreach (DataColumn col in dt.Columns)
                Console.Write("{0} ", col.ColumnName);


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine();
                foreach (DataColumn col in dt.Columns)
                    Console.Write("{0} ", row[col.ColumnName]);
            }
            Console.WriteLine();

        }


        static string GetHtmlOutput(DataTable dt)
        {
            string html =

            @"
            <!DOCTYPE html>
            <html lang='en'>
            <html><head>

 

            <script type='text/javascript' language='javascript' src='https://code.jquery.com/jquery-3.5.1.js'></script>

            <link rel='stylesheet' type='text/css' href='https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css'/>

            <script type='text/javascript' src='https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js'></script>

 

            <script type='text/javascript' class='init'>

                $(document).ready(function () 
                {
                    $('#result').DataTable();
                });

            </script>

            </head>

            

            <h3>Site Show</h3>

                    <meta charset='UTF-8'>
                    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>


                <title>Database</title>

            </head>
            <body>

            ";


            html += "<table id='result' class='display' ><thead><tr>";
            foreach (DataColumn col in dt.Columns)
            {
                //Console.WriteLine(col.ColumnName);
                html += string.Format("<th>{0}</th> ", col.ColumnName);
            }
            html += "</tr></thead>";
            html +=
            "<tbody><tr>";



            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    html += string.Format("<td>{0}</td> ", row[col.ColumnName]);
                html += "</tr>";
            }
            html += "</tbody>";



            html += "<tfoot><tr>";
            foreach (DataColumn col in dt.Columns)
            {
                //Console.WriteLine(col.ColumnName);
                html += string.Format("<th>{0}</th> ", col.ColumnName);
            }
            html += "</tr></tfoot>";




            html += "</table> </body></html>";

            return html;
        }












    }
}