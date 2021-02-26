using System;
using System.Collections.Generic;

//Assignment 06
//Author: Passic, Lars, 2011958

namespace Assignment_06_WinForms
{
    public enum Flavor { REGULAR, ORANGE, LEMON }
    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        //Parameterless constructor - default
        static FlavorOps()
        {
            //Build the _allFlavors list object with everything in the enumeral
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnumeral = ToFlavor(flavorName);
                _allFlavors.Add(flavorEnumeral);
            }
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            //Fix casing from user input
            FlavorName = FlavorName.ToUpper();
            
            //Another example of defaulting to REGULAR - gross.
            Flavor result = Flavor.REGULAR;
            
            //Check to see if the flavor exists in the Enum
            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                result = (Flavor)Enum.Parse(typeof(Flavor),FlavorName); //Assign the flavor from the enum
            }
            //Otherwise if the flavor was not found, throw an exception
            else
            {
                throw new VENDBADFLAVORException("Unknown flavor ", FlavorName);
            }
            return result;
        }

        // property to return a List<Flavor> of all of the Varieties
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }

    }
}