using System.Data;


using Model;

/*******************************************************************************************************************\
*                    
                     DZ220530 - DataTransfer

                     Version : 1.2
                     Release : June 3/2022
                    
                     Re : Practice code for DLL                                                                     
                     Update : fixed bug for building
                                                                                                                    *
\*******************************************************************************************************************/
namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string html;
            string Path = @"\MainApp\MainApp\test.xlsx";
            
            Model.outputHTML mainLib = new Model.outputHTML();
            Model.excelData excelData = new Model.excelData();
            Model.sqlData sqlData = new Model.sqlData();


            DataTable? dataTable_ExcelData = excelData.ExcelSheetGetDt(Path);
            //DataTable? dataTable_Sql = sqlData.GetDbTableSql();

            html = outputHTML.GetHtmlOutput(dataTable_ExcelData);    //  - excel
            //html = outputHTML.GetHtmlOutput(dataTable_Sql);         // - SqlServer

            File.WriteAllText("mydzout.html", html);

            Console.WriteLine();
            Console.WriteLine("Enter any key to exit !");
            Console.ReadKey();
        }
    }

}


