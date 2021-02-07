
//Assignment 03
//Author: Passic, Lars, 2011958


namespace Ex_3_2_Can_Class
{
    //  This class represents the purchase price of something.
    //  In our software project, we will use it to represent the price of
    //  one can of soda.
    public class PurchasePrice
    {
        private decimal price = 0;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            price = 0m; 
        }
        

        // This constructor allows a new purchase price to be set by the user - as an INTEGER
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice; //Change the constructor to reach over to the PROPERTY to leverage new conversions to/from decimal
        }

        // This constructor allows a new purchase price to be set by the user - as a DECIMAL
        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice; //Change the constructor to reach over to the PROPERTY to leverage new conversions to/from decimal
        }


        //  This property gets and sets the value the purchase price.
        public int Price
        {
            get
            {
                return (int)price * 100;
            }
            set
            {
                price = value / 100m;
            }
        }

        //  This property gets and sets the value the purchase price. (API v2!)
        public decimal PriceDecimal
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


    } //end PurchasePrice

}