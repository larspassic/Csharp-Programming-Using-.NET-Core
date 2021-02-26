using System;

//Assignment 06
//Author: Passic, Lars, 2011958

namespace Assignment_06_WinForms
{
    //  This class represents the purchase price of something.
    //  In our software project, we will use it to represent the price of
    //  one can of soda.
    class PurchasePrice
    {
        private decimal price = 0M;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            price = 0M;
        }
        // This constructor allows a new purchase price to be set by the user
        [Obsolete("Use the decimal version of this constructor instead", false)]
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        //  This property gets and sets the value the purchase price.
        [Obsolete("Use the decimal version of this property instead", false)]
        public int Price
        {
            get
            {
                return (int)(price * 100);
            }
            set
            {
                price = value / 100M;
            }
        }

        //  This property gets and sets the value the purchase price.        
        public decimal PriceDecimal
        {
            get
            {
                return price;
            }
            private set
            {
                price = value;
            }
        }
    } //end PurchasePrice

}