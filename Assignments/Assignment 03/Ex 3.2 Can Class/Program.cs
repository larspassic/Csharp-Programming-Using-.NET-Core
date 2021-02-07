using System;

//Assignment 03
//Author: Passic, Lars, 2011958

namespace Ex_3_2_Can_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(35);

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write($"Please insert {sodaPrice.PriceDecimal:c} cents: ");
            int valueInserted = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have inserted {valueInserted} cents");
            Console.WriteLine("Thanks, here is your soda.");
        }
    }
}
