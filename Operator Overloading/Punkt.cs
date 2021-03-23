namespace ConsoleApp1
{
    public class Punkt
    {
        public int X { get; }
        public int Y { get; }

        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Bereits bekannt, analog zu Operator-Überladung
        public override string ToString()
        {
            return $"P({X},{Y})";
        }
        
        // --- NEU:

        // Normale Rechenoperatoren (+, -, *, /, %, ...), sowie das bitweise & und | können überladen werden
        public static Punkt operator +(Punkt a, Punkt b)
        {
            return new Punkt(a.X + b.X, a.Y + b.Y);
        }
        
        // Die unären Operatoren (++, --, true, false, ...) können überladen werden
        public static Punkt operator ++(Punkt a) // analog zu --
        {
            return new Punkt(a.X + 1, a.Y + 1);
        }

        public static bool operator true(Punkt a)
        {
            return a.X != 0 && a.Y != 0; // Definition hier etwas schwierig -> "Wann ist ein Punkt wahr?"
        }

        // Falls der operator true überladen ist, Muss auch false überladen werden
        public static bool operator false(Punkt a)
        {
            // Hier kann man sich eines Tricks behelfen -> false ist nicht true
            return a.X == 0 || a.Y == 0;
        }
        
        // Es können auch Vergleichsoperatoren überladen werden. Sobald eines davon überladen ist, muss es das Gegenteil auch sein
        // Beispiel: Wenn < überladen, dann auch >
        public static bool operator <(Punkt a, Punkt b)
        {
            return a.X < b.X && a.Y < b.Y;
        }

        public static bool operator >(Punkt a, Punkt b)
        {
            // Trick: a > b, falls a nicht < b und a != b. Hier greifen wir auf den bereits überladenen Operator zu von Zeile 45
            return !(a < b) && a != b;
        }
        
        // uvm.
    }
}
