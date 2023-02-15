namespace Topic_3__Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("1.");
            string name;
            Console.WriteLine("What is you name?");
            name = Console.ReadLine();
            

            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            

            int year;
            Console.WriteLine("What year is it?");
            year = Convert.ToInt32(Console.ReadLine());
            int birthYear = year - age;
            Console.WriteLine($"Hi {name}, it is {year} and you were born in {birthYear} .");

            //------------------------------------------------------------------------------------------------
            Console.WriteLine("");  
            Console.WriteLine("2.");
            
            int a;
            int b;
            int c;
            Console.WriteLine("Enter a number:");            
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one more number:");
            c = Convert.ToInt32(Console.ReadLine());
            int d = a + b + c;
            Console.WriteLine($"Your total is {d}");

            //------------------------------------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("3.");
            double dis1;
            double dis2;
            double dis3;
            Console.WriteLine("Enter a distance:");
            dis1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another distance:");
            dis2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one more distance:");
            dis3 = Convert.ToInt32(Console.ReadLine());
            double disAvg = (dis1 + dis2 + dis3) / 3;
            disAvg = Math.Round(disAvg, 2);
            Console.WriteLine($"Your average distance was {disAvg}");

            //--------------------------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("4.");
            double xleg;
            double yleg;
            Console.WriteLine("Enter length of the horizontal leg:");
            xleg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of vertical leg:");
            yleg = Convert.ToInt32(Console.ReadLine());
            double hypotenuse = Math.Sqrt(xleg*xleg + yleg*yleg);
            hypotenuse = Math.Round(hypotenuse, 2);
            Console.WriteLine($"The length of the hypotenuse is {hypotenuse}");















        }   
    }
}