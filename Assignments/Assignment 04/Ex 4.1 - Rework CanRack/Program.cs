﻿using System;
using System.Drawing;

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
                    //Create decimal value to calculate how much is remaining, and request the user to insert in coins
                    decimal priceRemaining = sodaPrice.PriceDecimal - valueInserted;
                    Console.Write($"You have deposited {valueInserted:c}.  Please insert {priceRemaining:c} in coins: ");

                    //Take input from the user and convert it to uppercase
                    string userInputString = Console.ReadLine();
                    userInputString = userInputString.ToUpper();

                    if (Enum.IsDefined(typeof(Coin.Denomination), userInputString))
                    {
                        coin = new Coin(userInputString);
                        Console.WriteLine($"You inserted a {coin} which is {coin.ValueOf:c}");
                    }
                    else
                    {
                        Console.WriteLine($"{userInputString} is not a recognized coin type.");
                    }

                    //Add the recent deposit into the total valueInserted decimal
                    valueInserted += coin.ValueOf;

                }
                //Tell the user they have paid enough to make a purchase, and display current inventory.
                Console.WriteLine();
                Console.WriteLine($"You may now select a soda.");
                sodaRack.DisplayCanRack();

                //Tell the user to make a selection, and take input as a string.
                Console.Write($"Please make a selection. Type the name of the flavor you would like:");
                string userInputFlavorChoice = Console.ReadLine();
                userInputFlavorChoice = userInputFlavorChoice.ToUpper();

                //No current logic to choose flavors so remove regular flavor by default.
                sodaRack.RemoveACanOf(userInputFlavorChoice);

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
