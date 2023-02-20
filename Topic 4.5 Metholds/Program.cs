using System;
using System.Threading;

namespace Topic_4._5_Metholds
{
    class Program
    {
        static void Main(string[] args)
        {
            string programType;
            Console.WriteLine("Would you like to run  greetings, animal, bye or Joke?");
            programType = Console.ReadLine().ToUpper();
            if (programType == "ART")
            {
                grettings();
            }
            else if (programType == "BYE")
            {
                bye();
            }
            else if (programType == "ANIMAL")
            {
                animal();
            }
            else if (programType == "JOKE")
            {
                knockKnockJoke();
            }
            else
            {
                Console.WriteLine("That is not a vaild response");
            }

        }
        static void grettings()
        {
            Console.WriteLine("   _____            __  _                 _      __         __   __\r\n / ___/______ ___ / /_(_)__  ___ ____   | | /| / /__  ____/ /__/ /\r\n/ (_ / __/ -_) -_) __/ / _ \\/ _ `(_-<   | |/ |/ / _ \\/ __/ / _  / \r\n\\___/_/  \\__/\\__/\\__/_/_//_/\\_, /___/   |__/|__/\\___/_/ /_/\\_,_/  \r\n                           /___/                                  ");
         
        }
        static void animal()
        {
            Console.WriteLine("");
        }
        static void bye()
        {
            Console.WriteLine("   ___             _      __         __   __\r\n  / _ )__ _____   | | /| / /__  ____/ /__/ /\r\n / _  / // / -_)  | |/ |/ / _ \\/ __/ / _  / \r\n/____/\\_, /\\__/   |__/|__/\\___/_/ /_/\\_,_/  \r\n     /___/                                  ");
        }
        static void knockKnockJoke()
        {
            Console.WriteLine("Ready to hear a joke?");
            Console.ReadLine();
            Thread.Sleep(700);
            Console.WriteLine("Knock Knock!");
            Thread.Sleep(900);
            Console.WriteLine("Who's there?");
            Thread.Sleep(700);
            Console.WriteLine("Yah");
            Thread.Sleep(900);
            Console.WriteLine("Yah Who?");
            Thread.Sleep(1200);
            Console.WriteLine("No, I perfer Google");
        }
    }
}
