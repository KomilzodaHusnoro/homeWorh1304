using System;
using System.Data;
using System.Data.SqlClient;
namespace msql
{
    class PersonDB
    {
        const string conString = @"Data Source= localhost; Initial Catalog = phones; user id= sa; password=Root123.";
        SqlConnection con = new SqlConnection(conString);


        public void CheckingConnection()
        {
        if (con.State == ConnectionState.Open)
            {
                System.Console.WriteLine("Connected successfully!!!");
            }else{
                System.Console.WriteLine("Ooops, troubles with connection!!!");
            } 
        }
        public void OpenConnecting ()
        {
            con.Open();
            System.Console.WriteLine("db is connected!");
        }
        public void CloseConnecting()
        {
            con.Close();
            System.Console.WriteLine("db is closed!");
        }
    }
}