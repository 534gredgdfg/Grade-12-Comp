namespace The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Owen";
            string favMovie = "The Matrix".ToUpper();

            Console.WriteLine("1");
            Console.WriteLine("");

            string greeting = ($"Hey man, my name is {firstName} my faviote movie is {favMovie}. Figuerd you woud want to know.");
            Console.WriteLine(greeting.ToLower());

            Console.WriteLine(greeting);

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = (favMovie.Replace("A", "@"));
            favMovie = (favMovie.Replace("E", "3"));

            Console.WriteLine(favMovie);

            Console.WriteLine("2");
            Console.WriteLine("");

            string quote = "I smell of stupid";
            Console.WriteLine(quote);
            quote = quote.Replace("e", "");
            quote = quote.Replace("o", "");
            quote = quote.Replace("I", "");
            quote = quote.Replace("u", "");
            Console.WriteLine(quote);
            Console.WriteLine(quote.ToUpper());

            Console.WriteLine("3");
            Console.WriteLine("");

            Console.WriteLine("   _____            __  _                 _      __         __   __\r\n / ___/______ ___ / /_(_)__  ___ ____   | | /| / /__  ____/ /__/ /\r\n/ (_ / __/ -_) -_) __/ / _ \\/ _ `(_-<   | |/ |/ / _ \\/ __/ / _  / \r\n\\___/_/  \\__/\\__/\\__/_/_//_/\\_, /___/   |__/|__/\\___/_/ /_/\\_,_/  \r\n                           /___/                                  ");

            Console.WriteLine("");
            Console.WriteLine("   ___             _      __         __   __\r\n  / _ )__ _____   | | /| / /__  ____/ /__/ /\r\n / _  / // / -_)  | |/ |/ / _ \\/ __/ / _  / \r\n/____/\\_, /\\__/   |__/|__/\\___/_/ /_/\\_,_/  \r\n     /___/                                  ");
        }   
    }
}