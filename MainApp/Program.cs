using System.Data;


using Model;

/*******************************************************************************************************************\
*                    
                     DZ220530 - DataTransfer

                     Version : 1.2
                     Release : June 5/2022
                    
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
            string htmlExcelSchema;
            string htmlExcelData;
                     
            string htmlSqlSchema;
            string htmlSqlData;

            string dataTableName = "someInfo";

            string Path = @"Book2.xlsx";

            Model.outputHTML mainLib = new Model.outputHTML();
            Model.excelData excelData = new Model.excelData();
            Model.sqlData sqlData = new Model.sqlData();
            Model.TableSchema tableSchema = new Model.TableSchema();


            DataTable? dataTable_ExcelData = excelData.ExcelSheetGetDt(Path);
            htmlExcelSchema = outputHTML.GetHtmlColumns(dataTable_ExcelData);
            File.WriteAllText(Path + "_Schema.html", htmlExcelSchema);

            htmlExcelData = outputHTML.GetHtmlOutput(dataTable_ExcelData);
            File.WriteAllText(Path + "_Output.html", htmlExcelData);



            DataTable? dataTable_Sql = sqlData.GetDbTableSql(dataTableName);
            htmlSqlSchema = outputHTML.GetHtmlColumns(dataTable_Sql);
            File.WriteAllText(dataTableName + "_Schema.html", htmlSqlSchema);

            htmlSqlData = outputHTML.GetHtmlOutput(dataTable_Sql);
            File.WriteAllText(dataTableName + "_Output.html", htmlSqlData);

            dataTableName = "C#table";
            string htmlNewSqlData;

            DataTable? newDataTable_Sql = sqlData.GetDbTableSql(dataTableName);
            htmlSqlSchema = outputHTML.GetHtmlColumns(newDataTable_Sql);
            File.WriteAllText(dataTableName + "_Schema.html", htmlSqlSchema);

            htmlNewSqlData = outputHTML.GetHtmlOutput(newDataTable_Sql);
            File.WriteAllText(dataTableName + "_Output.html", htmlNewSqlData);


            string newDataTableName = "tete";
            sqlData.CreationDT(newDataTableName);





            Console.WriteLine();
            Console.WriteLine("Enter any key to exit !");
            Console.ReadKey();

        }
    }

}


