using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik.Map
{
    class Graph<T>
    {
        Gdictionary<int, Node<T>> listOfNodes = new Gdictionary<int, Node<T>>();

        public Gdictionary<int, Node<T>> ListOfNodes
        {
            get { return listOfNodes; }
        }

        public Graph()
        {

        }

        public int AddNode(T value)
        {
            Node<T> node = new Node<T>(value);
            listOfNodes.Add(node.GetNodeIndex, node);
            return node.GetNodeIndex;
        }

        public void AddEdgeToNode(int startNode, int endNode, bool bidirectional = true)
        {
            listOfNodes[startNode].AddEdge(endNode);
            if (bidirectional)
            {
                AddEdgeToNode(endNode, startNode, false);
            }
        }
    }
}
