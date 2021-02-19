using System;
using System.Collections.Generic;

//Assignment 05
//Author: Passic, Lars, 2011958


namespace Exercise_5._1_FlavorOps
{
    public enum Flavor { REGULAR, ORANGE, LEMON }

    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        //I don't know what this is
        static FlavorOps()
        {
            int i = 0;
            foreach (Flavor flavorObject in Enum.GetValues(typeof(Flavor)))
            {
                _allFlavors[i] = flavorObject;
                i++;
            }
        }

        //Method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            Flavor convertedToFlavorObject = (Flavor)Enum.Parse(typeof(Flavor), FlavorName);
            
            return convertedToFlavorObject;
        }

        //Property to return a List<Flavor> of all of the Varieties
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }

    }
}
