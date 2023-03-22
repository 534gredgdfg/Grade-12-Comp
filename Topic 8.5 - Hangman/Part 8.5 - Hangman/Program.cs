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
            int incorrect;
            bool done;
            done = false;
            incorrect = 0;
            string userLetter;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string displayWord = "";
            List<string> words = new List<string>();
            words.Add("B E A V E R");
            words.Add("H U N T E R");
            words.Add("M A D D O X");
            words.Add("W H E A T");
            words.Add("P O W E R");
            words.Add("S E A T");
            words.Add("A I D S");
            words.Add("F I T N E S S");
            words.Add("M O T H E R");
            words.Add("P E A N U T");
            words.Add("P Y T H O N");
            words.Add("W O N D E R F U L");
            words.Add("P O W E R F U L");
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
            do
            {
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
                    word = words[rand.Next(0, words.Count)];
                    switch (word.Length)
                    {
                        case 7: displayWord = "_ _ _ _"; break;
                        case 9: displayWord = "_ _ _ _ _"; break;
                        case 11: displayWord = "_ _ _ _ _ _"; break;
                        case 13: displayWord = "_ _ _ _ _ _ _"; break;
                        case 15: displayWord = "_ _ _ _ _ _ _ _"; break;


                    }
                }

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