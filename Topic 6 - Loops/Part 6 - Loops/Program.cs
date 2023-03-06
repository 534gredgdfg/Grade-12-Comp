using System;

namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string program;
            bool done;
            done = false;
            while (done != true)
            {

                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.WriteLine("---MENU---");
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("3 - Oddsum");
                Console.WriteLine("");
                Console.Write("Run program 1, 2, 3, 4, 5: ");

                program = Console.ReadLine();

                switch (program)
                {
                    case "0":
                        Console.WriteLine("Quiting...");
                        done = true;
                        break;
                    case "1":
                        Prompter();
                        
                        break;

                    case "2":
                        PercentPassing();
                        break;

                    case "3":
                        OddSum();
                        break;

                    default:
                        Console.WriteLine("Not an option, Choose between 1-5");
                        break;
                        

                }
            }

        }
        static void Prompter()
        {
            //Prompter 
            int maxValue, minValue, userValue;
            bool done;  
            done = false;
            
            
            minValue = 0;
            maxValue = 0;

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.Write("Enter a minimum value: ");

            while (!Int32.TryParse(Console.ReadLine(), out minValue))
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.Write("Enter a valid minimum value: ");
            }

                

            do
            {

                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.Write("Enter a maximum value: ");

                while (!Int32.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    Console.Write("Enter a valid maximum value: ");
                }

                    
                if (minValue > maxValue)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Minimum value cannot be greater than maximum");
                    Console.WriteLine("Try again");
                }
                else
                {
                    
                    done = true;
                }
                    
                    
            }
            while (!done);


            do
            {
                Console.WriteLine("");
                Thread.Sleep(700);
                Console.Write($"Enter a number between {minValue} and {maxValue}: ");
                userValue = Convert.ToInt32(Console.ReadLine());
            } while (userValue > maxValue || userValue < minValue);
            Console.WriteLine("DONE!");
        }

        static void PercentPassing()
        {
            //Percent Passing
            int DiffScores, Scores;
            int i = 1;
            
            Console.Write("How many differnt scores do you have? ");
            DiffScores = Convert.ToInt32(Console.ReadLine());
            
            while (DiffScores >= i)
            {
                Console.Write("Enter Score: ");
                Scores = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
                
            }
            //Console.Write(Scores);
        }
        static void OddSum()
        {
            int number, sum;
            Console.WriteLine("");
            Console.Write("Enter a number: ");

            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.Write("Enter a valid number: ");

            sum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Thread.Sleep(1000);
            Console.WriteLine($"The sum of all odd values between 1 and { number } is {sum}.");
        }
    }




}