using System;
using ConsoleApp1.enumerator;
using ConsoleApp1.i_comparable;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // IComparable<Person>
            var person1 = new Person(100, "Jan");
            var person2 = new Person(21, "Jan");
            
            var compareValue = person1.CompareTo(person2);
            Console.WriteLine(compareValue); // drei (oder auch mehr) Werte abbildbar
        
            // IEnumerator, IEnumerable
            var autoListe = new AutoListe();

            // for (int i = 0; i < autoListe.autos.Length; i++)
            foreach (var auto in autoListe)
            {
                Console.WriteLine(auto.farbe);
                Console.WriteLine(auto.ps);
            }
        }
    }
}
