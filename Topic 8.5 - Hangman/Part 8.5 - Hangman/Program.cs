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

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string displayWord = "";
            
            
            Console.WriteLine("Welcome to Hangman!");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Try to guess my Seceret Word");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("You get 6 guesses to get it right");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Every wrong guess, a limb gets added to the Hangman");
            Thread.Sleep(1000);
            Console.WriteLine();
            
            do
            {   if (createWord == true)
                {
                    Console.Write("What difficulty would you like to play on, 1, 2 or 3? ");

                    while (!Int32.TryParse(Console.ReadLine(), out difficulty))
                        Console.Write("Please Enter 1, 2 or 3? ");
                    if (difficulty > 3)
                        difficulty = 3;
                    else if (difficulty < 0)
                        difficulty = 0;
                    List<string> words = new List<string>();

                    //Choose Scerect word based on difficulty
                    var wordFileDIff1 = File.ReadAllLines("Words Level 1.txt");
                    var wordFileDIff2 = File.ReadAllLines("Words Level 2.txt");
                    var wordFileDIff3 = File.ReadAllLines("Words Level 3.txt");

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


                    }

                    //Ensure displaying word has as numnber of dashes as seceret word
                    string word = words[rand.Next(0, words.Count)];
                    switch (word.Length)
                    {
                        case 7: displayWord = "_ _ _ _"; break;
                        case 9: displayWord = "_ _ _ _ _"; break;
                        case 11: displayWord = "_ _ _ _ _ _"; break;
                        case 13: displayWord = "_ _ _ _ _ _ _"; break;
                        case 15: displayWord = "_ _ _ _ _ _ _ _"; break;
                        case 17: displayWord = "_ _ _ _ _ _ _ _ _"; break;
                    }
                }
               

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine(displayWord);
                Thread.Sleep(1000);
                Console.WriteLine();
                do
                {
                    Console.Write("Enter a Letter: ");
                    userLetter = Console.ReadLine().ToUpper();
                    
                }
                while (userLetter.Length > 1);

                if (word.Contains(userLetter))
                {
                    
                    displayWord = displayWord.Remove(word.IndexOf(userLetter), 1);
                    displayWord = displayWord.Insert(word.IndexOf(userLetter), userLetter);
                    
                }
                else
                {
                    incorrect++;
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("That Letter is not in the Word");
                }


                if (displayWord == word)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("You got the word Right!");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    DrawManAlive();
                    Thread.Sleep(1000);
                    Console.WriteLine();                    
                    Console.WriteLine("Press Enter to Play Again");
                    Console.ReadLine();
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
                        case 5: DrawMan5(); break;
                        case 6: DrawManDead(); break;
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
        
        
    }
}