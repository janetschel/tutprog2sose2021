using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.enumerator
{
    public class AutoListe : IEnumerable<Auto>
    {
        // Interne Liste von Autos
        public Auto[] autos;

        public AutoListe()
        {
            autos = new []
            {
                new Auto("rot", 100),
                new Auto("geld", 120),
                new Auto("schwarz", 200)
            };
        }

        /// <summary>
        /// Diese Methode wird gecalled, sobald die AutoListe in einer foreach schleife (o.Ä.) benutzt wird.
        /// Mit dem "yield return" wird mit dem return gewartet, bis die for-schleife durchgelaufen ist, und dann werden
        /// alle Werte auf einmal zurück gegeben (mehr dazu nächste Woche) -> Es wird ein Enumerator von Autos zurück
        /// gegeben
        /// </summary>
        /// <returns>
        /// Durch das yield return ein IEnumerator des Typs Auto, welcher in Schleifen benutzt werden kann
        /// </returns>
        public IEnumerator<Auto> GetEnumerator()
        {
            foreach (var auto in autos) // Iteration auch möglich durch eine normale for-Schleife
            {
                // Warten und "sammeln" der Auto-Objekte im Array
                yield return auto; 
            }
            
            // Hier würde nun die eigentliche Rückgabe erst stattfinden
            // "return IEnumerator<Auto>" <-- kein valider Code, aber so könnte man sich das vorstellen
        }

        /// <summary>
        /// Diese Methode wird nur aufgerufen, wenn manuell über diesen Enumerator iteriert wird.
        /// Das würde dann folgendermaßen aussehen:
        /// 
        /// IEnumerator enum = autoListe.GetEnumerator();
        /// while (enum.MoveNext())
        /// {
        ///     bar = (Foo)enum.Current
        ///     ...
        /// }
        ///
        /// Dafür müsste dann allerdings auch das Interface IEnumerator implementiert sein, um den Methoden .MoveNext()
        /// Sinn zu geben. Dazu am Dienstag mehr!
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Auto
    {
        public string farbe;
        public int ps;

        public Auto(string farbe, int ps)
        {
            this.farbe = farbe;
            this.ps = ps;
        }
    }
}