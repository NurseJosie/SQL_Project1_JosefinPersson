using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Project1_JosefinPersson
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------meny------------------
            
            Menu menu = new(); // instansierar menyn
            menu.mainMenu(); // kör mainmenu .......... dubbelkolla senare......

            //-------------databas--------------
            Console.WriteLine("ange ett namn...");
            var input = Console.ReadLine();

            var sql = "SELECT first_name, last_name FROM MOCK_DATA WHERE first_name LIKE @param";  //skriver param istället för input(säkrare, kan bli av med data annars), (sql injection..., drop datatable...)
            var dt = GetDataTable(sql, "@param", "%" + input + "%");
            PrintRow(dt);

            // ska läggas in i metoder/ i switchen för respektive fråga



        }
    }
}