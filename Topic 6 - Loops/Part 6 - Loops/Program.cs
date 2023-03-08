﻿using System;

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
                Console.WriteLine("4 - Random Numbers");
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

                    case "4":
                        RandomNumbers();
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

                    
                if (minValue >= maxValue)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Minimum value cannot be greater or equal to maximum");
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
                while (!Int32.TryParse(Console.ReadLine(), out userValue))
                {
                    Console.WriteLine("Enter a valid response! ");
                    Console.Write($"Enter a number between {minValue} and {maxValue}: ");
                }
            } while (userValue > maxValue || userValue < minValue);
            Console.WriteLine("DONE!");
        }

        static void PercentPassing()
        {
            //Percent Passing
            int Scores;
            string exit;
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
                Console.WriteLine($"{percent}% of scores are above 70!");
                Thread.Sleep(700);
                Console.WriteLine("");

                
                Console.WriteLine("");
                Thread.Sleep(700);
                Console.Write("Would you like to quit? ");
                exit = Console.ReadLine().ToUpper();
                Thread.Sleep(700);
                Console.WriteLine("");
                if (exit == "YES" || exit == "Y")
                {
                    done = true;
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
        static void RandomNumbers()
        {
            Random genorator = new Random();
            int minNumber, maxNumber;
            bool done;
            done = false;
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to Random Numbers");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("Enter a minimum number: ");
            while (!Int32.TryParse(Console.ReadLine(), out minNumber))
                Console.Write("Enter a valid minimum number: ");
            do
            {

                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.Write("Enter a maximum value: ");

                while (!Int32.TryParse(Console.ReadLine(), out maxNumber))
                {
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    Console.Write("Enter a valid maximum value: ");
                }


                if (minNumber >= maxNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Minimum value cannot be greater or equal to maximum");
                    Console.WriteLine("Try again");
                }
                else
                {

                    done = true;
                }


            }
            while (!done);

            for (int i = 1; i <= 25; i++)
            {
                int randomNumber = genorator.Next(minNumber, maxNumber + 1);
                Console.WriteLine($"{i}.   {randomNumber}");
            }
        }
    }




}