using System;
using System.Collections.Generic;
using System.Linq;

//Assignment 05
//Author: Passic, Lars, 2011958

namespace Exercise_5._1_FlavorOps
{
    class OrderProcessor
    {
        private List<Flavor> flavorOrder = new List<Flavor>();
        decimal payment = 0M;

        public void CreateOrder(string[] args)
        {
            foreach (string arg in args)
            {
                Flavor requestedFlavor;
                Coin.Denomination insertedCoin;

                // attempt to convert the string into a soda flavor
                if (Enum.IsDefined(typeof(Flavor),arg.ToUpper()) && 
                    Enum.TryParse<Flavor>(arg.ToUpper(), out requestedFlavor))
                {
                    flavorOrder.Add(requestedFlavor);
                }
                // attempt to convert the string into a coin denomination
                else if (Enum.IsDefined(typeof(Coin.Denomination),arg.ToUpper()) && 
                    Enum.TryParse<Coin.Denomination>(arg.ToUpper(), out insertedCoin))
                {
                    payment += new Coin(insertedCoin).ValueOf;
                }
                else
                {
                    Console.WriteLine("Unrecognized command-line argument: {0}", arg);
                }
            }
        }

        public void fulfillOrder(VendingMachine sodaVendingMach, PurchasePrice sodaPrice)
        {
            decimal moneyRemaining = payment;
            while (moneyRemaining >= sodaPrice.PriceDecimal && flavorOrder.Any())
            {
                // if the can was dispensed, subtract its price from the
                // money entered
                if (sodaVendingMach.DispenseCan(flavorOrder[0]))
                {
                    System.Diagnostics.Debug.WriteLine("{0} Can dispensed from initial order", flavorOrder[0]);
                    moneyRemaining -= sodaPrice.PriceDecimal;
                }
                // remove the request from the order whether the can was dispensed or not
                flavorOrder.RemoveAt(0);
            }
            foreach (Flavor soda in flavorOrder)
            {
                Console.WriteLine("Requested {0} soda could not be dispensed", soda);
            }
            if (moneyRemaining > 0M)
            {
                Console.WriteLine("Here is your {0:c} back", moneyRemaining);
            }

        }
    }
}
