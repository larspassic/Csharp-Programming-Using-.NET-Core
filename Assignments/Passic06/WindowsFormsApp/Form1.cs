﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supplied_06._0_Vend_Lib;

namespace WindowsFormsApp
{
    public partial class FormSodaMachine : Form
    {
        public FormSodaMachine()
        {
            
            
            InitializeComponent();

            //Demo in class
            CanRack therackX = new CanRack();


        }

        //This code inserts a half-dollar in to the temp box
        private void buttonInsertHalfDollar_Click(object sender, EventArgs e)
        {
            //Write code to insert a half-dollar coin in to the temp box

        }
    }
}
