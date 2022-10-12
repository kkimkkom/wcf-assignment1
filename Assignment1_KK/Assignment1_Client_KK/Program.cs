/* Program.cs
 * Class for the client side Console app
 * 
 * Revision History:
 *      Keum Ji Kim, 2022.10.11: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Client_KK
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionsReference.FunctionClient client = new FunctionsReference.FunctionClient();

            int answer = 0;
            string inputString = "";

            Console.WriteLine("\tWCF Assignment 1");
            Console.WriteLine();
            Console.WriteLine("\t\t8644646 ");
            Console.WriteLine("\t\tKeum Ji Kim");
            Console.WriteLine();
            
            while (answer != 6)
            {
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("\t Enter your choice: ");
                answer = Convert.ToInt32(Console.ReadLine());

                inputString = "";
                
                switch (answer)
                {
                    case 1:
                        Console.Write("Enter Number: ");
                        inputString = Console.ReadLine();
                        Console.WriteLine("\t\t" + client.IsPrimeNumber(inputString));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter Numbers: ");
                        inputString = Console.ReadLine();
                        Console.WriteLine("\t\t" + client.SumOfDigits(inputString));
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter String: ");
                        inputString = Console.ReadLine();
                        Console.WriteLine("\t\t" + client.ReverseAString(inputString));
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter tag: ");
                        string tag = Console.ReadLine();
                        Console.Write("Enter string: ");
                        inputString = Console.ReadLine();
                        Console.WriteLine("\t\t" + client.PrintHtml(tag, inputString));
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Sort Type");
                        Console.Write("1. Ascending \t 2. Descending \t: ");
                        int sortType = Convert.ToInt32(Console.ReadLine());
                        List<int> inputNumbers = new List<int>(5);
                        Console.Write("Enter Number1: ");
                        inputNumbers.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Enter Number2: ");
                        inputNumbers.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Enter Number3: ");
                        inputNumbers.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Enter Number4: ");
                        inputNumbers.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Enter Number5: ");
                        inputNumbers.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("\t\t" + client.SortNumbers(sortType, inputNumbers.ToArray()));
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Please enter an integer between 1 to 6");
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
            }

        }
    }
}
