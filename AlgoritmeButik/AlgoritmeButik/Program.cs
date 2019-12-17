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

            foreach(int i in gList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
