﻿using System;
using System.Threading;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Balance, betNumber;
            int betType, roll1, roll2, sum;
            string restart;
            Balance = 100.00;
            Die rolling = new Die();
            bool  done, runProgram;
            done = false;
            
            while (done != true)
            {


                Console.WriteLine($"You initial balance is ${Balance}");
                Console.WriteLine("");
                Console.WriteLine("Would you like to bet on:");
                Console.WriteLine("1.Doubles (Win double your bet)");
                Console.WriteLine("2.Not Doubles (Win half your bet)");
                Console.WriteLine("3.Even Sum (Win your bet)");
                Console.WriteLine("4.Odd Sum (Win your bet)");
                Console.WriteLine("");


                if (Int32.TryParse(Console.ReadLine(), out betType) && betType <= 4 && betType >= 1)
                {

                    Console.Write("How much would you like to bet? $");
                    if (double.TryParse(Console.ReadLine(), out betNumber))
                    {

                        if (betNumber >= Balance)
                        {
                            betNumber = Balance;
                        }
                        else if (betNumber <= 0)
                        {
                            betNumber = 0.00;
                        }
                        Console.WriteLine($"Your betting ${betNumber}");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to roll dice:");
                        Console.ReadLine();
                        Console.WriteLine("Rolling!");
                        Thread.Sleep(1000);
                        Console.WriteLine("");

                        Console.WriteLine($"You rolled a {rolling}");
                        rolling.DrawRoll();
                        roll1 = rolling.Roll;

                        Thread.Sleep(700);
                        Console.WriteLine("");
                        rolling.RollDie();
                        Console.WriteLine($"And rolled a {rolling}");
                        rolling.DrawRoll();
                        roll2 = rolling.Roll;
                        sum = roll1 + roll2;

                        Thread.Sleep(900);

                        if (betType == 1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You bet on doubles");
                            if (roll1 == roll2)
                            {
                                Balance += betNumber * 2;
                                Console.WriteLine("You Win!");
                                Console.WriteLine($"You double yor money and your new balance is ${Balance}");
                            }
                            else
                            {
                                Balance -= betNumber;
                                Console.WriteLine("You Lose!");
                                Console.WriteLine($"Your new balance is ${Balance}");
                            }
                        }
                        else if (betType == 2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You bet on not doubles");
                            if (roll1 == roll2)
                            {
                                Balance -= betNumber;
                                Console.WriteLine("You Lose!");
                                Console.WriteLine($"Your new balance is ${Balance}");

                            }
                            else
                            {
                                Balance += betNumber / 2;
                                Console.WriteLine("You Win!");
                                Console.WriteLine($"Your new balance is ${Balance}");
                            }
                        }
                        else if (betType == 3)
                        {

                            Console.WriteLine("");
                            Console.WriteLine("You bet on an even sum");
                            Console.WriteLine($"The total sum of the dice is {sum}");

                            if (sum % 2 == 0)
                            {

                                Balance += betNumber;

                                Console.WriteLine("Number is even. You Win!");
                                Console.WriteLine($"Your new total is ${Balance}");
                            }
                            else
                            {
                                Balance -= betNumber;
                                Console.WriteLine("Your number is odd");
                                Console.WriteLine($"Your new balance is ${Balance}");

                            }



                        }
                        else if (betType == 4)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You bet on odd sum");
                            if (sum % 2 == 0)
                            {

                                Balance -= betNumber;

                                Console.WriteLine("Number is even. You Lose!");
                                Console.WriteLine($"Your new total is ${Balance}");
                            }
                            else
                            {
                                Balance += betNumber;
                                Console.WriteLine("Your number is odd. You Win!");
                                Console.WriteLine($"Your new balance is ${Balance}");

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
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.Write("Would you like to play again? ");
                restart = Console.ReadLine().ToUpper();
                if (restart == "YES" && Balance > 0)
                {
                    done = false;
                }
                else if (Balance <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have insuffincient funds");
                    Console.WriteLine("");
                    Console.WriteLine("See you next time!");
                    done = true;
                }
                else
                {
                    done = true;
                    Console.WriteLine("");
                    Console.WriteLine("See you next time!");
                }
                
            }


        } 
      
    }
}