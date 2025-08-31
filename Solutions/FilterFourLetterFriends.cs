namespace TinasAlgorithms
{
    internal class FilterFourLetterFriends
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {

            List<string> name = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length == 4)
                {
                    name.Add(names[i]);
                }
            }
            return name;
        }
    }
}
