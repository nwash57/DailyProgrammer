using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    class Calculator
    {
        public static void Main(String[] args)
        {
            int input;

            Console.WriteLine("\n1: Force (F=MA)\n" +
                                "2: Acceleration (A=F/M)\n" +
                                "3: Mass (M=F/A)");
            input = Convert.ToInt16(Console.ReadLine());

            switch (input)
            {
                case 1:
                    CalculateForce();
                    break;
                case 2:
                    CalculateAcceleration();
                    break;
                case 3:
                    CalculateMass();
                    break;
            }

        }

        public static void CalculateForce()
        {
            double mass, accel, force;

            Console.WriteLine("Enter the object's acceleration: ");
            accel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the object's mass: ");
            mass = Convert.ToDouble(Console.ReadLine());

            force = mass * accel;

            Console.WriteLine("The object's force is " + force + "N");
            Again();
        }

        public static void CalculateAcceleration()
        {
            double mass, force, accel;

            Console.WriteLine("Enter the object's net force: ");
            force = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the object's mass: ");
            mass = Convert.ToDouble(Console.ReadLine());

            accel = force / mass;

            Console.WriteLine("The object's acceleration is " + accel + "m/s^2");
            Again();
        }

        public static void CalculateMass()
        {
            double force, accel, mass;

            Console.WriteLine("Enter the object's net force: ");
            force = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the object's acceleration: ");
            accel = Convert.ToDouble(Console.ReadLine());

            mass = force / accel;

            Console.WriteLine("The object's mass is " + mass + "kg");
            Again();
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
