namespace TinasAlgorithms
{
    internal class HighAndLowNumberExtractor
    {
        public static string HighAndLow(string numbers)
        {
            List<int> numsList = new List<int>();
            string[] nums = numbers.Split(' ');
            foreach (string s in nums)
            {
                numsList.Add(int.Parse(s));
            }

            numsList.Sort();

            return $"{numsList[numsList.Count - 1]} {numsList[0]}";
        }
    }
}
