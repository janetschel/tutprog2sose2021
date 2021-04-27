using System;
using System.Collections;
using Listen;

namespace Tutorium
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            list.Print();
            
            list.Add("Hallo");
            list.Add("Welt");
            list.Add("!");
            
            list.Print();

            var list2 = new List<int>();
            list2.Add(2);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            
            list2.Print();
        }
    }

    class Test
    {
        // Aufruf mit test?.sageHallo();
        public void sageHallo()
        {
            Console.WriteLine("Hallo Welt!");
        }
    }
}
