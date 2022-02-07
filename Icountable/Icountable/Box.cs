using System.Collections.Generic;

namespace Icountable
{
    class Box<T>
    {
        // Generates a list to store stuff in box
        public List<T> listBox = new List<T>();

        public void Add(T item)
        {
            listBox.Add(item);
        }

        public int counter()
        {
            return listBox.Count;
        }
    }
}
