using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik
{
    class Glist<T> : IEnumerable<T>
    {
        private T[] allTheTease;
        private int count;

        public Glist()
        {
            count = 0;
            allTheTease = new T[4];
        }

        public void Add(T item)
        {
            while(allTheTease.Length <= count)
            {
                BiggerBetterStrongFaster();
            }

            allTheTease[count] = item;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return allTheTease[i];
            }
        }

        private void BiggerBetterStrongFaster()
        {
            T[] temp = new T[allTheTease.Length * 2];
            for (int i = 0; i < allTheTease.Length; i++)
            {
                temp[i] = allTheTease[i];
            }
            allTheTease = temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
