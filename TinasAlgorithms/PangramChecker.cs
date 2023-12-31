using System.Collections;

namespace TinasAlgorithms
{
    internal class PangramChecker
    {
        public bool CheckIfPangram(string sentence)
        {
            if (sentence.Length < 26) return false;

            Hashtable letterTable = new Hashtable();

            foreach (char letter in sentence.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    if (!letterTable.ContainsKey(letter))
                    {
                        letterTable.Add(letter, null);
                    }
                }
            }

            return letterTable.Count == 26;
        }
    }
}
