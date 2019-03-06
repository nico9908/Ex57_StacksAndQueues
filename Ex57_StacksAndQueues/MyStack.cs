using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StacksAndQueues
{
    public class MyStack<T>
    {
        private List<T> stack;
        public MyStack()
        {
            stack = new List<T>();
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                T data = stack.Last();
                stack.Remove(stack.Last());
                return data;
            }
        }

        public T Peek()
        {
            return stack.Last();
        }

        public int Count()
        {
            return stack.Count();
        }

        public Boolean IsEmpty()
        {
            if (Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
