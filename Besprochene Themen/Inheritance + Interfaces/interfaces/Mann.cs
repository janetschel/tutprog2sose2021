using System;

namespace Tutorium
{
    public class Mann : Mensch, IAktionen, IGefuehle
    {

        // Konstruktoraufruf in der Superklasse -> : base(name, alter)
        public Mann(string name, int alter) : base(name, alter)
        {
        }
        
        public override void sageTest()
        {
            Console.WriteLine("Mann sagt:");
            
            // Methodenaufruf in der Superklasse
            base.sageTest();
            var i = alter;
        }

        public void SageHallo()
        {
            throw new System.NotImplementedException();
        }

        public void SageIrgendwas(string irgendwas)
        {
            throw new System.NotImplementedException();
        }

        public void SageGefuehle()
        {
            throw new System.NotImplementedException();
        }
    }
}