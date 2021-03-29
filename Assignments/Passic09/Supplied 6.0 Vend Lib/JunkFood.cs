using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    public abstract class JunkFood : Snack
    {
        public JunkFood (string name, PurchasePrice price, int CaloriesFromFat)
            : base(name, price)
        {
            this.CaloriesFromFat = CaloriesFromFat;
        }

        public readonly int CaloriesFromFat;

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.Append("Category: Junk Food" + Environment.NewLine);
            result.Append("Calories from fat: " + CaloriesFromFat + Environment.NewLine);
            return result.ToString();
        }
    }
}
