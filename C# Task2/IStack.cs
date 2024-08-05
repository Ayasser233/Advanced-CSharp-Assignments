using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal interface IStack<T>
    {
        void Push(T item);
        T Pop();
    }
}
