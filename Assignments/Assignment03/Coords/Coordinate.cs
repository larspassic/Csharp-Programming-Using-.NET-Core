using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coords
{
    // this code demonstrates that the implementation of a class
    // is separate from its interface (or presentation) to the 
    // user of that class. Here, the implementation of the class
    // is done using cartesian coordinates. At the same time,
    // the interface to this class allows users to use either
    // cartesian or polar coordinates. 
    // For a clear contrast between cartesian and polar coordinates,
    // we are using ints for cartesian coordinates and doubles
    // for polar coordinates. Because of that, small values 
    // (i.e., between zero and one) of x and y will yeild significant 
    // errors in some results.
    class Coordinate
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
            _hypotenuse = Math.Sqrt(X * X + Y * Y);
        }

        public Coordinate(double radius, double theta)
        {
            _hypotenuse = radius;
            X = (int)(Math.Cos(theta) * _hypotenuse);
            Y = (int)(Math.Sin(theta) * _hypotenuse);
        }

        public int X
        {
            get { return _x; }
            private set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            private set { _y = value; }
        }

        private double _hypotenuse; 

        public double radius
        { get { return _hypotenuse; } }

        public double theta
        { get { return Math.Asin(Y/_hypotenuse); } }

        private int _x;
        private int _y;
    }
}
