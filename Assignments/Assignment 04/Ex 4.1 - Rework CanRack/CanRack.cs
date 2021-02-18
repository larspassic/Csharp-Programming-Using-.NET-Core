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
        /* commenting this stuff out because this is probably maybe what we are reworking
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
        // This method uses unknown magic sorcery from the Wizard Kevin
        // So I am writing heavy comments for the first method to help understand what it does.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            //FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper(); //no longer needed since we're not using strings

            //Create the enumeral to hold the real flavor value
            Flavor flavorEnumeral;
            if (IsFull(FlavorOfCanToBeAdded)) //Check to see if the bin is already full
            {
                Debug.WriteLine($"Error: Unable to add a can of {FlavorOfCanToBeAdded} because the rack is already full.");
            }
            else
            {
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeAdded)) //Returns true if the FlavorOfCanToBeAdded was found in the enum
                {
                    //Sets flavorEnumeral to be the Flavor type that was found to match FlavorOfCanToBeAdded.
                    //This essentially translates string FlavorOfCanToBeAdded into a Flavor object
                    //Enum.Parse definition: "Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object."
                    flavorEnumeral = (Flavor)/*cast as Flavor type*/Enum.Parse(typeof(Flavor)/*pass the type*/, FlavorOfCanToBeAdded/* and pass the string*/ ); //result is that flavorEnumeral is now a legitimate, enumerated Flavor object

                    int flavorIndex = (int)/*When casting the enumeral as an int, returns the index of the enum?*/flavorEnumeral;
                    rack[flavorIndex]++; //Since the rack was made via the enum, the indexes of the array match the indexes of the enum.
                    Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");
                }
                else //If the Flavor was NOT found in the enum, we can't add a can to the rack.
                {
                    //Kind of wondering why Kevin's solution code does this validation. This would have already been exposed during the IsFullvalidation?
                    Debug.WriteLine("Error: attempt to add a can of unknown flavor {0}", FlavorOfCanToBeAdded, DUMMYARGUMENT); 
                }
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded) //More advanced method override (that uses Flavor type) simply leans on the backward-compatible version of the method that takes string...
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            //Create the enumeral to hold the real flavor value
            Flavor flavorEnumeral;
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"Error: Unable to remove a can of {FlavorOfCanToBeRemoved} because the rack is already empty.");
                Console.WriteLine($"Error: Unable to remove a can of {FlavorOfCanToBeRemoved} because the rack is already empty.");
            }
            else
            {

                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeRemoved)) //Once we know the rack is not already empty, need to check to see if the flavor exists in the enum
                {
                    flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeRemoved); //Turn the string in to a Flavor enum object
                    rack[(int)flavorEnumeral]--; //trying to compress this code and not use the flavorIndex variable, if we already can cast it as an int
                    Debug.WriteLine($"Info: Successfully removed one can of {FlavorOfCanToBeRemoved} from the rack");
                    Console.WriteLine($"Thanks, here is your can of {FlavorOfCanToBeRemoved} soda.");
                }
                else
                {
                    Debug.WriteLine($"Error: Attempt to remove a can of unknown flavor {FlavorOfCanToBeRemoved}");
                }
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            
            foreach (int flavorIndex in Enum.GetValues(typeof(Flavor)))
            {
                //My goal is to write out each flavor's name as it's being filled. But I have no idea how to do that so I just guessed. I think this is just going to write out the index. :(
                Debug.WriteLine($"Info: Filling the can rack of flavor {rack[flavorIndex].ToString()}"); //Maybe try using Enum.GetName()


                //Fill the rack by setting it to the maximum size of the bin.
                rack[flavorIndex] = BINSIZE;
            }
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeEmptied))
            {
                
                Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            }
                

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
            Boolean result = false;
            Flavor flavorEnumeral;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeChecked)) //Returns true if the FlavorOfBinToBeChecked was found in the enum
            {
                Debug.WriteLine($"Info: Checking if can rack is full of flavor {FlavorOfBinToBeChecked}");

                flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeChecked);//Gets the actual flavor object

                if (rack[(int)flavorEnumeral] == BINSIZE)
                {
                    result = true;
                    Debug.WriteLine($"Info: The flavor {flavorEnumeral} was found to have {rack[(int)flavorEnumeral]} cans");
                }
                

                return result;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
                return result;
            }
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString());
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            Boolean result = false;
            Flavor flavorEnumeral;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeChecked)) //Returns true if the FlavorOfBinToBeChecked was found in the enum
            {
                Debug.WriteLine($"Info: Checking if can rack is empty of flavor {FlavorOfBinToBeChecked}");
                flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeChecked); //I don't really know what this actually does

                
                if (rack[(int)flavorEnumeral] == EMPTYBIN) //This seems to always evaluate to true :(
                {
                    result = true;
                    Debug.WriteLine($"The rack for flavor {flavorEnumeral} was found to have {rack[(int)flavorEnumeral]} cans in it.");
                }
                ;

                return result;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
                return result;
            }
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
            Console.WriteLine();//Extra space from whatever came before this.

            int i = 0; //I need to set up some sort of index value to be able to call the rack index

            //Hopefully this foreach loop is starting from 0 and working through elements of the enum 
            //in the same way that I will be starting from 0 and iterating through the rack array
            foreach (string flavorName in Enum.GetNames(typeof(Flavor))) //I'm glad Kevin included this loop because I really don't understand how to work with Enums :(
            {
                Console.WriteLine($"{flavorName} flavor has {rack[i]} cans of soda.");
                
                i++; //increment the index
            }
        }

    } //end Can_Rack

}
