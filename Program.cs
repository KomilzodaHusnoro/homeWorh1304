using System;
using System.Data;
using System.Data.SqlClient;

namespace msql
{
    class Program
    {
        static void Main(string[] args)
        {
            const string conString = @"Data Source= localhost; Initial Catalog= phones; user id=sa; password=Root123.";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                System.Console.WriteLine("Connected!");
            }
        }

    }
}
