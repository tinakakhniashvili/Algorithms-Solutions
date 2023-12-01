using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinasAlgorithms
{
    internal class MyQueue
    {
        List<int> queue = new List<int>();
        int Head;
        int Tail;

        public MyQueue()
        {
            Head = 0;
            Tail = 0;
        }

        public void Push(int x)
        {
            queue.Add(x);
            Tail++;
        }

        public int Pop()
        {
            if (queue.Count == 0)
            {
                return 0;
            }
            else
            {
                int removedElement = queue[Head];
                queue.RemoveAt(Head);
                Tail--;
                return removedElement;
            }
        }

        public int Peek()
        {
            if (queue.Count < 1) return 0;
            return queue[Head];
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
