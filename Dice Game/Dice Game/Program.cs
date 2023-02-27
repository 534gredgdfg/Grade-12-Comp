namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balence;
            int betType, sum;
            Balence = 100.00;
            Die rolling = new Die();
            
            Console.WriteLine($"You initial balence is {Balence}");
            Console.WriteLine("Would you like to bet on 1.double, 2.not doubles, 3.even sum or 4.odd sum");
            Console.WriteLine("");
            

            if (Int32.TryParse(Console.ReadLine(), out betType))
            {

                if (betType == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You bet on doubles");
                    Rolling_the_dice();
                }
                else if (betType == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You bet on not doubles");
                    Rolling_the_dice();
                }
                else if (betType == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You bet on even sum");
                    Rolling_the_dice();
                    
                    

                }
                else if (betType == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You bet on odd sum");
                    Rolling_the_dice();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        } 
        public static void Rolling_the_dice()
        {
            Die rolling = new Die();
            Console.WriteLine("");
            int roll1;
            int roll2;


            Console.WriteLine($"You rolled a {rolling}");           
            rolling.DrawRoll();
            roll1 = rolling.Roll;
            

            rolling.RollDie();
            Console.WriteLine($"And rolled a {rolling}");
            rolling.DrawRoll();
            roll2 = rolling.Roll;
        }
    }
}