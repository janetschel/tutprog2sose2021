using System;
using Tutorium.generic.@where.structure;

namespace Tutorium.generic.@where
{
    // where T : class erlaubt nur eigene Klassen und keine prim. Datentypen
    // where T : new() -> Klasse braucht einen Standardkonstruktor
    public class PersonenListe<T> where T : Person
    {
        public void Add(T obj)
        {
            Console.WriteLine("Adding...");
        }
    }
}