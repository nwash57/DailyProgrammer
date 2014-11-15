using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E006
{
    class Pi
    {
        public static double digits, yourPi;
        public static double PI = 3.141592653589793238462643383279502884197;

        public static void Main(string[] args)
        {
            int input;

            Console.WriteLine("1: Calculate Pi using the Gregory-Leibniz series\n" +
                              "2: Calculate Pi using the Nilakantha series");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many iterations of the series would you like to run?");
            digits = Convert.ToDouble(Console.ReadLine());

            switch (input)
            {
                case 1:
                    GregoryL();
                    Again();
                    break;
                case 2:
                    Nilakantha();
                    Again();
                    break;
            }
        }

        public static void GregoryL()
        {
            double denominator = 1;
            Stopwatch sw = Stopwatch.StartNew();

            for (double i = 0; i < digits; i++)
            {
                if (i % 2 == 0)
                    yourPi += Math.Round((4 / denominator), 30);
                else yourPi -= Math.Round((4 / denominator), 30);
                denominator += 2;
            }
            sw.Stop();

            Console.WriteLine(Math.Round(yourPi, 30));
            Console.WriteLine("Calculated in: {0}ms", sw.ElapsedMilliseconds);
            Console.WriteLine(CalculateCorrect() + " correct digits of Pi");
        }

        public static void Nilakantha()
        {
            double x = 2;
            yourPi = 3;
            Stopwatch sw = Stopwatch.StartNew();

            for (double i = 0; i < digits; i++)
            {
                if (i % 2 == 0)
                {
                    yourPi += 4 / (x * (x + 1) * (x + 2));
                }
                else yourPi -= 4 / (x * (x + 1) * (x + 2));

                x += 2;
            }
            sw.Stop();

            Console.WriteLine(yourPi);
            Console.WriteLine("Calculated in: {0}ms", sw.ElapsedMilliseconds);
            Console.WriteLine(CalculateCorrect() + " correct digits of Pi");
        }

        public static int CalculateCorrect()
        {
            char[] piList = Convert.ToString(PI).ToCharArray();
            char[] yourPiList = Convert.ToString(yourPi).ToCharArray();
            int correct = -1;

            for (int i = 0; i < piList.Length; i++)
            {
                if (piList[i].Equals(yourPiList[i]))
                {
                    correct++;
                }
                else break;
            }
            return correct;
        }

        public static void Again()
        {
            string input;

            Console.WriteLine("\nRun the program again? y/n");
            input = Console.ReadLine();

            if (input.Equals("y"))
            {
                digits = 0;
                yourPi = 0;
                Main(null);
            }
            else System.Environment.Exit(1);
        }
    }
}
