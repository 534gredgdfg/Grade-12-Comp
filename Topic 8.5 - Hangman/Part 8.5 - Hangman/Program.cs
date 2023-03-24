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
            int incorrect, difficulty;
            bool done, createWord;
            createWord = true;
            done = false;
            incorrect = 0;
            string userLetter;
            string word = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string displayWord = "";
            
            
            Console.WriteLine("Welcome to Hangman!");
            Rest();
            Console.WriteLine();
            Console.WriteLine("Try to guess my Seceret Word");
            Rest();
            Console.WriteLine();
            Console.WriteLine("You get 7 guesses to get it right");
            Rest();
            Console.WriteLine();
            Console.WriteLine("Every wrong guess, a limb gets added to the Hangman");
            Rest();
            Console.WriteLine();
            
            do
            {   if (createWord == true)
                {
                    Console.WriteLine("What difficulty would you like to play on");
                    Console.WriteLine("1 - Easy");
                    Console.WriteLine("2 - Medium");
                    Console.WriteLine("3 - Hard");
                    Console.Write("Choice: ");
                    while (!Int32.TryParse(Console.ReadLine(), out difficulty))
                        Console.Write("Please Enter 1, 2 or 3? ");
                    //if (difficulty > 3)
                    //    difficulty = 3;
                    //else if (difficulty < 0)
                    //    difficulty = 0;
                    List<string> words = new List<string>();

                    //Choose Scerect word based on difficulty
                    var wordFileDIff1 = File.ReadAllLines("Words Level 1.txt");
                    var wordFileDIff2 = File.ReadAllLines("Words Level 2.txt");
                    var wordFileDIff3 = File.ReadAllLines("Words Level 3.txt");
                    var test = File.ReadAllLines("tester.txt");

                    switch (difficulty)
                    {
                        case 1:
                            foreach (var s in wordFileDIff1)
                                words.Add(s);
                            break;

                        case 2:
                            foreach (var s in wordFileDIff2)
                                words.Add(s);
                            break;

                        case 3:
                            foreach (var s in wordFileDIff3)
                                words.Add(s);
                            break;
                        case 4:
                            foreach (var s in test)
                                words.Add(s);
                            break;


                    }

                    //Ensure displaying word has as numnber of dashes as seceret word
                    word = words[rand.Next(0, words.Count)];
                    switch (word.Length)
                    {
                        case 5: displayWord = "_ _ _"; break;
                        case 7: displayWord = "_ _ _ _"; break;
                        case 9: displayWord = "_ _ _ _ _"; break;
                        case 11: displayWord = "_ _ _ _ _ _"; break;
                        case 13: displayWord = "_ _ _ _ _ _ _"; break;
                        case 15: displayWord = "_ _ _ _ _ _ _ _"; break;
                        case 17: displayWord = "_ _ _ _ _ _ _ _ _"; break;
                        case 19: displayWord = "_ _ _ _ _ _ _ _ _ _"; break;
                        case 21: displayWord = "_ _ _ _ _ _ _ _ _ _ _"; break;
                    }
                }


                Rest();
                Console.WriteLine();
                Console.WriteLine(displayWord);
                Rest();
                Console.WriteLine();
                do
                {
                    Console.Write("Enter a Letter: ");
                    userLetter = Console.ReadLine().ToUpper();
                    
                }
                while (userLetter.Length > 1);



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


                        Console.WriteLine(word);
                    }
                }
                else
                {
                    incorrect++;
                    Rest();
                    Console.WriteLine();
                    Console.WriteLine("That Letter is not in the Word");
                }


                if (displayWord == word)
                {
                    Win();
                    incorrect = 0;
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
                            Rest();
                            Console.WriteLine();
                            Console.WriteLine($"The word was {word}");
                            Lose();
                            incorrect = 0;
                            Console.Clear();

                            Rest();
                            Console.WriteLine();
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
            Rest();
            Console.WriteLine();
            Console.WriteLine("You ran out of guesses :(");
            Rest();
            Console.WriteLine();           
            Console.WriteLine("Press Enter to Play Again");
            Console.ReadLine();
        }
        static void Win()
        {
            Rest();
            Console.WriteLine();
            Console.WriteLine("You got the word Right!");
            Rest();
            Console.WriteLine();
            DrawManAlive();
            Rest();
            Console.WriteLine();
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