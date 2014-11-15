using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E008
{
    class Beer
    {
        public static void Main(string[] args)
        {
            for (int i = 99; i >= 0; i--)
            {
                if (i > 2)
                    Console.Write("{0} bottles of beer on the wall, {0} bottles of beer. Take one down, pass it around, {1} bottles of beer on the wall. ", i, (i - 1));
                else if (i == 2)
                    Console.Write("{0} bottles of beer on the wall, {0} bottles of beer. Take one down, pass it around, {1} bottle of beer on the wall. ", i, (i - 1));
                else if (i == 1)
                    Console.Write("{0} bottle of beer on the wall, {0} bottle of beer. Take one down, pass it around, no bottles of beer on the wall. We are sad.", i);
            }
            Console.Read();
        }
    }
}
