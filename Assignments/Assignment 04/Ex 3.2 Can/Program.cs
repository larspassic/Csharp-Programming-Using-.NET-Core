using System;

namespace Exercise_03._2_Can
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                PurchasePrice sodaPrice = new PurchasePrice(0.35M);
                CanRack sodaRack = new CanRack();

                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
                Console.Write("Please insert {0:c}: ", sodaPrice.PriceDecimal);
                decimal valueInserted2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("You have inserted {0:c}", valueInserted2);
                sodaRack.RemoveACanOf(Flavor.REGULAR);
                Console.WriteLine("Thanks, here is your soda.");

            }
        }
    }
}
