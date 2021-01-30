using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


//Assignment 02
//Author: Passic, Lars, 2011958

namespace SodaVendingMachine
{
    
    
    //This class will represent a can storage rack of the vending machine.
    //A can of soda will simply be represented as a number
    //(e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    class CanRack
    {
        
        int regularCans;
        int orangeCans;
        int lemonCans;

        //Constructor for a can rack. The rack starts out full
        public CanRack()
        {
            //Just call the FillTheCanRack method!
            FillTheCanRack();
        }

        //This method adds a can of the specified flavor to the rack.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {

            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (FlavorOfCanToBeAdded == "REGULAR")
            {
                Debug.WriteLine("Add one can of regular to the rack.");
                regularCans += 1;
            }
            else if (FlavorOfCanToBeAdded == "ORANGE")
            {
                Debug.WriteLine("Add one can of orange to the rack.");
                orangeCans += 1;
            }
            else if (FlavorOfCanToBeAdded == "LEMON")
            {
                Debug.WriteLine("Add one can of lemon to the rack.");
                lemonCans += 1;
            }
            else
            {
                //"Default case" 
                Debug.WriteLine("The flavor the user entered was invalid. No cans were added.");

            }

        }

        //This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();

            switch (FlavorOfCanToBeRemoved) //Try to use a switch instead of if/else
            {
                case "REGULAR":
                    Debug.WriteLine("Removing one can of regular from the rack.");
                    regularCans -= 1;
                    break;
                
                case "ORANGE":
                    Debug.WriteLine("Removing one can of orange from the rack.");
                    orangeCans -= 1;
                    break;
                
                case "LEMON":
                    Debug.WriteLine("Removing one can of lemon from the rack.");
                    lemonCans -= 1;
                    break;
                
                default:
                    Debug.WriteLine("The flavor the user entered was invalid. No cans were added.");
                    break;

            }
        }

        //This method will fill the can rack.
        public void FillTheCanRack()
        {
            //Write to debug
            Debug.WriteLine("Fill up the can rack. Setting Regular, Orange, and Lemon can racks to the current technology limitation of 3 cans.");

            //Fill each rack to 3.
            regularCans = 3;
            orangeCans = 3;
            lemonCans = 3;

        }

        //This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();

            switch (FlavorOfBinToBeEmptied) //Try to use a switch instead of if/else
            {
                case "REGULAR":
                    Debug.WriteLine("Removing all cans of regular from the rack.");
                    while (regularCans > 0)
                    {
                        RemoveACanOf("Regular");
                    }
                    break;

                case "ORANGE":
                    Debug.WriteLine("Removing all cans of orange from the rack.");
                    while (orangeCans > 0)
                    {
                        RemoveACanOf("Orange");
                    }
                    break;

                case "LEMON":
                    Debug.WriteLine("Removing all cans of lemon from the rack.");
                    while (lemonCans > 0)
                    {
                        RemoveACanOf("Lemon");
                    }
                    break;

                default:
                    Debug.WriteLine("The flavor the user entered was invalid. No bins were emptied.");
                    break;

            }
        }

        //OPTIONAL - returns true if the rack is full of a specified flavor
        //false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            if (FlavorOfBinToCheck == "REGULAR")
            {
                if (regularCans == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (FlavorOfBinToCheck == "ORANGE")
            {
                if (orangeCans == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (FlavorOfBinToCheck == "LEMON")
            {
                if (lemonCans == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Debug.WriteLine("The flavor the user entered was invalid. No racks were checked.");
                return false;
            }
        }
            //OPTIONAL - returns true if the rack is empty of a specified flavor
            //false otherwise
            public Boolean IsEmpty(string FlavorOfBinToCheck)
            {
                FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
                if (FlavorOfBinToCheck == "REGULAR")
                {
                    if (regularCans == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (FlavorOfBinToCheck == "ORANGE")
                {
                    if (orangeCans == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (FlavorOfBinToCheck == "LEMON")
                {
                    if (lemonCans == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    Debug.WriteLine("The flavor the user entered was invalid. No racks were checked.");
                    return false;
                }

            }
    }
}
