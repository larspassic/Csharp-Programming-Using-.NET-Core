using System;

//Assignment 01
//Author: Passic, Lars, 2011958

namespace SodaVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Introduce the program
                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
                
                //Prompt the user for input
                Console.Write("Please insert 35 cents:");

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
