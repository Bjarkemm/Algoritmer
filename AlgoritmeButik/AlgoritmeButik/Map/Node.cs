using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik.Map
{
    class Node<T>
    {
        T nodeValue;

        private static int nodeCounter = 0;
        readonly int nodeIndex;

        Glist<Edge> myEdges = new Glist<Edge>();

        public int GetNodeIndex
        {
            get { return this.nodeIndex; }
        }

        public Glist<Edge> GetEdges
        {
            get { return this.myEdges; }
        }

        public Node(T nodeValue)
        {
            this.nodeValue = nodeValue;
            nodeIndex = nodeCounter;
            nodeCounter++;
        }

        public void AddEdge(int otherNodeName)
        {
            myEdges.Add(new Edge(otherNodeName));
        }
    }
}
