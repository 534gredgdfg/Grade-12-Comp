using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace Topic_7__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool done;
            int menuChoice, removedNumber;
            Random genorator = new Random();
            done = false;
            List<int> numbers = new List<int>();
            Console.WriteLine("List: ");
            numbers.Add(genorator.Next(10, 20));
            for (int i = 0; i <25; i++)
            {
                numbers.Add(genorator.Next(10, 21));
                
                Console.Write($"{numbers[i]}, ");
            }
            do
            {


                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose a option from the list:");
                Console.WriteLine("1 - Sort List");
                Console.WriteLine("2 - Make New Random List");
                Console.WriteLine("3 - Remove a Number");
                Console.WriteLine("4 - Add Number");
                Console.WriteLine("5 - Count Number of Occurences of a Number");
                Console.WriteLine("6 - Print Largest Number");
                Console.WriteLine("7 - Print Smallest Number");
                Console.WriteLine("8 - Quit");
                Console.Write("Choice: ");
                while (!Int32.TryParse(Console.ReadLine(), out menuChoice))
                    Console.WriteLine("Enter a valid option: ");

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Sorting List...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        numbers.Sort();
                        Console.WriteLine("The Sorted List Is: ");

                        for (int i = 0; i < 25; i++)
                        {
                            Console.Write($"{numbers[i]}, ");
                        }
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Making New List...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("The New List Is: ");
                        numbers.Clear();

                        for (int i = 0; i < 25; i++)
                        {
                            numbers.Add(genorator.Next(10, 21));
                            Console.Write($"{numbers[i]}, ");
                        }
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.Write("Which Number Would You Like to Remove? ");
                        while (!Int32.TryParse(Console.ReadLine(), out removedNumber))
                        {
                            Console.WriteLine("Enter a valid option: ");                           
                        }
                        numbers.Remove(removedNumber);
                        Console.Write($"{removedNumber} has been removed from list ");

                      
                        break;


                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        Console.WriteLine();
                        Console.WriteLine("Quiting...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        done = true;
                        break;

                    default:
                        Console.WriteLine("Not an option");
                        break;


                }
            }
            while (!done);
            Console.WriteLine();



        }
    }
}