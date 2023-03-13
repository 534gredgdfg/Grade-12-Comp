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
            
            bool done, doneCase4Choice;
            int menuChoice, removedNumber, addedNumber , occurenceNumber, Occurences, largestNumber, smallestNumber, listValues;
            Random genorator = new Random();
            done = false;
            listValues = 25;
            doneCase4Choice = false;
            List<int> numbers = new List<int>();
            Console.WriteLine("List: ");
            numbers.Add(genorator.Next(10, 20));
            for (int i = 0; i < listValues; i++)
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
                    Console.Write("Enter a valid option: ");

                switch (menuChoice)
                {
                    case 1:
                        // Sort List
                        Console.WriteLine();
                        Console.WriteLine("Sorting List...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        numbers.Sort();
                        Console.WriteLine("The Sorted List Is: ");

                        for (int i = 0; i < listValues; i++)
                        {
                            Console.Write($"{numbers[i]}, ");
                        }
                        break;

                    case 2:
                        //New List
                        Console.WriteLine();
                        Console.WriteLine("Making New List...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("The New List Is: ");
                        numbers.Clear();

                        for (int i = 0; i < listValues; i++)
                        {
                            numbers.Add(genorator.Next(10, 21));
                            Console.Write($"{numbers[i]}, ");
                        }
                        break;

                    case 3:
                        //Remove Number
                        Console.WriteLine();
                        Console.Write("Which Number Would You Like to Remove? ");
                        while (!Int32.TryParse(Console.ReadLine(), out removedNumber))                       
                            Console.Write("Enter a valid option: ");                           
                        
                        Occurences = 0;
                        for (int i = 0; i < listValues; i++)
                        {
                            if (numbers[i] == removedNumber)
                            {
                                Occurences += 1;
                                listValues -= 1;
                            }

                        }
                        for (int i = 0; i < Occurences; i++)
                            numbers.Remove(removedNumber);
                            

                        Console.Write($"{removedNumber} has been removed from list ");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                      

                        break;


                    case 4:
                        //Add Number                                                 
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Which Number Would You Like to Add Between 10 and 20? ");
                            while (!Int32.TryParse(Console.ReadLine(), out addedNumber))                                
                                Console.Write("Enter a valid option: ");
                                
                            if (addedNumber >= 10 && addedNumber <= 20)
                            {
                                doneCase4Choice = true;
                            }
                            else
                            {
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.Write("Enter a number between 10 and 20!");
                            }
                        }
                        while (!doneCase4Choice);

                        numbers.Add(addedNumber);
                        listValues += 1;

                        Thread.Sleep(1000);
                        Console.WriteLine();                                              
                        Console.WriteLine("The New List Is: ");                          
                        for (int i = 0; i < listValues; i++)
                        {                              
                            Console.Write($"{numbers[i]}, ");
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine();
                         

                        break;

                    case 5:
                        //Count Occurences

                        Occurences = 0;
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        
                        Console.Write("Which Number Would You Like to See the Amount of Occurences it Has? ");
                        while (!Int32.TryParse(Console.ReadLine(), out occurenceNumber))                       
                            Console.Write("Enter a valid option: ");
                        for (int i = 0; i < listValues; i++)
                        {
                            if (numbers[i] == occurenceNumber)
                            {
                                Occurences += 1;

                            }
                            else
                            {
                                
                            }
                            
                        }
                        
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Number {occurenceNumber} has {Occurences} Occurences");



                        break;

                    case 6:
                        //Largest Number

                        numbers.Sort();
                        largestNumber = numbers[listValues];
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine($"The Largest Number in the List is: {largestNumber}");
                        
                        Console.WriteLine();
                       
                        break;

                    case 7:
                        //Smallest Number
                        numbers.Sort();
                        smallestNumber = numbers[0];
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine($"The Smallest Number in the List is: {smallestNumber}");

                        Console.WriteLine();
                        break;

                    case 8:
                        //Quit
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