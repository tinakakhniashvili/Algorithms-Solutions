namespace TinasAlgorithms
{
    internal class NodeInsertionInLinkedList
    {
        public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode list, int data, int position)
        {
            SinglyLinkedListNode newList = new SinglyLinkedListNode();
            newList.data = data;

            if (position == 0)
            {
                newList.next = list;
                return newList;
            }

            SinglyLinkedListNode current = list;

            for (int i = 0; i < position - 1; i++)
                current = current.next;

            if (current == null) return list;

            newList.next = current.next;
            current.next = newList;

            return list;
        }
    }
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;
    }
}
