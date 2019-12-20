using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmeButik.Map;

namespace AlgoritmeButik
{
    public static class AStar
    {
        static Node<string> priorNode = null;

        public static void Pathfinding(BuildStore buildStore, Node<string> start, Node<string> goal, int h)
        {
            Glist<Node<string>> openList = new Glist<Node<string>>();
            Glist<Node<string>> closedList = new Glist<Node<string>>();

            openList.Add(start);
            foreach(Edge neighbor in start.GetEdges)
            {
                openList.Add(buildStore.GetGraph.ListOfNodes[Convert.ToString(neighbor)]);
            }

            while(openList.Count > 0)
            {

            }
        }
    }
}
