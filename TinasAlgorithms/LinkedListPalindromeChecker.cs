namespace TinasAlgorithms
{
    internal class LinkedListPalindromeChecker
    {
        public bool IsPalindrome(ListNode head)
        {
            bool isPalindrome = true;
            List<int> list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
   /* public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    } */
}
