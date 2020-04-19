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
        public void Selection()
        {
            string commandText = "Select * from Person";
            SqlCommand command = new SqlCommand(commandText, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"ID:{reader.GetValue(0)}\nLast Name:{reader.GetValue(1)}\nFirst Name:{reader.GetValue(2)}\nMiddle Name:{reader.GetValue(3)}");
            } 
        }
        public void Insert (string lastName, string firstName, string middleName, int dateOfBirth)
        {
            string insertingSqlCommand = string.Format($"insert into Person([Last_Name],[First_Name],[Middle_Name], [Birth_date]) values ('{lastName}','{firstName}','{middleName}',{dateOfBirth})");
            
            SqlCommand command = new SqlCommand(insertingSqlCommand,con);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                System.Console.WriteLine("Insert command successfull!!!");
            }
        }

    }
}