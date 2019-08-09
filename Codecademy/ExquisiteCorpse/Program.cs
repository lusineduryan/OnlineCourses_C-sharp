using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            //BuildACreature("GHOST", "MONSTER", "BUG");
            RandomMode(out int head, out int body, out int feet);
            SwitchCase(head, body, feet);
            Console.ReadKey();
        }
        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
        }
        static void RandomMode(out int head, out int body, out int feet)
        {
            Random randomNumber = new Random();
            head = randomNumber.Next(1, 4);
            body = randomNumber.Next(1, 4);
            feet = randomNumber.Next(1, 4);
        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1: GhostHead(); break;
                case 2: BugHead(); break;
                case 3: MonsterHead(); break;
                default: break;
            }
            switch (body)
            {
                case 1: GhostBody(); break;
                case 2: BugBody(); break;
                case 3: MonsterBody(); break;
                default: break;
            }
            switch (feet)
            {
                case 1: GhostFeet(); break;
                case 2: BugFeet(); break;
                case 3: MonsterFeet(); break;
                default: break;
            }
        }
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "GHOST": return 1;
                case "MONSTER": return 3;
                case "BUG": return 2;
                default: return 1;
            }
        }
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
