using System;

namespace TokenRing.DynamischeDatenstrukturen
{
    public class Simulator
    {
        private readonly Network _network;

        public Simulator(Network network) =>
            _network = network;
        
        public void Start(int source, int destination, string data)
        {
            Console.WriteLine("\nStarte Simulation...");

            if (source == destination)
                Console.WriteLine("Kann kein Paket senden, wenn die Start- und End-Adressen die Gleichen sind!");
            else
                _network.Send(source, destination, data);
            
            Console.WriteLine("\nSimulation beendet. Bitte eine Taste drücken...");
            Console.ReadKey(); // waits for user to press a key
        }
    }
}