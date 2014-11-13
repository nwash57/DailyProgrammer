using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH4
{
    class Challenge4
    {
        public static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_+=!@#$%^&*()[]{}\\|/?`~,<>.";
        public static int passLength, numOfPass;
        public static Challenge4Form form = new Challenge4Form();
        public static Random rand = new Random();
        public static string password;
        public static List<string> passwords = new List<string>();

        public static void Main(string[] args)
        {
            Application.Run(form);
        }

        public static void CreatePasswords()
        {
            for (int i = 0; i < numOfPass; i++)
            {
                password = "";

                for (int j = 0; j < passLength; j++)
                {
                    password += chars[rand.Next(0, chars.Length)];
                }
                passwords.Add(password);
            }
        }
    }
}
