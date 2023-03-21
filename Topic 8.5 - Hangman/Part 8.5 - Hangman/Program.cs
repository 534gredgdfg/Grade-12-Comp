using System.Linq;

namespace Part_8._5___Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int incorrect;
            bool done;
            done = false;
            incorrect = 0;
            string userLetter;
            string word = "COMPUTER";
            string displayWord = "________";
            
            

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Try to guess my Seceret Word");
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
                    displayWord.Remove(word.IndexOf(userLetter));
                    displayWord = displayWord.Insert(word.IndexOf(userLetter), userLetter);
                    
                }
                else
                    incorrect++;

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

                }

                if (incorrect == 0)
                    DrawMan0();
                else if (incorrect == 1)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("That Letter is not in the Word");
                    DrawMan1();
                }
                    
                else if (incorrect == 2)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("That Letter is not in the Word");
                    DrawMan2();
                }
                else if (incorrect == 3)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("That Letter is not in the Word");
                    DrawManDead();
                }
                
                    
                    
                

            }
            while (!done);
            
        }

        static void DrawMan0()
        {
            Console.WriteLine(" +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan1()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawMan2()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");
        }
        static void DrawManDead()
        {
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
        }
        static void DrawManAlive()
        {
            Console.WriteLine("  +---+\r\n      |\r\n      | \r\n \\O/  |\r\n  |   |\r\n / \\  |\r\n=========");
        }
        static void NewWord()
        {
            List<string> words = new List<string>();
            words.Add("BEAVER", "WHALE", "HUNTER", "ALSWORTH");
        }
    }
}