using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Supplied_06._0_Vend_Lib
{
    public class CoinBox
    {
        private List<Coin> box;

        // constructor to create an empty coin box
        public CoinBox()
        {
            box = new List<Coin>();
        }

        // constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {
            box = SeedMoney;                
        }

        // Note that the reverse list object must be created
        // because List<Coin.Denomination>.Reverse() reverses the list but
        // that list is readonly and therefore cannot be modified outside
        // of its defining class
        private static List<Coin.Denomination> reversedCoinList = null;

        static CoinBox()
        {
            reversedCoinList = new List<Coin.Denomination>(Coin.AllDenominations);
            reversedCoinList.Reverse();
        }

        // put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        // take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            var aCoin =
                from firstCoin in box
                where firstCoin.DenominationEnumeral == ACoinDenomination
                select firstCoin;

            Boolean result = false;
            if (aCoin.Count() > 0)
            {
                result = box.Remove(aCoin.First());
            }
            return result;
        }

         // attempt to remove an amount of money from the coin box
        public Boolean Withdraw(decimal AmountToRemove)
        {
            decimal amountRemoved = 0M;
            decimal amountLeftToRemove = AmountToRemove;
            if ((AmountToRemove % Coin.ValueOfCoin(Coin.Denomination.NICKEL)) != 0)
            {
                Debug.WriteLine("Withdrawal failed on amount {0:C}: non multiple of 5 cents", AmountToRemove);
                return false;
            }
            if (!ContainsExactChangeFor(AmountToRemove))
            {
                Debug.WriteLine("Withdraw failed: Exact change requirement not met ValueOf={0:c}, AmountToRemove={1:c}",
                    this.ValueOf,AmountToRemove);
                return false;
            }

            foreach (Coin.Denomination denominationEnumeral in reversedCoinList)
            {
                decimal amountOfThisCoinRemoved = 0M;
                if (amountLeftToRemove >= Coin.ValueOfCoin(denominationEnumeral))
                {
                    amountOfThisCoinRemoved = removeCoinDenomiation(
                        amountLeftToRemove, denominationEnumeral);
                    amountLeftToRemove -= amountOfThisCoinRemoved;
                    amountRemoved += amountOfThisCoinRemoved;
                }

            }
            Debug.WriteLine("AmountRemoved {0:c}, AmountToRemove {1:c}", amountRemoved, AmountToRemove);
            return amountRemoved == AmountToRemove;
        }

        private bool ContainsExactChangeFor(decimal Amount)
        {
            Boolean result = false;
            decimal amountToCheckFor = Amount;
            
            if (amountToCheckFor < 0M)
                {
                    result = false;
                }
            else if (amountToCheckFor == 0M)
            {
                result = true;
            }
            else
            {
                foreach (Coin.Denomination denominationEnumeral in reversedCoinList)
                {
                    for (int i = 0; i < coinCount(denominationEnumeral); i++)
                    {
                        if (amountToCheckFor >= Coin.ValueOfCoin(denominationEnumeral))
                        {
                            amountToCheckFor -= Coin.ValueOfCoin(denominationEnumeral);
                        }
                        else
                        {
                            break;
                        }
                    }
                    result = amountToCheckFor == 0M;
                }
            }
            return result;
        }

        // remove as many of a specified coin as possible, without going over
        private decimal removeCoinDenomiation(decimal AmountToRemove, Coin.Denomination denominationEnumeral)
        {
            var coins =
                from aCoin in box
                where aCoin.DenominationEnumeral == denominationEnumeral
                select aCoin;

            var coinArray = coins.ToArray();

            decimal amountRemoved = 0M;
            decimal amountLeftToRemove = AmountToRemove;

            foreach (Coin aCoin in coinArray)
            {
                if (amountLeftToRemove >= Coin.ValueOfCoin(denominationEnumeral))
                {
                    box.Remove(aCoin);
                    amountRemoved += aCoin.ValueOf;
                    amountLeftToRemove -= aCoin.ValueOf;                    
                }
                else
                {
                    break;
                }
            }

            return amountRemoved;
        }

        public Boolean CanMakeChange
        {
            get
            {
                return (
                    ContainsExactChangeFor(0.05M) &&
                    ContainsExactChangeFor(0.20M) &&
                    ContainsExactChangeFor(0.25M) &&
                    ContainsExactChangeFor(0.35M) &&
                    ContainsExactChangeFor(0.45M) &&
                    ContainsExactChangeFor(0.50M)
                    );
            }
        }

        public int coinCount(Coin.Denomination denominationEnumeral)
        {
            var roll =
                    from coin in box
                    where coin.DenominationEnumeral == denominationEnumeral
                    select coin;

            return roll.Count();
        }

        // number of half dollars in the coin box
        public int HalfDollarCount
        {
            get
            {
                return coinCount(Coin.Denomination.HALFDOLLAR);
            }
        }

        // number of quarters in the coin box
        public int QuarterCount
        {
            get
            {
                return coinCount(Coin.Denomination.QUARTER);
            }
        }

        // number of dimes in the coin box
        public int DimeCount
        {
            get
            {
                return coinCount(Coin.Denomination.DIME);
            }
        }

        // number of nickels in the coin box
        public int NickelCount
        {
            get
            {
                return coinCount(Coin.Denomination.NICKEL);
            }
        }
        
        // number of worthless coins in the coin box
        public int SlugCount
        {
            get
            {
                return coinCount(Coin.Denomination.SLUG);
            }
        }

        // total amount of money in the coin box
        public decimal ValueOf
        {
            get
            {
                decimal result =
                    HalfDollarCount * (decimal)Coin.Denomination.HALFDOLLAR/100M +
                    QuarterCount * (decimal)Coin.Denomination.QUARTER / 100M +
                    DimeCount * (decimal)Coin.Denomination.DIME / 100M +
                    NickelCount * (decimal)Coin.Denomination.NICKEL / 100M;
                return result;

            }
        }

        public decimal Transfer(CoinBox Destination)
        {
            decimal result = 0M;
            int count = box.Count;
            for (int index = 0; index < count; index++)
            {
                result += box[0].ValueOf;
                Destination.Deposit(box[0]);
                this.box.Remove(box[0]);
            }
            return result;
        }

        public Boolean Transfer(CoinBox Destination, decimal Amount, Boolean ExceedIfRequired)
        {
            Boolean result = false;  // start out assuming transfer didn't happen

            if (this.ValueOf >= Amount)
            {
                decimal amountRemoved = 0M;
                decimal amountDeposited = 0M;
                decimal amountLeftToTransfer = Amount;
                // try to withdraw exact amount and deposit it into Destination
                foreach (Coin.Denomination denominationEnumeral in reversedCoinList)
                {
                    Coin aCoin = new Coin(denominationEnumeral);
                    amountDeposited = 0M;
                    amountRemoved = this.removeCoinDenomiation(amountLeftToTransfer, aCoin.DenominationEnumeral);
                    while (amountDeposited < amountRemoved)
                    {
                        Destination.Deposit(aCoin);
                        amountDeposited += aCoin.ValueOf;
                    }
                    amountLeftToTransfer -= amountRemoved;
                }

                // Nothing left to transfer? Success.
                if (amountLeftToTransfer <= 0M)
                {
                    result = true;
                }
                
                // withdraw an overage if necessary and deposit it into Destination
                else if (amountLeftToTransfer > 0M && ExceedIfRequired)
                {
                    foreach (Coin.Denomination denominationEnumeral in Coin.AllDenominations)
                    {
                        while (amountLeftToTransfer > 0M)
                        {
                            if (this.coinCount(denominationEnumeral) > 0)
                            {
                                this.Withdraw(denominationEnumeral);
                                Coin aCoin = new Coin(denominationEnumeral);
                                Destination.Deposit(aCoin);
                                amountLeftToTransfer -= aCoin.ValueOf;
                            }
                            else
                            {
                                break; // there are no coins of this denomination: go to next denomination
                            }

                        }
                    }
                    // Transfer done
                    result = true;
                }
            }
            else // value of source coinbox less than requested transfer amount: no transfer done
            {
                result = false;
            }
            return result;            
        }

    }
}
