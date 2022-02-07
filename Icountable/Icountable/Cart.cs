using System;
using System.Collections.Generic;

namespace Icountable
{
    class Cart<T> where T:ICountable
    {
        //store stuff in list for cart
        public List<T> listCart = new List<T>();

        public void Adder(T item)
        {
            listCart.Add(item);
        }

        public int count()
        {
            foreach(var box in listCart)
            {
                var count = box.Count();
                Console.WriteLine(count);
            }
            return listCart.Count;
        }
    }
}
