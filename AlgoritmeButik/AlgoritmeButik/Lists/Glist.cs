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

        public int Count
        {
            get { return count; }
        }
        
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

        public void Remove(T item)
        {
            RemoveFromArray(item);
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

        private void RemoveFromArray(T item)
        {
            T[] temp = new T[allTheTease.Length];

            bool passedValue = false;

            for (int i = 0; i < allTheTease.Length; i++)
            {
                if (!allTheTease[i].Equals(item) && !passedValue)
                {
                    temp[i] = allTheTease[i];
                }
                else if (passedValue)
                {
                    int toAdd = i;
                    toAdd--;
                    temp[toAdd] = allTheTease[i];
                }
                if(allTheTease[i].Equals(item))
                {
                    passedValue = true;
                    
                }

            }
            count--;
            allTheTease = temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
