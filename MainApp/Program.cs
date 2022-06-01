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

            sqlData.Main(null);

            string p = excelData.path;

            DataSet? dataSet_ExcelData = excelData.GetDataSetFromExcelFile(p);
            DataTable? dataTable_ExcelData = Technical.ConvertDataSetToDatatable(dataSet_ExcelData);

            //Technical.ShowConsoleOutput(dataTable_ExcelData);

            //dataSample = outputHTML.dataSample();
            //outputHTML.GetHtmlOutput(dataSample);


            outputHTML.GetHtmlOutput(dataTable_ExcelData);

            Console.WriteLine();





            Console.WriteLine();
            Console.WriteLine("Enter any key to exit !");
            Console.ReadKey();
        }
    }

}


