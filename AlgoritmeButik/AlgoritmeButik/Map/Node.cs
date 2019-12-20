using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik.Map
{
    public class Node<T>
    {
        T nodeValue;

        private int gPoint;

        Glist<Edge> myEdges = new Glist<Edge>();

        public Glist<Edge> GetEdges
        {
            get { return this.myEdges; }
        }

        public int GetGPoint
        {
            get { return gPoint; }
        }

        public Node(T nodeValue)
        {
            this.nodeValue = nodeValue;
            this.gPoint = 10;

        }

        public void AddEdge(string name)
        {
            myEdges.Add(new Edge(name));
        }
    }
}
