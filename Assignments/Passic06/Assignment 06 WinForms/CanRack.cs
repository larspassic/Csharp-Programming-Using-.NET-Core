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
    public class CanRack
    {
        private Dictionary<Flavor,int> rack = null;
        public const int EMPTYBIN = 0; 
        public const int BINSIZE = 3;

        private const int DUMMYARGUMENT = 0;
        
        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            rack = new Dictionary<Flavor,int>();
            FillTheCanRack();
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine($"Error: Failed attempt to add a can of {FlavorOfCanToBeAdded} to a full rack.");
            }
            else
            {
                Debug.WriteLine($"Info: adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack.");
                // convert the string Flavor into the Flavor value
                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeAdded);
                rack[flavorEnumeral]++;
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
                Debug.WriteLine($"Error: Failed attempt to remove a can of {FlavorOfCanToBeRemoved} from an empty rack.");
            }
            else
            {
                Debug.WriteLine($"Info: Removing a can of {FlavorOfCanToBeRemoved} flavored soda from the rack.");
                // convert the string Flavor into the appropriate Flavor value
                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeRemoved);
                rack[flavorEnumeral]--;
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine($"Info: Filling the can rack.");
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                rack[aFlavor] = BINSIZE;
            }
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeEmptied);
            Debug.WriteLine($"Info: Emptying can rack of flavor {FlavorOfBinToBeEmptied}.");
            rack[flavorEnumeral] = EMPTYBIN;
        }


        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            Debug.WriteLine($"Checking if can rack is full of flavor {FlavorOfBinToBeChecked}.");
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeChecked);
            return rack[flavorEnumeral] == BINSIZE;
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString());
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            Debug.WriteLine($"Checking if can rack is empty of flavor {FlavorOfBinToBeChecked}.");
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeChecked);
            return rack[flavorEnumeral] == EMPTYBIN;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }

        //Apparently "this" is an indexer - need to re-watch lesson 5 videos on "this and indexer" to hope to understand this!
        //"An indexer is a way to make an object look a little bit like an array"
        //Still don't get it. Oh well!
        public int this[Flavor FlavorOfBin]
        {
            get
            {
                return rack[FlavorOfBin];
            }
            set
            {
                // we could just assign a value right here
                // (once we verify it is not too big or too small),
                // but let's pretend that AddACanOf() and RemoveACanOf()
                // perform some kind of data tracking operation 
                // for sales statistics, or something of that sort, so we need to call those.
                if (rack[FlavorOfBin] == value)
                {
                    // do nothing
                }
                else if (rack[FlavorOfBin] < value)
                {
                    while (!IsFull(FlavorOfBin) && rack[FlavorOfBin] < value)
                    {
                        AddACanOf(FlavorOfBin);
                    }
                }
                else if (rack[FlavorOfBin] > value)
                {
                    while (!IsEmpty(FlavorOfBin) && rack[FlavorOfBin] > value)
                    {
                        RemoveACanOf(FlavorOfBin);
                    }
                }

                int sodaCansLeftOver = rack[FlavorOfBin] - value;
                if (sodaCansLeftOver == 0)
                {
                    // do nothing
                }
                else if (sodaCansLeftOver < 0)
                {
                    string pluralCan = string.Format(sodaCansLeftOver == -1 ? "" : "s");
                    string pluralWas = string.Format(sodaCansLeftOver == -1 ? "was" : "were");
                    Debug.WriteLine($"{FlavorOfBin} Bin Full. {-sodaCansLeftOver} can{pluralCan} of flavor {FlavorOfBin} {pluralWas} not placed in vending machine");
                }
                else if (sodaCansLeftOver > 0)
                {
                    string pluralCan = string.Format(sodaCansLeftOver == 1 ? "" : "s");
                    string pluralWas = string.Format(sodaCansLeftOver == 1 ? "was" : "were");
                    Debug.WriteLine($"{FlavorOfBin} Bin Empty. {sodaCansLeftOver} can{pluralCan} of flavor {FlavorOfBin} {pluralWas} not available for removal");
                }
            }
        }


        // write out the contents of rack array. For example, one flavor per line with the flavor name and
        // the number of cans of soda of that flavor. In a real system, this function would probably be in a 
        // separate class, and the CanRack would export this information as strings. We’re doing it this way
        // for the sake of the simplicity of the exercise.
        public void DisplayCanRack()
        {
            Console.WriteLine(".NET C# Vending Machine contents");
            Console.WriteLine("________________________________");
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                Console.WriteLine("{0}\t{1}", aFlavor, rack[aFlavor]);
            }
            Console.WriteLine("________________________________");
        }

    } //end Can_Rack

}
