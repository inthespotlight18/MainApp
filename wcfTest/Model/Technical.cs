using System.Data;


namespace Model
{
    public class Technical
    {
        public static void ShowConsoleOutput(DataTable dt)
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

        public static DataTable ConvertDataSetToDatatable(DataSet ds)
        {
            DataTable FirstDT = ds.Tables[0];
            return FirstDT;
        }


    }
}
