using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int minLength = 8;
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = lowercase.ToUpper();
            string digits = "0123456789";
            string specialChars = "!~`#$%^&*?";
            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 4: Console.WriteLine("password is extremely strong"); break;
                case 5: Console.WriteLine("password is extremely strong"); break;
                case 3: Console.WriteLine("password is strong"); break;
                case 2: Console.WriteLine("password is medium"); break;
                case 1: Console.WriteLine("password is weak"); break;
                default:
                    Console.WriteLine("password doesn’t meet any of the standards");
                    break;

            }
            Console.ReadKey();

        }
    }
}
