using System;
using System.Collections.Generic;

namespace Supplied_06._0_Vend_Lib
{
    public class Coin
    {
        private Denomination coinObject;
        public enum Denomination { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }
        public static readonly Coin HALFDOLLARCOIN = new Coin(Denomination.HALFDOLLAR);
        public static readonly Coin QUARTERCOIN = new Coin(Denomination.QUARTER);
        public static readonly Coin DIMECOIN = new Coin(Denomination.DIME);
        public static readonly Coin NICKELCOIN = new Coin(Denomination.NICKEL);
        public static readonly Coin SLUGCOIN = new Coin(Denomination.SLUG);

        // parameterless constructor – coin will be a slug
        public Coin()
        {
            coinObject = Denomination.SLUG;
        }

        // parametered constructor – coin will be of appropriate value
        // if value passed is outside normal set (e.g. 5 cents = Nickel)
        // coin is a slug     
        public Coin(Denomination DenominationEnumeral)
        {
            coinObject = DenominationEnumeral;
        }

        // This constructor will take a string and return the appropriate enumeral
        public Coin(string CoinName)
        {
            Denomination coinEnumeral;
            if (Enum.IsDefined(typeof(Denomination), CoinName) &&
                Enum.TryParse<Denomination>(CoinName, out coinEnumeral))
            {
                coinObject = coinEnumeral;
            }
            else
            {
                coinObject = Coin.Denomination.SLUG;
            }
        }

        public static Coin.Denomination ConvertStringToEnumeral(string CoinName)
        {
            Denomination denominationEnumeral = (Denomination)Enum.Parse(typeof(Denomination), CoinName);
            return denominationEnumeral;
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

        private static List<Denomination> _allDenominations = new List<Denomination>();
        static Coin()
        {
            foreach (string coinName in Enum.GetNames(typeof(Denomination)))
            {
                Denomination denominationEnumeral;
                Enum.TryParse<Denomination>(coinName, out denominationEnumeral);
                _allDenominations.Add(denominationEnumeral);
            }
        }

        //  This property will get the monetary value of the coin.
        public decimal ValueOf
        {
            get
            {
                return convertEnumeralToDecimal(coinObject);
            }
        }

        // decimal value of the specified coin denomination
        public static decimal ValueOfCoin(Coin.Denomination denominationEnumeral)
        {
            return convertEnumeralToDecimal(denominationEnumeral);
        }

        private static decimal convertEnumeralToDecimal(Coin.Denomination denominationEnumeral)
        {
            return (decimal)denominationEnumeral / 100M;
        }

        //  This property will get the coin name as an enumeral
        public Denomination DenominationEnumeral
        {
            get
            {
                return coinObject;
            }
        }


        // method to return a collection of all coin denominations
        public static List<Denomination> AllDenominations
        {
            get
            {
                return _allDenominations;
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
