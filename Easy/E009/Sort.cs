using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E009
{
    class Sort
    {
        public static void Main(string[] args)
        {
            string input;
            char[] ca;
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Input string to be sorted.");
            input = Console.ReadLine();
            ca = input.ToCharArray();
            Array.Sort(ca);

            for (int i = 0; i < ca.Length; i++ )
            {
                sb.Append(ca[i]);
            }
            Console.WriteLine(sb.ToString());
            Console.Read();
        }
    }
}
