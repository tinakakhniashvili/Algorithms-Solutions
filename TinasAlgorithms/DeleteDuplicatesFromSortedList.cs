namespace TinasAlgorithms
{
    internal class DeleteDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode listNode = head;

            while (listNode.next != null)
            {
                if (listNode.val == listNode.next.val)
                    listNode.next = listNode.next.next;
                else
                    listNode = listNode.next;
            }

            return head;
        }
    }
    
}
