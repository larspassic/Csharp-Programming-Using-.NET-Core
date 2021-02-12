using System;
using System.Diagnostics;

namespace Exercise_03._1_Purchase_Price_decimal
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;
        
        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
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
                Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                if (FlavorOfCanToBeAdded == "REGULAR") regular = regular + 1;
                else if (FlavorOfCanToBeAdded == "ORANGE") orange = orange + 1;
                else if (FlavorOfCanToBeAdded == "LEMON") lemon = lemon + 1;
                else Debug.WriteLine("Error: attempt to add a can of unknown flavor {0}", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("*** Failed attempt to remove a can of {0} from an empty rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                if (FlavorOfCanToBeRemoved == "REGULAR") regular = regular - 1;
                else if (FlavorOfCanToBeRemoved == "ORANGE") orange = orange - 1;
                else if (FlavorOfCanToBeRemoved == "LEMON") lemon = lemon - 1;
                else Debug.WriteLine("Error: attempt to remove a can of flavor {0}", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Console.WriteLine("Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            if (FlavorOfBinToBeEmptied == "REGULAR") regular = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "ORANGE") orange = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "LEMON") lemon = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            if (FlavorOfBinToBeChecked == "REGULAR") result = regular == BINSIZE;
            else if (FlavorOfBinToBeChecked == "ORANGE") result = orange == BINSIZE;
            else if (FlavorOfBinToBeChecked == "LEMON") result = lemon == BINSIZE;
            else Debug.WriteLine("Error: attempt to check rack status for unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            return result;
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            FlavorOfBinToBeChecked = FlavorOfBinToBeChecked.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            if (FlavorOfBinToBeChecked == "REGULAR") result = regular == EMPTYBIN;
            else if (FlavorOfBinToBeChecked == "ORANGE") result = orange == EMPTYBIN;
            else if (FlavorOfBinToBeChecked == "LEMON") result = lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status for unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            return result;
        }

    } //end Can_Rack

}
