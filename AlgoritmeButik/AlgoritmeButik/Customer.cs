using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmeButik.Map;

namespace AlgoritmeButik
{
    public class Customer
    {
        string name;

        

        Gqueue<string> shoppingList = new Gqueue<string>();

        public Customer(string name)
        {
            this.name = name;
        }

        public void MakeList(string item1, string item2)
        {
            shoppingList.Enqueue("Basket");
            shoppingList.Enqueue(item1);
            shoppingList.Enqueue(item2);
            shoppingList.Enqueue("Receipt");
        }
        public string WhatAmIDoing()
        {
            return "hej";
        }
    }
}
