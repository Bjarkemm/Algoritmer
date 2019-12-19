using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik.Map
{
    class Graph<T>
    {
        Gdictionary<string, Node<T>> listOfNodes = new Gdictionary<string, Node<T>>();

        public Gdictionary<string, Node<T>> ListOfNodes
        {
            get { return listOfNodes; }
        }

        public Graph()
        {

        }

        public void AddNode(T value)
        {
            Node<T> node = new Node<T>(value);
            listOfNodes.Add(Convert.ToString(value), node);
        }

        public void AddEdgeToNode(string startNode, string endNode, bool bidirectional = true)
        {
            listOfNodes[startNode].AddEdge(endNode);
            if (bidirectional)
            {
                AddEdgeToNode(endNode, startNode, false);
            }
        }
    }
}
