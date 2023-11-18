namespace TinasAlgorithms
{
    internal class ArrayRotate
    {
        public void Rotate(int[] nums, int k)
        {
            if (k <= 0) return;

            int n = nums.Length;
            k = k % n;
            int num = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = nums.Length - 2; j >= 0; j--)
                {
                    num = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = num;
                }
            }

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
    }
}
