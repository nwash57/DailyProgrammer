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
                    Console.WriteLine(ToMorse());
                    Again();
                    break;
                case 2:
                    ToAlphabetic();
                    Again();
                    break;
            }
        }

        public static string ToMorse()
        {
            string input;
            char[] ca;
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Input the string you would like converted to Morse Code.");
            input = Console.ReadLine();
            ca = input.ToCharArray();

            for (int i = 0; i < ca.Length; i++)
            {
                sb.Append(ConvertChar(ca[i]));
            }
            return sb.ToString();
        }

        public static void ToAlphabetic()
        {

        }

        public static string ConvertChar(char c)
        {
            string output = "";

            switch (c)
            {
                case 'a':
                case 'A':
                    output = ".- ";
                    break;
                case 'b':
                case 'B':
                    output = "-... ";
                    break;
                case 'c':
                case 'C':
                    output = "-.-. ";
                    break;
                case 'd':
                case 'D':
                    output = "-.. ";
                    break;
                case 'e':
                case 'E':
                    output = ". ";
                    break;
                case 'f':
                case 'F':
                    output = "..-. ";
                    break;
                case 'g':
                case 'G':
                    output = "--. ";
                    break;
                case 'h':
                case 'H':
                    output = ".... ";
                    break;
                case 'i':
                case 'I':
                    output = ".. ";
                    break;
                case 'j':
                case 'J':
                    output = ".--- ";
                    break;
                case 'k':
                case 'K':
                    output = "-.- ";
                    break;
                case 'l':
                case 'L':
                    output = ".-.. ";
                    break;
                case 'm':
                case 'M':
                    output = "-- ";
                    break;
                case 'n':
                case 'N':
                    output = "-. ";
                    break;
                case 'o':
                case 'O':
                    output = "--- ";
                    break;
                case 'p':
                case 'P':
                    output = ".--. ";
                    break;
                case 'q':
                case 'Q':
                    output = "--.- ";
                    break;
                case 'r':
                case 'R':
                    output = ".-. ";
                    break;
                case 's':
                case 'S':
                    output = "... ";
                    break;
                case 't':
                case 'T':
                    output = "- ";
                    break;
                case 'u':
                case 'U':
                    output = "..- ";
                    break;
                case 'v':
                case 'V':
                    output = "...- ";
                    break;
                case 'w':
                case 'W':
                    output = ".-- ";
                    break;
                case 'x':
                case 'X':
                    output = "-..- ";
                    break;
                case 'y':
                case 'Y':
                    output = "-.-- ";
                    break;
                case 'z':
                case 'Z':
                    output = "--.. ";
                    break;
                case '1':
                    output = ".---- ";
                    break;
                case '2':
                    output = "..--- ";
                    break;
                case '3':
                    output = "...-- ";
                    break;
                case '4':
                    output = "....- ";
                    break;
                case '5':
                    output = "..... ";
                    break;
                case '6':
                    output = "-.... ";
                    break;
                case '7':
                    output = "--... ";
                    break;
                case '8':
                    output = "---.. ";
                    break;
                case '9':
                    output = "----. ";
                    break;
                case '0':
                    output = "----- ";
                    break;
                case ' ':
                    output = "/ ";
                    break;
            }
            return output;
        }

        public static void Again()
        {
            string input;

            Console.WriteLine("\nRun the program again? y/n");
            input = Console.ReadLine();

            if (input.Equals("y"))
            {
                Main(null);
            }
            else System.Environment.Exit(1);
        }
    }
}
