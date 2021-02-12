using System;

namespace Exercise_03._1_Purchase_Price_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here's the code using the obsolete representation of money as int
            PurchasePrice sodaPrice = new PurchasePrice(35);
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write("Please insert {0} cents: ", sodaPrice.Price);
            int valueInserted = int.Parse(Console.ReadLine());
            Console.WriteLine("You have inserted {0} cents", valueInserted);
            sodaRack.RemoveACanOf("REGULAR");
            Console.WriteLine("Thanks, here is your soda.");

            Console.WriteLine();
            Console.WriteLine();


            // Here's the code using the improved decimal version
            PurchasePrice sodaPrice2 = new PurchasePrice(0.35M);
            CanRack sodaRack2 = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write("Please insert {0:c}: ", sodaPrice2.PriceDecimal);
            decimal valueInserted2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("You have inserted {0:c}", valueInserted2);
            sodaRack2.RemoveACanOf("REGULAR");
            Console.WriteLine("Thanks, here is your soda.");


        }
    }
}
