using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Part_5._0_Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programType;
            Console.WriteLine("Would you like to run ATM Program, Parking Program or Hurricane Program");
            programType = Console.ReadLine().ToUpper();
            if (programType == "ATM" || programType == "A")
            {
                ATM();
            }
            else if (programType == "PARKING PROGRAM" || programType =="PARKING" || programType == "B")
            {
                ParkingProgram();
            }
            else if (programType == "HURRICANE" || programType == "C")
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
            int charge, parkedhours;
            charge = 4;
            Console.WriteLine("Welcome to our Parking Garage");
            Console.WriteLine("Please enter number of miniutes parked:");
            if (Int32.TryParse(Console.ReadLine(), out parkedhours))
            {
                if (parkedhours <= 0)
                {
                    Console.WriteLine("You parked for less than 0 miniutes");
                    Console.WriteLine("No Charge");

                }
                else if (parkedhours <= 60 && parkedhours > 0)
                {
                    
                    Console.WriteLine($"You parked for 1 hour and are charged for ${charge}");
                }
                else if (parkedhours > 60 && parkedhours <= 120) { 
                    
                    charge += 2;
                    Console.WriteLine($"You parked for 2 hours and are charged for ${charge}");
                }
                else if (parkedhours > 120 && parkedhours <= 180)
                {

                    charge += 4;
                    Console.WriteLine($"You parked for 3 hours and are charged for ${charge}");
                }
                else if (parkedhours > 180 && parkedhours <= 240)
                {

                    charge += 8;
                    Console.WriteLine($"You parked for 4 hours and are charged for ${charge}");
                }
                else if (parkedhours > 240 && parkedhours <= 300)
                {

                    charge += 10;
                    Console.WriteLine($"You parked for 5 hours and are charged for ${charge}");
                }
                else if (parkedhours > 300 && parkedhours <= 360)
                {

                    charge += 12;
                    Console.WriteLine($"You parked for 6 hours and are charged for ${charge}");
                }
                else if (parkedhours > 360 && parkedhours <= 420)
                {

                    charge += 14;
                    Console.WriteLine($"You parked for 7 hours and are charged for ${charge}");
                }
                else if (parkedhours > 420 && parkedhours <= 480)
                {

                    charge += 16;
                    Console.WriteLine($"You parked for 8 hours and are charged for ${charge}");
                }
                
                else if (parkedhours > 480)
                {

                    charge = 20;
                    Console.WriteLine($"You parked for the charge limit and will be charged for ${charge}");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
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
            int category;
            Console.WriteLine("Welcome to our Hurricane Program");
            Console.WriteLine("Enter the categorty of Hurricane");
            category = Convert.ToInt32(Console.ReadLine());

            switch (category)
            {
                case 1:
                    Console.WriteLine("Winds speeds of 74-95mph or 64-82kt or 119-153km/hr");
                    break;
                case 2:
                    Console.WriteLine("Winds speeds of 96-110mph or 83-95kt or 154-177km/hr");
                    break;
                case 3:
                    Console.WriteLine("Winds speeds of 111-130mph or 96-113kt or 178-209km/hr");
                    break;
                case 4:
                    Console.WriteLine("Winds speeds of 131-155mph or 114-135kt or 210-249km/hr");
                    break;
                case 5:
                    Console.WriteLine("Winds speeds greater than 155mph or 135kt or 248km/hr");
                    break;
                default:
                    Console.WriteLine("That was not an option");
                    break;
            }
        }



    }
}