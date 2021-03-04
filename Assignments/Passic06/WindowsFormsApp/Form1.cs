using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supplied_06._0_Vend_Lib;

namespace WindowsFormsApp
{
    public partial class FormSodaMachine : Form
    {
        public FormSodaMachine()
        {
            //Apparently this section is just for creating the forms app - or something?

            //Demo in class with Kevin
            //CanRack therackX = new CanRack();

            //Does this part actually create the forms app??
            InitializeComponent();

            //At first I had my PurchasePrice, CanRack, and CoinBox declarations here - but nothing worked. Why was that??
        }

        //Establish today's soda purcahse price
        PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        //Create the CanRack object which holds soda counts
        CanRack sodaRack = new CanRack();

        //Create the primary CoinBox object which holds the change - notice that we are adding seed money here!!
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

        //I will try to program some of my own stuff here

        textBoxTotalMoney



        //This code inserts a half-dollar in to the temp box
        private void buttonInsertHalfDollar_Click(object sender, EventArgs e)
        {
            //Write code to insert a half-dollar coin in to the temp box
            tempBox.Deposit(Coin.HALFDOLLARCOIN);
        }

        private void buttonInsertQuarter_Click(object sender, EventArgs e)
        {
            //Insert a quarter coin in to the temp box
            tempBox.Deposit(Coin.QUARTERCOIN);
        }

        private void buttonInsertDime_Click(object sender, EventArgs e)
        {
            //Insert a dime coin in to the temp box
            tempBox.Deposit(Coin.DIMECOIN);
        }

        private void buttonInsertNickel_Click(object sender, EventArgs e)
        {
            //Insert a nickel coin in to the temp box
            tempBox.Deposit(Coin.NICKELCOIN);
        }

        private void buttonCoinReturn_Click(object sender, EventArgs e)
        {
            //Take the current value of the box and store it as a varaible
            decimal amountInTempBox = tempBox.ValueOf;

            //Withdraw the current value from the tempBox
            tempBox.Withdraw(amountInTempBox);
        }
    }
}
