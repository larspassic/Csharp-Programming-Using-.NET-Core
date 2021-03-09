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

        //Create the primary CoinBox object which holds the change
        //Adding seed money as a list of coins per the assignment instructions
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
        
        //I am not sure why this does not work
        //textBoxTotalMoneyInserted.Text = ;

        public void UpdateTempBoxTextBox()
        {
            textBoxTotalMoneyInserted.Text = tempBox.ValueOf.ToString("C");
        }

        //This code inserts a half-dollar in to the temp box
        private void buttonInsertHalfDollar_Click(object sender, EventArgs e)
        {
            //Write code to insert a half-dollar coin in to the temp box
            tempBox.Deposit(Coin.HALFDOLLARCOIN);

            //Update the value of the temp box after inserting
            UpdateTempBoxTextBox();
        }

        private void buttonInsertQuarter_Click(object sender, EventArgs e)
        {
            //Insert a quarter coin in to the temp box
            tempBox.Deposit(Coin.QUARTERCOIN);

            //Update the value of the temp box after inserting
            UpdateTempBoxTextBox();
        }

        private void buttonInsertDime_Click(object sender, EventArgs e)
        {
            //Insert a dime coin in to the temp box
            tempBox.Deposit(Coin.DIMECOIN);

            //Update the value of the temp box after inserting
            UpdateTempBoxTextBox();
        }

        private void buttonInsertNickel_Click(object sender, EventArgs e)
        {
            //Insert a nickel coin in to the temp box
            tempBox.Deposit(Coin.NICKELCOIN);

            //Update the value of the temp box after inserting
            UpdateTempBoxTextBox();
        }

        private void buttonCoinReturn_Click(object sender, EventArgs e)
        {
            if (tempBox.ValueOf > 0)
            {
                //Take the current value of the box and store it as a varaible
                decimal amountInTempBox = tempBox.ValueOf;

                //Notify user in the coin return tray
                richTextBoxCoinReturnTray.Text = $"Clink clink clink!! Returning {amountInTempBox:c} to you!!";

                //Withdraw the current value from the tempBox
                tempBox.Withdraw(amountInTempBox);

                //Update the value of the temp box after returning coins
                UpdateTempBoxTextBox();
            }
            else
            {
                richTextBoxCoinReturnTray.Text = "";
            }

        }

        private void buttonRegular_Click(object sender, EventArgs e)
        {
            EjectCan();
        }

        private void EjectCan()
        {
            //Do we have enough money and do we have a can of this flavor
            if (tempBox.ValueOf >= sodaPrice.PriceDecimal && sodaRack.IsEmpty(Flavor.REGULAR) == false)
            {
                //Check if the change box can make change
                if (changeBox.CanMakeChange)
                {
                    //Make change using tempbox minus purchase price
                    decimal changeToReturn = tempBox.ValueOf - sodaPrice.PriceDecimal;

                    //If there is some change to return
                    if (changeToReturn > 0M)
                    {
                        //Remove the change from the changeBox
                        changeBox.Withdraw(changeToReturn);

                        //Notify the user
                        richTextBoxCoinReturnTray.Text = $"Clink clink clink!!\nReturning {changeToReturn:C} in the coin return box.";
                    }

                    //Either way, update the the temp box indicator with zero
                    textBoxTotalMoneyInserted.Text = "$0.00";

                    //Eject the soda out to the user, and remove one soda from the rack
                    sodaRack.RemoveACanOf(Flavor.REGULAR);

                    //Turn off the eject button
                    buttonRegular.Enabled = false;
                    buttonOrange.Enabled = false;
                    buttonLemon.Enabled = false;

                    //Notify the customer they got a can of soda
                    MessageBox.Show($"Here is your can of {Flavor.REGULAR}");
                }
            }
        }
    }
}
