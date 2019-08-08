using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Tools
    {
        public static bool Contains(string target, string list)
        {
            for (int i = 0; i < target.Length - 1; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (target[i] == list[j]) return true;
                }
            }
            return false;
        }
    }
}
