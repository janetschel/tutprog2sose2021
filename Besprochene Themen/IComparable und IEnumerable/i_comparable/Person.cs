using System;

namespace ConsoleApp1.i_comparable
{
    public class Person : IComparable<Person>
    {
        public int alter;
        public string name;

        public Person(int alter, string name)
        {
            this.alter = alter;
            this.name = name;
        }

        public int CompareTo(Person person)
        {
            if (person?.alter < alter)
                return 1;

            if (person?.alter > alter)
                return -1;

            return 0;
        }
    }
}