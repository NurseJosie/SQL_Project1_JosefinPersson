using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Project1_JosefinPersson
{
    class Menu
    {
        public void mainMenu()
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("Ange ett nummeralternativ för att få svar på frågor om databasen...");
                Console.WriteLine("1) Hur många länder finns representerade?");
                Console.WriteLine("2) Är alla username och password unika?");
                Console.WriteLine("3) Hur många är från Norden respektive Skandinavien?");
                Console.WriteLine("4) Vilket är det vanligaste landet?");
                Console.WriteLine("5) Lista de 10 första användarna vars förnamn börjar på bokstaven L.");
                Console.WriteLine("6) Visa alla användare vars för- och efternamn har samma begynnelsebokstav.");
                Console.WriteLine("7) Exit");

                string userInput = Console.ReadLine();
                int input = 0;
                int.TryParse(userInput, out input);

                switch (input)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Ange en siffra mellan 1-7.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
