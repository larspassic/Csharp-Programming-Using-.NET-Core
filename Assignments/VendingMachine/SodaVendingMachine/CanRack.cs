using System;
using System.Collections.Generic;
using System.Text;

//Assignment 02
//Author: Passic, Lars, 2011958

namespace SodaVendingMachine
{
    //This class will represent a can storage rack of the vending machine.
    //A can of soda will simply be represented as a number
    //(e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    class CanRack
    {
        //Constructor for a can rack. The rack starts out full
        public CanRack()
        {
            int regularCans = 3;
            int orangeCans = 3;
            int lemonCans = 3;
        }

        //This method adds a can of the specified flavor to the rack.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            string caseSwitch = FlavorOfCanToBeAdded;
            switch (caseSwitch)
            {
                case "Regular":
                case "regular":
                    CanRack.RemoveACanOf("Regular");
                    break;
                case "Orange":
                case "orange":
                    CanRack.RemoveACanOf("Orange");
                    break;
                case "Lemon":
                case "lemon":
                    CanRack.RemoveACanOf("Lemon");
                    break;
                default:
                    Console.WriteLine("That was not a valid flavor. No cans have been added.");
                    break;
            }
        }

        //This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {

        }

        //This method will fill the can rack.
        public void FillTheCanRack()
        {

        }

        //This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {

        }

        //OPTIONAL - returns true if the rack is full of a specified flavor
        //false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            if (true) //need to finish this!
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
