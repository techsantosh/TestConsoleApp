using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //test comment tttttttttttttt
            string connectionString = @"Provider=PostgreSQL OLE DB Provider;Data Source=192.10.44.97;location=RPM;User ID=postgres;password=Pass@123;";//"Provider=PostgreSQL OLE DB Provider;Server=192.10.44.97;Database=RPM;User=postgres;Password=Pass@123;";

            string queryString = "select * from Public.\"HOCUser\"";
         
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Insert code to process data.
                    }
                    reader.Close();
                }
          

                //Comments by Santoshji Phape Saheb
            Console.WriteLine("Done!!!");
            Console.ReadKey();
        }
    }
}
