using System;
using System.Collections.Generic;
using System.Text;

//Assignment 02
//Author: Passic, Lars, 2011958

namespace SodaVendingMachine
{
    //This class represents the purchase price of something.
    //In our software project, we will use it to represent the price of one can of soda.
    class PurchasePrice
    {
        //This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            Price = 0;
        }

        //This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        //This property gets and sets the value of the purchase price
        public int Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

    }//end PurchasePrice
}
