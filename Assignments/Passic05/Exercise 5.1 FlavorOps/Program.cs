using System;

//Assignment 05
//Author: Passic, Lars, 2011958

namespace Exercise_5._1_FlavorOps
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
                Console.Write("Please insert {0:c} worth of coins: ", sodaPrice.PriceDecimal);

                decimal totalValueInserted = 0M;
                while (totalValueInserted < sodaPrice.PriceDecimal)
                {
                    // get the coin inserted
                    string coinNameInserted = Console.ReadLine().ToUpper();
                    Coin coinInserted = new Coin(coinNameInserted);
                    Console.WriteLine("You have inserted a {0} worth {1:c}", coinInserted, coinInserted.ValueOf);

                    // running total of the value of the coins inserted
                    totalValueInserted += coinInserted.ValueOf;
                    Console.WriteLine("Total value inserted is {0:c}", totalValueInserted);
                }

                // select a flavor of soda
                Boolean canDispensed = false;
                while (!canDispensed)
                {
                    Console.Write("What flavor would you like? : "); 
                    

                    // oooh, this looks like trouble. Why?
                    //Needs exception handling
                    Flavor flavor = new Flavor();
                    
                    bool flavorFound = false;
                    while (flavorFound == false) //I think this will work for exception handling?
                    {
                        try
                        {
                            //ask the user for flavor
                            string flavorName = Console.ReadLine().ToUpper();

                            flavor = FlavorOps.ToFlavor(flavorName); //If this parse is successful...
                            flavorFound = true; //... this WILL execute and get us out of the loop. Maybe?
                        }
                        catch (System.ArgumentException e)
                        {
                            Console.WriteLine($"{e.Message}" + " Please try again.");
                        }
                    }
                    
                    

                    if (!sodaRack.IsEmpty(flavor))
                    {
                        sodaRack.RemoveACanOf(flavor);
                        Console.WriteLine("Thanks, here is your can of {0}.", flavor);
                        canDispensed = true;
                    }
                    else
                    {
                        Console.WriteLine("We are out of {0}", flavor);
                    }
                }

                Console.Write("Exit the vending machine? (y/n): ");
                string response = Console.ReadLine();
                timeToExit = response.Trim().ToUpper().StartsWith("Y");

            } while (!timeToExit);

        }
    }
}
