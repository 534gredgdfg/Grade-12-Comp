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
            done = false;
            do
            {
                Console.WriteLine("Would you like to Run Integer Program or String Program?");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "INTEGER" || choice == "INTEGER PROGRAM" || choice == "1")
                {
                    Console.WriteLine("Running Integer Program...");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Integers();
                }
                else if (choice == "STRING" || choice == "STRING PROGRAM" || choice == "2")
                {

                    Console.WriteLine("Running String Program...");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    String();
                }
                else
                {
                    Console.WriteLine("Enter a Vaild Choice");
                }

            }
            while(!done);
        }
        static void Integers()
        {
            
            bool done, doneCase4Choice;
            int menuChoice, removedNumber, addedNumber , occurenceNumber, Occurences, largestNumber, smallestNumber, listValues;
            Random genorator = new Random();
            done = false;
            listValues = 25;
            addedNumber = 0;
            doneCase4Choice = false;
            List<int> numbers = new List<int>();
                        
            for (int i = 0; i < listValues; i++)
            {
                numbers.Add(genorator.Next(10, 21));                               
            }
            do
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                
                Console.WriteLine("--List--");
                for (int i = 0; i < numbers.Count; i++)
                {
                    
                    Console.Write($"{numbers[i]}, ");
                }
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose a option:");
                Console.WriteLine("1 - Sort List");
                Console.WriteLine("2 - Make New Random List");
                Console.WriteLine("3 - Remove a Number");
                Console.WriteLine("4 - Add Number");
                Console.WriteLine("5 - Count Number of Occurences of a Number");
                Console.WriteLine("6 - Print Largest Number");
                Console.WriteLine("7 - Print Smallest Number");
                Console.WriteLine("8 - Sum and Average");
                Console.WriteLine("9 - Quit");
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
                        
                        break;

                    case 2:
                        //New List
                        Console.WriteLine();
                        Console.WriteLine("Making New List...");
                        
                        numbers.Clear();

                        for (int i = 0; i < listValues; i++)
                        {
                            numbers.Add(genorator.Next(10, 21));
                            
                        }
                        break;

                    case 3:
                        //Remove Number
                        Console.WriteLine();
                        Console.Write("Which Number Would You Like to Remove? ");
                        while (!Int32.TryParse(Console.ReadLine(), out removedNumber))                       
                            Console.Write("Enter a valid option: ");                           
                        
                        Occurences = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == removedNumber)
                            {
                                Occurences += 1;
                                
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
                                doneCase4Choice = true;
                            
                            else
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.Write("Enter a number between 10 and 20!");
                            }
                        }
                        while (!doneCase4Choice);

                        numbers.Add(addedNumber);
                        
                        break;

                    case 5:
                        //Count Occurences

                        Occurences = 0;
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        Console.Write("Which Number Would You Like to See the Amount of Occurences it Has? ");
                        while (!Int32.TryParse(Console.ReadLine(), out occurenceNumber))                       
                            Console.Write("Enter a valid option: ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == occurenceNumber)                            
                                Occurences += 1;     
                        }
                        
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Number {occurenceNumber} has {Occurences} Occurences");
                        break;

                    case 6:
                        //Largest Number

                        numbers.Sort();
                        largestNumber = numbers[numbers.Count - 1];
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Largest Number in the List is: {largestNumber}");
                        
                        Console.WriteLine();
                       
                        break;

                    case 7:
                        //Smallest Number
                        numbers.Sort();
                        smallestNumber = numbers[0];
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Smallest Number in the List is: {smallestNumber}");

                        Console.WriteLine();
                        break;

                    case 8:
                        //Sum and Average
                        
                        int average, sum;
                        sum = 0;
                        average = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        average = sum / numbers.Count;

                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Sum of the List is {sum}");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Average of the List is {average}");
                        break;

                    case 9:
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
        static void String()
        {
            bool done, vaildCase1, vaildCase2, clearedList;
            done = false;
            vaildCase1 = false;
            vaildCase2 = false;
            clearedList = false;
            string removeValue;
            int menuChoice, valuesInList, removedIndex;
            
            List<string> vegtables = new List<string>();
            vegtables.Add("CARROT");
            vegtables.Add("BEET");
            vegtables.Add("CELERY");
            vegtables.Add("RADISH");
            vegtables.Add("CABBAGE");

            
            do
            {
                if (vegtables.Count == 0)
                    clearedList = true;

                
                
                valuesInList = 0;
                if (clearedList == false)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("--Vegtables--");
                    foreach (string v in vegtables)
                    {
                        valuesInList += 1;
                        Console.WriteLine($"{valuesInList} - {v}");
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine();
                }
                 
                if (clearedList == false)
                {
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine("1 - Remove Vegetable by Index");
                    Console.WriteLine("2 - Remove Vegtable by Value");
                    Console.WriteLine("3 - Search for Vegtable");
                    Console.WriteLine("4 - Add Vegtable");
                    Console.WriteLine("5 - Sort List");
                    Console.WriteLine("6 - Clear List");
                    Console.WriteLine("7 - Quit");
                    Console.Write("Choice: ");
                    while (!Int32.TryParse(Console.ReadLine(), out menuChoice))
                        Console.Write("Enter a valid option: ");
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("The List is Empty");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("You Must Add a Vegtable");
                    menuChoice = 4;
                }
                    
                switch (menuChoice)
                {
                    case 1:
                        //Remove by Index
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.Write("Which Vegtable Would You Like to Remove by Index?  ");
                        do
                        {
                            while (!Int32.TryParse(Console.ReadLine(), out removedIndex))
                                Console.Write("Enter a valid option: ");
                            if (removedIndex < 1 || removedIndex > valuesInList)                            
                                Console.Write("Enter a valid option: ");
                            
                            else
                                vaildCase1 = true;     
                        }
                        while (!vaildCase1);
                        vegtables.RemoveAt(removedIndex - 1);

                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("The New List is: ");

                        break;
                    case 2:
                        //Remove by Name
                        int occure;
                        occure = 0;
                       
                        
                        do
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("Which Vegtable Would You Like to Remove by Name?");
                            removeValue = Console.ReadLine().ToUpper();
                            
                            
                            foreach (string v in vegtables)
                            {
                                if (removeValue == v)                                
                                    occure += 1;                                            
                            }
                            if (occure >= 1)
                                vaildCase2 = true;
                            else
                            {
                                Console.Write("Enter a valid option");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                                
                        }
                        while (!vaildCase2);
                        vegtables.Remove(removeValue);

                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("The New List is: ");

                        break;
                    case 3:
                        //Search Vegtable
                        int i, indexFound;
                        bool vaildCase3;
                        string searchedVegtable;
                        vaildCase3 = false;
                        i = 1;
                        indexFound = 0;
                        do
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("Which Vegtable Would You Like to Find?");
                            searchedVegtable = Console.ReadLine().ToUpper();
                            foreach (string v in vegtables)
                            {
                                if (searchedVegtable == v)
                                    vaildCase3 = true;
                                
                            }
                            if (vaildCase3 == false)
                            {
                                Console.WriteLine();
                                Console.Write("Not Found in List. Enter a Vaild Option");
                            }
                        }
                        while (!vaildCase3);

                            foreach (string v in vegtables)
                        {
                            if(searchedVegtable == v)
                            {
                                indexFound = i;
                            }

                            i++;
                        }
                        
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"The Vegtable, {searchedVegtable} is on Index {indexFound}");

                        break;
                    case 4:
                        string addedVegtable;
                        bool vaildCase4;
                        
                        do
                        {
                            vaildCase4 = true;
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("Which Vegtable Would You Like to Add?");
                            addedVegtable = Console.ReadLine().ToUpper();
                            foreach (string v in vegtables)
                            {
                                if (addedVegtable == v)
                                    vaildCase4 = false;

                            }
                            if (vaildCase4 == false)
                            {
                                Console.WriteLine();
                                Console.Write($"{addedVegtable} is Already in the List. Enter a Vaild Option");
                            }
                        }
                        while (!vaildCase4);
                        vegtables.Add(addedVegtable);
                        clearedList = false;
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine($"{addedVegtable} has been Added");

                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Sorting List...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        vegtables.Sort();
                        Console.WriteLine("The List is Sorted");
                        break;

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Clearing List...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        vegtables.Clear();
                        Console.WriteLine("The List is Cleared");
                        
                        break;
                    case 7:
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
        }
       
    }
}