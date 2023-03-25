using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Part_8._5___Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int incorrect, difficulty, multiplayer;
            bool done, createWord;
            createWord = true;
            done = false;
            incorrect = 0;

            string userLetter ;
            string word = "";
            string displayWord = "";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            
            List<string> words = new List<string>();
            List<string> usedLetters = new List<string>();

            Console.WriteLine("   WELCOME to HANGMAN!   ");
            Console.WriteLine();
            Rest();         
            Console.WriteLine("You get 7 guesses to get the word right");
            Console.WriteLine();
            Rest();
            Console.WriteLine("Every wrong guess, a limb gets added to the Hangman");
            Console.WriteLine();
            Rest();

            do
            {   if (createWord == true)
                {
                    
                    Console.WriteLine("Would you like to play Singleplayer or Multiplayer player Hangman?");
                    Console.WriteLine("1 - Singleplayer");
                    Console.WriteLine("2 - Multiplayer");
                    Console.Write("Choice: ");
                    while (!Int32.TryParse(Console.ReadLine(), out multiplayer))
                        Console.Write("Please Enter 1 or 2? ");
                    if (multiplayer > 2)
                        multiplayer = 2;
                    else if (multiplayer < 0)
                        multiplayer = 0;
                    Console.WriteLine();
                    Rest();

                    if (multiplayer == 1)
                    {
                        Console.WriteLine("--Singleplayer Hangman--");
                        Console.WriteLine("What difficulty would you like to play on");
                        Console.WriteLine("1 - Easy");
                        Console.WriteLine("2 - Medium");
                        Console.WriteLine("3 - Hard");
                        Console.WriteLine("4 - Impossible");
                        Console.Write("Choice: ");
                        while (!Int32.TryParse(Console.ReadLine(), out difficulty))
                            Console.Write("Please Enter 1, 2, 3 or 4? ");
                        if (difficulty > 4)
                            difficulty = 4;
                        else if (difficulty < 0)
                            difficulty = 0;

                        Console.WriteLine();
                        Rest();
                        Console.WriteLine("Try to guess my Seceret Word");
                        Console.WriteLine();
                        Rest();

                        //Choose Scerect word based on difficulty
                        var wordFileDIff1 = File.ReadAllLines("Words Level 1.txt");
                        var wordFileDIff2 = File.ReadAllLines("Words Level 2.txt");
                        var wordFileDIff3 = File.ReadAllLines("Words Level 3.txt");
                        var impossible = File.ReadAllLines("tester.txt");


                        switch (difficulty)
                        {
                            case 1:
                                Console.WriteLine("Difficulty is set to Easy");
                                foreach (var s in wordFileDIff1)
                                    words.Add(s);
                                break;

                            case 2:
                                Console.WriteLine("Difficulty is set to Medium");
                                foreach (var s in wordFileDIff2)
                                    words.Add(s);
                                break;

                            case 3:
                                Console.WriteLine("Difficulty is set to Hard");
                                foreach (var s in wordFileDIff3)
                                    words.Add(s);
                                break;
                            case 4:
                                Console.WriteLine("Difficulty is set to Impossible");
                                Console.WriteLine("Good Luck");
                                foreach (var s in impossible)
                                    words.Add(s);
                                break;

                        }
                    word = words[rand.Next(0, words.Count)];
                    }
                    else if (multiplayer == 2)
                    {
                        Console.WriteLine("--Multiplayer Hangman--");
                        Console.WriteLine();
                        Rest();                        
                        Console.WriteLine("One person enter a word. The other guesses");
                        Console.WriteLine();
                        Rest();

                        Console.Write("Enter a Secert Word: ");
                        var pass = string.Empty;
                        ConsoleKey key;
                        do
                        {
                            var keyInfo = Console.ReadKey(intercept: true);
                            key = keyInfo.Key;

                            if (key == ConsoleKey.Backspace && pass.Length > 0)
                            {
                                Console.Write("\b \b");
                                pass = pass[0..^1];
                            }
                            else if (!char.IsControl(keyInfo.KeyChar))
                            {
                                Console.Write("*");
                                pass += keyInfo.KeyChar;
                            }
                        } while (key != ConsoleKey.Enter);                       
                        word = pass.ToUpper();

                    for (int i = 1; i < word.Length; i += 2)
                        {
                            word = word.Insert(i, " ");
                        }

                    }
                    //Ensure displaying word has as number of dashes as seceret word
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i % 2 != 0)                        
                            displayWord = displayWord.Insert(i, " ");                        
                        else
                            displayWord = displayWord.Insert(i, "_");
                    }                   
                }               
                Console.WriteLine();
                Rest();
                Console.WriteLine(displayWord);
                Console.WriteLine();
                Rest();
                Console.Write($"Letters Used: ");
                foreach (string l in usedLetters)
                    Console.Write($"{l}, ");
                Console.WriteLine();
                Console.WriteLine();
                Rest();
                
                do
                {
                    do
                    {
                        Console.Write("Enter a Letter: ");
                        userLetter = Console.ReadLine().ToUpper();
                    }
                    while (usedLetters.Contains(userLetter));
                    
                }
                while (userLetter.Length > 1);
                usedLetters.Add(userLetter);


                char[] charArr = userLetter.ToCharArray();
                int frequency = word.Count(f => (f == charArr[0]));

               
                if (word.Contains(userLetter))
                {
                    
                    
                    displayWord = displayWord.Remove(word.IndexOf(userLetter), 1);
                    displayWord = displayWord.Insert(word.IndexOf(userLetter), userLetter);
                    
                   

                    if (frequency > 1)
                    {
                        string previousWord = word;
                        for (int i = 2; i <= frequency; i++)
                        {
                            int previousIndex = word.IndexOf(userLetter, 1);
                            word = word.Remove(word.IndexOf(userLetter), 1);
                            word = word.Insert(word.IndexOf(userLetter), " ");

                            displayWord = displayWord.Remove(word.IndexOf(userLetter), 1);
                            displayWord = displayWord.Insert(word.IndexOf(userLetter), userLetter);

                            word = word.Remove(word.IndexOf(userLetter), 1);
                            word = word.Insert(previousIndex, userLetter);
                        }
                        word = previousWord;                        
                    }
                }
                else
                {
                    incorrect++;
                    Console.WriteLine();
                    Rest();
                    Console.WriteLine("That Letter is not in the Word");
                }


                if (displayWord == word)
                {
                    Console.WriteLine();
                    Rest();
                    Console.WriteLine(displayWord);
                    Win();                    
                    incorrect = 0;
                    displayWord = "";
                    words.Clear();
                    usedLetters.Clear();
                    Console.Clear();
                    createWord = true;                
                
                }
                else
                {
                    
                    createWord = false;
                    switch (incorrect)
                    {
                        
                        case 0: DrawManNormal(); break;
                        case 1: DrawMan1(); ; break;
                        case 2: DrawMan2(); break;
                        case 3: DrawMan3(); break;
                        case 4: DrawMan4(); break;
                        case 5: DrawMan5();  break;
                        case 6: DrawManDead(); Console.WriteLine("One More Chance!"); break;
                        case 7:
                            Console.WriteLine();
                            Rest();
                            Console.WriteLine($"The word was {word}");
                            Lose();
                            incorrect = 0;
                            displayWord = "";
                            words.Clear();
                            usedLetters.Clear();
                            Console.Clear();

                            Console.WriteLine();
                            Rest();
                            createWord = true;
                            break;
                    }
                }
            
             
            }
            while (!done);            
        }

        static void DrawManNormal()
        {
            Console.WriteLine(" +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan1()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan2()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan3()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan4()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan5()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========");

        }        
        static void DrawManDead()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
        }
        static void DrawManAlive()
        {
            Console.WriteLine("  +---+\r\n      |\r\n      | \r\n \\O/  |\r\n  |   |\r\n / \\  |\r\n=========");
        }
        static void Lose()
        {
            Console.WriteLine();
            Rest();
            Console.WriteLine("You ran out of guesses :(");
            Console.WriteLine();
            Rest();
            Console.WriteLine("Press Enter to Play Again");
            Console.ReadLine();
        }
        static void Win()
        {
            Console.WriteLine();
            Rest();
            Console.WriteLine("You got the word Right!");
            Console.WriteLine();
            Rest();
            DrawManAlive();
            Console.WriteLine();
            Rest();
            Console.WriteLine("Press Enter to Play Again");
            Console.ReadLine();
        }
        static void Rest()
        {
            int restTime = 1000;
            Thread.Sleep(restTime);

        }


    }
}