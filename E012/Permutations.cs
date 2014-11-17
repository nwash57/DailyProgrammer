using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E012
{
    class Permutations
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the string you would like to permutate");
            string input = Console.ReadLine();
            char[] ca = input.ToCharArray();
            Setper(ca);
            Console.Read();
        }

        public static void Swap(char a, char b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void Setper(char[] list)
        {
            int index = list.Length - 1;
            Permutate(list, 0, index);
        }

        public static void Permutate(char[] list, int recursionDepth, int maxDepth)
        {
            int i;

            
            
                for (i = recursionDepth; i <= maxDepth; i++)
                {
                    Swap(list[recursionDepth], list[i]);
                    Permutate(list, recursionDepth + 1, maxDepth);
                    Swap(list[recursionDepth], list[i]);
                }
                if (recursionDepth == maxDepth)
                    Console.Write("{0}\n", list[i - 1]);
        }
    }
}
