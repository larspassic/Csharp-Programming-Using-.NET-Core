
//Assignment 06
//Author: Passic, Lars, 2011958

namespace Assignment_06_WinForms
{
    public class Can
    {
        //Readonly field defaults to Regular?
        public readonly Flavor TheFlavor = Flavor.REGULAR;

        //Parameterless constructor - no default
        public Can()
        {
        }

        //Creates a can object of the flavor that was passed in
        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }


    }
}
