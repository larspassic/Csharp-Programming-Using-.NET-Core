﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supplied_06._0_Vend_Lib;

//Assignment 07
//Author: Passic, Lars, 2011958

namespace WindowsFormsApp
{
    public partial class FormSodaMachine : Form
    {
        public FormSodaMachine()
        {
            InitializeComponent();

            //disable the buttons on startup
            RefreshSodaButtons();

            //Set the exact change label
            RefreshExactChangeWarningLabel();
        }

        //Establish today's soda purcahse price
        PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        //Create the CanRack object which holds soda counts
        CanRack sodaRack = new CanRack();

        //Security check for the service tab - locked by default
        bool isLocked = true;

        //Hard-code the password as a string?
        string actualPassword = "service";

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

        public void RefreshTempBoxTextBox()
        {
            textBoxTotalMoneyInserted.Text = tempBox.ValueOf.ToString("C");
        }


        //
        //This section is all of the "Insert coin" buttons
        //
        private void buttonInsertHalfDollar_Click(object sender, EventArgs e)
        {
            DepositCoin(Coin.HALFDOLLARCOIN);
        }

        private void buttonInsertQuarter_Click(object sender, EventArgs e)
        {
            DepositCoin(Coin.QUARTERCOIN);
        }

        private void buttonInsertDime_Click(object sender, EventArgs e)
        {
            DepositCoin(Coin.DIMECOIN);
        }

        private void buttonInsertNickel_Click(object sender, EventArgs e)
        {
            DepositCoin(Coin.NICKELCOIN);
        }


        //This is the main DepositCoin method that handles the logic
        //Pass a coin denomination to this method to insert a coin in to the temp box
        //Also updates each button with can rack stock information during each run of the method
        private void DepositCoin(Coin coinToBeDepositied)
        {
            //Insert a dime coin in to the temp box
            tempBox.Deposit(coinToBeDepositied);

            //Update the value of the temp box after inserting
            RefreshTempBoxTextBox();

            //Update the coin return tray
            ReturnCoins();
            
            //Refresh the buttons based on soda availability and temp box money
            RefreshSodaButtons();
        }

        private void RefreshSodaButtons()
        {
            //Check if we have enough to buy a soda
            if (tempBox.ValueOf >= sodaPrice.PriceDecimal)
            {
                //For each button, always check to see if that flavor is in-stock, and if so, enable the button
                buttonRegular.Enabled = !sodaRack.IsEmpty(Flavor.REGULAR);
                buttonOrange.Enabled = !sodaRack.IsEmpty(Flavor.ORANGE);
                buttonLemon.Enabled = !sodaRack.IsEmpty(Flavor.LEMON);
            }
            else //if we don't have enough to buy a soda - all buttons are disabled
            {
                buttonRegular.Enabled = false;
                buttonOrange.Enabled = false;
                buttonLemon.Enabled = false;
            }
        }


        //Event handler for when the Coin Return button is clicked
        private void buttonCoinReturn_Click(object sender, EventArgs e)
        {
                //Take the current value of the box and store it as a varaible
                decimal amountInTempBox = tempBox.ValueOf;
                
                //If there's nothing to return, the coin return box will be reset. Otherwise it will return the coins.
                ReturnCoins(amountInTempBox);

                //Withdraw the current value from the tempBox
                tempBox.Withdraw(amountInTempBox);

                //Update the value of the temp box after returning coins
                RefreshTempBoxTextBox();
        }


        //Send this method nothing, and it will simply zero out the coin return tray
        private void ReturnCoins()
        {
            //Reset the text to be the default identifier text
            richTextBoxCoinReturnTray.Text = $"\n\n        COIN RETURN TRAY";
        }


        //Send this method a decimal and it will announce the coin returning to the user
        private void ReturnCoins(decimal amountToBeReturned)
        {
            if (amountToBeReturned > 0M)
            {
                //Notify user in the coin return tray
                richTextBoxCoinReturnTray.Text = $"Clink clink clink!!\nReturning {amountToBeReturned:c} in the coin return box.";
            }
            else //no coins to be returned so reset the coin return tray
            {
                ReturnCoins();
            }

        }


        //Main method to eject cans of soda - provide with a flavor
        private void EjectCan(Flavor flavorToEject)
        {
            //Do we have enough money and do we have a can of this flavor
            if (tempBox.ValueOf >= sodaPrice.PriceDecimal && sodaRack.IsEmpty(flavorToEject) == false)
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
                        ReturnCoins(changeToReturn);
                    }
                }
                //Either way, update the the temp box indicator with zero
                textBoxTotalMoneyInserted.Text = "$0.00";

                //Transfer the temp box in to the main box
                tempBox.Transfer(changeBox);

                //Check the exact change light
                RefreshExactChangeWarningLabel();

                //Eject the soda out to the user, and remove one soda from the rack
                sodaRack.RemoveACanOf(flavorToEject);

                //Refresh soda buttons
                RefreshSodaButtons();

                //Notify the customer they got a can of soda
                MessageBox.Show($"Here is your can of {flavorToEject}");

            }
        }

        //Method to refresh the warning level for exact change
        private void RefreshExactChangeWarningLabel()
        {
            labelExactChangeRequired.Visible = !changeBox.CanMakeChange;
        }

        //Regular button
        private void buttonRegular_Click(object sender, EventArgs e)
        {
            EjectCan(Flavor.REGULAR);
        }
        //Orange button
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            EjectCan(Flavor.ORANGE);
        }
        //Lemon button
        private void buttonLemon_Click(object sender, EventArgs e)
        {
            EjectCan(Flavor.LEMON);
        }

        //Vend tab entered
        private void tabVend_Enter(object sender, EventArgs e)
        {
            RefreshTempBoxTextBox();
            RefreshExactChangeWarningLabel();
            RefreshSodaButtons();
        }

        //Service tab entered
        private void tabService_Enter(object sender, EventArgs e)
        {
            RefreshServiceTab();

        }

        private void RefreshServiceTab()
        {
            //things to do if service tab is locked
            if (isLocked == true)
            {
                //Make the group boxes locked
                labelService.Text = "Service is locked";
                groupBoxCanStock.Visible = false;
                groupBoxChangeBoxCoinStock.Visible = false;
                groupBoxTempBoxCoinStock.Visible = false;
                buttonLockServiceTab.Visible = false;

                //Make the password elements visible
                labelPassword.Visible = true;
                textBoxPasswordBox.Visible = true;
                buttonPasswordSubmit.Visible = true;
            }

            //Things to do if the service tab is unlocked
            if (isLocked == false)
            {
                //Make the password elements invisible
                labelPassword.Visible = false;
                textBoxPasswordBox.Visible = false;
                labelIncorrectPassword.Visible = false;
                buttonPasswordSubmit.Visible = false;
                
                //Make the service tab elements visible
                labelService.Text = "Service";
                groupBoxCanStock.Visible = true;
                groupBoxChangeBoxCoinStock.Visible = true;
                groupBoxTempBoxCoinStock.Visible = true;
                buttonLockServiceTab.Visible = true;

                //Refresh everything
                RefreshCanStockListBox();
                RefreshCoinBoxListView(changeBox, listViewChangeBoxInventory);
                RefreshCoinBoxListView(tempBox, listViewTempBoxInventory);
            }
        }

        private void RefreshCoinBoxListView(CoinBox coinBoxToRead, ListView listViewToRefresh)
        {
            //First clear out the old listView entries
            listViewToRefresh.Items.Clear();

            //Loop through each type of coin and add it to the listview
            foreach (Coin.Denomination aCoin in Coin.AllDenominations)
            {
                //Special case to skip SLUGs
                if (aCoin == Coin.Denomination.SLUG)
                {
                    continue;
                }

                //Create a row item and add two columns to it
                ListViewItem lviRow = new ListViewItem(aCoin.ToString());
                lviRow.SubItems.Add($"{coinBoxToRead.coinCount(aCoin)}");
                lviRow.SubItems.Add($"{(Coin.ValueOfCoin(aCoin) * coinBoxToRead.coinCount(aCoin)).ToString("C")}");

                //Add the row item to the listview 
                listViewToRefresh.Items.Add(lviRow);
            }

            //Create a TOTAL row to show the total amount of coins in the coin box
            ListViewItem lviTotalRow = new ListViewItem("TOTAL");
            lviTotalRow.Font = new Font(lviTotalRow.Font, lviTotalRow.Font.Style | FontStyle.Bold);
            lviTotalRow.SubItems.Add($"");
            lviTotalRow.SubItems.Add($"{coinBoxToRead.ValueOf.ToString("C")}");
            listViewToRefresh.Items.Add(lviTotalRow);

            //After pulling data in, set to auto resize
            listViewToRefresh.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewToRefresh.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void RefreshCanStockListBox()
        {
            //First clear out the old listBox entries
            listBoxCanStock.Items.Clear();

            //Loop through and make a list entry for each actual can of each flavor type
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                for (int i = 0; i < sodaRack[aFlavor]; i++)
                {
                    listBoxCanStock.Items.Add($"{aFlavor}");
                }
            }

            //Count the total list items
            numericUpDownCanCount.Value = (listBoxCanStock.Items.Count);
        }

        private void buttonRefillCanRack_Click(object sender, EventArgs e)
        {
            sodaRack.FillTheCanRack();
            RefreshCanStockListBox();
        }

        private void buttonEmptyChangeBox_Click(object sender, EventArgs e)
        {
            changeBox.Withdraw(changeBox.ValueOf);
            RefreshCoinBoxListView(changeBox, listViewChangeBoxInventory);
        }

        private void buttonEmptyTempBox_Click(object sender, EventArgs e)
        {
            tempBox.Withdraw(tempBox.ValueOf);
            RefreshCoinBoxListView(tempBox, listViewTempBoxInventory);
        }

        private void buttonPasswordSubmit_Click(object sender, EventArgs e)
        {
            //Load the inserted password in to a variable
            string insertedPassword = textBoxPasswordBox.Text;

            if (insertedPassword == actualPassword)
            {
                textBoxPasswordBox.Text = "";
                isLocked = false;
                RefreshServiceTab();
            }
            else
            {
                textBoxPasswordBox.Text = "";
                labelIncorrectPassword.Visible = true;
            }
        }

        private void textBoxPasswordBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = buttonPasswordSubmit;
        }

        private void buttonLockServiceTab_Click(object sender, EventArgs e)
        {
            isLocked = true;
            RefreshServiceTab();
        }
    }
}
