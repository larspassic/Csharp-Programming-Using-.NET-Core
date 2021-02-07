using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3._2_Can_Class
{
    enum Flavor { REGULAR, ORANGE, LEMON}
    
    class Can
    {
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
