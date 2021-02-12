using System;

//Assignment 04
//Author: Passic, Lars, 2011958

namespace Ex_4._1_Rework_CanRack
{
    class Program
    {
        static void Main(string[] args)
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
