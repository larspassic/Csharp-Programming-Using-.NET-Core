using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    class Apple : HealthFood
    {
        //This is a constructor
        public Apple(string name, PurchasePrice price) : base(name, price, DateTime.Now.AddMonths(1))
        {
          
        }

        public override string ToString()
        {
            string message = "I keep the doctor away.";
            return base.ToString() + message;
        }

        public override object Clone()
        {
            return new Apple(name, price);
        }
    }

}