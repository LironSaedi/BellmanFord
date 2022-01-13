using System;
using System.Collections.Generic;

namespace BellmanFord
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person joe = new Person("Joe", 34);
            Dictionary<Person, decimal> Tabs = new Dictionary<Person, decimal>();

            //instead of modifying Person to attach data, use a dictionary
            //joe.Tab += 5.00m;
            Tabs[joe] = 5.00m;
        }
    }
}
