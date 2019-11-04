using System;
using System.Text;

namespace Person
{
    public class Person
    {
        string name;

        int age;

        public Person(string name, int age)
        {
            Name = name;

            if (age >= 0)
            {
                Age = age;
            }
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(String.Format($"Name: {Name}, Age: {Age}"));

            return stringBuilder.ToString();
        }

    }
}
