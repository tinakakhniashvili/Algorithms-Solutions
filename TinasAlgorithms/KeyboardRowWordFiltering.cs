namespace TinasAlgorithms
{
    internal class KeyboardRowWordFiltering
    {
        public string[] FindWords(string[] words)
        {
            List<string> properWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (Row1(words[i])) properWords.Add(words[i]);
                else if (Row2(words[i])) properWords.Add(words[i]);
                else if (Row3(words[i])) properWords.Add(words[i]);
            }
            return properWords.ToArray();
        }

        public bool Row1(string word)
        {
            string row1 = "qwertyuiop";
            foreach (char letter in word)
            {
                if (!row1.Contains(char.ToLower(letter))) return false;
            }
            return true;
        }
        public bool Row2(string word)
        {
            string row2 = "asdfghjkl";
            foreach (char letter in word)
            {
                if (!row2.Contains(char.ToLower(letter))) return false;
            }
            return true;
        }
        public bool Row3(string word)
        {
            string row3 = "zxcvbnm";
            foreach (char letter in word)
            {
                if (!row3.Contains(char.ToLower(letter))) return false;
            }
            return true;
        }
    }
}
