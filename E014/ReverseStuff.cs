using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E014
{
    class ReverseStuff
    {
        public static List<string> list = new List<string>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Input strings and press enter. Input 'done' to end input.");
            Console.Write("Input: ");

            string input = Console.ReadLine();
            while (!input.Equals("done"))
            {
                Console.Write("Input: ");
                input = Console.ReadLine();
                list.Add(input);
            }

            Console.WriteLine("How large of blocks would you like to swap?");
            Console.Write("Block Size: ");

            int blockSize = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (((i * blockSize) % blockSize) % 1 == 0 && (i + blockSize < list.Count))
                {
                    list.Reverse(i, blockSize);
                }
            }

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].ToString());
            Console.Read();
        }
    }
}
