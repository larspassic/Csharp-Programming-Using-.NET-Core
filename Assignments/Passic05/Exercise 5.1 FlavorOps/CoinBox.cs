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
            //I don't understand the difference between what line 14 is doing and what line 21 is doing.
            box = new List<Coin>();
        }

        //Constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {
            box = SeedMoney;
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
                return CoinCount(Coin.Denomination.HALFDOLLAR);
            }

        }

        //Number of quarters in the coin box
        //Need to use a LINQ query here
        public int QuarterCount
        {
            get
            {
                return CoinCount(Coin.Denomination.QUARTER);
            }
        }

        //Number of dimes in the coin box
        //Need to use a LINQ query here
        public int DimeCount
        {
            get
            {
                return CoinCount(Coin.Denomination.DIME);
            }
            
        }

        //Number of nickels in the coin box
        //Need to use a LINQ query here
        public int NickelCount
        {
            get
            {
                return CoinCount(Coin.Denomination.NICKEL);
            }
        }

        //Number of worthless coins in the coin box
        //Need to use a LINQ query here
        public int SlugCount
        {
            get
            {
                return CoinCount(Coin.Denomination.SLUG);
            }
        }

        //Total amount of money in the coin box
        public decimal ValueOf
        {
            get
            {
                decimal totalValue = 0m;


                return totalValue;
            }
            
        }

        public int CoinCount(Coin.Denomination ADenomination)
        {
            //Create a variable to store the result
            int coinCountFound = 0;
            
            //LINQ query to find only coins that match the demonination that was passed in
            var findCoins =
            from possibleCandidate in box
            where possibleCandidate.CoinEnumeral == ADenomination
            select possibleCandidate;

            //Now store the count of the results as the int variable
            coinCountFound = findCoins.Count();

            return coinCountFound;
        }


    }
}

