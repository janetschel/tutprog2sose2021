using System;

namespace TokenRing.DynamischeDatenstrukturen
{
    public class UserInteraction
    {
        private readonly Network _network;

        public UserInteraction()
        {
            _network = new Network();
            Console.Clear();
        }

        // it is implied that the user behaves like expected -> does not want to produce errors
        // error detection left as exercise
        public void StartMenu()
        {
            var userInput = 0;
            while (true)
            {
                _network.Print();

                Console.WriteLine("\nMenü:");
                Console.WriteLine("(1) Neue Geräte hinzufügen");
                Console.WriteLine("(2) Gerät entfernen");
                Console.WriteLine("(3) Datenpaket versenden");
                Console.WriteLine("(4) Programm beenden");

                while (userInput < 1 || userInput > 4)
                {
                    Console.Write("> ");
                    userInput = GetUserInput();
                }

                if (userInput == 4)
                    break; // break out of loop if user does not want to continue
                
                // decide what to do based on user action
                switch (userInput)
                {
                    case 1: // it seems that if the network is empty the user cannot provide a previous address
                        Console.WriteLine("\nNeue Geräte hinzufügen...");
                        if (_network.IsEmpty())
                        {
                            Console.Write("Anzahl neuer Geräte > ");
                            AddDevices(GetUserInput());
                        }
                        else
                        {
                            Console.Write("Adresse des Vorgänger-Gerätes > ");
                            var previousAddress = GetUserInput();
                            
                            Console.Write("Anzahl neuer Geräte > ");
                            AddDevicesAfterPreviousAddress(GetUserInput(), previousAddress);
                        }
                        break;
                    
                    case 2:
                        Console.WriteLine("\nGerät entfernen...");
                        Console.Write("Adresse des Gerätes > ");
                        RemoveDevice(GetUserInput()); // abstraction maybe not needed here
                        break;
                    
                    case 3:
                        Console.WriteLine("\nDatenpaket versenden...");
                        Console.Write("Datenpaket > ");
                        var data = Console.ReadLine();
                        
                        Console.Write("Adresse des Senders: > ");
                        var source = GetUserInput();
                        
                        Console.Write("Adresse des Empfängers: > ");
                        var destination = GetUserInput();

                        var simulator = new Simulator(_network);
                        simulator.Start(source, destination, data);
                        break;
                    
                    default:
                        Console.WriteLine("Unerwarteter Fehler!");
                        break;
                }

                userInput = 0;
                Console.Clear();
            }
        }

        private void AddDevices(int numberOfDevices)
        {
            for (var i = 0; i < numberOfDevices; i++)
                _network.Add();
        }

        private void AddDevicesAfterPreviousAddress(int numberOfDevices, int previousAddress)
        {
            _network.Insert(previousAddress);
            _network.Print();

            for (var i = 0; i < numberOfDevices - 1; i++)
            {
                _network.Insert(_network.NextAddress - 1);
                _network.Print();
            }
        }

        private void RemoveDevice(int addressToRemove) =>
            _network.Remove(addressToRemove);

        private int GetUserInput() => Convert.ToInt32(Console.ReadLine());
    }
}