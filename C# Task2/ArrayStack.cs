using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class ArrayStack<T> : IStack<T>
    {
        private T[] items;
        private int current;
        public ArrayStack(int size) 
        {
            items = new T[size];
            current = 0;
        }

        public void Push(T item)
        {
            if (current >= items.Length)
            {
                throw new InvalidOperationException("Stack is full");
            }
            items[current] = item;
            current++;
        }

        public T Pop()
        { 
            if (current == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            current--;
            return items[current];

            
        }
    }
}
