using System;

namespace TokenRing.DynamischeDatenstrukturen
{
    public class Network
    {
        private Device Head { get; set; }
        private int _currentAddress = 1;
        
        public int NextAddress => _currentAddress;

        public void Add()
        {
            if (Head == null)
            {
                Head = new Device {Address = _currentAddress};
                Head.Next = Head;
            }
            else
                Head.Append(_currentAddress, Head);

            _currentAddress++;
        }
        
        public void Insert(int previousAddress) =>
            Head.Insert(previousAddress, _currentAddress++);

        public void Remove(int addressToRemove)
        {
            if (Head.Address == addressToRemove)
                Head = Head.Next;

            Head.Remove(addressToRemove);
        }

        public void Print()
        {
            Console.WriteLine("Status des Ringpuffer-Netzwerks:");
            
            if (Head == null)
                Console.WriteLine("Leer");
            else
                Head.Print(Head);
        }

        public void Send(int source, int destination, string data) =>
            Head?.SendData(source, destination, data, false);

        public bool IsEmpty() => Head == null;
    }
}