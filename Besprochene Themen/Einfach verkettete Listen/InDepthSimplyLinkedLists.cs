using System;

namespace TokenRing.Tutorium
{
    public class Test
    {
        public static void Main(string[] args)
        {
            // Knoten (Elemente)
            /*
             * wert : 6
             * nachfolger: Knoten
             */

            var knoten = new Knoten(32); // Hauptknoten
            // Hauptknoten.nachfolger = null
            knoten.nachfolger = new Knoten(6);
            knoten.nachfolger.nachfolger = new Knoten(60);
            // Hauptknoten.nachfolger = 1
            // ZweiterKnoten.nachfolger = null
            // 32 -> 6 -> 60 -> null

            // 6 -> null
            // 6 -> 1 -> 2 -> null
            
            // Am Ende einfügen
            // 6 -> null
            // 6 -> 1 -> null
            
            // Am Anfang einfügen
            // 6 -> null
            // 1 -> 6 -> null
            
            // gewonnen mit Add()-Methode auf Knoten:
            var neuerKnoten = new Knoten(32); // 32 -> null
            neuerKnoten.Add(6);               // 32 -> 6 -> null
            neuerKnoten.Add(60);              // 32 -> [6] -> 60 -> null
            neuerKnoten.Add(66);              // 32 -> [6] -> 60 -> 66 -> null

            /*
            neuerKnoten.Remove(60);               // 32 -> 6 -> 60 ->  66 -> null
                                                  // 23 -> 6   (60 ->) 66 -> null
                                                  //       -----------^
            */
            
            // Liste (Array)
            // int[] a = new int[3]
            // a[0] = 3
            // 3.Add(2)  a[1] = 2

            Liste liste = new Liste(); // analog: int[] a = new int[3] (Länge gibts nicht)
            liste.FuegeZuListeHinzu(32); // a[0] = 32
            liste.FuegeZuListeHinzu(6);  // a[1] = 6 ....
            liste.FuegeZuListeHinzu(60);
            liste.FuegeZuListeHinzu(66);
            
            // zusätzliche Methoden, aber nicht wichtig
            /*
            liste.Print();
            Console.WriteLine(liste);
            liste.Remove(66);
            liste.ElementAt(4);
            liste.IndexOf(32);
            */

            // 32 -> 6 -> 60 -> 66 -> null
        }
    }

    public class Liste
    {
        public Knoten head; // oberster Knoten / Hauptknoten / Kopf (einer Schlange)

        public void FuegeZuListeHinzu(int data)
        {
            // head == null
            if (head == null) // keinen obersten Knoten
            {
                head = new Knoten(data);
            } // head != null
            else
            {
                head.Add(data);
            }
        }
    }

    public class Knoten // Element
    {
        public int wert;
        public Knoten nachfolger;

        public Knoten(int wert)
        {
            this.wert = wert;
        }

        public void Add(int data)
        {
            // .. -> 2 -> null (nachfolger) [letztes valide Element in Liste]
            if (nachfolger == null)
            {
                nachfolger = new Knoten(data);
            }
            else
            {
                // .. -> 2 -> 1 -> [5] -> .. -> null
                nachfolger.Add(data);
            }
        }
    }
}