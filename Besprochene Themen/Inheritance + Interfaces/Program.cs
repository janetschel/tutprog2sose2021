using System;
using Tutorium.@where;

namespace Tutorium
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Inheritance
            var rechteck = new Rechteck(4, 6);
            var umfang = rechteck.BerechneUmfang();
            Console.WriteLine(umfang);
            
            // Inheritance + Interfaces
            var mann = new Mann("Jan", 21);
            Mensch mensch = mann as Mensch;

            if (mann is Mensch)
            {
                Console.WriteLine("Mann ist ein Mensch");
            }
            
            // where bei Generics
            var list = new TierListe<Hund>(); // where zum Einschränken der Generics
            list.Add(new Hund());
            list.Add(new Hund());
        }
    }
}