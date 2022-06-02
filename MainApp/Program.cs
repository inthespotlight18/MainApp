using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.IO;
using System.Data.SqlClient;


using Model;

/*******************************************************************************************************************\

*                                                                                                                *

\*******************************************************************************************************************/
namespace MainApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Model.outputHTML mainLib = new Model.outputHTML();
            Model.excelData excelData = new Model.excelData();
            Model.Technical Technical = new Model.Technical();
            Model.sqlData sqlData = new Model.sqlData();

            string p = excelData.path;

            DataSet? dataSet_ExcelData = excelData.GetDataSetFromExcelFile(p);
            DataTable? dataTable_ExcelData = Technical.ConvertDataSetToDatatable(dataSet_ExcelData);

            //dataSample = outputHTML.dataSample();



/*******************************************************************************************************************\

*           Functions below get data from different sources and turn it in HTML code   (3 ways)                     *
*                   Uncomment commands below. You may have to change your SqlConnectionString for using sqlData     *

\*******************************************************************************************************************/

            //outputHTML.GetHtmlOutput(dataSample);              //  - manual
            //outputHTML.GetHtmlOutput(dataTable_ExcelData);    //  - excel
            //outputHTML.GetHtmlOutput(sqlData.GetSqlDT());    // - SqlServer


            Console.WriteLine();





            Console.WriteLine();
            Console.WriteLine("Enter any key to exit !");
            Console.ReadKey();
        }
    }

}


