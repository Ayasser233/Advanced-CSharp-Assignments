using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class Company
    {
        private int id;
        private string name;
        private Dictionary<Products, int> company = new Dictionary<Products, int>();
        public event Action<Products> stock;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Company(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        public void pay(Products prdouct, int quantity) 
        {
            if(company.ContainsKey(prdouct))
            {
                company[prdouct] += quantity;
                Console.WriteLine($"Product {prdouct.Name} paid for successfully");
            }
            else
            {
                company.Add(prdouct, quantity);
                Console.WriteLine($"Product {prdouct.Name} added successfully");
            }
        }
        public void sell(Products prdouct, int quantity)
        {
            if (company.ContainsKey(prdouct))
            {
                company[prdouct] -= quantity;
                Console.WriteLine($"Product {prdouct.Name} sold successfully and remaining {company[prdouct]}");

                if (company[prdouct] < 5)
                {
                    stock?.Invoke(prdouct);
                }
            }
            else
            {
                Console.WriteLine($"Product {prdouct.Name} not found");
            }
        }
    }
}
