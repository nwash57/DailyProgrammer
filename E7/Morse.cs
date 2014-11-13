using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    class Morse
    {
        public static void Main(string[] args)
        {
            int input;
            Console.WriteLine("1: Convert alphabetic to morse\n2: Convert morse to alphabetic");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    ToMorse();
                    break;
                case 2:
                    ToAlphabetic();
                    break;
            }
        }

        public static void ToMorse()
        {

        }

        public static void ToAlphabetic()
        {

        }
    }
}
