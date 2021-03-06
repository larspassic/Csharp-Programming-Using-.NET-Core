﻿using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    class Banana : HealthFood
    {
        //This is a constructor
        public Banana (string name, PurchasePrice price) : base (name, price, DateTime.Now.AddDays(7))
        {

        }

        public override string ToString()
        {
            string message = "Peel me!";
            return base.ToString() + message;
        }

        public override object Clone()
        {
            return new Banana(name, price);
        }
    }
}