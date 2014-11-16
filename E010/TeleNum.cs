using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E010
{
    class TeleNum
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d{3}[.-]\d{3}[.-]\d{4}|[(]\d{3}[)]\s\d{3}.\d{4}|[(]\d{3}[)]\d{3}[-.]\d{4}|\d{10}|\d{7}");
            string num;

            Console.WriteLine("\nInsert a valid telephone number.");
            num = Console.ReadLine();

            if (regex.Match(num).Success)
                Console.WriteLine("Valid");
            else Console.WriteLine("Invalid");
            Main(null);
        }
    }
}
