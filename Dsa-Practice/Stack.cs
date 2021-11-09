using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_Practice
{

    public class Stack<T>   // Stack -> LIFO principle
    {
        Entry top;      // properties of Stack 'top' of Entry type

        public void Push(T data)
        {
            top = new Entry(top, data);
        }

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }

            T result = top.Data;
            top = top.Next;
            return result;
        }

        class Entry     // none modifier allows access for class and namespace
        {
            public Entry Next
            {
                get;
                set;
            }

            public T Data
            {
                get;
                set;
            }

            public Entry(Entry next, T data)
            {
                this.Next = next;
                this.Data = data;
            }


        }
    }
}




