namespace Part_5._0_Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random rand = new Random();
            string transationType;
            double Balance = rand.Next(100, 150);
            double fee;
            fee = 0.75;
                       
            Console.WriteLine("Bank of Blorb");

            Console.WriteLine($"Your initial balnce is ${Balance}");
            Console.WriteLine("Please enter you transation type: deposit, withdraw, bill payment or an account balence update");
            transationType = Console.ReadLine().ToUpper();
            if (transationType == "DEPOSIT")
            {
                Console.WriteLine("Enter the amount you wish add to your account");
                double depositNumber = Convert.ToInt32(Console.ReadLine());
                Balance += depositNumber;
                Balance -= fee;
                Console.WriteLine($"New balence is ${Balance}");
            }
            else if (transationType == "WITHDRAW")
            {
                Console.WriteLine("Enter the amount you wish to withdraw");
                double withdrawNumber = Convert.ToInt32(Console.ReadLine());
            }


        }

      
    }
}