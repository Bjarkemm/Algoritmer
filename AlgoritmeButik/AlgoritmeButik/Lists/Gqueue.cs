using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik
{
    class Gqueue<T> : IEnumerable<T>
    {
        private T[] allTheTease;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Gqueue()
        {
            count = 0;
            allTheTease = new T[4];
        }

        public void Enqueue(T item)
        {
            while (allTheTease.Length <= count)
            {
                BiggerBetterStrongFaster();
            }

            allTheTease[count] = item;
            count++;
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

        public void Clear()
        {
            allTheTease = new T[4];
        }

        public T Dequeue()
        {
            T[] temp = new T[allTheTease.Length];

            bool isFirst = true;

            T item = default(T);

            for (int i = 0; i < allTheTease.Length; i++)
            {
                if (isFirst)
                {
                    item = allTheTease[i];
                    isFirst = false;
                }
                else
                {
                    int toAdd = i;
                    toAdd--;
                    temp[toAdd] = allTheTease[i];
                }

            }
            count--;
            allTheTease = temp;
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return allTheTease[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
