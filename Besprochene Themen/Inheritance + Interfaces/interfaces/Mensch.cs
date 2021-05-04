using System;

namespace Tutorium
{
    public class Mensch // Superklasse / Elternklasse/ Baseklasse
    {
        public string name;
        public int alter;

        public Mensch(string name, int alter)
        {
            this.name = name;
            // ...
        }

        public virtual void sageTest()
        {
            Console.WriteLine("Test...");
        }
    }
}