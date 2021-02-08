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

        public Can()
        {

        }

        public Can (Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}
