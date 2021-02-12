using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._3_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin mySlug = new Coin();
            Coin myNickel = new Coin(0.05M);
            Coin myOtherSlug = new Coin(23M); // 23M is a value, but not one of a recognized coin
            Coin anotherSlug = new Coin("222"); // "222" can be converted to a number, but not a coin value

            Console.WriteLine(mySlug);
            Console.WriteLine(myNickel);
            Console.WriteLine(myOtherSlug);
            Console.WriteLine(anotherSlug);

            Console.WriteLine("{0:c}",myNickel.ValueOf);
            Console.WriteLine(myNickel.CoinEnumeral);

            Console.WriteLine(new Coin("NICKEL"));
            Console.WriteLine(new Coin("NICKEL").ValueOf);

            Console.WriteLine(new Coin("SLUG").ValueOf);

            
        }
    }
}
