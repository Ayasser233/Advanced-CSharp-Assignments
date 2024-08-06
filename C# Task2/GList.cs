using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class GList<T> 
    {
        private List<T> items;
        public GList() 
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"Added item: {item} of type {item.GetType()} " );
        }
        public void Display()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"item: {item} of type {item.GetType()} ");
            }
        }
    }
}
