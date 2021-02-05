using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coords
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate cartPoint = new Coordinate(3, 4);
            printPoint(cartPoint);

            Coordinate polarPoint = 
                new Coordinate(cartPoint.radius, cartPoint.theta);
            printPoint(polarPoint);

            polarPoint = new Coordinate(1, Math.PI);
            printPoint(polarPoint);

            polarPoint = new Coordinate(1.0, 1.0);
            printPoint(polarPoint);




        }

        private static void printPoint(Coordinate point)
        {
            Console.Write("In cartesian coordinates, ");
            Console.WriteLine("the point is at ({0},{1})",
                point.X, point.Y);
            Console.Write("In polar coordinates, ");
            Console.WriteLine("the point is {0} from the origin, at {1} radians",
                point.radius, point.theta);
        }
    }
}
