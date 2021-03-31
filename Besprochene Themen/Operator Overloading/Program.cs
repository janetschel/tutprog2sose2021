using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(2, 1);
            Punkt p2 = new Punkt(5, 4);

            Punkt p3 = p1 + p2; // Überladung Operator +

            if (p3) // Überladung Operator true
            {
                p3++; // Überladung Operator ++
            }
            else if (p1 < p2) // Überladung < und >
            {
                p1++;
            }

            Console.WriteLine(p3);
            Console.WriteLine(p1.X == 2 && p1.Y == 1); // Zu erwarten
            Console.WriteLine(p3.X == 8 && p3.Y == 6); // Zu erwarten
        }
    }
}