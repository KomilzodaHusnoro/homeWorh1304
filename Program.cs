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
         start:
         System.Console.WriteLine("Push *1* --> to add information \nPush *2* --> to see db \nPush *3* --> to select by ID\nPush *4* --> to update ID\nPush *5* --> to delete ID \nYour choise:");
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
            string dateOfBirth = Console.ReadLine();
                editor.Insert(lastName,
                              firstName,
                              middleName,
                              dateOfBirth);
             break;
             case 2:
                editor.Selection();
             break;
             case 3:
             System.Console.WriteLine("Enter ID: ");
             int idselect = int.Parse(Console.ReadLine());
             editor.SelectionById(idselect);
             break;
             case 4:
             System.Console.WriteLine("Enter ID yoy want to update: ");
             int inputId = int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter new Last Name: ");
             string lastName2 = Console.ReadLine();
             System.Console.WriteLine("Enter new First Name: ");
             string firstName2 = Console.ReadLine();
             System.Console.WriteLine("Enter new Middle Name: ");
             string middleName2 = Console.ReadLine();
             System.Console.WriteLine("Enter new date of birth: ");
             string dateOfBirth2 = Console.ReadLine();
             editor.UpdateById(inputId, lastName2, firstName2, middleName2, dateOfBirth2);
             break;
             case 5:
                System.Console.WriteLine("Enter ID you want to delete: ");
                int deleteId = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Are you sure? This ID and all infotmation will be deleted!");
                string choise3 = Console.ReadLine().ToLower();
                switch (choise3)
                {
                    case "yes":
                    editor.DeleteId(deleteId);
                    break;
                    case "no":
                    goto start;
                }

             break;
         }
         editor.CloseConnecting();
        }

    }
}
