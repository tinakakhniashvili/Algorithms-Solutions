namespace TinasAlgorithms
{
    internal class IsAnagramCheck
    {
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) return false;

            List<char> chars = new List<char>();

            foreach (char c in s) chars.Add(c);

            for (int i = 0; i < t.Length; i++)
            {
                if (chars.Contains(t[i])) chars.Remove(t[i]);
                else return false;
            }

            return true;
        }
    }
}
