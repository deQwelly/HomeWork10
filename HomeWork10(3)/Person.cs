using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_3_
{
    public class Person
    {
        public delegate void NeedfulEvent(string e);
        public event NeedfulEvent ReactionToEvent;

        public readonly static List<Person> all = new List<Person>();
        public string Name { get; private set; }
        public string WhatAwaits { get; private set; }

        public Person(string name, string whatAwaits)
        {
            Name = name;
            WhatAwaits = whatAwaits;
            all.Add(this);
        }

        public void React()
        {
            ReactionToEvent.Invoke($"{Name} очень рад событию {WhatAwaits}");
        }
    }
}
