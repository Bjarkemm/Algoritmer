using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeButik
{
    class Gdictionary<Tkey, Tvalue>
    {
        private Tvalue[] allTheTvalue;
        private Tkey[] allTheTkey;
        private int count;

        public Tvalue this[Tkey key]
        {
            get
            {
                for (int i = 0; i < allTheTkey.Length; i++)
                {
                    if (allTheTkey[i].Equals(key))
                    {
                        return allTheTvalue[i];
                    }
                }

                throw new Exception();
            }

            set
            {
                for (int i = 0; i < allTheTkey.Length; i++)
                {
                    if (allTheTkey[i].Equals(key))
                    {
                        allTheTvalue[i] = value;
                        return;
                    }
                }

                throw new Exception();
            }
        }

        public Tkey this[Tvalue value2]
        {
            get
            {
                for (int i = 0; i < allTheTvalue.Length; i++)
                {
                    if (allTheTvalue[i].Equals(value2))
                    {
                        return allTheTkey[i];
                    }
                }

                throw new Exception();
            }

            set
            {
                for (int i = 0; i < allTheTvalue.Length; i++)
                {
                    if (allTheTvalue[i].Equals(value2))
                    {
                        allTheTkey[i] = value;
                        return;
                    }
                }

                throw new Exception();
            }
        }

        public int Count
        {
            get { return count; }
        }

        public Gdictionary()
        {
            count = 0;
            allTheTvalue = new Tvalue[4];
            allTheTkey = new Tkey[4];
        }

        public bool ContainsKey(Tkey key)
        {
            if (allTheTkey.Contains<Tkey>(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsValue(Tvalue value)
        {
            if (allTheTvalue.Contains<Tvalue>(value))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Add(Tkey key,Tvalue item)
        {
            if (!allTheTkey.Contains(key))
            {
                while (allTheTvalue.Length <= count)
                {
                    BiggerBetterStrongFaster();
                }

                allTheTvalue[count] = item;
                allTheTkey[count] = key;
                count++;
            }
            else
            {
                throw new Exception("Can't have dublicates of Tkey");
            }
        }

        public void Remove(Tkey key)
        {
            RemoveFromArray(key);
        }

        private void BiggerBetterStrongFaster()
        {
            Tkey[] tempKey = new Tkey[allTheTkey.Length * 2];
            Tvalue[] tempValue = new Tvalue[allTheTvalue.Length * 2];
            for (int i = 0; i < allTheTvalue.Length; i++)
            {
                tempValue[i] = allTheTvalue[i];
                tempKey[i] = allTheTkey[i];
            }
            allTheTkey = tempKey;
            allTheTvalue = tempValue;
        }

        private void RemoveFromArray(Tkey key)
        {
            Tvalue[] tempValue = new Tvalue[allTheTvalue.Length];
            Tkey[] tempKey = new Tkey[allTheTkey.Length];

            bool passedValue = false;

            for (int i = 0; i < allTheTkey.Length; i++)
            {
                if (!allTheTkey[i].Equals(key) && !passedValue)
                {
                    tempKey[i] = allTheTkey[i];
                    tempValue[i] = allTheTvalue[i];
                }
                else if (passedValue)
                {
                    int toAdd = i;
                    toAdd--;
                    tempKey[toAdd] = allTheTkey[i];
                    tempValue[toAdd] = allTheTvalue[i];
                }
                if (allTheTkey[i].Equals(key))
                {
                    passedValue = true;

                }

            }
            count--;
            allTheTkey = tempKey;
            allTheTvalue = tempValue;

        }

        //public IEnumerator<Tvalue> GetEnumerator()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        yield return allTheTvalue[i];
        //    }
        //}


        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
