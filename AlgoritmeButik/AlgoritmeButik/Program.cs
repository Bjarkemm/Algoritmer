using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmeButik.Map;

namespace AlgoritmeButik
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildStore buildStore = new BuildStore();

            //AStar.Pathfinding()

            Customer lars = new Customer("Lars");
            Customer peter = new Customer("Peter");
            Customer terkel = new Customer("Terkel");

            lars.MakeList("Dairy", "Candy");
            peter.MakeList("Tools", "Fruit");
            terkel.MakeList("Bakery", "Colonial");



            Console.ReadKey();
        }
    }
}
