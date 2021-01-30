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
            while (true)
            {
                //Introduce the program
                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

                //Create a purchase price object
                PurchasePrice currentPrice = new PurchasePrice();

                //Prompt the user for input
                Console.Write($"Please insert {currentPrice.Price} cents:");

                //Store user input in a string
                string input = Console.ReadLine();

                //Convert the string to an int
                int inputInt = int.Parse(input);

                //Echo the input back to the user and report success
                Console.WriteLine($"You have inserted {inputInt} cents");
                Console.WriteLine("Thanks. Here is your soda.");
                
                //Extra line space to prepare for the next run
                Console.WriteLine();
            }
            
        }
    }
}
