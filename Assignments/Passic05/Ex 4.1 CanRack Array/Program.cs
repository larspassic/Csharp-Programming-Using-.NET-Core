using System;

namespace Exercise_04._1_CanRack_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            Boolean timeToExit = false;
            do
            {
                sodaRack.DisplayCanRack();
                Console.Write("Please insert {0:c}: ", sodaPrice.PriceDecimal);
                decimal valueInserted = decimal.Parse(Console.ReadLine());
                Console.WriteLine("You have inserted {0:c}", valueInserted);
                sodaRack.RemoveACanOf(Flavor.REGULAR);
                Console.WriteLine("Thanks, here is your soda.");

                
                Console.Write("Exit the vending machine? (y/n): ");
                string response = Console.ReadLine();
                timeToExit = response.Trim().ToUpper().StartsWith("Y");
                    
            } while (!timeToExit);
           
        }

    }
}
