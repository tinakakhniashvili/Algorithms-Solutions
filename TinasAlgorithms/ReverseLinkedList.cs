namespace TinasAlgorithms
{
    internal class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            List<int> list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            ListNode newHead = null;

            for (int i = 0; i < list.Count; i++)
            {
                ListNode newNode = new ListNode(list[i]);
                newNode.next = newHead;
                newHead = newNode;
            }

            return newHead;
        }
    }
}
