namespace TinasAlgorithms
{
    internal class MergeTwoLinkedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> list = new List<int>();

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    list.Add(list2.val);
                    list2 = list2.next;
                }
                else if (list2 == null)
                {
                    list.Add(list1.val);
                    list1 = list1.next;
                }
                else if (list1.val < list2.val)
                {
                    list.Add(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    list.Add(list2.val);
                    list2 = list2.next;
                }
            }

            ListNode dummy = new ListNode();
            ListNode current = dummy;

            for (int i = 0; i < list.Count; i++)
            {
                current.next = new ListNode(list[i]);
                current = current.next;
            }

            return dummy.next;
        }
    }
}
