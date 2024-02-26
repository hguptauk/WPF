using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverterForParameterizedConstructor
{
    [TypeConverter(typeof(PersonTypeConverter))]
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string WelcomeMessage => $"Hi I am {Name} and I am {Age} yr old";
    }
}
