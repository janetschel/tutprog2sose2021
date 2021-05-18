using System;

namespace Tutorium.generic
{
    public class Map<K, V> 
        where K : class 
        where V : new()

    {
    public MapElement head;

    public void Add(K key, V value)
    {
        if (head == null)
            head = new MapElement(key, value);
        else
            head.Add(key, value);
    }

    public class MapElement
    {
        public K key;
        public V value;
        public MapElement next;

        public MapElement(K key, V value)
        {
            this.value = value;
        }

        public void Add(K key, V value)
        {
            if (Equals(this.key, key))
            {
                throw new ArgumentException("Keys sind unique!");
            }

            if (next == null)
                next = new MapElement(key, value);
            else
                next.Add(key, value);
        }
    }
    }
}