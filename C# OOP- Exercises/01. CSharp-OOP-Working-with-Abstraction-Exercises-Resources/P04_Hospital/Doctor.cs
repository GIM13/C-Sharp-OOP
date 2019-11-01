using System;
using System.Collections.Generic;

namespace P04_Hospital
{
    public class Doctor : IComparable<Doctor>
    {
        public Doctor(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Patients = new List<string>();
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<string> Patients { get; set; }

        public int CompareTo(Doctor other)
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return 1;
            }
            else if (Surname.CompareTo(other.Surname) != 0)
            {
                return 1;
            }

                return 0;
        }
    }
}
      