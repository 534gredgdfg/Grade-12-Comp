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
                Console.WriteLine("");
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
            Console.WriteLine("Welcome to Prompter");
            Thread.Sleep(1000);
            Console.WriteLine("");

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
            double percent, correct;
            bool done;
            int i = 0;
            Scores = 0;
            correct = 0;
            done = false;

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to Percent Passing");
            Thread.Sleep(1000);
            Console.WriteLine("");
            
            do
            {
                Console.Write("Enter Score: ");


                while (!Int32.TryParse(Console.ReadLine(), out Scores))
                    Console.Write("Enter Score: ");


                i = i + 1;
                
                if (Scores >= 70)
                {
                    correct += 1;
                }
                
                
                percent = correct / i ;

                if (percent >= 1)
                {
                    percent = 1;
                }
                else if (percent <= 0)
                {
                    percent = 0;
                }
                percent = (percent * 100);
                percent = Math.Round(percent, 2);


                Console.WriteLine("");
                Thread.Sleep(700);
                Console.WriteLine($"{percent}% of your scores are over 70.");
                Thread.Sleep(700);
                Console.WriteLine("");

                if (i % 2 != 0)
                {
                    Console.WriteLine("");
                    Thread.Sleep(700);
                    Console.WriteLine($"Do you want to quit?");
                    Thread.Sleep(700);
                    Console.WriteLine("");
                }
            }
            while (!done);

            
            
        }
        static void OddSum()
        {
            int number, sum;

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to Oddsum");
            Thread.Sleep(1000);
            
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