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
            Coin coin = new Coin();

            while (true) //Start the main program loop
            {

                //Instructions for the user
                Console.WriteLine();
                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

                
                
                decimal valueInserted = 0m; //set up decimal value for loop

                while (valueInserted < sodaPrice.PriceDecimal)
                {
                    //Create decimal value for how much is remaining for the user to insert
                    decimal priceRemaining = sodaPrice.PriceDecimal - valueInserted;

                    //Take input from the user and convert it to, and store it as, a decimal, and communicate what the user inserted
                    Console.Write($"You have deposited {valueInserted:c}.  Please insert {priceRemaining:c}: ");
                    decimal valueInserted2 = decimal.Parse(Console.ReadLine());

                    //Add the recent deposit into the total valueInserted decimal
                    valueInserted += valueInserted2;

                    Console.WriteLine($"You just inserted {valueInserted2:c}");
                }
                
                //No current logic to choose flavors so remove regular flavor by default.
                sodaRack.RemoveACanOf(Flavor.REGULAR);

                //Call the newly-created DisplayCanRack method to display inventory.
                sodaRack.DisplayCanRack();

                //Ask the user if they want to quit
                Console.WriteLine();
                Console.Write("Would you like to quit? (Y/N):");
                string userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")
                {
                    Console.WriteLine("You have chosen to quit. Exiting program.");
                    //Start-Sleep 5; //How to make a little timer here?
                    break;
                }
            }
        }
    }
}
