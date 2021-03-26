using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

namespace Food
{
    public class HealthFood : Snack
    {
        public readonly PurchasePrice price;
        public readonly string name;

        public Snack(string name, PurchasePrice price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Snack Food: {name}, {price.PriceDecimal:c}" +
                Environment.NewLine;
        }
    }
}
