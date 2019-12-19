using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmeButik.Map;

namespace AlgoritmeButik
{
    class BuildStore
    {
        Glist<string> items = new Glist<string>();
        Graph<Node<string>> mapGraph = new Graph<Node<string>>();

        public Glist<string> Items
        {
            get { return items; }
        }

        public BuildStore()
        {

        }

        public void BuildItems()
        {
            items.Add("Fruit");
            items.Add("Dairy");
            items.Add("Meat");
            items.Add("Colonial");
            items.Add("Tools");
            items.Add("Candy");
            items.Add("Electronics");
            items.Add("Bakery");
            items.Add("Basket");
            items.Add("Receipt");
        }

        public void BuildMap()
        {
            mapGraph.AddNode(new Node<string>(FindInItems("Basket")));
            
        }

        public string FindInItems(string what)
        {
            foreach(string item in items)
            {
                if(item == what)
                {
                    return what;
                }
            }
            throw new Exception("Your Item does not exist");
        }
    }
}
