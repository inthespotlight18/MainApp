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
            Model.MainLib mainLib = new Model.MainLib();
            Model.damTest damTest = new Model.damTest();

            Model.MainLib.GetSomeOutput();

            Console.WriteLine();





            Console.WriteLine();
            Console.WriteLine("Enter any key to exit !");
            Console.ReadKey();
        }
    }

}


