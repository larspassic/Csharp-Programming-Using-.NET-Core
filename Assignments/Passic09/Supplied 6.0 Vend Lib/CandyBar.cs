﻿using System;
using System.Collections.Generic;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    class CandyBar : JunkFood
    {


        //This is a constructor
        public CandyBar(string name, PurchasePrice price) : base (name, price, 160)
        {
        }

        public override object Clone()
        {
            return new CandyBar(name, price);
        }

    }
}