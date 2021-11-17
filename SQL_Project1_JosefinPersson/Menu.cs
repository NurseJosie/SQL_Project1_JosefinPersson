using System;
using System.Data;
using System.Data.SqlClient;

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
                        //SELECT COUNT(DISTINCT country)
                        //FROM MOCK_DATA
                                                                //svar: 122

                        break;
                    case 2:
                        //SELECT*
                        //FROM MOCK_DATA
                        //WHERE password = username                    inget lösen är detsamma som användarnamnet

                        //SELECT DISTINCT password                     alla är unika
                        //FROM MOCK_DATA

                        //SELECT DISTINCT username                     alla är unika
                        //FROM MOCK_DATA

                                                          // rätt? hur ska man visa resultatet?

                        break;
                    case 3:
                        //('Sweden', 'Denmark', 'Finland', 'Norway', 'Iceland', 'Greenland', 'Faroe Islands', 'Åland Islands') = norden
                        //('Sweden', 'Denmark', 'Norway') = skandinavien

                        //SELECT COUNT(country)            hur många som är från ETT visst land..... 
                        //FROM MOCK_DATA
                        //WHERE country = 'Sweden'

                        break;
                    case 4:
                        //SELECT country, COUNT(country) AS value_occurrence                                    funkar ej!!! fattar inte...
                        //FROM MOCK_DATA GROUP BY country ORDER BY value_occurrence DESC LIMIT 1;
                        break;
                    case 5:
                        //SELECT top 10 last_name
                        //FROM MOCK_DATA
                        //WHERE last_name LIKE 'L%'

                        break;
                    case 6:
                        //SELECT * 
                        //FROM MOCK_DATA
                        //WHERE UPPER(LEFT(first_name, 1)) = UPPER(LEFT(last_name, 1))


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
