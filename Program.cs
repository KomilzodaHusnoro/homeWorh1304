using System;
using System.Data;
using System.Data.SqlClient;

namespace msql
{
    class Program
    {
        static void Main(string[] args)
        {
         PersonDB editor = new PersonDB();
         editor.CheckingConnection();
         editor.OpenConnecting();
         editor.CloseConnecting();
        }

    }
}
