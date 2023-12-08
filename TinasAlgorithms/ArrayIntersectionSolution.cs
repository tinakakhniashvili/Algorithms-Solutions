namespace TinasAlgorithms
{
    internal class ArrayIntersectionSolution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            List<int> list = new List<int>();

            int index1 = 0;
            int index2 = 0;

            while (index1 < nums1.Length && index2 < nums2.Length)
            {
                if (nums1[index1] == nums2[index2])
                {
                    list.Add(nums1[index1]);
                    index1++;
                    index2++;
                }
                else if (nums1[index1] < nums2[index2]) index1++;
                else index2++;
            }

            return list.ToArray();
        }
    }
}
