using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    public abstract class HealthFood : Snack
    {

        //This is a constructor
        public HealthFood(string name, PurchasePrice price, DateTime freshUntil) : base (name, price)
        {
            FreshUntil = freshUntil;
        }

        public readonly DateTime FreshUntil;

        //Override ToString to add the snack food name and price
        public override string ToString()
        {
            return $"Snack Food: {name}, {price.PriceDecimal:c}" +
                Environment.NewLine;
        }
    }
}
