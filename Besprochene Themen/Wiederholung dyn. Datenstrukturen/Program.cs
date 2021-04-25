using System;

namespace Tutorium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[3]; // Liste
            integerArray[0] = 3; // Element -> 3
            integerArray[1] = 6;
            integerArray[2] = 9;

            // 3 -> 6 -> 9 -> null
            Element element = new Element(3);
            element.Add(6);
            element.Add(9);
            
            Element element2 = new Element(34);
            element2.Add(677);
            element2.Add(95);
            
            // 4 4 "Hallo Welt" 6 3 -> 6 -> 9 -> null 43 "String"
            //                    ^
            //                    k

            Liste meineIntegerListe = new Liste();
            meineIntegerListe.Hinzufuegen(3);
            meineIntegerListe.Hinzufuegen(6);
            meineIntegerListe.Hinzufuegen(9);
            Console.WriteLine("Erste Liste:" + meineIntegerListe.length);
            
            Liste meineIntegerListe2 = new Liste();
            meineIntegerListe2.Hinzufuegen(3);
            Console.WriteLine("Zweite Liste:" + meineIntegerListe2.length);
            
            // 3 -> 6 -> 9 -> null
            //      k
        }
    }

    public class Liste // integerArray
    {
        public Element kopf;
        public int length;

        public void LoescheKopf()
        {
            kopf = kopf.nachfolger;
        }

        public void Hinzufuegen(int neuerWert)
        {
            // Schleife (Iteration)
            if (kopf == null)
            {
                kopf = new Element(neuerWert);
            }
            else
            {
                Element jetzigesElement = kopf; // current / curr
            
                while (jetzigesElement.nachfolger != null)
                {
                    jetzigesElement = jetzigesElement.nachfolger;
                }

                jetzigesElement.nachfolger = new Element(neuerWert);
            }
            
            // Rekursion
            if (kopf == null)
            {
                kopf = new Element(neuerWert);
            }
            else
            {
                kopf.Add(neuerWert);
            }
        }
    }

    public class Element // Node, Knoten
    {
        public int wert;
        public Element nachfolger;

        public Element(int wert)
        {
            this.wert = wert;
        }

        // Zweck: Anfügen eines Elements am Ende der Liste
        public void Add(int neuerWert) // neuerWert hier: 9
        {
            // 1. Fall: nachfolger = null
            // ICH bin letztes Element
            if (nachfolger == null) // Abbruchbedingung
            {
                nachfolger = new Element(neuerWert);
            }
            else // 2. Fall: nachfolger != null
            {
                nachfolger.Add(neuerWert); // Rekursiver Aufruf
            }
            
            // 3 -> 6 -> 9 -> null
            //           ^
        }
    }
}
