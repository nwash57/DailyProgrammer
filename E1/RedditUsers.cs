using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class RedditUsers
    {
        public static void Main(String[] args)
        {
            string name, redditName;
            int age;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your reddit username: ");
            redditName = Console.ReadLine();

            Console.WriteLine("Your name is " + name + ", you are " + age + " years old, and your reddit username is " + redditName + ".");
            saveData(name, age, redditName);
            Console.Read();
        }

        public static void saveData(string n, int a, string rn)
        {
            string[] lines = { n, Convert.ToString(a), rn };

            System.IO.File.WriteAllLines(@"C:\Users\Nathan\Documents\visual studio 2013\Projects\DailyPogrammer\DailyPogrammer\Easy\CH1\redditUsers.txt", lines);
        }
    }
}
