using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.Design;

//Assignment 05
//Author: Passic, Lars, 2011958

namespace Exercise_5._1_FlavorOps
{
    class CoinBox
    {
        private List<Coin> box;


        //Constructor to create an empty coin box
        public CoinBox()
        {
            //Do something to establish the different coins at zero?
            box = new List<Coin>();
        }

        //Constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {

        }

        //Put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        //Take a coin of the specified denomination out of the box
        //Need to use a LINQ query here
        public Boolean Withdraw(Coin.Denomination denomination)
        {
            bool result = false;



            return result;
        }

        //Number of Half Dollars in the coin box
        //Need to use a LINQ query here
        public int HalfDollarCount
        {
            get
            {
                return;
            }

        }

        //Number of quarters in the coin box
        //Need to use a LINQ query here
        public int QuarterCount
        {

        }

        //Number of dimes in the coin box
        //Need to use a LINQ query here
        public int DimeCount
        {

        }

        //Number of nickels in the coin box
        //Need to use a LINQ query here
        public int NickelCount
        {

        }

        //Number of worthless coins in the coin box
        //Need to use a LINQ query here
        public int SlugCount
        {

        }

        //Total amount of money in the coin box
        public decimal ValueOf
        {

        }

        public int CoinCount(Coin.Denomination ADenomination)
        {
            int coinCountFound = 0;
            var findHalfDollars =
            from possibleCandidate in box
            where possibleCandidate.Count == ADenomination;
            select possibleCandidate;

            return coinCountFound;
        }


    }
}

