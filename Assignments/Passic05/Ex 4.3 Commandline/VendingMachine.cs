using System;

namespace Exercise_04._3_Commandline
{
    // The VendingMachine class is a helper class for the Program class.
    // It is a sort of glue package holding other objects
    // (like Can and CanRack) together. Logically, it does include
    // the concept of I/O (i.e., the vending machine does interface
    // with the outside world), and so can reasonably include
    // I/O.
    // It provides functionality for Main() to use.
    class VendingMachine
    {
        private CanRack sodaRack = new CanRack();
        public PurchasePrice sodaPrice = new PurchasePrice(0M);

        public VendingMachine()
        {
        }

        public void Vend()
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            Boolean timeToExit = false;
            do
            {
                sodaRack.DisplayCanRack();
                ReceivePayment();
                Flavor flavorToDispense = ChooseFlavor();
                DispenseCan(flavorToDispense);
                Console.Write("Exit the vending machine? (y/n): ");
                string response = Console.ReadLine();
                timeToExit = response.Trim().ToUpper().StartsWith("Y");

            } while (!timeToExit);
        }

        public void ReceivePayment()
        {
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
        }

        // Allow the user to select a flavor of soda.
        // Note that the design of this code might
        // lead us to need exception handling
        // while this is not strictly bad
        // we might consider creating a 
        // method like TryChooseFlavor()
        // to reduce this need.
        public Flavor ChooseFlavor()
        {
            Boolean flavorChosen = false;
            Flavor flavor = Flavor.REGULAR;
            while (!flavorChosen)
            {
                Console.Write("What flavor would you like? : ");
                string flavorName = Console.ReadLine().ToUpper();
                // oooh, this looks like trouble. Why?
                flavor = (Flavor)Enum.Parse(typeof(Flavor), flavorName);
                flavorChosen = true;
            }
            return flavor; 
        }

        public bool DispenseCan(Flavor CanToDispense)
        {
            bool result = false;
            if (!sodaRack.IsEmpty(CanToDispense))
            {
                sodaRack.RemoveACanOf(CanToDispense);
                Console.WriteLine("Thanks, here is your can of {0}.", CanToDispense);
                result = true;
            }
            else
            {
                Console.WriteLine("We are out of {0}", CanToDispense);
                result = false;
            }
            return result;
        }
    }
}
