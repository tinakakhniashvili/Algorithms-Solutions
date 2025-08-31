using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinasAlgorithms
{
    internal class VowelRemoval
    {
        public static string Disemvowel(string str)
        {
            string str2 = "";
            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    str2 += c;
                }
            }
            return str2;
        }
        public static bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') return true;
            else return false;
        }
    }
}
