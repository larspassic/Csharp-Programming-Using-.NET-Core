using System;
using System.Diagnostics;


//Assignment 03
//Author: Passic, Lars, 2011958

namespace Ex_3_2_Can_Class
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    public class CanRack
    {
        private const int  EMPTYBIN = 0;
        private const int  BINSIZE = 3;

        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        private const int  DUMMYARGUMENT = 0;

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
                Debug.WriteLine("***Error: [AddACanOf-String] Failed attempt to add a can of {0} to a full rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("Info: [AddACanOf-String] adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                if (FlavorOfCanToBeAdded == "REGULAR") regular = regular + 1;
                else if (FlavorOfCanToBeAdded == "ORANGE") orange = orange + 1;
                else if (FlavorOfCanToBeAdded == "LEMON") lemon = lemon + 1;
                else Debug.WriteLine("Error: [AddACanOf-String] attempt to add a can of unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
        }

        //This is an overload of the AddACanOf method to support using Flavor types
        public void AddACanOf(Flavor FlavorOfCanToAdd)
        {
            if (IsFull(FlavorOfCanToAdd))
            {
                Debug.WriteLine("***Error: [AddACanOf-Flavor] Failed attempt to add a can of {0} to a full rack", FlavorOfCanToAdd, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine($"***Info: [AddACanOf-Flavor] Failed attempt to add a can of {FlavorOfCanToAdd} to a full rack");
                if (FlavorOfCanToAdd == Flavor.REGULAR) regular = regular + 1;
                else if (FlavorOfCanToAdd == Flavor.ORANGE) orange = orange + 1;
                else if (FlavorOfCanToAdd == Flavor.LEMON) lemon = lemon + 1;
                else Debug.WriteLine($"Error: [AddACanOf-Flavor] attempt to add a can of unknown flavor {FlavorOfCanToAdd} to the rack");
            }
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("***Error: [RemoveACanOf-String] Failed attempt to remove a can of {0} from an empty rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("Info: [RemoveACanOf-String] removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                if (FlavorOfCanToBeRemoved == "REGULAR") regular = regular - 1;
                else if (FlavorOfCanToBeRemoved == "ORANGE") orange = orange - 1;
                else if (FlavorOfCanToBeRemoved == "LEMON") lemon = lemon - 1;
                else Debug.WriteLine("Error: [RemoveACanOf-String]attempt to remove a can of unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
        }

        //This is an overload of the RemoveACanOf method to support using Flavor types
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            if (IsFull(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("***Error: [AddACanOf-Flavor] Failed attempt to remove a can of {0} from a full rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine($"***Info: [AddACanOf-Flavor] Failed attempt to remove a can of {FlavorOfCanToBeRemoved} to a full rack");
                if (FlavorOfCanToBeRemoved == Flavor.REGULAR) regular = regular - 1;
                else if (FlavorOfCanToBeRemoved == Flavor.ORANGE) orange = orange - 1;
                else if (FlavorOfCanToBeRemoved == Flavor.LEMON) lemon = lemon - 1;
                else Debug.WriteLine($"Error: [AddACanOf-Flavor] attempt to remove a can of unknown flavor {FlavorOfCanToBeRemoved} from the rack");
            }
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Info: [FillTheCanRack] Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Debug.WriteLine("Info: [EmptyCanRackOf-String] Emptying can rack of flavor {0}", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "REGULAR") regular = EMPTYBIN;
            else if (FlavorOfBinToCheck  == "ORANGE") orange = EMPTYBIN;
            else if (FlavorOfBinToCheck == "LEMON") lemon = EMPTYBIN;
            else Debug.WriteLine("Error: [EmptyCanRackOf-String] Attempt to empty rack of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
        }

        //This overload of the EmptyCanRackOf method will empty the rack of a given flavor, using the flavor type
        public void EmptyCanRackOf(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine($"Info: [EmptyCanRackOf-Flavor] Emptying can rack of flavor {FlavorOfBinToCheck}");
            if (FlavorOfBinToCheck == Flavor.REGULAR) regular = EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.ORANGE) orange = EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.LEMON) lemon = EMPTYBIN;
            else Debug.WriteLine($"Error: [EmptyCanRackOf-Flavor] Attempt to empty rack of unkown flavor {FlavorOfBinToCheck}");
        }


        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Info: [IsFull-String] Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == BINSIZE;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == BINSIZE;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == BINSIZE;
            else Debug.WriteLine("Error: [IsFull-String] Attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }
        //This is an... overload? of the IsFull method - this one uses Flavor types instead of strings
        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Info: [IsFull-Flavor] Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == Flavor.REGULAR) result = regular == BINSIZE;
            else if (FlavorOfBinToCheck == Flavor.ORANGE) result = orange == BINSIZE;
            else if (FlavorOfBinToCheck == Flavor.ORANGE) result = lemon == BINSIZE;
            else Debug.WriteLine("Error: [IsFull-Flavor] Attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }


        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Info: [IsEmpty-String] Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == EMPTYBIN;
            else Debug.WriteLine("Error: [IsEmpty-String] attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine($"Info: [IsEmpty-Flavor] Checking if can rack is empty of flavor {FlavorOfBinToCheck}");
            if (FlavorOfBinToCheck == Flavor.REGULAR) result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.REGULAR) result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.REGULAR) result = lemon == EMPTYBIN;
            else Debug.WriteLine($"Error: [IsEmpty-Flavor] Attempt to check rack status of unknown flavor {FlavorOfBinToCheck}");
            return result;
        }

    } //end Can_Rack

}
