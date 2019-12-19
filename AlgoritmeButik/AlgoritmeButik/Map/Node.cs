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

        Glist<Edge> myEdges = new Glist<Edge>();

        public Glist<Edge> GetEdges
        {
            get { return this.myEdges; }
        }

        public Node(T nodeValue)
        {
            this.nodeValue = nodeValue;
        }

        public void AddEdge(string name)
        {
            myEdges.Add(new Edge(name));
        }
    }
}
