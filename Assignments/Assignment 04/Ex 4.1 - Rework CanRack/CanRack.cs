using System;
using System.Diagnostics;

//Assignment 04
//Author: Passic, Lars, 2011958

namespace Ex_4._1_Rework_CanRack
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    public class CanRack
    {
        //Create an array of integers represnting the number of cans in the rack indexed by the flavors
        //The Enum.GetValues().Length value represents the number of flavors (for example, values in the type flavors)
        
        // This creates a new array of integers, the size of the array will be the count of elements in the Flavor enum.
        //This will dynamically increase or decrease depending on the count of type flavor in the enum?
        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length]; 

        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        //This is our old "rack" aka "instance variables"
        /* commenting this stuff out because this is probably what we are reworking
        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;
        */


        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., 3 cans of each flavor).
        public CanRack()
        {
            //Use a quick foreach loop to set them all to an int - "before we touch them arithmatically"
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavorValue] = EMPTYBIN;
            }

            FillTheCanRack();
        }

        

        //  This method adds a can of the specified flavor to the rack.
        // Updated to convert the string in to a real flavor value.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            //FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper(); //no longer needed since we're not using strings
            
            //Create the enumeral to hold the real flavor value
            Flavor flavorEnumeral;

            if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeAdded)) //Returns true if the FlavorOfCanToBeAdded was found in the enum
            {
                //Sets flavorEnum to be the Flavor type that was found to match FlavorOfCanToBeAdded.
                //This essentially translates string FlavorOfCanToBeAdded into a Flavor object
                flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeAdded);

                int flavorIndex = (int)flavorEnumeral;
                rack[flavorIndex]++;
                Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");
            }
            else
            {
                 Debug.WriteLine("Error: attempt to add a can of unknown flavor {0}", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("*** Failed attempt to remove a can of {0} from an empty rack", FlavorOfCanToBeRemoved);
            }
            else
            {
                Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved);
                if (FlavorOfCanToBeRemoved == "REGULAR") rack[(int)Flavor.REGULAR] = rack[(int)Flavor.REGULAR] - 1;
                else if (FlavorOfCanToBeRemoved == "ORANGE") rack[(int)Flavor.ORANGE] = rack[(int)Flavor.ORANGE] - 1;
                else if (FlavorOfCanToBeRemoved == "LEMON") rack[(int)Flavor.LEMON] = rack[(int)Flavor.LEMON] - 1;
                else Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0}", FlavorOfCanToBeRemoved, 0);
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            rack[(int)Flavor.REGULAR] = BINSIZE;
            rack[(int)Flavor.ORANGE] = BINSIZE;
            rack[(int)Flavor.LEMON] = BINSIZE;
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            if (FlavorOfBinToBeEmptied == "REGULAR") rack[(int)Flavor.REGULAR] = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "ORANGE") rack[(int)Flavor.ORANGE] = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "LEMON") rack[(int)Flavor.LEMON] = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty the rack of unknown flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
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
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            if (FlavorOfBinToBeChecked == "REGULAR") result = rack[(int)Flavor.REGULAR] == BINSIZE;
            else if (FlavorOfBinToBeChecked == "ORANGE") result = rack[(int)Flavor.ORANGE] == BINSIZE;
            else if (FlavorOfBinToBeChecked == "LEMON") result = rack[(int)Flavor.LEMON] == BINSIZE;
            else Debug.WriteLine("Error: attempt to check status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
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
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked);
            if (FlavorOfBinToBeChecked == "REGULAR") result = rack[(int)Flavor.REGULAR] == 0;
            if (FlavorOfBinToBeChecked == "ORANGE") result = rack[(int)Flavor.ORANGE] == 0;
            if (FlavorOfBinToBeChecked == "LEMON") result = rack[(int)Flavor.LEMON] == 0;
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }

        //write out the contents of rack array. For example, one flavor per line with the flavor name and
        //the number of cans of soda of that flavor. In a real system, this function would probasbly be in a
        //separate class, and the CanRack would export this information as strings. We're doing it this way
        //for the sake of the simplicity of the exercise.
        public void DisplayCanRack()
        {
            foreach (int flavorValue in rack)
            {
                Console.WriteLine($"Flavor {flavorValue} has {rack[flavorValue]} cans of soda.");
            }
        }

    } //end Can_Rack

}
