using System;



namespace Part_5_Decisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programType;
            Console.WriteLine("Would you like to run ATM Program, Parking Program or Hurricane Program");
            programType = Console.ReadLine().ToUpper();
            if (programType == "ATM")
            {
                ATM();
            }
            else if (programType == "PARKING PROGRAM")
            {
                ParkingProgram();
            }
            else if (programType == "HURRICANE")
            {
                Hurricane();
            }
            else
            {
                Console.WriteLine("Program Failed");
                Console.WriteLine("Invalid Input");
            }
        }   

       
            
        public static void ATM()
        {
            Random rand = new Random();
            string transationType;
            double Balance = rand.Next(100, 150);
            double fee, withdrawNumber, billNumber, depositNumber;
            fee = 0.75;
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Bank of Blorb");

            Console.WriteLine($"Your initial balnce is ${Balance}");
            Console.WriteLine("Please enter you transation type: deposit, withdrawal, bill payment or an account balance update");
            transationType = Console.ReadLine().ToUpper();

            if (transationType == "DEPOSIT")
            {
                Console.WriteLine("Enter the amount you wish add to your account");
                if (Double.TryParse(Console.ReadLine(), out depositNumber))
                {

                    if (depositNumber <= 0)
                    {
                        Console.WriteLine("Transaction Failed");
                        Console.WriteLine("You can't deposit zero or negitive money");
                    }
                    else
                    {
                        Balance += depositNumber;
                        Balance -= fee;
                        Console.WriteLine($"New balance is ${Balance}");
                    }
                }
                else
                {
                    Console.WriteLine("Transation Failed");
                    Console.WriteLine("Invalid Input");
                }
               
                    
            }
            else if (transationType == "WITHDRAWAL" || transationType == "WITHDRAW")
            {
                Console.WriteLine("Enter the amount you wish to withdrawal");

                if (Double.TryParse(Console.ReadLine(), out withdrawNumber))
                
                {
                    if (withdrawNumber <= 5)
                    {
                        Console.WriteLine("Can't withdrawal less than $5, bank policy");
                    }

                    else if (withdrawNumber < Balance - fee) {
                        Balance -= withdrawNumber;
                        Balance -= fee;
                        Console.WriteLine($"New balance is ${Balance}");

                    }
                    
                    else
                    {
                        Console.WriteLine("Transaction Failed");
                        Console.WriteLine("You dont have enough money");
                    }
 
                }
                else
                {
                    Console.WriteLine("Transation Failed");
                    Console.WriteLine("Invalid Input");
                }

            }
            else if (transationType == "BILL PAYMENT"){
                Console.WriteLine("How much is the bill you need to pay?");

                if (Double.TryParse(Console.ReadLine(), out billNumber))
                {
                    if (billNumber > Balance)
                    {
                        Console.WriteLine("Transation Failed");
                        Console.WriteLine("You do not have enough money in your account");
                    }
                    else if (billNumber < Balance + fee)
                    {
                        Balance -= billNumber;
                        Balance -= fee;
                        Console.WriteLine($"{billNumber} was removed form your account to pay your bill");
                        Console.WriteLine($"New balance is ${Balance}");
                    }

                }
                else
                {
                    Console.WriteLine("Transation Failed");
                    Console.WriteLine("Invalid Input");
                }

            }
            else if (transationType == "BALANCE UPDATE" || transationType == "ACCOUNT BALANCE UPDATE" || transationType == "UPDATE")
            {
                Balance -= fee;
                Console.WriteLine($"Your balance is ${Balance}");
            }
            else
            {
                Console.WriteLine("Transation Failed");
                Console.WriteLine("Invalid Input");
            }
        }



        public static void ParkingProgram()
        {
            int  parkedhours;
            int charge = 4;
            Console.WriteLine("Welcome to our Parking Garage");
            Console.WriteLine("Please enter number of miniutes parked:");
            if (Int32.TryParse(Console.ReadLine(), out parkedhours))
            {
                if (parkedhours <= 0)
                {
                    Console.WriteLine("You parked for less than 0 miniutes");
                    Console.WriteLine("No Charge");

                }
                else if (parkedhours <= 60)
                {
                    
                    Console.WriteLine($"You were charged ${charge}");
                }
                else if (parkedhours > 60)
                {
                    
                    charge += 2;
                    Console.WriteLine($"You were charged ${charge}");
                }
                    

            }
            else
            {
                Console.WriteLine("Transation Failed");
                Console.WriteLine("Invalid Input");
            }
        }
        public static void Hurricane()
        {
            Console.WriteLine("Welcome to Hurricane");
        }



    }
}