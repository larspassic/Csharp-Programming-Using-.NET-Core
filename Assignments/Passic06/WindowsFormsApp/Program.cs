using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supplied_06._0_Vend_Lib;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Maybe do stuff before running the form?
            //This is where my project begins.

            //Establish today's soda purcahse price
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);

            //Create the CanRack object which holds soda counts
            CanRack sodaRack = new CanRack();
            
            //Create the primary CoinBox object which holds the change - notice that we are adding seed money here
            CoinBox changeBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL),
                new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.DIME)
            });

            //Create another CoinBox object which holds coins temporarily while the user inserts them
            CoinBox tempBox = new CoinBox();

            //This was already here before I started working on Program.cs
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSodaMachine());




        }
    }
}
