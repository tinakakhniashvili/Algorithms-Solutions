namespace TinasAlgorithms
{
    internal class MinStack
    {
        public int top;
        List<int> stack = new List<int>();
        public MinStack()
        {
            top = -1;
        }

        public void Push(int val)
        {
            top++;
            stack.Add(val);
        }

        public void Pop()
        {
            if (top >= 0)
            {
                stack.RemoveAt(top);
                top--;
            }
            else
            {
                stack[top] = 0;
            }
        }

        public int Top()
        {
            if (top >= 0)
            {
                return stack[top];
            }
            return 0;
        }

        public int GetMin()
        {
            if (top < 0) return 0;
            int min = stack[0];

            for (int i = 0; i < stack.Count; i++)
            {
                if (stack[i] < min) min = stack[i];
            }

            return min;
        }
    }
}
