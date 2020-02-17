using System;
using System.Collections.Generic;

namespace DesingPatter_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Luca = new Person("Luca");
            Person enfant1 = new Person("Enfant1");
            Person enfant2 = new Person("Enfant2");

            Person enfant1a = new Person("Enfant de enfant1");
            Person enfant1b = new Person("Enfantb de enfant1");

            Luca.DirectDescendant.Add(enfant1);
            Luca.DirectDescendant.Add(enfant2);

            enfant1.DirectDescendant.Add(enfant1a);
            enfant1.DirectDescendant.Add(enfant1b);
            Console.WriteLine(Luca.ToString());
        }
    }
    class Person
    {
        public string Name { get; set; }
        public List<Person> DirectDescendant { get; set; } = new List<Person>();
        public Person(string name)
        {
            Name = name;
        }
        public override String ToString()
        {
            string descritpion = Name;
            foreach (Person person in DirectDescendant)
            {
                descritpion += "\n" + person;
            }
            return descritpion;

        }
    }

}
