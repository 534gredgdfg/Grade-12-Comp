using System.Reflection.Emit;
using System.Security.Cryptography;

namespace Topic_7__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            Random genorator = new Random();

            List<int> numbers = new List<int>();

            numbers.Add(genorator.Next(10, 20));
            for (int i = 0; i <25; i++)
            {
                numbers.Add(genorator.Next(10, 21));
                Console.Write($"{numbers[i]}, ");
            }

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
            while (!Int32.TryParse(Console.ReadLine(), out menuChoice))
                Console.WriteLine("Enter a valid option: ");

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Sorting List");
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
                    break;

                case 8:
                    break;

                default:
                    Console.WriteLine("Not an option");
                    break;

            }



        }
    }
}