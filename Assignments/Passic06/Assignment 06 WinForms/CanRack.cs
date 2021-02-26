using System;
using System.Collections.Generic;
using System.Diagnostics;

//Assignment 06
//Author: Passic, Lars, 2011958

namespace Assignment_06_WinForms
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number in an array indexed
    //  by the Flavor enumeration (e.g., rack[Flavor.ORANGE] == 1 means 
    //  that there is one can of orange soda in the rack).
    class CanRack
    {
        //private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length]; //ancient technology that our ancestors used for Soda Can Rack software
        private Dictionary<Flavor, int> rack = null;
        public const int EMPTYBIN = 0;
        public const int BINSIZE = 3;

        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            rack = new Dictionary<Flavor, int>();
            FillTheCanRack();
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine("*** Failed attempt to add a can of {0} to a full rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
            else
            {
                // convert the string Flavor into the appropriate int value
                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeAdded);

                //Check to see if the rack has the flavor value in it
                if(rack.ContainsKey(flavorEnumeral))
                {
                    //Write success to the debug log
                    Debug.WriteLine($"Info: Adding a can of {flavorEnumeral} flavored soda to the rack");
                    
                    //Flavor flavorIndex = flavorEnumeral; 
                    rack[flavorEnumeral]++;
                }
                else
                {
                    Debug.WriteLine("Error: attempt to add a can of unknown flavor {0}", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                }
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            if (rack.ContainsKey(FlavorOfCanToBeAdded)) //Check to see if they flavor object exists in the rack dictionary object
            {
                FlavorOfCanToBeAdded.ToString();
            }

            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        // This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();

            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"Error: Failed attempt to remove a can of {FlavorOfCanToBeRemoved} from an empty rack");
            }
            else
            {
                // convert the string Flavor into the appropriate int value
                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeRemoved)  ;
                //if (Enum.IsDefined(typeof(Flavor),FlavorOfCanToBeRemoved))
                if(rack.ContainsKey(flavorEnumeral))
                {
                    //Write success to the debug log
                    Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                    //int flavorIndex = (int)flavorEnumeral;
                    rack[flavorEnumeral]--;
                }
                else
                {
                    Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0}", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                }
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        // This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (Flavor flavorValue in FlavorOps.AllFlavors)
            {
                rack[flavorValue] = BINSIZE;
            }
        }


        // This public void will empty the rack of a given flavor.
        // This takes a slightly different approach and sometimes uses f and sometimes uses FlavorOps.ToFlavor on the fly
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            //Convert the string value to all uppercase to purify input
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();

            if (rack.ContainsKey(FlavorOps.ToFlavor(FlavorOfBinToBeEmptied)))
            {
                //Convert string to type Flavor using FlavorOps
                Flavor f = FlavorOps.ToFlavor(FlavorOfBinToBeEmptied);

                //Write success to the debug log
                Debug.WriteLine($"Info: Emptying can rack of flavor {FlavorOfBinToBeEmptied}");

                //Do the actual emptying of the rack
                rack[f] = EMPTYBIN;
            }
            else
            {
                Debug.WriteLine($"Error: Illegal attempt to empty bin of invalid flavor {FlavorOfBinToBeEmptied}");
            }
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            Boolean result = false;
            // convert the string Flavor into the appropriate int value
            
            
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeChecked);
            if (rack.ContainsKey(flavorEnumeral))
            {
                //Write success to the debug log
                Debug.WriteLine($"Info: Checking if can rack is full of flavor {FlavorOfBinToBeChecked}"); 
                
                //int flavorIndex = (int)flavorEnumeral;
                result = rack[flavorEnumeral] == BINSIZE;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            }
            return result;
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString());
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            bool result = false;
            
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeChecked);
            if (rack.ContainsKey(flavorEnumeral))
            {
                //
                Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked);
                
                result = rack[flavorEnumeral] == EMPTYBIN;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            }
            return result;
        }

        public Boolean IsEmpty(Flavor CanBinToCheck)
        {
            return IsEmpty(CanBinToCheck.ToString());
        }

        // write out the contents of rack array. For example, one flavor per line with the flavor name and
        // the number of cans of soda of that flavor. In a real system, this function would probably be in a 
        // separate class, and the CanRack would export this information as strings. We’re doing it this way
        // for the sake of the simplicity of the exercise.
        public void DisplayCanRack()
        {
            Console.WriteLine(".NET C# Vending Machine contents");
            Console.WriteLine("________________________________");
            foreach (Flavor flavorName in FlavorOps.AllFlavors)
            {
                //Flavor flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), flavorName);
                //int flavorIndex = (int)flavorEnumeral;
                Console.WriteLine($"{flavorName}\t{rack[flavorName]}");
            }
            Console.WriteLine("________________________________");
        }


    } //end Can_Rack

}
