using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E011
{
    class DateToDayOfWeek
    {
        public static void Main(string[] args)
        {
            int Y, y, c, d, m, w;
            string dayOfWeek = "";

            Console.WriteLine("\nDay: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: ");
            Y = Convert.ToInt32(Console.ReadLine());

            if (m < 3)
            {
                m += 12;
                Y -= 1;
            }

            y = Y;
            while (y > 99)
            {
                y -= 100;
            }

            c = Y;
            while (!(c % 100 == 0))
            {
                c--;
            }
            c /= 100;

            w = (d + ((13 * (m + 1)) / 5) + y + (y / 4) + (c / 4) - (2 * c)) % 7;

            switch (w)
            {
                case 2:
                    dayOfWeek = "Monday";
                    break;
                case 3:
                    dayOfWeek = "Tuesday";
                    break;
                case 4:
                    dayOfWeek = "Wednesday";
                    break;
                case 5:
                    dayOfWeek = "Thursday";
                    break;
                case 6:
                    dayOfWeek = "Friday";
                    break;
                case 0:
                    dayOfWeek = "Saturday";
                    break;
                case 1:
                    dayOfWeek = "Sunday";
                    break;
            }
            Console.WriteLine(dayOfWeek);

            Main(null);
        }
    }
}
