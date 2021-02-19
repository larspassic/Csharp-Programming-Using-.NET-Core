using System;

namespace Exercise_04._2_Coins_Names
{
    class Coin
    {
        private Denomination coinObject;
        public enum Denomination { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }

        // parameterless constructor – coin will be a slug
        public Coin()
        {
            coinObject = Denomination.SLUG;
        }

        // parametered constructor – coin will be of appropriate value
        // if value passed is outside normal set (e.g. 5 cents = Nickel)
        // coin is a slug     
        public Coin(Denomination CoinEnumeral)
        {
            coinObject = CoinEnumeral;
        }

        // This constructor will take a string and return the appropriate enumeral
        public Coin(string CoinName)
        {
            Denomination coinEnumeral;
            if (Enum.IsDefined(typeof(Denomination),CoinName) && 
                Enum.TryParse<Denomination>(CoinName, out coinEnumeral))
            {
                coinObject = coinEnumeral;
            }
            else
            {
                coinObject = Coin.Denomination.SLUG;
            }
        }

        // parametered constructor – coin will be of appropriate value
        public Coin(decimal CoinValue)
        {
            Denomination castFromValue = (Denomination)(CoinValue * 100);
            switch (castFromValue)
            {
                case Denomination.NICKEL:
                case Denomination.DIME:
                case Denomination.QUARTER:
                case Denomination.HALFDOLLAR:
                    coinObject = castFromValue;
                    break;
                default:
                    coinObject = Denomination.SLUG;
                    break;
            }
        }

        //  This property will get the monetary value of the coin.
        public decimal ValueOf
        {
            get
            {
                return (decimal)coinObject / 100M;
            }
        }

        //  This property will get the coin name as an enumeral
        public Denomination CoinEnumeral
        {
            get
            {
                return coinObject;
            }
        }


        // use Enum.GetName() with a private Denomination instance variable
        // to produce a string
        public override string ToString()
        {
            return Enum.GetName(typeof(Denomination), coinObject);
        }
    }
}
