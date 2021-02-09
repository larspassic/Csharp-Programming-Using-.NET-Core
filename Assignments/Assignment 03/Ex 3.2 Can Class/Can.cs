using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3_2_Can_Class
{
    public enum Flavor { REGULAR, ORANGE, LEMON}
    
    class Can
    {
        //It looks like this is initializing TheFlavor and defaulting it to REGULAR
        public readonly Flavor TheFlavor = Flavor.REGULAR;

        //I don't know what this does. I think I need to make a get/set but I am not sure
        public Can()
        {

        }

        //This... thing allows the user to set the flavor
        public Can (Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}
