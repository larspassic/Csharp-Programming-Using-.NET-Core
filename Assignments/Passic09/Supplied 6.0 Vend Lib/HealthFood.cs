using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    public class HealthFood : Snack
    {
        //These are properties?
        public readonly PurchasePrice price;
        public readonly string name;

        //This is a constructor
        public HealthFood(string name, PurchasePrice price, DateTime freshUntil) : base (name, price)
        {
            this.name = name;
            this.price = price;
        }

        public readonly DateTime freshUntil;

        //Override ToString to add the snack food name and price
        public override string ToString()
        {
            return $"Snack Food: {name}, {price.PriceDecimal:c}" +
                Environment.NewLine;
        }
    }
}
