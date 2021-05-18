namespace Tutorium.generic
{
    public class Liste<T>
    {
        public ListenElement head;
        
        public void Add(T value)
        {
            if (head == null)
                head = new ListenElement(value);
            else
                head.Add(value);
        }

        public class ListenElement
        {
            public T value;
            public ListenElement next;

            public ListenElement(T value)
            {
                this.value = value;
            }

            public void Add(T value)
            {
                if (next == null)
                    next = new ListenElement(value);
                else
                    next.Add(value);
            }
        }
    }
}