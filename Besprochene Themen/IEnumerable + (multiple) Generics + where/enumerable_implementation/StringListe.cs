using System.Collections;
using System.Collections.Generic;

namespace Tutorium
{
    public class StringListe : IEnumerable<StringListe.Element>
    {
        public Element head;

        public void Add(string value)
        {
            if (head == null)
                head = new Element(value);
            else
                head.Add(value);
        }
        
        public class Element
        {
            public Element next;
            public string value;

            public Element(string value)
            {
                this.value = value;
            }

            public void Add(string value)
            {
                if (next == null)
                    next = new Element(value);
                else
                    next.Add(value);
            }            
        }

        public IEnumerator<Element> GetEnumerator()
        {
            var current = head;

            while (current != null)
            {
                // machen...
                yield return current;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}