using System;
// ReSharper disable InvalidXmlDocComment

namespace Listen
{
    public class List<DATENTYP> // Generic
    {
        public class Node
        {
            public DATENTYP Value { get; set; }
            public Node Prev  { get; set; } 
            public Node Next  { get; set; } // public Node next;

            public Node(DATENTYP value)
            {
                Value = value;
            }

            public void Add(DATENTYP value)
            {
                if (Next == null)
                {
                    var newNode = new Node(value); // { Prev = this }
                    newNode.Prev = this;
                    Next = newNode;
                }
                else
                    Next.Add(value);
            }

            public void Print()
            {
                var prevVal = Prev == null ? "/" : Prev.Value.ToString();
                var nextVal = Next == null ? "/" : Next.Value.ToString();
            
                Console.WriteLine($"Node(value = {Value}, prev = {prevVal}, next = {nextVal})");
                Next?.Print();
            }
        }

        public Node Head { get; set; }

        public void Add(DATENTYP value)
        {
            if (Head == null)
                Head = new Node(value);
            else
                Head.Add(value);
        }

        public void InsertAtBeginning(DATENTYP value)
        {
            var oldHead = Head;
            Head = new Node(value);

            oldHead.Prev = Head;
            Head.Next = oldHead;
        }

        public void Print()
        {
            if (Head == null)
                Console.WriteLine("Empty list!");
            else
                Head.Print();
        }
    }
}