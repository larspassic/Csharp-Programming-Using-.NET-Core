using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyDoubleProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0; i < 1; i += .01)
            {
                Console.WriteLine(i);
            }

            for (decimal i = 0; i < 1; i += .01M)
            {
                Console.WriteLine(i);
            }
        }
    }
}
