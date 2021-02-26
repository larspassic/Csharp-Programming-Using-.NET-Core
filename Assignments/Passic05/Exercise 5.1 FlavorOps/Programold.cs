using System;

//Assignment 05
//Author: Passic, Lars, 2011958

namespace Exercise_5._1_FlavorOps
{
    public class Programold
    {
        static VendingMachine sodaVendingMach = new VendingMachine();
        static PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        static void processCommandLine(string[] args)
        {
            OrderProcessor sodaOrder = new OrderProcessor();
            sodaOrder.CreateOrder(args);
            sodaOrder.fulfillOrder(sodaVendingMach, sodaPrice);
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            //Trying to use these two bools to help implement exception handling
            bool orderProcessed = false;
            bool vendCompleted = false;

            sodaVendingMach.sodaPrice = sodaPrice;
           while (orderProcessed == false)
            {
                try
                {
                    processCommandLine(args);
                    orderProcessed = true;
                }
                catch (System.ArgumentException e)
                {
                    Console.WriteLine($"{e.Message}, please try again.");
                    processCommandLine(args);
                }
            }
            
            while (vendCompleted == false) //I don't really understand how to
            {
                try
                {
                    sodaVendingMach.Vend();
                    vendCompleted = true;
                }
                catch (System.ArgumentException e)
                {
                    Console.WriteLine($"{e.Message}, please try again.");
                    
                }
            }
            

            Console.WriteLine($"{FlavorOps.AllFlavors[0]}");
        }
 
    }
}