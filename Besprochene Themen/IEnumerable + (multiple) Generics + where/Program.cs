using System;
using Tutorium.generic;
using Tutorium.generic.@where;
using Tutorium.generic.@where.structure;

namespace Tutorium
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enumerable
            var liste = new StringListe();
            liste.Add("Hallo");
            liste.Add("Welt");
            liste.Add("!");

            // Ausgabe in einer foreach Schleifen ?
            foreach (StringListe.Element element in liste)
            {
                Console.WriteLine(element.value);
            }
            #endregion
            
            // Wenn int und string gemischt dann anstatt T = object
            
            var list = new Liste<int>();
            list.Add(3);
            list.Add(5);

            var map = new Map<string, long>();
            map.Add("jan", 21);
            map.Add("peter", 19);
            
            // echte Map
            // map[key] -> null
            
            // where
            var personenListe = new PersonenListe<Student>();
            personenListe.Add(new Erstsemestler());
            personenListe.Add(new Erstsemestler());
            personenListe.Add(new HoehereSemester());

            // Fehler! Studen spezifischer als Person
            // personenListe.Add(new Vorstand());
            
        }
        
        // [ 34, 36, 90, 90, 12 ]
        // { { "key": "value"}, { "key2":"value2"} }
    }
}