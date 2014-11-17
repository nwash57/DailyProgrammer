using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E013
{
    class DayOfYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < month - 1; i++)
            {
                if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                    day += 31;
                if (i == 3 || i == 5 || i == 8 || i == 10)
                    day += 30;
                if (i == 1)
                    day += 29;
            }

            Console.WriteLine("The day of the year is: {0}", day);
            Console.ReadLine();
        }
    }
}
