using System.Data;

namespace Model
{
    public class TableSchema
    {

        static private string TableSchemaToHtml(DataTable dt)
        {
            string html = "<table>";

            html += "<tr><th>Name</th><th>Type</th><th>Size</th></tr>";
            
            foreach (DataColumn col in dt.Columns)
            {
                Console.WriteLine("name[{0}] type[{1}] sz[{2}]", col.ColumnName, col.DataType, "sz");
            }



            return html;
        }s
    }
}
