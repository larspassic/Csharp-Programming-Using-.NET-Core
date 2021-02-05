
//Assignment 
//Author: Passic, Lars, 2011958


namespace Ex_3._1_Decimal_Money
{
    //  This class represents the purchase price of something.
    //  In our software project, we will use it to represent the price of
    //  one can of soda.
    public class PurchasePrice
    {
        private int price = 0;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            price = 0; 
        }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            price = initialPrice;
        }
        //  This property gets and sets the value the purchase price.
        public int Price
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