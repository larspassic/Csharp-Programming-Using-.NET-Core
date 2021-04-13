using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958


namespace Food
{
    public abstract class Snack : ICloneable
    {
        //These are properties
        public readonly PurchasePrice price;
        public readonly string name;

        //I think this is a constructor of the snack class
        public Snack(string name, PurchasePrice price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract object Clone();

        //Override the ToString method for the snack class
        public override string ToString()
        {
            return string.Format($"Snack food: {name}, {price.PriceDecimal:c}" +
                Environment.NewLine);
        }
    }
}