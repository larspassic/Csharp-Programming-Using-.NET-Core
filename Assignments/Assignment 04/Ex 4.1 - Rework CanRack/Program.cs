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


            while (true) //Start the main program loop
            {

                //Instructions for the user
                Console.WriteLine();
                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

                //Take input from the user and convert it to, and store it as, a decimal, and communicate what the user inserted
                Console.Write("Please insert {0:c}: ", sodaPrice.PriceDecimal);
                decimal valueInserted2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("You have inserted {0:c}", valueInserted2);
                
                //No current logic to choose flavors so remove regular flavor by default. YOU CAN'T RUSH ART!
                sodaRack.RemoveACanOf(Flavor.REGULAR);

                //Call the newly-created DisplayCanRack method to display inventory.
                sodaRack.DisplayCanRack();
            }
        }
    }
}
