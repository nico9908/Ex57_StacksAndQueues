﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StacksAndQueues
{
    public class MyQueue<T>
    {
        // Insert local datastructures here ...
        private List<T> queue;
        public MyQueue()
        {
            queue = new List<T>();
        }

        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                T data = queue[0];
                queue.RemoveAt(0);
                return data;
            }
        }

        public int Count()
        {
            return queue.Count();
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
