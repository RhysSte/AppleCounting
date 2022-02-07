using System.Collections.Generic;

namespace Icountable
{
    class Counter<T>
    {
        public List<T> listCounter = new List<T>();

        public void Adder(T item)
        {
            listCounter.Add(item);
        }

        public int count()
        {
            return listCounter.Count;
        }
    }
}