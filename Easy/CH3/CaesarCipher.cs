using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DailyProgrammer.Easy.CH3
{
    class CaesarCipher
    {
        public static int ioStyle = 0, offPut;
        public static string decipheredInput, ciphered, userName;
        

        public static void Main(String[] args)
        {
            userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            userName = userName.Substring(userName.IndexOf('\\'));

            GetInputStyle();
            GetOutputStyle();

            switch (ioStyle)
            {
                case 5: //console in:console out, you cant explain that
                    ConsoleInput();
                    ConsoleOutput();
                    Again();
                    break;
                case 6: //text in:console out
                    TextFileInput();
                    ConsoleOutput();
                    Again();
                    break;
                case 9: //console in:text out
                    ConsoleInput();
                    TextFileOutput();
                    Again();
                    break;
                case 10: //text in:text out, you cant explain that
                    TextFileInput();
                    TextFileOutput();
                    Again();
                    break;
            }
        }

        public static void TextFileInput()
        {
            string input;
            
            Console.WriteLine("\nPut the text file in your Documents folder, and enter the name of the file here: ");

            input = Console.ReadLine();

            Console.WriteLine("\nHow many characters would you like to rotate the input?");
            offPut = Convert.ToInt32(Console.ReadLine());

            if (input.Substring(input.Length - 4, 4).Equals(".txt"))
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\" + userName + "\\Documents\\" + input))
                {
                    String line = sr.ReadToEnd();
                    Cipher(line, offPut);
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(input + ".txt"))
                {
                    String line = sr.ReadToEnd();
                    Cipher(line, offPut);
                }
            }
        }

        public static void TextFileOutput()
        {
            System.IO.File.WriteAllText("C:\\Users\\" + userName + "\\Documents\\ciphered.txt", ciphered);
        }

        public static void ConsoleInput()
        {
            Console.WriteLine("\nEnter your text into the console and press Enter: ");
            decipheredInput = Console.ReadLine();

            Console.WriteLine("\nHow many characters would you like to rotate the input?");
            offPut = Convert.ToInt32(Console.ReadLine());

            Cipher(decipheredInput, offPut);
        }

        public static void ConsoleOutput()
        {
            Console.WriteLine(ciphered);
        }

        public static void Cipher(string input, int num)
        {
            char[] ca = input.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < ca.Length; i++)
            {
                ca[i] = Convert.ToChar(ca[i] + num);
            }
            
            for (int i = 0; i < ca.Length; i++)
            {
                sb.Append(ca[i]);
            }

            ciphered = sb.ToString();
        }

        public static void GetInputStyle()
        {
            int input;

            Console.WriteLine("\n1: Input through console\n" +
                                "2: Input through a plain text file");

            input = Convert.ToInt16(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ioStyle += 1;
                    break;
                case 2:
                    ioStyle += 2;
                    break;
            }
        }

        public static void GetOutputStyle()
        {
            int input;

            Console.WriteLine("\n1: Output to console\n" +
                                "2: Output to plain text file");

            input = Convert.ToInt16(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ioStyle += 4;
                    break;
                case 2:
                    ioStyle += 8;
                    break;
            }
        }

        public static void Again()
        {
            string input;

            Console.WriteLine("\nRun the program again? y/n");
            input = Console.ReadLine();

            if (input.Equals("y"))
            {
                ioStyle = 0;
                Main(null);
            }
            else System.Environment.Exit(1);
        }
    }
}
