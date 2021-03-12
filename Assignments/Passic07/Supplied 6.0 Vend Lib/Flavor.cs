using System;
using System.Collections.Generic;

namespace Supplied_06._0_Vend_Lib
{
    public enum Flavor { REGULAR, ORANGE, LEMON }
    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps()
        {
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnumeral = ToFlavor(flavorName);
                _allFlavors.Add(flavorEnumeral);
            }
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper();
            Flavor result = Flavor.REGULAR;
            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                result = (Flavor)Enum.Parse(typeof(Flavor),FlavorName);
            }
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