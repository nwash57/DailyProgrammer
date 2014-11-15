using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
    class PasswordProtected
    {
        public static void Main(string[] args)
        {
            string user, pass, inputUser, inputPass;
            List<string> list = new List<string>();

            list = System.IO.File.ReadLines(Properties.Resources.up).ToList<string>();
            user = list[0];
            pass = list[1];

            Console.WriteLine("User: ");
            inputUser = Console.ReadLine();

            Console.WriteLine("Password: ");
            inputPass = Console.ReadLine();

            if (pass.Equals(inputPass) && user.Equals(inputUser))
            {
                Program();
            }
            else Console.WriteLine("Access Denied");
        }

        private static void Program()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
