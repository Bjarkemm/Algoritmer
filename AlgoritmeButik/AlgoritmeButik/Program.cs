using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik
{
    class Program
    {
        static void Main(string[] args)
        {
            Glist<int> gList = new Glist<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Gqueue<int> gQueue = new Gqueue<int>();
            Gstack<int> gStack = new Gstack<int>();

            gQueue.Enqueue(1);
            gQueue.Enqueue(2);
            gQueue.Enqueue(3);
            gQueue.Enqueue(4);
            gQueue.Enqueue(5);
            gQueue.Enqueue(6);

            gStack.Push(1);
            gStack.Push(2);
            gStack.Push(3);
            gStack.Push(4);
            gStack.Push(5);
            gStack.Push(6);

            foreach (int i in gList)
            {
                Console.WriteLine(i);
            }

            gList.Remove(6);

            foreach(int i in gList)
            {
                Console.WriteLine(i);
            }

            List<int> listOfInt = new List<int>();

            gList.Add(6);

            foreach(int i in gList)
            {
                Console.WriteLine(i);
            }

            while(0 < gQueue.Count)
            {
                Console.WriteLine(gQueue.Dequeue());
            }

            while(0 < gStack.Count)
            {
                Console.WriteLine(gStack.Pop());
            }

            Console.ReadKey();
        }
    }
}
