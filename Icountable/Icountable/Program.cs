using System;

namespace Icountable
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Counter<string> counterString = new Counter<string>();
            counterString.Adder("bob");
            counterString.Adder("Test");
            Console.WriteLine(counterString.count());

            Counter<int> counterInt = new Counter<int>();
            counterInt.Adder(1);
            counterInt.Adder(2);
            Console.WriteLine(counterInt.count());
        }
    }
}