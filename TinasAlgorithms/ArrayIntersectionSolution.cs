namespace TinasAlgorithms
{
    internal class ArrayIntersectionSolution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (list.Count == nums2.Length)
                    {
                        return list.ToArray();
                    }
                    else if (nums1[i] == nums2[j])
                    {
                        list.Add(nums2[j]);
                        break; 
                    }
                }
            }

            return list.ToArray();
        }
    }
}
