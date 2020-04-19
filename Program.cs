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
         System.Console.WriteLine("Push *1* --> to add information \nPush *2* --> to see db \n Your choise:");
         int choise = int.Parse(Console.ReadLine());
         switch (choise)
         {
             case 1:
            System.Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            System.Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            System.Console.WriteLine("Enter Middle Name: ");
            string middleName = Console.ReadLine();
            System.Console.WriteLine("Enter date of birth: ");
            int dateOfBirth = int.Parse(Console.ReadLine());
                editor.Insert(lastName,
                              firstName,
                              middleName,
                              dateOfBirth);
             break;
             case 2:
                editor.Selection();
             break;
         }
         editor.CloseConnecting();
        }

    }
}
