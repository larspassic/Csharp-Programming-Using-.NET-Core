using System;
using System.Collections.Generic;

//Assignment 06
//Author: Passic, Lars, 2011958

namespace Assignment_06_WinForms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the sodaPrice object
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);
            
            //Create the rack object
            CanRack sodaRack = new CanRack();

            //Create a changeBox object
            //Looks like this is going to use the "seed money" constructor
            CoinBox changeBox = new CoinBox(new List<Coin> { 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME), 
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER), 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            Boolean timeToExit = false;
            do
            {
                sodaRack.DisplayCanRack();
                Console.Write($"Please insert {sodaPrice.PriceDecimal:c} worth of coins: ");

                decimal totalValueInserted = 0M;

                //Loop while the user is inserting money
                while (totalValueInserted < sodaPrice.PriceDecimal)
                {
                    Coin coinInserted = null;
                    while (coinInserted == null)
                    {
                        // get the coin inserted
                        string coinNameInserted = Console.ReadLine().ToUpper();
                        coinInserted = new Coin(coinNameInserted);
                    }
                    Console.WriteLine($"You have inserted a {coinInserted} worth {coinInserted.ValueOf:c}");
                    changeBox.Deposit(coinInserted);

                    // running total of the value of the coins inserted
                    totalValueInserted += coinInserted.ValueOf;
                    Console.WriteLine($"Total value inserted is {totalValueInserted:c}");
                }

                // select a flavor of soda
                Boolean canDispensed = false;
                
                //Loop until a can gets dispensed
                while (!canDispensed)
                {
                    //Default flavor is REGULAR - kinda weird.
                    Flavor flavorEnumeral = Flavor.REGULAR;
                    Boolean flavorChosen = false;
                    Console.Write("What flavor would you like? : ");
                    
                    //Loop until a flavor has been chosen
                    while (!flavorChosen)
                    {
                        try
                        {
                            // get the flavor request
                            string flavorName = Console.ReadLine().ToUpper();
                            // Well, this used to be trouble.
                            flavorEnumeral = FlavorOps.ToFlavor(flavorName);
                            flavorChosen = true;
                        }
                        catch (System.ComponentModel.InvalidEnumArgumentException e)
                        {
                            Console.WriteLine(e.Message + "Please retry.");
                        }
                        catch (VENDBADFLAVORException ve)
                        {
                            Console.WriteLine(ve.Message);
                            Console.WriteLine("Please retry.");
                        }
                    }
                    
                    //If the sodaRack is NOT empty of the flavor that was found above
                    if (!sodaRack.IsEmpty(flavorEnumeral))
                    {
                        sodaRack.RemoveACanOf(flavorEnumeral);
                        Console.WriteLine("Thanks, here is your can of {0}.", flavorEnumeral);
                        canDispensed = true;
                    }
                    else
                    {
                        //Tell the user that the flavor is empty
                        Console.WriteLine($"We are out of {flavorEnumeral}");
                    }
                }

                Console.Write("Exit the vending machine? (y/n): ");
                string response = Console.ReadLine();
                //This is a super interesting way to get a purified yes/no response!
                timeToExit = response.Trim().ToUpper().StartsWith("Y");
                
             //If it is NOT time to exit...
            } while (!timeToExit); 

            Console.WriteLine("Contents of Coin Box:");

            Console.WriteLine("{0}\tHalf Dollar(s)", changeBox.HalfDollarCount);
            Console.WriteLine("{0}\tQuarter(s)", changeBox.QuarterCount);
            Console.WriteLine("{0}\tDime(s)", changeBox.DimeCount);
            Console.WriteLine("{0}\tNickel(s)", changeBox.NickelCount);
            Console.WriteLine("{0}\tSlug(s)", changeBox.SlugCount);

            Console.WriteLine();
            Console.WriteLine("Total value in coin box is {0:c}", changeBox.ValueOf);
        }
    }
}
