namespace TinasAlgorithms
{
    internal class CountTallestCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int maxHeight = candles.Max();
            int sum = 0;
            foreach (int height in candles)
            {
                if (height == maxHeight) sum++;
            }

            return sum;
        }
    }
}
