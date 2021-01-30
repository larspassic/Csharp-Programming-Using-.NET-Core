using System;
using System.Diagnostics;

//Assignment 02
//Author: Passic, Lars, 2011958

namespace SodaVendingMachine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Debug.WriteLine("This goes to the debug window");
            Debug.WriteLine("To make this window visible use menu item");
            Debug.WriteLine("Debug\\Windows\\Output");

            //Create a purchase price object
            PurchasePrice currentPrice = new PurchasePrice();

            //Create a CanRack object
            CanRack canRack = new CanRack();

            while (true)
            {
                
                //Introduce the program
                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

                //Prompt the user for input
                Console.Write($"Please insert {currentPrice.Price} cents:");

                //Store user input in a string
                string input = Console.ReadLine();

                //Convert the string to an int
                //Need to do some error handling on this to check for "" strings
                int inputInt = int.Parse(input);

                //Echo the input back to the user and report success
                Console.WriteLine($"You have inserted {inputInt} cents");

                //Check to see if input was enough to buy a soda
                if (inputInt >= currentPrice.Price)
                {
                    //Inform the user that they paid enough to purchase a soda
                    Console.WriteLine("You inserted enough cents to purchase a soda.");
                    
                    //Start to dispense the soda
                    if (canRack.IsEmpty("Regular") == false) //First check to see if the rack is empty - regular soda for now
                    {
                        canRack.RemoveACanOf("Regular"); //Subtract a can
                        Debug.WriteLine("Dispensing one can of soda to the user");
                        Console.WriteLine("Thanks. Here is your soda.");
                    }
                    else if (canRack.IsEmpty("Regular") == true)
                    {
                        Debug.WriteLine("The user attempted to buy a can of soda, but the rack was empty.");
                        Console.WriteLine("Sorry. That rack is empty.");
                    }
                }
                else
                {
                    Console.WriteLine("You did not insert enough cents to purchase a soda.");
                }
                
                //Extra line space to prepare for the next run
                Console.WriteLine();

            }
            
        }
    }
}
