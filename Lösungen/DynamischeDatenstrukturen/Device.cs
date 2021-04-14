using System;

namespace TokenRing.DynamischeDatenstrukturen
{
    public class Device
    {
        public Device Next { get; set; }
        public int Address { get; set; }
        private int Upload { get; set; }
        private int Download { get; set; }
        
        public void Append(int currentAddress, Device head)
        {
            if (Next == head)
                Next = new Device
                {
                    Address = currentAddress, 
                    Next = head
                };
            else
                Next.Append(currentAddress, head);
        }

        public void Insert(int previousAddress, int currentAddress)
        {
            if (Address == previousAddress)
            {
                var temp = new Device {Next = Next, Address = currentAddress};
                Next = temp;
            }
            else 
                Next.Insert(previousAddress, currentAddress);
        }
        
        public void Remove(int addressToRemove)
        {
            if (Next.Address == addressToRemove)
                Next = Next.Next;
            else
                Next.Remove(addressToRemove);
        }

        public void Print(Device head)
        {
            Console.WriteLine($"Gerät mit Adresse {Address}: Anzahl Uploads/Downloads = {Upload}/{Download} | ({Address} -> {Next.Address})");
            
            if (Next != head)
                Next.Print(head);
        }

        public void SendData(int source, int destination, string data, bool seenAtSource)
        {
            if (Address == source && seenAtSource) // came back to source -> destination address does not exist
            {
                Console.WriteLine($"Gerät {Address} vernichtet Datenpaket (\"{data}\", {source}, {destination})");
            }
            else if (Address == source)
            {
                Console.WriteLine($"Gerät {Address} sendet Datenpaket (\"{data}\", {source}, {destination})");
                Next.SendData(source, destination, data, true);
                Upload++;
            }
            else if (Address == destination && seenAtSource) // only valid destination if source has been seen (dest before source)
            {
                Console.WriteLine($"Gerät {Address} empfängt Datenpaket (\"{data}\", {source}, {destination})");
                Download++;
            }
            else if (Address > source)
            {
                Console.WriteLine($"Gerät {Address} leitet Datenpaket (\"{data}\", {source}, {destination}) weiter");
                Next.SendData(source, destination, data, seenAtSource);
            }
            else if (Address <= destination)
            {
                Next.SendData(source, destination, data, seenAtSource);
            }
        }
    }
}