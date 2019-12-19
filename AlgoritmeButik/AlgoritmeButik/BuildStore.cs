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
        Graph<string> mapGraph = new Graph<string>();

        public Glist<string> Items
        {
            get { return items; }
        }

        public BuildStore()
        {
            BuildItems();
            BuildNodeMap();
            AddEdge();
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

        public void BuildNodeMap()
        {
            mapGraph.AddNode(FindInItems("Basket"));
            mapGraph.AddNode(FindInItems("Fruit"));
            mapGraph.AddNode(FindInItems("Dairy"));
            mapGraph.AddNode(FindInItems("Meat"));
            mapGraph.AddNode(FindInItems("Colonial"));
            mapGraph.AddNode(FindInItems("Tools"));
            mapGraph.AddNode(FindInItems("Candy"));
            mapGraph.AddNode(FindInItems("Electronics"));
            mapGraph.AddNode(FindInItems("Bakery"));
            mapGraph.AddNode(FindInItems("Receipt"));
        }

        public void AddEdge()
        {
            mapGraph.AddEdgeToNode("Basket", "Fruit", false);
            mapGraph.AddEdgeToNode("Fruit", "Bakery");
            mapGraph.AddEdgeToNode("Basket", "Meat", false);
            mapGraph.AddEdgeToNode("Fruit", "Meat");
            mapGraph.AddEdgeToNode("Meat", "Dairy");
            mapGraph.AddEdgeToNode("Dairy", "Colonial");
            mapGraph.AddEdgeToNode("Meat", "Electronics");
            mapGraph.AddEdgeToNode("Meat", "Candy");
            mapGraph.AddEdgeToNode("Electronics", "Candy");
            mapGraph.AddEdgeToNode("Electronics", "Tools");
            mapGraph.AddEdgeToNode("Electronics", "Receipt", false);
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
