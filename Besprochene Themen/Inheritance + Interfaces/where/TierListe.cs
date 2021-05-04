using System;

namespace Tutorium.where
{
    public class TierListe<T> where T : Tier
    {

        public void Add(T neu)
        {
            Console.WriteLine("Adding... " + neu);
        }

        public void FindeErstesTierDasWenigIsst()
        {
            Console.WriteLine("Suche...");
        }
    }
}