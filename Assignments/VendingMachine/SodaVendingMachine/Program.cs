using System;
using System.Diagnostics;

//Assignment 01
//Author: Passic, Lars, 2011958

namespace SodaVendingMachine
{
    class Program
    {
        
        //This class represents the purchase price of something.
        //In our software project, we will use it to represent the price of one can of soda.
        class PurchasePrice
        {
            //This constructor sets the purchase price to zero
            public PurchasePrice()
            {
                Price = 0;
            }

            //This constructor allows a new purchase price to be set by the user
            public PurchasePrice(int initialPrice)
            {
                Price = initialPrice;
            }

            //This property gets and sets the value of the purchase price
            public int Price
            {
                get
                {
                    return Price;
                }
                set
                {
                    Price = value;
                }
            }
        } //end PurchasePrice



        //This class will represent a can storage rack of the vending machine.
        //A can of soda will simply be represented as a number
        //(e.g., orangeCans = 1 means there is one can of orange soda in the rack).
        class CanRack
        {
            //Constructor for a can rack. The rack starts out full
            public CanRack()
            {

            }

            //This method adds a can of the specified flavor to the rack.
            public void AddACanOf(string FlavorOfCanToBeAdded)
            {

            }

            //This method will remove a can of the specified flavor from the rack.
            public void RemoveACanOf(string FlavorOfCanToBeRemoved)
            {

            }

            //This method will fill the can rack.
            public void FillTheCanRack()
            {

            }

            //This public void will empty the rack of a given flavor.
            public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
            {

            }

            //OPTIONAL - returns true if the rack is full of a specified flavor
            //false otherwise
            public Boolean IsFull(string FlavorOfBinToCheck)
            {
                if ()
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
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
