using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    class Morse
    {
        public static void Main(string[] args)
        {


            int input;
            string sinput;
            Console.WriteLine("1: Convert alphabetic to morse\n2: Convert morse to alphabetic\n3: Beep My Morse");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine(ToMorse());
                    Again();
                    break;
                case 2:
                    Console.WriteLine(ToAlphabetic());
                    Again();
                    break;
                case 3:
                    Console.WriteLine("Enter the morse you would like beeped");
                    sinput = Console.ReadLine();
                    BeepMyMorse(sinput);
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
            input = Console.ReadLine().ToLower();
            ca = input.ToCharArray();

            for (int i = 0; i < ca.Length; i++)
            {
                sb.Append(ConvertChar(ca[i]));
            }
            return sb.ToString();
        }

        public static string ToAlphabetic()
        {
            string input;
            int currIndex = 0;
            int nextIndex;

            List<string> morseList = new List<string>();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Input the Morse code you would like converted to real words.");
            input = Console.ReadLine() + " ";

            while (input.Length > 0)
            {
                nextIndex = input.IndexOf(' ') + 1;

                morseList.Add(input.Substring(currIndex, nextIndex));
                input = input.Remove(currIndex, nextIndex - currIndex);
            }

            for (int i = 0; i < morseList.Count; i++)
            {
                sb.Append(ConvertMorse(morseList[i]));
            }
            return sb.ToString();
        }

        public static void BeepMyMorse(string morse)
        {
            char[] ca = morse.ToCharArray();

            SoundPlayer dot = new SoundPlayer(Properties.Resources.dot);
            SoundPlayer line = new SoundPlayer(Properties.Resources.line);

            for (int i = 0; i < ca.Length; i++)
            {
                if (ca[i].Equals('.'))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    dot.Play();
                    System.Threading.Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                }

                else if (ca[i].Equals('-'))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    line.Play();
                    System.Threading.Thread.Sleep(1500);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                }

                else if (ca[i].Equals(' ') || ca[i].Equals('/'))
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
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

        public static string ConvertMorse(string s)
        {
            string output = "";

            switch (s)
            {
                case ".- ":
                    output = "a";
                    break;
                case "-... ":
                    output = "b";
                    break;
                case "-.-. ":
                    output = "c";
                    break;
                case "-.. ":
                    output = "d";
                    break;
                case ". ":
                    output = "e";
                    break;
                case "..-. ":
                    output = "f";
                    break;
                case "--. ":
                    output = "g";
                    break;
                case ".... ":
                    output = "h";
                    break;
                case ".. ":
                    output = "i";
                    break;
                case ".--- ":
                    output = "j";
                    break;
                case "-.- ":
                    output = "k";
                    break;
                case ".-.. ":
                    output = "l";
                    break;
                case "-- ":
                    output = "m";
                    break;
                case "-. ":
                    output = "n";
                    break;
                case "--- ":
                    output = "o";
                    break;
                case ".--. ":
                    output = "p";
                    break;
                case "--.- ":
                    output = "q";
                    break;
                case ".-. ":
                    output = "r";
                    break;
                case "... ":
                    output = "s";
                    break;
                case "- ":
                    output = "t";
                    break;
                case "..- ":
                    output = "u";
                    break;
                case "...- ":
                    output = "v";
                    break;
                case ".-- ":
                    output = "w";
                    break;
                case "-..- ":
                    output = "x";
                    break;
                case "-.-- ":
                    output = "y";
                    break;
                case "--.. ":
                    output = "z";
                    break;
                case ".---- ":
                    output = "1";
                    break;
                case "..--- ":
                    output = "2";
                    break;
                case "...-- ":
                    output = "3";
                    break;
                case "....- ":
                    output = "4";
                    break;
                case "..... ":
                    output = "5";
                    break;
                case "-.... ":
                    output = "6";
                    break;
                case "--... ":
                    output = "7";
                    break;
                case "---.. ":
                    output = "8";
                    break;
                case "----. ":
                    output = "9";
                    break;
                case "----- ":
                    output = "0";
                    break;
                case "/ ":
                    output = " ";
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
