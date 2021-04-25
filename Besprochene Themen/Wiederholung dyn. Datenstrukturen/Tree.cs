namespace Tutorium
{
    public class Baum // Liste
    {
        public BaumElement wurzel;
        
        // Sortiert Einfügen
        public void Insert(int neuerWert) // Hinzufuegen(neuerWert)
        {
            if (wurzel == null)
            {
                wurzel = new BaumElement(neuerWert);
            }
            else if (neuerWert < wurzel.wert)
            {
                wurzel.links.Add(neuerWert);
            }
            else // if (neuerWert > wurzel.wert)
            {
                wurzel.rechts.Add(neuerWert);
            }
        }
    }

    public class BaumElement // Element
    {
        public int wert;
        public BaumElement links;
        public BaumElement rechts;

        public BaumElement(int wert)
        {
            this.wert = wert;
        }

        public void Add(int neuerWert)
        {
            // Implementierung folgt
        }
    }
}