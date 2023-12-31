﻿using System.Text;


namespace TinasAlgorithms
{
    internal class CaesarCipher
    {
        public static string CaesarCipherEncrypt(string s, int k)
        {
            char l;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder sb = new StringBuilder(s);

            k = k % alphabet.Length;

            for (int i = 0; i < s.Length; i++)
            {
                bool isUpperCase = Char.IsUpper(s[i]) ? true : false;

                if (Char.IsLetter(s[i]))
                {
                    l = Char.ToLower(s[i]);

                    int index = (alphabet.IndexOf(l) + k) % alphabet.Length;

                    if (index < 0) index += alphabet.Length;

                    l = alphabet[index];

                    if (isUpperCase) l = Char.ToUpper(l);

                    sb[i] = l;
                }
            }

            return sb.ToString();
        }
        public static string CaesarCipherDecrypt(string s, int k)
        {
            char l;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder sb = new StringBuilder(s);

            k = k % alphabet.Length;

            for (int i = 0; i < s.Length; i++)
            {
                bool isUpperCase = Char.IsUpper(s[i]) ? true : false;

                if (Char.IsLetter(s[i]))
                {
                    l = Char.ToLower(s[i]);

                    int index = (alphabet.IndexOf(l) - k) % alphabet.Length;

                    if (index < 0) index += alphabet.Length;

                    l = alphabet[index];

                    if (isUpperCase) l = Char.ToUpper(l);

                    sb[i] = l;
                }
            }

            return sb.ToString();

        }
    }
}
