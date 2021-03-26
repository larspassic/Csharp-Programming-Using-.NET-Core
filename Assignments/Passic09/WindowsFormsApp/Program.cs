using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //This is where my project begins.

            //
            //I tried to put my PurchasePrice, CanRack, and CoinBox object declarations
            //here at first, since I thought that Main() would be the beating heart of my program
            //but that did not work. I had to move them over to Form1.cs and then move them
            //out of the FormSodaMachine() method, in order for them to work.
            //

            //This was already here before I started working on Program.cs
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSodaMachine());




        }
    }
}
