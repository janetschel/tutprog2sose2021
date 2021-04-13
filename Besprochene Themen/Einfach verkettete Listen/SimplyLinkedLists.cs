using System;

namespace Tutorium
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerListe list = new IntegerListe();
            
            list.Add(3);
            list.Add(1);
            list.Add(5);
            list.Add(1);
            list.Add(2);

            // list.SearchElement(5); // -> 2
            
            // list[3] -> 1
            var dataAtIndex = list.FindDataAtIndex(3);
            Console.WriteLine(dataAtIndex); // -> 1
            Console.WriteLine(list[3]); // -> 1
            
            Console.WriteLine(list.length);
            
            // circular simply linked list
            // 4 -> 2 -> 3 -> 5
            // ^              |
            // |              v
            // ----------------
        }
    }

    class IntegerListe // Array
    {
        public IntegerNode head; // erste Element
        public int length;
        
        public int this[int index]
        {
            get
            {
                return FindDataAtIndex(index);
            }
        }

        public IntegerListe()
        {
            head = null;
        }

        // am ende anfügen (liste FIFO)
        public void Add(int data)
        {
            if (head == null)
            {
                head = new IntegerNode(data);
                
                // circular simply linked list
                // head.next = head;   4 -
                //                     ^ |
            }
            else
            {
                head.Append(data);
            }

            length++;
        }
        
        // prepend = am anfang anfügen (stack FILO)
        public void Prepend(int data)
        {
            if (head == null)
            {
                head = new IntegerNode(data);
            } 
            else
            {
                IntegerNode integerNode = new IntegerNode(data);
                integerNode.nachfolger = head;
                head = integerNode;
                
                /*
                 * 4 -> 3
                 * h
                 *
                 * 2 -> 4 -> 3
                 *      h
                 *
                 * 2 -> 4 -> 3
                 * h
                 */
                
                /*
                 var temp = new Node(data);
                 temp.next = head;
                 head = temp;
                 */
            }
            
            // (2 ->) 4 -> 3
            // 4.nachfolger: 3
            // 3.nachfolger: null

            length++;
        }

        public int FindDataAtIndex(int index)
        {
            if (index == 0)
            {
                return head.data;
            }
            
            return head.nachfolger.FindDataAtIndex(1, index);
        }
    }
    
    // 4 -> 2 -> 3 einfache verkettete Liste
    class IntegerNode // Element im Array
    {
        public int data;
        public IntegerNode nachfolger;
        public static int length;

        public IntegerNode(int data)
        {
            this.data = data;
            nachfolger = null;
            length++;
        }
        
        // Hinten anfügen
        public void Append(int data /*, IntegerNode head */)
        {
            if (nachfolger == null) // nachfolger == head
            {
                // circular simply linked list
                // var tempHead = head;
                
                nachfolger = new IntegerNode(data);
                
                // nachfolger.nachfolger = tempHead;
            }
            else
            {
                nachfolger.Append(data);
            }
        }

        public int FindDataAtIndex(int currentIndex, int index)
        {
            if (currentIndex == index)
            {
                return data;
            }
            else
            {
                return nachfolger.FindDataAtIndex(currentIndex + 1, index);
            }
        }

        public void Print()
        {
            Console.Write($"{data} -> "); // data + "-> "

            if (nachfolger != null)
            {
                nachfolger.Print();
            }
            
            // anstatt if
            // nachfolger?.Print();
        }
    }
}