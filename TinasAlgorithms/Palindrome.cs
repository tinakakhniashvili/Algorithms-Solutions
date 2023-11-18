using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinasAlgorithms
{
    internal class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            string[] words = s.Split(' ', ',', '.', ';', ':', '!', '?', '\'', '"', '@', '#', '_', '[', ']', '{', '}', '\\', '-', '(', ')', '`');
            string word = "";
            foreach (string w in words) word += w;

            string second = "";

            for (int i = word.Length - 1; i >= 0; i--) second += word[i];

            string firtsPart = word.ToLower();
            string secondPart = second.ToLower();

            return firtsPart == secondPart;
        }
    }
}
