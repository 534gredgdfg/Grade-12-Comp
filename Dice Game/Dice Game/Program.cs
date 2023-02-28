using System;
using System.Threading;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balence, betNumber;
            int betType, roll1, roll2, sum;
            Balence = 100.00;
            Die rolling = new Die();
            
            Console.WriteLine($"You initial balence is ${Balence}");
            Console.WriteLine("");
            Console.WriteLine("Would you like to bet on:");
            Console.WriteLine("1.Doubles (Win double your bet)");
            Console.WriteLine("2.Not Doubles (Win half your bet)");
            Console.WriteLine("3.Even Sum (Win your bet)");
            Console.WriteLine("4.Odd Sum (Win your bet)");
            Console.WriteLine("");


            if (Int32.TryParse(Console.ReadLine(), out betType) && betType <=4 && betType >= 1)
            {
                Console.WriteLine("How much would you like to bet?");
                if (Double.TryParse(Console.ReadLine(), out betNumber))
                {
                    
                    
                    betNumber = Math.Round(betNumber, 2);
                    if (betNumber < Balence || betNumber > 0)
                    {
                        if (betNumber >= Balence)
                        {
                            betNumber = 100.00;
                        }
                        else if (betNumber <= 0)
                        {
                            betNumber = 0.00;
                        }
                        Console.WriteLine($"Your betting ${betNumber}");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to roll dice:");
                        Console.ReadLine();

                        Console.WriteLine($"You rolled a {rolling}");
                        rolling.DrawRoll();
                        roll1 = rolling.Roll;

                        Thread.Sleep(700);

                        rolling.RollDie();
                        Console.WriteLine($"And rolled a {rolling}");
                        rolling.DrawRoll();
                        roll2 = rolling.Roll;
                        sum = roll1 + roll2;

                        Thread.Sleep(700);

                        if (betType == 1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You bet on doubles");
                            if (roll1 == roll2)
                            {
                                Balence += betNumber * 2;
                                Console.WriteLine("You Win!");
                                Console.WriteLine($"You double yor money and your new balence is ${Balence}");
                            }
                            else
                            {
                                Balence -= betNumber;
                                Console.WriteLine("You Lose!");
                                Console.WriteLine($"Your new balence is ${Balence}");
                            }
                        }
                        else if (betType == 2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You bet on not doubles");
                            if (roll1 == roll2)
                            {
                                Balence -= betNumber;
                                Console.WriteLine("You Lose!");
                                Console.WriteLine($"Your new balence is ${Balence}");

                            }
                            else
                            {
                                Balence += betNumber / 2;
                                Console.WriteLine("You Win!");
                                Console.WriteLine($"Your new balence is ${Balence}");
                            }
                        }
                        else if (betType == 3)
                        {

                            Console.WriteLine("");
                            Console.WriteLine("You bet on an even sum");
                            Console.WriteLine($"The total sum of the dice is {sum}");

                            if (sum % 2 == 0)
                            {

                                Balence += betNumber;

                                Console.WriteLine("Number is even. You Win!");
                                Console.WriteLine($"Your new total is ${Balence}");
                            }
                            else
                            {
                                Balence -= betNumber;
                                Console.WriteLine("Your number is odd");
                                Console.WriteLine($"Your new balence is ${Balence}");

                            }



                        }
                        else if (betType == 4)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You bet on odd sum");
                            if (sum % 2 == 0)
                            {

                                Balence -= betNumber;

                                Console.WriteLine("Number is even. You Lose!");
                                Console.WriteLine($"Your new total is ${Balence}");
                            }
                            else
                            {
                                Balence += betNumber;
                                Console.WriteLine("Your number is odd. You Win!");
                                Console.WriteLine($"Your new balence is ${Balence}");

                            }
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
                else
                {
                    Console.WriteLine("That is not a valid bet");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid choice");

            }
            

            


                


        } 
      
    }
}