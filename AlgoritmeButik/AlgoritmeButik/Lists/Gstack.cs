using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik
{
    public class Gstack<T> : IEnumerable<T>
    {
        private T[] allTheTease;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Gstack()
        {
            count = 0;
            allTheTease = new T[4];
        }

        public void Push(T item)
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

        public T Pop()
        {
            T[] temp = new T[allTheTease.Length];

            int value = count - 1;

            T item = allTheTease[value];

            for (int i = 0; i < allTheTease.Length; i++)
            {
                if (!allTheTease[i].Equals(item))
                {
                    temp[i] = allTheTease[i];
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
